using static System.Net.Mime.MediaTypeNames;

namespace TheTask;
/// <summary>
/// Retrieves the blur size from the parameters and prints a message.
/// </summary>
public class BlurPlugin : IImagePlugin
{
    public string Name => "Blur";

    public void ApplyEffect(Image image, Dictionary<string, object> parameters)
    {
        int blurSize = (int)parameters["BlurSize"];
        Console.WriteLine($"Applying blur of size {blurSize} pixels.");
    }
}
