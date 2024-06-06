using static System.Net.Mime.MediaTypeNames;
using System;
namespace TheTask;

public class Program
{
    static void Main(string[] args)
    {
        var pluginManager = new PluginManager();
        
        pluginManager.AddPlugin(new ResizePlugin());
        pluginManager.AddPlugin(new BlurPlugin());
        pluginManager.AddPlugin(new GrayscalePlugin());

        var images = new List<(Image Image, List<(string PluginName, Dictionary<string, object> Parameters)> Effects)>
        {
            (new Image("Image1"), new List<(string, Dictionary<string, object>)>
            {
                ("Resize", new Dictionary<string, object> { { "Size", 100 } }),
                ("Blur", new Dictionary<string, object> { { "BlurSize", 2 } })
            }),
            (new Image("Image2"), new List<(string, Dictionary<string, object>)>
            {
                ("Resize", new Dictionary<string, object> { { "Size", 100 } })
            }),
            (new Image("Image3"), new List<(string, Dictionary<string, object>)>
            {
                ("Resize", new Dictionary<string, object> { { "Size", 150 } }),
                ("Blur", new Dictionary<string, object> { { "BlurSize", 5 } }),
                ("Grayscale", new Dictionary<string, object>())
            })
        };

        foreach (var (image, effects) in images)
        {
            Console.WriteLine($"Processing {image.Name}");
            pluginManager.ApplyPlugins(image, effects);
        }
    }
}