using Triangular.Business.Entities;
using Triangular.Business.Interfaces;

namespace Triangular.Business.Services;

public class TriangleByGridReferenceService : ITriangleByGridReferenceService
{
    private readonly ITriangleServiceFactory TriangleServiceFactory;

    public TriangleByGridReferenceService(ITriangleServiceFactory triangleServiceFactory)
    {
        TriangleServiceFactory = triangleServiceFactory;
    }

    public async Task<GridShape> Calculate(Grid grid, GridReference gridReference)
    {
        GridShape gridShape = new();

        ITriangleService? triangleCalculator = await TriangleServiceFactory.Make(gridReference);

        if (triangleCalculator is not null)
        {
            gridShape = await triangleCalculator.Calculate(grid, gridReference);
        }

        return gridShape;
    }
}
