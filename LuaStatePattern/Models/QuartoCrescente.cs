using LuaStatePattern.Services;

namespace LuaStatePattern.Models
{
    public class QuartoCrescente : IFaseLua
    {
        public void ProximaFase(ContextoLua contexto)
        {
            contexto.DefinirFase(new LuaCheia());
        }
    }
}
