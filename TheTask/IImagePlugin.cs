namespace TheTask;

/// <summary>
/// Creating the interface.
/// </summary>
public interface IImagePlugin
{
    string Name { get; }
    void ApplyEffect(Image image, Dictionary<string, object> parameters);
}
