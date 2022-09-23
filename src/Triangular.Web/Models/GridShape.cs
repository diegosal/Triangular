namespace Triangular.Web.Models;

public class GridShape
{
    public List<Coordinate> coordinates { get; set; }

    public GridShape()
    {
        coordinates = new();
    }
}
