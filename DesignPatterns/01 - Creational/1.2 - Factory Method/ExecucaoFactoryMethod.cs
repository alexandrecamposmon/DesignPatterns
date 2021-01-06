using System.Collections.Generic;

namespace DesignPatterns.Factory_Method
{
    public class ExecucaoFactoryMethod
    {
        public static void Executar()
        {
            var veiculos = new List<Veiculo>
            {
                VeiculoCreator.Criar("Caminhão", TipoVeiculo.Terrestre),
                VeiculoCreator.Criar("Navio", TipoVeiculo.Maritimo)
            };
            veiculos.ForEach(x => new Logistica().Entregar(x).RealizarEntrega());
        }
    }
}
