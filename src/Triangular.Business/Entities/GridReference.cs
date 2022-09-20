namespace Triangular.Business.Entities;

public class GridReference
{
    public char Row { get; private set; }
    public int Column { get; private set; }

    public GridReference(char row, int column)
    {
        Row = row;
        Column = column;
    }
    public GridReference(int row, int column)
    {
        Row = NumberToAlphabet(row);
        Column = column;
    }

    public int GetNumericRow() => (int)Row - 64;


    public char NumberToAlphabet(int number) => (Char)(64 + number);
}
