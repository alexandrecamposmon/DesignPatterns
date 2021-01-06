using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Abstract_Factory
{
    public abstract class CozinhaFactory
    {
        public abstract Panela CriarPanela();
        public abstract Alimento CriarAlimento(string Nome, TipoAlimento tipoAlimento);
    }
}
