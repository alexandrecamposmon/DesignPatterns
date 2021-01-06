using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Abstract_Factory
{
    public class Cozinha
    {
        private readonly Alimento _alimento;
        private readonly Panela _panela;

        public Cozinha(CozinhaFactory factory, Alimento alimento)
        {
            _alimento = factory.CriarAlimento(alimento.Nome, alimento.TipoAlimento);
            _panela = factory.CriarPanela();
        }
        public void RealizarComida()
        {
            _panela.Cozinhar(_alimento);
        }

        public static Cozinha Cozinhar(Alimento alimento)
        {
            switch (alimento.TipoAlimento)
            {
                case TipoAlimento.Agridoce:
                    return new Cozinha(new CozinharAgridoceFactory(), alimento);
                case TipoAlimento.Doce:
                    return new Cozinha(new CozinharDoceFactory(), alimento);
                case TipoAlimento.Salgado:
                    return new Cozinha(new CozinharSalgadoFactory(), alimento);
                default:
                    throw new Exception("Não foi possível cozinhar!");
            }
        }


    }
}
