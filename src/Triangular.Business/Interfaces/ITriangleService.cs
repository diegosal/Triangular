using Triangular.Business.Entities;

namespace Triangular.Business.Interfaces;
public interface ITriangleService
{
    Task<GridShape> Calculate(Grid grid, GridReference gridReference);
}
