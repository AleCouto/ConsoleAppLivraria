using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Livraria
{
    public partial class Usuario
    {
        public int usuarioId { get; set; }
        public string nomeUsuario { get; set; }
        public int telefone { get; set; }
        public string email { get; set; }
        public string morada { get; set; }
        public int numeroPorta { get; set; }
        public string fracao { get; set; }
        public int codigoPostal { get; set; }
        public DateTime? dataNascimento { get; set; }
        public int bilheteIdentidade { get; set; }
        public int contribuinte { get; set; }
        public ICollection<Requisicao> Requisicoes { get; set; }
        public ICollection<Livro> Livros { get; set; }

    }
}
