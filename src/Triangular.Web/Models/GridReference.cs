namespace Triangular.Web.Models;
public class GridReference
{
    public int Row { get; private set; }
    public char Column { get; private set; }

    public GridReference(int row, char column)
    {
        Row = row;
        Column = column;
    }

    public GridReference()
    {
        Row = default;
        Column = default;
    }

    public GridReference(int row, int column)
    {
        Row = row;
        Column = NumberToAlphabet(column);
    }

    public int GetNumericRow() => (int)Column - 64;

    public char NumberToAlphabet(int number) => (Char)(64 + number);

    public string GetReference() => $"{Row}{Column}";
}

