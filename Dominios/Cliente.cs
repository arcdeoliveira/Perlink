using System.Collections.Generic;

namespace Entidades.Dominios
{
    public class Cliente
    {
        //propriedades        
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Estado { get; set; }


        //Relacionamentos
        public virtual ICollection<Processo> Processos { get; set; }
    }
}
