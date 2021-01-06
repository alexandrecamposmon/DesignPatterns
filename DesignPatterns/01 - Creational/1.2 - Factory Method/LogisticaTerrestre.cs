using System;

namespace DesignPatterns.Factory_Method
{
    public class LogisticaTerrestre
    {
        public Veiculo RealizarEntregaTerrestre(Veiculo veiculo)
        {
            Console.WriteLine("Criação de rota pela rodovia efetuada com sucesso!");
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
