using Triangular.Business.Entities;

namespace Triangular.Business.Interfaces;

public interface IGridReferenceService
{
    Task<GridReference> CalculateAsync(Grid grid, Triangle triangle);
}
