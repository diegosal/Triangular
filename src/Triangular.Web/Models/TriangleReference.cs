namespace Triangular.Web.Models;

public class TriangleReference
{
    public char row { get; set; }
    public int column { get; set; }

    public TriangleReference()
    {
        row = default;
        column = 0;
    }
}

