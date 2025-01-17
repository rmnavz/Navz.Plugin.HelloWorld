using Navz.Plugin.HelloWorld.UnitTest.Helpers;

namespace Navz.Plugin.HelloWorld.UnitTest;
public class HelloWorldPluginTests
{
    [Fact]
    public async Task ShouldDisplayHelloWorld()
    {
        // Arrange
        var plugin = new HelloWorldPlugin();

        // Capture console output
        using var consoleOutput = new ConsoleOutput();

        // Act
        var result = await plugin.Execute();

        // Assert
        Assert.Equal(0, result); // Validate return value
        Assert.Contains("Hello World!", consoleOutput.GetOutput());
    }
}