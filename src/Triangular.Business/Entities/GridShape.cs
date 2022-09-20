namespace Triangular.Business.Entities;

public class GridShape
{
    private readonly List<Coordinate> _coordinates = new();
    public IReadOnlyCollection<Coordinate> Coordinates => _coordinates.AsReadOnly();

    public void AddCoordinate(int coordinateX, int coordinateY)
    {
        if (!Coordinates.Any(i => i.CoordinateX == coordinateX && i.CoordinateY == coordinateY))
        {
            _coordinates.Add(new(coordinateX, coordinateY));
            return;
        }
    }
}
