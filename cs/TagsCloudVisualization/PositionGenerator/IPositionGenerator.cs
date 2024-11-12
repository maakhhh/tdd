using System.Drawing;

namespace TagsCloudVisualization;

public interface IPositionGenerator
{
    public Point GetNextPosition();
}
