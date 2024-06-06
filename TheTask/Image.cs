namespace TheTask;
/// <summary>
/// Takes the name of the image and assigns it to the Name property.
/// </summary>
public class Image
{
    public string Name { get; set; }
    public Image(string name)
    {
        Name = name;
    }
}

