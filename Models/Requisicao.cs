using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Livraria
{
    public class Requisicao
    {
        public int requisicaoId { get; set; }
        public DateTime dataRequisicao { get; set; }
        public DateTime dataDevolucao { get; set; }

        [ForeignKey("Livro")]
        public int livroId { get; set; }
        public Livro Livro { get; set; }

        [ForeignKey("Localidade")]
        public int localidadeId { get; set; }
        public Localidade Localidade { get; set; }
    }

}
