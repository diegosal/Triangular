using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Triangular.Api.Models;
using Triangular.Business.Entities;
using Triangular.Business.Interfaces;

namespace Triangular.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TriangleByGridReferenceController : ControllerBase
    {
        private readonly ITriangleByGridReferenceService TriangleByGridReferenceService;

        public TriangleByGridReferenceController(ITriangleByGridReferenceService triangleByGridReferenceService)
        {
            TriangleByGridReferenceService = triangleByGridReferenceService;
        }

        [HttpPost]
        public async Task<ActionResult<GridShape>> GetGridShape([FromBody] GridReferenceGrid gridReferenceGrid)
        {
            Grid grid = new(gridReferenceGrid.Height, gridReferenceGrid.Width, gridReferenceGrid.CellSize);
            GridReference gridReference = new(gridReferenceGrid.Row, gridReferenceGrid.Column);

            return await TriangleByGridReferenceService.Calculate(grid, gridReference);
        }
    }
}
