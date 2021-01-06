using System;

namespace DesignPatterns.Abstract_Factory
{
    public abstract class Panela
    {
        protected Panela(TipoAlimento tipoAlimento)
        {
            TipoAlimento = tipoAlimento;
        }
        public TipoAlimento TipoAlimento { get; set; }
        public abstract void Cozinhar(Alimento alimento);
    }
    public class PanelaForma : Panela //Para agridoce
    {
        public PanelaForma(TipoAlimento tipoAlimento) : base(tipoAlimento)
        {
        }

        public override void Cozinhar(Alimento alimento)
        {
            Console.WriteLine("Cozinhando uma comida agridoce - Nome do prato: " + alimento.Nome);
        }
    }
    public class PanelaPipoqueira : Panela //Para doce
    {
        public PanelaPipoqueira(TipoAlimento tipoAlimento) : base(tipoAlimento)
        {
        }

        public override void Cozinhar(Alimento alimento)
        {
            Console.WriteLine("Cozinhando uma comida doce - Nome do prato: " + alimento.Nome);
        }
    }
    public class PanelaFrigideira : Panela //Para salgado
    {
        public PanelaFrigideira(TipoAlimento tipoAlimento) : base(tipoAlimento)
        {
        }

        public override void Cozinhar(Alimento alimento)
        {
            Console.WriteLine("Cozinhando uma comida salgada - Nome do prato: " + alimento.Nome);
        }
    }

    public class PanelaCreator
    {
        public static Panela Criar(TipoAlimento tipoAlimento)
        {
            switch (tipoAlimento)
            {
                case TipoAlimento.Agridoce:
                    return new PanelaForma(tipoAlimento);
                case TipoAlimento.Doce:
                    return new PanelaPipoqueira(tipoAlimento);
                case TipoAlimento.Salgado:
                    return new PanelaFrigideira(tipoAlimento);
                default:
                    return new PanelaFrigideira(tipoAlimento);
            }
        }
    }
}
