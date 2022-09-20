namespace Triangular.Api.Models;

public class GridTriangle
{
    public int Height { get; private set; }
    public int Width { get; private set; }
    public int CellSize { get; private set; }
    public int VertexXX { get; private set; }
    public int VertexXY { get; private set; }
    public int VertexYX { get; private set; }
    public int VertexYY { get; private set; }
    public int VertexZX { get; private set; }
    public int VertexZY { get; private set; }

    public GridTriangle(int height, int width, int cellSize, int vertexXX, int vertexXY, int vertexYX, int vertexYY, int vertexZX, int vertexZY)
    {
        Height = height;
        Width = width;
        CellSize = cellSize;
        VertexXX = vertexXX;
        VertexXY = vertexXY;
        VertexYX = vertexYX;
        VertexYY = vertexYY;
        VertexZX = vertexZX;
        VertexZY = vertexZY;
    }
}