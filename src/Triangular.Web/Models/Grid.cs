namespace Triangular.Web.Models;

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

    public int GetRowCount()
    {
        int rowCount = Height / CellSize;

        if (rowCount > 26)
        {
            rowCount = 26;
        }

        return rowCount;
    }

    public int GetColumnCount()
    {
        int columnCount = Width / CellSize;

        if (columnCount > 26)
        {
            columnCount = 26;
        }

        return columnCount;
    }

    public bool IsGridVisable()
    {
        bool isGridVisable = true;

        if (CellSize > Width || CellSize > Height)
        {
            isGridVisable = false;
        }

        if (Width % CellSize > 0 || Height % CellSize > 0)
        {
            isGridVisable = false;
        }

        return isGridVisable;
    }
}
