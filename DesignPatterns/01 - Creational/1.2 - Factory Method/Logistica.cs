using System;

namespace DesignPatterns.Factory_Method
{
    public class Logistica
    {
        public Veiculo Entregar(Veiculo veiculo)
        {
            switch (veiculo.TipoVeiculo)
            {
                case TipoVeiculo.Maritimo:
                    return new LogisticaMaritima().RealizarEntregaMaritima(veiculo);
                case TipoVeiculo.Terrestre:
                    return new LogisticaTerrestre().RealizarEntregaTerrestre(veiculo);
                default:
                    throw new Exception("Falha ao realizar entrega!");
            }
        }
    }
}
