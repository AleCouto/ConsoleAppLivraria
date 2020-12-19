using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Livraria
{
    class Tratamento
    {

        public static void AddNovoLivro()
        {
            Livro novoLivro = new Livro();
            novoLivro.registarlivros();
            using (var context = new LivrariaContext())
            {
                context.DLivros.Add(novoLivro);
                context.SaveChanges();
            };
        }
        public static void AddNovoUsuario()
        {
            Usuario novoUsuario = new Usuario();
            novoUsuario.registarUsuarios();
            using (var context = new LivrariaContext())
            {
                context.DUsuarios.Add(novoUsuario);
                context.SaveChanges();
            };
        }
        public static void AddNovaEditora()
        {
            Editora novaEditora = new Editora();
            novaEditora.registarEditoras();
            using (var context = new LivrariaContext())
            {
                context.DEditoras.Add(novaEditora);
                context.SaveChanges();
            }
        }

        public static void AddNovoAutor()
        {
            Autor novoAutor = new Autor();
            novoAutor.registarAutores();
            using (var context = new LivrariaContext())
            {
                context.DAutores.Add(novoAutor);
                context.SaveChanges();
            }
        }
        public static void ListarLivros()
        {
            using (var context = new LivrariaContext())
            {
                foreach (var item in context.DLivros)
                {
                    item.MostrarLivros();
                }

                //resolver 
                //var query3 = context.DLivros.Include("Autoria.Autor");
                //foreach (var livro in query3)
                //{
                //    livro.MostrarLivros();
                //    foreach (var Aut in livro.Autorias)
                //    {
                //        Console.WriteLine($"Autor...........:" + Aut.Autor.nomeautor);
                //    }
                //}
            }
        }
        public static void PesquisaTitulos()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Pesquisa de Livros por Título:");
            Console.Write("Título: ");
            string m = Console.ReadLine();

            using (var context = new LivrariaContext())
            {
                var query1 = from l in context.DLivros
                             where l.titulo.Contains(m)
                             select l;

                foreach (var item in query1)
                {
                    item.MostrarLivros();
                }
            }
        }
        public static void PesquisaAutores()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Pesquisa de Livros por Autores:");
            Console.Write("Autor: ");
            string m = Console.ReadLine();

            using (var context = new LivrariaContext())
            {
                var query2 = context.DAutores.Where(Autor => Autor.nomeautor.Contains(m));
                {
                    foreach (var item in query2)
                    {
                        item.MostrarAutores();
                    }
                }
            }
        }

        public static void ListUsuarios()
        {
            using (var context = new LivrariaContext())
            {
                foreach (var item in context.DUsuarios)
                {
                    item.MostrarUsuarios();
                }
            }
        }

        public static void ListEditoras()
        {
            using (var context = new LivrariaContext())
            {
                foreach (var item in context.DEditoras)
                {
                    item.MostrarEditoras();
                }
            }
        }

        public static void ListAutores()
        {
            using (var context = new LivrariaContext())
            {
                foreach (var item in context.DAutores)
                {
                    item.MostrarAutores();
                }
            }
        }

        public static void RemoverAutores()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Remover Autor:");
            Console.Write("Autor: ");
            string m = Console.ReadLine();
            using (var context = new LivrariaContext())
            {
                var query1 = from l in context.DAutores
                             where l.nomeautor.Contains(m)
                             select l;

                foreach (var item in query1)
                {
                    context.DAutores.Remove(item);
                }
                context.SaveChanges();
            }
            Console.WriteLine("Autor Removido");
        }
        public static void RemoverEditoras()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Remover Editora:");
            Console.Write("Editora: ");
            string m = Console.ReadLine();
            using (var context = new LivrariaContext())
            {
                var query1 = from l in context.DEditoras
                             where l.nomeEditora.Contains(m)
                             select l;

                foreach (var item in query1)
                {
                    context.DEditoras.Remove(item);
                }
                context.SaveChanges();
            }
            Console.WriteLine("Editora Removida");
        }
        public static void RemoverUsuarios()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Remover Usuário:");
            Console.Write("Usuário: ");
            string m = Console.ReadLine();
            using (var context = new LivrariaContext())
            {
                var query1 = from l in context.DUsuarios
                             where l.nomeUsuario.Contains(m)
                             select l;

                foreach (var item in query1)
                {
                    context.DUsuarios.Remove(item);
                }
                context.SaveChanges();
            }
            Console.WriteLine("Usuário Removido");
        }
        public static void RemoverLivros()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Remover Livro:");
            Console.Write("Título: ");
            string m = Console.ReadLine();
            using (var context = new LivrariaContext())
            {
                var query1 = from l in context.DLivros
                             where l.titulo.Contains(m)
                             select l;

                foreach (var item in query1)
                {
                    context.DLivros.Remove(item);
                }
                context.SaveChanges();
            }
            Console.WriteLine("Livro Removido");
        }

        public static void EditarLivros()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Editar Livro:");
            Console.Write("Título: ");
            string m = Console.ReadLine();
            using (var context = new LivrariaContext())
            {
                var query = from l in context.DLivros
                             where l.titulo.Contains(m)
                             select l;

                foreach (var item in query)
                {
                    item.MostrarLivros();
                    item.registarlivros();
                    context.DLivros.Update(item);
                }

                Console.WriteLine("Confirmar as Alterações: [S|N]");
                char c = Convert.ToChar(Console.ReadLine());
                if (c == 's' || c == 'S')
                {
                    context.SaveChanges();
                    Console.WriteLine("Livro alterado com sucesso");
                }
                else
                {
                    Program.Inicio();
                }
            }
        }

        public static void EditarUsuarios()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Editar Usuário:");
            Console.Write("Nome do Usuário: ");
            string m = Console.ReadLine();
            using (var context = new LivrariaContext())
            {
                var query = from l in context.DUsuarios
                            where l.nomeUsuario.Contains(m)
                            select l;

                foreach (var item in query)
                {
                    item.MostrarUsuarios();
                    item.registarUsuarios();
                    context.DUsuarios.Update(item);
                }

                Console.WriteLine("Confirmar as Alterações: [S|N]");
                char c = Convert.ToChar(Console.ReadLine());
                if (c == 's' || c == 'S')
                {
                    context.SaveChanges();
                    Console.WriteLine("Usuário alterado com sucesso");
                }
                else
                {
                    Program.Inicio();
                }
            }
        }

        public static void EditarEditoras()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Editar Editoras:");
            Console.Write("Nome da Editora: ");
            string m = Console.ReadLine();
            using (var context = new LivrariaContext())
            {
                var query = from l in context.DEditoras
                            where l.nomeEditora.Contains(m)
                            select l;

                foreach (var item in query)
                {
                    item.MostrarEditoras();
                    item.registarEditoras();
                    context.DEditoras.Update(item);
                }

                Console.WriteLine("Confirmar as Alterações: [S|N]");
                char c = Convert.ToChar(Console.ReadLine());
                if (c == 's' || c == 'S')
                {
                    context.SaveChanges();
                    Console.WriteLine("Editora alterada com sucesso");
                }
                else
                {
                    Program.Inicio();
                }
            }
        }

        public static void EditarAutores()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Editar Autores");
            Console.Write("Nome do Autor: ");
            string m = Console.ReadLine();
            using (var context = new LivrariaContext())
            {
                var query = from l in context.DAutores
                            where l.nomeautor.Contains(m)
                            select l;

                foreach (var item in query)
                {
                    item.MostrarAutores();
                    item.registarAutores();
                    context.DAutores.Update(item);
                }

                Console.WriteLine("Confirmar as Alterações: [S|N]");
                char c = Convert.ToChar(Console.ReadLine());
                if (c == 's' || c == 'S')
                {
                    context.SaveChanges();
                    Console.WriteLine("Editora alterada com sucesso");
                }
                else
                {
                    Program.Inicio();
                }
            }
        }

    }
}
