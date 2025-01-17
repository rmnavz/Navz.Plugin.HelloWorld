using System.Reflection;
using Navz.Plugin.Core.Plugins;

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
