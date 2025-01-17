# Navz.Plugin.HelloWorld
Example Plugin Template for Navz.Plugin.Core Nuget Package

## Getting Started

> Reference Navz.PluginCore.dll to your client project

1. Initialize the pluginHost with the locations of plugins to enable the loader to find the assemblies:

    ```csharp
    var pluginHost = new PluginHost("Plugins", new List<PluginSettings> {
        new PluginSettings {
            Name = "Navz.Plugin.HelloWorld",
            Version = "Latest",
            RepositoryUrl = "https://github.com/rmnavz/Navz.Plugin.HelloWorld",
            AssetName = "Navz.Plugin.HelloWorld"
        }
    });
    ```
    or using json

    ```csharp
    IConfiguration configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("plugins.json", optional: false, reloadOnChange: true)
        .Build();

    var pluginHost = new PluginHost(configuration);
    ```

    plugin.json
    ```json
    {
        "PluginConfiguration": {
            "RootPath": "Plugins",
            "Plugins": [
                {
                    "Name": "Navz.Plugin.HelloWorld",
                    "Version": "Latest",
                    "RepositoryUrl": "https://github.com/rmnavz/Navz.Plugin.HelloWorld",
                    "AssetName": "Navz.Plugin.HelloWorld"
                }
            ]
        }
    }
    ```

2. Load the plugins using the pluginHost:

    ```csharp
    var commandPlugins = await pluginHost.LoadPluginsAsync<ICommandPlugin>();

    foreach (var commandPlugin in commandPlugins)
    {
        await commandPlugin.Execute();
    }
    ```