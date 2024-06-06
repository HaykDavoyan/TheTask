using static System.Net.Mime.MediaTypeNames;

namespace TheTask;
/// <summary>
/// Creating the methods for adds a plugin to the list,removes a plugin from the list by its name,
/// returns a plugin by its name,applies a list of effects to an image using the appropriate plugins,
/// </summary>
public class PluginManager
{
    private readonly List<IImagePlugin> plugins = new List<IImagePlugin>();

    public void AddPlugin(IImagePlugin plugin)
    {
        plugins.Add(plugin);
    }

    public void RemovePlugin(string pluginName)
    {
        plugins.RemoveAll(p => p.Name == pluginName);
    }

    public IImagePlugin GetPlugin(string pluginName)
    {
        return plugins.FirstOrDefault(p => p.Name == pluginName);
    }

    public void ApplyPlugins(Image image, List<(string PluginName, Dictionary<string, object> Parameters)> effects)
    {
        foreach (var effect in effects)
        {
            var plugin = GetPlugin(effect.PluginName);
            plugin?.ApplyEffect(image, effect.Parameters);
        }
    }
}

