var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

Task("Restore")
    .Does(() =>
    {
        var settings = new DotNetCoreRestoreSettings
        {
            Verbose = false
        };

        DotNetCoreRestore(settings);
    });

Task("Build")
    .IsDependentOn("Restore")
    .Does(() =>
    {
        var settings = new DotNetCoreBuildSettings
        {
            Configuration = configuration
        };

        foreach(var file in GetFiles("*.sln"))
            DotNetCoreBuild(file.ToString(), settings);
    });

Task("Test")
    .IsDependentOn("Build")
    .Does(() =>
    {
        foreach(var file in GetFiles("./tests/**/*Tests.csproj"))
            DotNetCoreRun(file.ToString());
    });

Task("Pack")
    .IsDependentOn("Test")
    .Does(() =>
    {
        var settings = new DotNetCorePackSettings
        {
            Configuration = "Release",
            OutputDirectory = "./artifacts/"
        };

        DotNetCorePack("./src/StoryTests/StoryTests.csproj", settings);
    });

Task("Default")
    .IsDependentOn("Pack");

RunTarget(target);