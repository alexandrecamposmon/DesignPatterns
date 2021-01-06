using System;

namespace DesignPatterns.Factory_Method
{
    public class LogisticaMaritima
    {
        public Veiculo RealizarEntregaMaritima(Veiculo veiculo)
        {
            Console.WriteLine("Criação de rota pelo mar efetuada com sucesso!");
            switch (veiculo.TipoVeiculo)
            {
                case TipoVeiculo.Maritimo:
                    return new Navio(veiculo.NomeVeiculo, veiculo.TipoVeiculo);
                case TipoVeiculo.Terrestre:
                    return new Caminhao(veiculo.NomeVeiculo, veiculo.TipoVeiculo);
                default:
                    throw new Exception("Falha ao realizar a entrega");
            }
        }
    }
}
