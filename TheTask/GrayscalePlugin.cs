using static System.Net.Mime.MediaTypeNames;

namespace TheTask;
/// <summary>
/// Prints a message about the conversion.
/// </summary>
public class GrayscalePlugin : IImagePlugin
{
    public string Name => "Grayscale";

    public void ApplyEffect(Image image, Dictionary<string, object> parameters)
    {
        Console.WriteLine("Converting image to grayscale.");
    }
}
