using System.Drawing;
namespace TagsCloudVisualization;

public static class Program
{
    public static void Main()
    {
        var rectanglesCounts = new int[3] { 50, 100, 200 };
        var imageSize = new Size(800, 800);
        
        foreach (var count in rectanglesCounts)
        {
            var cloud = CloudGenerator
                .GenerateRandomCloudWithCenter(new(imageSize.Width / 2, imageSize.Height / 2), count);
            var visualiser = new CloudVisualiser();
            visualiser.VisualiseAndSave(cloud.GetRectangles(), GetPathToFile(count), imageSize);
        }
    }

    private static string GetPathToFile(int rectanglesCount)
    {
        var root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
        var samplesDirectory = Path.Combine(root, "Samples");
        var fileName = $"{rectanglesCount}_tags_cloud.png";

        if (!Directory.Exists(samplesDirectory))
            Directory.CreateDirectory(samplesDirectory);

        return Path.Combine(samplesDirectory, fileName);
    }
}
