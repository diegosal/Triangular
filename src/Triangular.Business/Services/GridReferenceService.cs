using System.Data.Common;
using Triangular.Business.Entities;
using Triangular.Business.Interfaces;

namespace Triangular.Business.Services;

public class GridReferenceService : IGridReferenceService
{
    public async Task<GridReference> CalculateAsync(Grid grid, Triangle triangle)
    {
        int row = 0;
        int column = 0;

        await Task.Run(() =>
        {
            row = triangle.VertexCoordinateX.CoordinateY / grid.CellSize;

            if (triangle.VertexCoordinateY.CoordinateY == triangle.VertexCoordinateX.CoordinateY)
            {
                row++;
            }

            column = (triangle.VertexCoordinateX.CoordinateX / grid.CellSize) * 2;

            if (triangle.VertexCoordinateY.CoordinateX == triangle.VertexCoordinateX.CoordinateX)
            {
                column++;
            }
        });

        return new(row, column);
    }
}
