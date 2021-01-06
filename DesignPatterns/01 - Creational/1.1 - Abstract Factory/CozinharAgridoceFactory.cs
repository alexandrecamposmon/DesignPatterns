namespace DesignPatterns.Abstract_Factory
{
    public class CozinharAgridoceFactory : CozinhaFactory
    {
        public override Alimento CriarAlimento(string Nome, TipoAlimento tipoAlimento)
        {
            return AlimentoCreator.Criar(Nome, tipoAlimento);
        }

        public override Panela CriarPanela()
        {
            return PanelaCreator.Criar(TipoAlimento.Agridoce);
        }
    }
}
