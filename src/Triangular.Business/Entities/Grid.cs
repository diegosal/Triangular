namespace Triangular.Business.Entities;

public class Grid
{
    public int Height { get; private set; }
    public int Width { get; private set; }
    public int CellSize { get; private set; }

    public Grid(int height, int width, int cellSize)
    {
        Height = height;
        Width = width;
        CellSize = cellSize;
    }

    public int GetRowCount() => Height / CellSize;

    public int GetColumnCount() => Width / CellSize;
}
