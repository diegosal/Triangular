namespace Triangular.Api.Models;

public class GridReferenceGrid
{
    public char Row { get; private set; }
    public int Column { get; private set; }
    public int Height { get; private set; }
    public int Width { get; private set; }
    public int CellSize { get; private set; }

    public GridReferenceGrid(char row, int column, int height, int width, int cellSize)
    {
        Row = row;
        Column = column;
        Height = height;
        Width = width;
        CellSize = cellSize;
    }
}

