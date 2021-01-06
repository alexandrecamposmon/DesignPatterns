using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Abstract_Factory
{
    public class CozinharDoceFactory : CozinhaFactory
    {
        public override Alimento CriarAlimento(string Nome, TipoAlimento tipoAlimento)
        {
            return AlimentoCreator.Criar(Nome, tipoAlimento);
        }

        public override Panela CriarPanela()
        {
            return PanelaCreator.Criar(TipoAlimento.Doce);
        }
    }
}
