using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Abstract_Factory
{
    public abstract class Alimento
    {
        protected Alimento(string nome, TipoAlimento tipoAlimento)
        {
            Nome = nome;
            TipoAlimento = tipoAlimento;
        }
        public string Nome { get; set; }
        public TipoAlimento TipoAlimento { get; set; }

    }

    public enum TipoAlimento
    {
        Agridoce,
        Doce,
        Salgado
    }

    public class AlimentoAgridoce : Alimento
    {
        public AlimentoAgridoce(string nome, TipoAlimento tipoAlimento) : base(nome, tipoAlimento)
        {
        }
    }
    public class AlimentoDoce : Alimento
    {
        public AlimentoDoce(string nome, TipoAlimento tipoAlimento) : base(nome, tipoAlimento)
        {
        }
    }
    public class AlimentoSalgado : Alimento
    {
        public AlimentoSalgado(string nome, TipoAlimento tipoAlimento) : base(nome, tipoAlimento)
        {
        }
    }

    public class AlimentoCreator
    {
        public static Alimento Criar(string nome, TipoAlimento tipoAlimento)
        {
            switch (tipoAlimento)
            {
                case TipoAlimento.Agridoce:
                    return new AlimentoAgridoce(nome, tipoAlimento);
                case TipoAlimento.Doce:
                    return new AlimentoDoce(nome, tipoAlimento);
                case TipoAlimento.Salgado:
                    return new AlimentoSalgado(nome, tipoAlimento);
                default:
                    return new AlimentoSalgado(nome, tipoAlimento);
            }
        }
    }

}
