using LuaStatePattern.Services;

namespace LuaStatePattern.Models
{
    public class QuartoMinguante : IFaseLua
    {
        public void ProximaFase(ContextoLua contexto)
        {
            contexto.DefinirFase(new LuaNova());
        }
    }
}
