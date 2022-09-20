namespace Triangular.Business.Entities;

public class Triangle: GridShape
{
    public Coordinate VertexCoordinateX { get; private set; }
    public Coordinate VertexCoordinateY { get; private set; }
    public Coordinate VertexCoordinateZ { get; private set; }

    public Triangle(Coordinate vertexCoordinateX, Coordinate vertexCoordinateY, Coordinate vertexCoordinateZ)
    {
        VertexCoordinateX = vertexCoordinateX;
        VertexCoordinateY = vertexCoordinateY;
        VertexCoordinateZ = vertexCoordinateZ;

        AddCoordinate(VertexCoordinateX.CoordinateX, VertexCoordinateX.CoordinateY);
        AddCoordinate(VertexCoordinateY.CoordinateX, VertexCoordinateY.CoordinateY);
        AddCoordinate(VertexCoordinateZ.CoordinateX, VertexCoordinateZ.CoordinateY);
    }
}
