using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StoryTests.Epilogs;
using StoryTests.Prologs;

namespace StoryTests.Unit.Tests
{
    [TestFixture]
    public class ExtensionMethodTests
    {
        [TestCase(typeof(OnePointEpilog<,>), typeof(OnePointEpilogExtensions))]
        [TestCase(typeof(TwoPointEpilog<,,>), typeof(TwoPointEpilogExtensions))]
        [TestCase(typeof(ThreePointEpilog<,,,>), typeof(ThreePointEpilogExtensions))]
        [TestCase(typeof(FourPointEpilog<,,,,>), typeof(FourPointEpilogExtensions))]
        [TestCase(typeof(FivePointEpilog<,,,,,>), typeof(FivePointEpilogExtensions))]
        [TestCase(typeof(OnePointProlog<>), typeof(OnePointPrologExtensions))]
        [TestCase(typeof(TwoPointProlog<,>), typeof(TwoPointPrologExtensions))]
        [TestCase(typeof(ThreePointProlog<,,>), typeof(ThreePointPrologExtensions))]
        [TestCase(typeof(FourPointProlog<,,,>), typeof(FourPointPrologExtensions))]
        [TestCase(typeof(FivePointProlog<,,,,>), typeof(FivePointPrologExtensions))]
        public void ThenAllAsynMethodsHaveAnExtension(Type subject, Type extensionClass)
        {
            var missingMethods = new List<string>();

            var methods = subject
                .GetMethods()
                .Where(x => typeof(Task).IsAssignableFrom(x.ReturnType))
                .Select(x => Method.From(subject, x));

            var extensionMethods = extensionClass
                .GetMethods()
                .Select(ExtensionMethod.From)
                .ToList();

            foreach (var method in methods)
            {
                if (!extensionMethods.Any(x => x.Equals(method)))
                    missingMethods.Add(method.ToString());
            }

            if(missingMethods.Count > 0)
                Assert.Fail($"Missing extension method in '{extensionClass.Name}': \n{string.Join("\n", missingMethods)}");
        }

        private class ExtensionMethod
        {
            private readonly Parameter[] _parameters;
            private readonly Type _returnType;
            private readonly string _name;

            public static ExtensionMethod From(MethodInfo methodInfo)
            {
                return new ExtensionMethod(methodInfo.Name, methodInfo.ReturnType, methodInfo.GetParameters().Skip(1).Select(Parameter.From).ToArray());
            }

            private ExtensionMethod(string name, Type returnType, Parameter[] parameters)
            {
                _name = name;
                _returnType = returnType;
                _parameters = parameters;
            }

            public bool Equals(Method method)
            {
                return method.IsCalled(_name) && method.ReturnTypeEquals(_returnType) && method.ParametersEqual(_parameters);
            }
        }

        private class Parameter
        {
            private readonly string _name;
            private readonly Type _type;

            public static Parameter From(ParameterInfo arg)
            {
                return new Parameter(arg.Name, arg.ParameterType);
            }

            private Parameter(string name, Type type)
            {
                _name = name;
                _type = type;
            }

            public bool Equals(Parameter other)
            {
                return _type.TypeEquals(other._type);
            }

            public override string ToString()
            {
                return $"{_type.ToPrettyName()} {_name}";
            }

            public IEnumerable<Type> GenericParameters()
            {
                return _type.GetGenericContraints();
            }

            public string ToName()
            {
                return _name;
            }
        }

        private class Method
        {
            private readonly Type _containingType;
            private readonly Parameter[] _parameters;
            private readonly Type _returnType;
            private readonly string _name;

            public static Method From(Type containingType, MethodInfo methodInfo)
            {
                return new Method(containingType, methodInfo.Name, methodInfo.ReturnType, methodInfo.GetParameters().Select(Parameter.From).ToArray());
            }

            private Method(Type containingType, string name, Type returnType, Parameter[] parameters)
            {
                _containingType = containingType;
                _name = name;
                _returnType = returnType;
                _parameters = parameters;
            }

            public bool IsCalled(string name)
            {
                return _name == name;
            }

            public bool ReturnTypeEquals(Type returnType)
            {
                return _returnType.TypeEquals(returnType);
            }

            public bool ParametersEqual(IReadOnlyList<Parameter> parameters)
            {
                if (_parameters.Length != parameters.Count)
                    return false;

                for (var i = 0; i < _parameters.Length; i++)
                {
                    if (!_parameters[i].Equals(parameters[i]))
                        return false;
                }

                return true;
            }

            public override string ToString()
            {
                var genericTypeParameters = _containingType
                    .GetTypeInfo()
                    .GenericTypeParameters
                    .Select(x => x.ToPrettyName())
                    .ToList();

                var parameters = _parameters
                    .Select(x => x.ToString())
                    .ToList();

                var contraints = _parameters
                    .SelectMany(x => x.GenericParameters())
                    .Union(_returnType.GetGenericContraints())
                    .Distinct()
                    .ToArray()
                    .ToPrettyName();

                var stringBuilder = new StringBuilder();
                stringBuilder.AppendLine($"public static async {_returnType.ToPrettyName()} {_name}<{contraints}>(this Task<IStoryEpilog<{string.Join(", ", genericTypeParameters)}>> self, {string.Join(", ", parameters)})");
                stringBuilder.AppendLine("{");
                stringBuilder.AppendLine("    var result = await self;");
                stringBuilder.AppendLine($"    return await result.{_name}({string.Join(", ", _parameters.Select(x => x.ToName()))});");
                stringBuilder.AppendLine("}");

                return stringBuilder.ToString();
            }
        }
    }

    public static class TypeExtensions
    {
        public static bool TypeEquals(this Type self, Type other)
        {
            if (other.Name != self.Name)
                return false;

            if (self.GenericTypeArguments.Length != other.GenericTypeArguments.Length)
                return false;

            for (var i = 0; i < self.GenericTypeArguments.Length; i++)
            {
                if (self.GenericTypeArguments[i].Name != other.GenericTypeArguments[i].Name)
                    return false;

                if (self.GenericTypeArguments[i].GenericTypeArguments.Length != other.GenericTypeArguments[i].GenericTypeArguments.Length)
                    return false;

                for (var j = 0; j < self.GenericTypeArguments[i].GenericTypeArguments.Length; j++)
                {
                    if (self.GenericTypeArguments[i].GenericTypeArguments[j].Name != other.GenericTypeArguments[i].GenericTypeArguments[j].Name)
                        return false;
                }
            }

            return true;
        }

        public static List<Type> GetGenericContraints(this Type self)
        {
            var genericConstraints = new List<Type>();
            foreach (var genericArgument in self.GetTypeInfo().GetGenericArguments())
            {
                if (!genericArgument.IsGenericParameter)
                {
                    genericConstraints.AddRange(genericArgument.GetGenericContraints());
                    continue;
                }

                genericConstraints.Add(genericArgument);
            }

            return genericConstraints;
        }


        public static string ToPrettyName(this Type[] self)
        {
            if (self.Length == 0)
                return string.Empty;

            var typeName = new StringBuilder();

            for (var index = 0; index < self.Length; index++)
            {
                if (index != 0)
                    typeName.Append(", ");

                typeName.Append(self[index].ToPrettyName());
            }

            return typeName.ToString();
        }

        public static string ToPrettyName(this Type self)
        {
            var typeName = new StringBuilder();

            typeName.Append(self.Name.Split('`')[0]);

            if (self.GenericTypeArguments.Length != 0)
                typeName.Append($"<{self.GenericTypeArguments.ToPrettyName()}>");
            
            return typeName.ToString();
        }
    }
}