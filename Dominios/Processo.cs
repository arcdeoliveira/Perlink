using System;

namespace Entidades.Dominios
{
    public class Processo
    {
        //propriedades
        public int IdProcesso { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }
        public DateTime Criacao { get; set; }
        public string Local { get; set; }
        public decimal Valor { get; set; }


        //relacionamento
        public virtual Cliente Cliente { get; set; }
    }
}
