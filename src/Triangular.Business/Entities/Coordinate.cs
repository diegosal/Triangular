namespace Triangular.Business.Entities;

public class Coordinate
{
    public int CoordinateX { get; private set; }
    public int CoordinateY { get; private set; }

    public Coordinate(int coordinateX, int coordinateY)
    {
        CoordinateX = coordinateX;
        CoordinateY = coordinateY;
    }
}

