using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria
{
    public partial class Editora
    {
        public int editoraId { get; set; }
        public string nomeEditora { get; set; }
        public int telefone { get; set; }
        public string email { get; set; }
        public string morada { get; set; }
        public int numeroPorta { get; set; }
        public string fracao { get; set; }
        public int codigoPostal { get; set; }
        public string webSite { get; set; }

        public ICollection<Livro> Livros { get; set; }
    }
}

