using Microsoft.AspNetCore.Mvc;
using LuaStatePattern.Models;
using LuaStatePattern.Services;

namespace LuaStatePattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LuaController : ControllerBase
    {
        private readonly ContextoLua _contextoLua;

        public LuaController(ContextoLua contextoLua)
        {
            _contextoLua = contextoLua;
        }

        [HttpGet]
        public IActionResult GetFaseAtual()
        {
            return Ok(new { FaseAtual = _contextoLua.ObterFaseAtual() });
        }

        [HttpPost("proximo")]
        public IActionResult ProximaFase()
        {
            _contextoLua.ProximaFase();
            return Ok(new { Mensagem = "Fase avançada com sucesso." });
        }
    }
}
