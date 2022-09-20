using Triangular.Business.Entities;
using Triangular.Business.Interfaces;

namespace Triangular.Business.Services;

public class TriangleServiceFactory : ITriangleServiceFactory
{
    public async Task<ITriangleService?> Make(GridReference gridReference)
    {
        ITriangleService? triangleService = null;

        await Task.Run(() =>
        {
            if (gridReference.Column % 2 == 0)
            {
                triangleService = new RightTriangleService();
            }
            else
            {
                triangleService = new LeftTriangleService();
            }
        });

        return triangleService;
    }
}
