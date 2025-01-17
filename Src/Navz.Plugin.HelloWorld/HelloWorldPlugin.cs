using System.Reflection;
using Navz.Plugin.Core.Plugins;

[assembly: AssemblyMetadata("PluginVersion", "0.1.0")]
[assembly: AssemblyMetadata("MinLoaderVersion", "0.3.0")]
namespace Navz.Plugin.HelloWorld;

public class HelloWorldPlugin : CommandPlugin
{
    public override string Name => "HelloWorld";

    public override string Description => "Displays \"Hello World\" message.";

    public override async Task<int> Execute()
    {
        await Task.Run(() => Console.WriteLine("Hello World!"));

        return 0;
    }
}
