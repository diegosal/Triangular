namespace Triangular.Web.Models;

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

    public GridTriangle(int height, int width, int cellSize, string[] triangleX, string[] triangleY, string[] triangleZ)
    {
        int vertexXX;
        int vertexXY;
        int vertexYX;
        int vertexYY;
        int vertexZX;
        int vertexZY;

        _ = int.TryParse(triangleX[0], out vertexXX);
        _ = int.TryParse(triangleX[1], out vertexXY);

        _ = int.TryParse(triangleY[0], out vertexYX);
        _ = int.TryParse(triangleY[1], out vertexYY);

        _ = int.TryParse(triangleZ[0], out vertexZX);
        _ = int.TryParse(triangleZ[1], out vertexZY);


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