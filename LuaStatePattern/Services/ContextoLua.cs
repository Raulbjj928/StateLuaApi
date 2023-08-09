// ContextoLua.cs
using LuaStatePattern.Models;
using System;

namespace LuaStatePattern.Services
{
    public class ContextoLua
    {
        private IFaseLua _faseAtual;

        public ContextoLua()
        {
            _faseAtual = new LuaNova();
        }

        public void DefinirFase(IFaseLua fase)
        {
            _faseAtual = fase;
        }

        public string ObterFaseAtual()
        {
            return _faseAtual.GetType().Name;
        }

        public void ProximaFase()
        {
            _faseAtual.ProximaFase(this);

            _faseAtual = _faseAtual switch
            {
                LuaNova => new QuartoCrescente(),
                QuartoCrescente => new LuaCheia(),
                LuaCheia => new QuartoMinguante(), // Adicione essa linha para corrigir
                QuartoMinguante => new LuaNova()
            };
        }
    }
}
