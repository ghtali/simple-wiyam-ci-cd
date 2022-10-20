#tool nuget:?package=Wyam&version=2.2.0
#addin nuget:?package=Cake.Wyam&version=2.1.3

var target = Argument("target", "Build");

Task("Build")
    .Does(() =>
    {
        Wyam( new WyamSettings {
            Recipe = "Web",
            Theme = "CleanWeb"
        });
    });

Task("Preview")
    .Does(() =>
    {
        Wyam(new WyamSettings
        {
            Recipe = "Web",
            Theme = "CleanWeb",
            Preview = true,
            Watch = true
        });
    });

RunTarget(target);