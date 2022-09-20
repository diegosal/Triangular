using Triangular.Business.Entities;
using Triangular.Business.Interfaces;

namespace Triangular.Business.Services;

internal class LeftTriangleService : ITriangleService
{
    public async Task<GridShape> Calculate(Grid grid, GridReference gridReference)
    {
        GridShape gridShape = new();

        await Task.Run(() =>
        {
            int leftX = ((gridReference.Column - 1) * grid.CellSize) / 2;
            int bottomY = gridReference.GetNumericRow() * grid.CellSize;

            int topLeftY = (gridReference.GetNumericRow() - 1) * grid.CellSize;

            int bottomRightX = leftX + grid.CellSize;

            gridShape.AddCoordinate(leftX, topLeftY);
            gridShape.AddCoordinate(leftX, bottomY);
            gridShape.AddCoordinate(bottomRightX, bottomY);
        });

        return gridShape;
    }
}
