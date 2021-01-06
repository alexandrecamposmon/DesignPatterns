using System.Collections.Generic;

namespace DesignPatterns.Abstract_Factory
{
    public class ExecucaoAbstractFactory
    {
        public static void Executar()
        {
            var Alimentos = new List<Alimento>
            {
                AlimentoCreator.Criar("Pipoca doce", TipoAlimento.Doce),
                AlimentoCreator.Criar("Salada com maçã", TipoAlimento.Agridoce),
                AlimentoCreator.Criar("Frango frito", TipoAlimento.Salgado)
            };

            Alimentos.ForEach(x => Cozinha.Cozinhar(x).RealizarComida());
        }
    }
}
