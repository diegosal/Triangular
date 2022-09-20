using Triangular.Business.Entities;
using Triangular.Business.Interfaces;

namespace Triangular.Business.Services;

internal class RightTriangleService : ITriangleService
{
    public async Task<GridShape> Calculate(Grid grid, GridReference gridReference)
    {
        GridShape gridShape = new();

        await Task.Run(() =>
        {
            int topLeftX = (((gridReference.Column / 2) - 1) * grid.CellSize);
            int leftY = (gridReference.GetNumericRow() - 1) * grid.CellSize;

            int bottomX = topLeftX + grid.CellSize;
            int bottomRightY = leftY + grid.CellSize;

            gridShape = new();
            gridShape.AddCoordinate(topLeftX, leftY);
            gridShape.AddCoordinate(bottomX, leftY);
            gridShape.AddCoordinate(bottomX, bottomRightY);
        });

        return gridShape;
    }
}
