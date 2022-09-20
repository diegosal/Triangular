using Triangular.Business.Entities;

namespace Triangular.Business.Interfaces;

public interface ITriangleByGridReferenceService
{
    Task<GridShape> Calculate(Grid grid, GridReference gridReference);
}

