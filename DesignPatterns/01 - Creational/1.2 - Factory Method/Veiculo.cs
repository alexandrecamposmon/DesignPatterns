using System;

namespace DesignPatterns.Factory_Method
{
    public abstract class Veiculo
    {
        public Veiculo(string nomeVeiculo, TipoVeiculo tipoVeiculo)
        {
            NomeVeiculo = nomeVeiculo;
            TipoVeiculo = tipoVeiculo;
        }
        public string NomeVeiculo { get; set; }
        public TipoVeiculo TipoVeiculo { get; set; }
        public abstract void RealizarEntrega();
    }

    public enum TipoVeiculo
    {
        Maritimo,
        Terrestre
    }

    public class Caminhao : Veiculo
    {
        public Caminhao(string nomeVeiculo, TipoVeiculo tipoVeiculo) : base(nomeVeiculo, tipoVeiculo)
        {
            NomeVeiculo = nomeVeiculo;
            TipoVeiculo = tipoVeiculo;
        }
        public override void RealizarEntrega()
        {
            Console.WriteLine("Realizando entrega com: " + NomeVeiculo + " Tipo: " + TipoVeiculo);
        }
    }

    public class Navio : Veiculo
    {
        public Navio(string nomeVeiculo, TipoVeiculo tipoVeiculo) : base(nomeVeiculo, tipoVeiculo)
        {
            NomeVeiculo = nomeVeiculo;
            TipoVeiculo = tipoVeiculo;
        }
        public override void RealizarEntrega()
        {
            Console.WriteLine("Realizando entrega com: " + NomeVeiculo + " Tipo: " + TipoVeiculo);
        }
    }
    public class VeiculoCreator
    {
        public static Veiculo Criar(string nome, TipoVeiculo tipoVeiculo)
        {
            switch (tipoVeiculo)
            {
                case TipoVeiculo.Maritimo:
                    return new Navio(nome, tipoVeiculo);
                case TipoVeiculo.Terrestre:
                    return new Caminhao(nome, tipoVeiculo);
                default:
                    throw new Exception("Não foi possível realizar a criação do veículo!");
            }
        }
    }
}
