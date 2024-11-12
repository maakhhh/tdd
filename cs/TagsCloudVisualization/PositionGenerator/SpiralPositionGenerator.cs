using System.Drawing;

namespace TagsCloudVisualization;

public class SpiralPositionGenerator : IPositionGenerator
{
    private const double ANGLE_OFFSET = 0.1;
    private readonly Point center;
    private readonly double step;
    private double angle;

    public SpiralPositionGenerator(Point center, double step = 0.1)
    {
        this.step = step;
        this.center = center;
        angle = 0;
    }

    public Point GetNextPosition()
    {
        var radius = step * angle;
        var x = (int) (center.X + radius * Math.Cos(angle));
        var y = (int) (center.Y + radius * Math.Sin(angle));

        angle += ANGLE_OFFSET;

        return new(x, y);
    }
}
