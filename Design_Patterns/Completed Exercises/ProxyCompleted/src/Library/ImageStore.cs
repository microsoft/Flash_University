namespace Proxy.Library;


/**
 * All of the data contained in an image
 */
internal class ImageData
{
    public string Name { get; init; } = "";
    public int Width { get; init; } = 0;
    public int Height { get; init; } = 0;
    public string Caption { get; init; } = "";
}

/**
 * Manages loading raw image data
 *
 * In a real world scenario, this would pull images from the disk, network, etc.
 * To mimic that behavior in this example, there are a couple of Thread.Sleep() calls sprinkled throughout
 */
internal class ImageStore
{
    internal static readonly List<ImageData> Images = new ()
    {
        new ImageData { Name = "apple", Width = 128, Height = 128, Caption = "an apple" },
        new ImageData { Name = "orange", Width = 128, Height = 128, Caption = "an orange" },
        new ImageData { Name = "landscape", Width = 1024, Height = 512, Caption = "a picturesque landscape" },
        new ImageData { Name = "person", Width = 128, Height = 256, Caption = "a stock photo of a person" },
    };

    internal static List<string> GetImageNames()
    {
        // pretend this is using resources (eg getting file names from disk)
        Thread.Sleep(1000);

        return Images.Select(data => data.Name).ToList();
    }

    internal static ImageData LoadImage(string name)
    {
        // pretend this is using lots of resources (eg loading the image from disk)
        Thread.Sleep(2000);

        var data = Images.Find(image => image.Name == name);

        if (data == null)
        {
            throw new Exception($"image {name} not found");
        }

        return data;
    }
}

