using System.Drawing;

namespace TagsCloudVisualization;

public class CloudVisualiser : ICloudVisualiser
{
    public CloudVisualiser() { }

    public void VisualiseAndSave(IEnumerable<Rectangle> rectangles, string path, Size bitmapSize)
    {
        var bitmap = new Bitmap(bitmapSize.Width, bitmapSize.Height);
        var graphics = Graphics.FromImage(bitmap);
        graphics.Clear(Color.White);

        foreach (var rectangle in rectangles)
        {
            var brash = new SolidBrush(GetRandomColor());
            graphics.FillRectangle(brash, rectangle);
        }

        bitmap.Save(path);
    }

    private Color GetRandomColor()
    {
        var random = new Random();

        return Color.FromArgb(random.Next(0, 255), random.Next(0,255), random.Next(0,255));
    }
}
