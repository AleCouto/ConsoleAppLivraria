using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Livraria
{
    public class LivrariaContext : DbContext
    {
        public DbSet<Livro> DLivros { get; set; }
        public DbSet<Autor> DAutores { get; set; }
        public DbSet<Usuario> DUsuarios { get; set; }
        public DbSet<Editora> DEditoras { get; set; }
        public DbSet<Requisicao> DRequisicoes { get; set; }
        public DbSet<Autoria> Autorias { get; set; }
        public DbSet<Localidade> Localidades { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

           optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=LivrosBasaDeDados;Trusted_Connection=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>().HasData(
                new Autor() { autorId = 1, nomeautor = "Jose Saramago", pais = "Portugal", lingua = "português" },
                new Autor() { autorId = 2, nomeautor = "Fernando Pessoa", pais = "Portugal", lingua = "português" },
                new Autor() { autorId = 3, nomeautor = "Eça de Queirós", pais = "Portugal", lingua = "português" },
                new Autor() { autorId = 4, nomeautor = "Miguel Torga", pais = "Portugal", lingua = "português" }
             );
            modelBuilder.Entity<Editora>().HasData(
                new Editora() { editoraId = 1, nomeEditora = "Porto", telefone = 226088322, email = "porto@porto.com.pt", morada = "Rua da Restauração", numeroPorta = 365, fracao = "na", codigoPostal = 4099023, webSite = "www.portoeditora.pt" },
                new Editora() { editoraId = 2, nomeEditora = "Bertrand Editora", telefone = 217626000, email = "bertrand@editoa.com.pt", morada = "Rua Professor Jorge Silva Horta", numeroPorta = 1, fracao = "na", codigoPostal = 1500499, webSite = "www.bertrandeditora.pt" },
                new Editora() { editoraId = 3, nomeEditora = "Leya", telefone = 214272200, email = "leya@editora.com.pt", morada = "Rua Cidade de Córdova", numeroPorta = 2, fracao = "na", codigoPostal = 42610038, webSite = "www.leya.com" }
             );
            modelBuilder.Entity<Livro>().HasData(
                new Livro() { livroId = 1, titulo = "Ensaio sobre a Cegueira", ano = 1995, genero = "Romance", preco = 17, quantidade = 100, editoraId = 1 },
                new Livro() { livroId = 2, titulo = "Poemas Completos de Alberto Caeiro", ano = 1946, genero = "Poesia", preco = 18, quantidade = 150, editoraId = 2 },
                new Livro() { livroId = 3, titulo = "O Primo Basílio", ano = 1878, genero = "Romance", preco = 8, quantidade = 150, editoraId = 3 },
                new Livro() { livroId = 4, titulo = "Bichos", ano = 1940, genero = "Poesia", preco = 10, quantidade = 150, editoraId = 1 }
             );
            modelBuilder.Entity<Autoria>().HasData(
                new Autoria() { autoriaId = 1, autorId = 1, livroId =1 },
                new Autoria() { autoriaId = 2, autorId = 2, livroId = 2 },
                new Autoria() { autoriaId = 3, autorId = 3, livroId = 3 },
                new Autoria() { autoriaId = 4, autorId = 4, livroId = 4 }
             );
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario() { usuarioId = 1, nomeUsuario = "Alexandre Couto", telefone = 222222222, email = "aecmar@hotmail.com", morada = "Rua Vitimas da Guerra", numeroPorta = 30, fracao = "anexo a", codigoPostal = 2825420, dataNascimento = null, bilheteIdentidade = 6666666, contribuinte = 294260250},
                new Usuario() { usuarioId = 2, nomeUsuario = "João Golçalves", telefone = 333333333, email = "jg@hotmail.com", morada = "Rua Lisboa", numeroPorta = 40, fracao = "na", codigoPostal = 1234567, dataNascimento = null, bilheteIdentidade = 7777777, contribuinte = 289076145 },
                new Usuario() { usuarioId = 3, nomeUsuario = "Pedro Jose", telefone = 444444444, email = "apjose@hotmail.com", morada = "Rua Almirante reis", numeroPorta = 3, fracao = "2E", codigoPostal = 7654321, dataNascimento = null, bilheteIdentidade = 8888888, contribuinte = 876956456 }
             );
            modelBuilder.Entity<Localidade>().HasData(
                new Localidade() { localidadeId = 1, Local = "Lisboa" },
                new Localidade() { localidadeId = 2, Local = "Porto" }
             );
            modelBuilder.Entity<Requisicao>().HasData(
                new Requisicao() { requisicaoId = 1, localidadeId = 1, livroId = 2 },
                new Requisicao() { requisicaoId = 2, localidadeId = 2, livroId = 1 },
                new Requisicao() { requisicaoId = 3, localidadeId = 1, livroId = 4 },
                new Requisicao() { requisicaoId = 4, localidadeId = 2, livroId = 3 }
             );
        }
    }
}
