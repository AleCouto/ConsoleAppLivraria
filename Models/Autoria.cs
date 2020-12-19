using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Livraria
{
    public class Autoria
    {
        public int autoriaId { get; set; }


        [ForeignKey("Livro")]
        public int livroId { get; set; }
        public Livro Livro { get; set; }

        [ForeignKey("Autor")]
        public int autorId { get; set; }
        public Autor Autor { get; set; }
    }
}
