using Microsoft.AspNetCore.Mvc;
using TemplateAPI.Service.Dto;
using TemplateAPI.Service.Interfaces;

namespace TemplateAPI.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaConhecimentoController : ControllerBase
    {
        private readonly IAreaConhecimentoService _areaConhecimentoService;

        public AreaConhecimentoController(IAreaConhecimentoService areaConhecimentoService)
        {
            this._areaConhecimentoService = areaConhecimentoService;
        }

        [HttpGet]
        public async Task<ActionResult<List<AreaConhecimentoDto>>> BuscarAreas()
        {
            return _areaConhecimentoService.BuscarTodos();
        }
    }
}
