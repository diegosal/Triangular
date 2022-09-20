using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Triangular.Api.Models;
using Triangular.Business.Entities;
using Triangular.Business.Interfaces;
using Triangular.Business.Services;

namespace Triangular.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GridReferenceController : ControllerBase
    {
        private readonly IGridReferenceService GridReferenceService;

        public GridReferenceController(IGridReferenceService gridReferenceService)
        {
            GridReferenceService = gridReferenceService;
        }

        [HttpPost]
        public async Task<ActionResult<GridReference>> GetGridReference([FromBody] GridTriangle gridTriangle)
        {
            Grid grid = new(gridTriangle.Height, gridTriangle.Width, gridTriangle.CellSize);
            Triangle triangle = new(new Coordinate(gridTriangle.VertexXX, gridTriangle.VertexXY), new Coordinate(gridTriangle.VertexYX, gridTriangle.VertexYY), new Coordinate(gridTriangle.VertexZX, gridTriangle.VertexZY));

            return await GridReferenceService.CalculateAsync(grid, triangle);
        }
    }
}
