using Triangular.Business.Entities;

namespace Triangular.Business.Interfaces;

public interface ITriangleServiceFactory
{
    Task<ITriangleService?> Make(GridReference gridReference);
}
