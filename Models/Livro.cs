using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria
{
    public partial class Livro
    {
        public int livroId { get; set; }
        public string titulo { get; set; }
        public int? ano { get; set; }
        public string? genero { get; set; }
        public decimal? preco { get; set; }
        public int? quantidade { get; set; }

        [ForeignKey("Editora")]
        public int? editoraId { get; set; }
        public Editora Editora { get; set; }

        public ICollection<Autoria> Autorias { get; set; }
    }
   
}


