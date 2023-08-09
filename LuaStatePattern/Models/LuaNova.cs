using LuaStatePattern.Services;

namespace LuaStatePattern.Models
{
    public class LuaNova : IFaseLua
    {
        public void ProximaFase(ContextoLua contexto)
        {
            contexto.DefinirFase(new QuartoCrescente());
        }
    }
}
