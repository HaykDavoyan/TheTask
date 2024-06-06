using static System.Net.Mime.MediaTypeNames;

namespace TheTask;
/// <summary>
/// Retrieves the new size from the parameters and prints a message.
/// </summary>
public class ResizePlugin : IImagePlugin
{
    public string Name => "Resize";

    public void ApplyEffect(Image image, Dictionary<string, object> parameters)
    {
        int newSize = (int)parameters["Size"];
        Console.WriteLine($"Resizing image to {newSize} pixels.");
    }
}
