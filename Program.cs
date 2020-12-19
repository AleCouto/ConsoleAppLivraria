using System;

namespace Livraria
{
    class Program
    {
        public static string opc;
        public static string opc2;
        public static string opc3;
        public static string opc4;
        static void Main(string[] args)
        {
            Console.Clear();
            Inicio();
        }

        public static void Inicio()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("------------------------------");
                Console.WriteLine("Bem Vindo a Livraria 1.0");
                Console.WriteLine("------------------------------");
                Console.WriteLine("--Selecione a opção desejada--");
                Console.WriteLine("[1] Listar Todos os Livros");
                Console.WriteLine("[2] Pesquisa por Títulos");
                Console.WriteLine("[3] Pesquisa por Autor");
                Console.WriteLine("[4] Solicitar Livro");
                Console.WriteLine("[5] Registar/Gerenciar");
                Console.WriteLine("[6] Encerrar Programa");
                Console.WriteLine("------------------------------");
                Console.Write("Opção: ");
                opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        Console.WriteLine();
                        ListarLivro();
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine();
                        PesquisaTitulo();
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine();
                        PesquisaAutor();
                        Console.ReadLine();
                        break;

                    case "4":
                        Console.WriteLine();
                        SolicitarLivro();
                        Console.ReadLine();
                        break;

                    case "5":
                        Console.WriteLine();
                        Registar();
                        Console.ReadLine();
                        break;

                    case "6":
                        Console.WriteLine();
                        Console.WriteLine("Fim Do Programa Livraria 1.0");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Opção Invalida!!");
                        Console.ReadLine();
                        break;
                }
            } while (opc != "6");
        }

        public static void Remover()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("------------------------------");
                Console.WriteLine("Bem Vindo a Livraria 1.0");
                Console.WriteLine("------------------------------");
                Console.WriteLine("--Selecione a opção desejada--");
                Console.WriteLine("[1] Remover Livro");
                Console.WriteLine("[2] Remover Usuário");
                Console.WriteLine("[3] Remover Editora");
                Console.WriteLine("[4] Remover Autor");
                Console.WriteLine("[5] Voltar");
                Console.WriteLine("------------------------------");
                Console.Write("Opção: ");
                opc3 = Console.ReadLine();
                switch (opc3)
                {
                    case "1":
                        Console.WriteLine();
                        RemoverLivro();
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine();
                        RemoverUsuario();
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine();
                        RemoverEditora();
                        Console.ReadLine();
                        break;

                    case "4":
                        Console.WriteLine();
                        RemoverAutor();
                        Console.ReadLine();
                        break;

                    case "5":
                        Console.WriteLine();
                        Voltar();
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Opção Invalida!!");
                        Console.ReadLine();
                        break;
                }
            } while (opc3 != "5");
        }

        private static void RemoverAutor()
        {
            Tratamento.RemoverAutores();
        }
        private static void RemoverEditora()
        {
            Tratamento.RemoverEditoras();
        }

        private static void RemoverUsuario()
        {
            Tratamento.RemoverUsuarios();
        }

        private static void RemoverLivro()
        {
            Tratamento.RemoverLivros();
        }

        private static void SolicitarLivro()
        {
            throw new NotImplementedException();
        }

        private static void PesquisaAutor()
        {
            Tratamento.PesquisaAutores();
        }

        private static void PesquisaTitulo()
        {
            Tratamento.PesquisaTitulos();
        }

        private static void ListarLivro()
        {
            Tratamento.ListarLivros();
        }

        public static void Registar()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("------------------------------");
                Console.WriteLine("Bem Vindo a Livraria 1.0");
                Console.WriteLine("------------------------------");
                Console.WriteLine("--Selecione a opção desejada--");
                Console.WriteLine("[1] Novo Livro");
                Console.WriteLine("[2] Novo Usuário");
                Console.WriteLine("[3] Nova Editora");
                Console.WriteLine("[4] Novo Autor");
                Console.WriteLine("[5] Listar Usuários");
                Console.WriteLine("[6] Listar Editoras");
                Console.WriteLine("[7] Listar Autores");
                Console.WriteLine("[8] Editar Registos");
                Console.WriteLine("[9] Voltar");
                Console.WriteLine("------------------------------");
                Console.Write("Opção: ");
                opc2 = Console.ReadLine();
                switch (opc2)
                {
                    case "1":
                        Console.WriteLine();
                        NovoLivro();
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine();
                        NovoUsuario();
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine();
                        NovaEditora();
                        Console.ReadLine();
                        break;

                    case "4":
                        Console.WriteLine();
                        NovoAutor();
                        Console.ReadLine();
                        break;

                    case "5":
                        Console.WriteLine();
                        ListarUsuarios();
                        Console.ReadLine();
                        break;

                    case "6":
                        Console.WriteLine();
                        ListarEditoras();
                        Console.ReadLine();
                        break;

                    case "7":
                        Console.WriteLine();
                        ListarAutores();
                        Console.ReadLine();
                        break;

                    case "8":
                        Console.WriteLine();
                        EditarRegisto();
                        Console.ReadLine();
                        break;

                    case "9":
                        Console.WriteLine();
                        Voltar();
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Opção Invalida!!");
                        Console.ReadLine();
                        break;
                }
            } while (opc2 != "9");

        }

        private static void Voltar()
        {
            Inicio();
        }

        private static void ListarAutores()
        {
            Tratamento.ListAutores();
        }

        private static void ListarEditoras()
        {
            Tratamento.ListEditoras();
        }

        private static void ListarUsuarios()
        {
            Tratamento.ListUsuarios();
        }

        private static void NovoAutor()
        {
            Tratamento.AddNovoAutor();
        }

        private static void NovaEditora()
        {
            Tratamento.AddNovaEditora();
        }

        private static void NovoUsuario()
        {
            Tratamento.AddNovoUsuario();
        }

        private static void NovoLivro()
        {
            Tratamento.AddNovoLivro();
        }

        public static void EditarRegisto()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("------------------------------");
                Console.WriteLine("Bem Vindo a Livraria 1.0");
                Console.WriteLine("------------------------------");
                Console.WriteLine("--Selecione a opção desejada--");
                Console.WriteLine("[1] Editar Livro");
                Console.WriteLine("[2] Editar Usuário");
                Console.WriteLine("[3] Editar Editora");
                Console.WriteLine("[4] Editar Autor");
                Console.WriteLine("[5] Remover");
                Console.WriteLine("[6] Voltar");
                Console.WriteLine("------------------------------");
                Console.Write("Opção: ");
                opc4 = Console.ReadLine();
                switch (opc4)
                {
                    case "1":
                        Console.WriteLine();
                        EditarLivro();
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine();
                        EditarUsuario();
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine();
                        EditarEditora();
                        Console.ReadLine();
                        break;

                    case "4":
                        Console.WriteLine();
                        EditarAutor();
                        Console.ReadLine();
                        break;

                    case "5":
                        Console.WriteLine();
                        Remover();
                        Console.ReadLine();
                        break;

                    case "6":
                        Console.WriteLine();
                        Voltar();
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Opção Invalida!!");
                        Console.ReadLine();
                        break;
                }
            } while (opc2 != "6");
        }

        private static void EditarAutor()
        {
            Tratamento.EditarAutores();
        }

        private static void EditarEditora()
        {
            Tratamento.EditarEditoras();
        }

        private static void EditarUsuario()
        {
            Tratamento.EditarUsuarios();
        }

        private static void EditarLivro()
        {
            Tratamento.EditarLivros();
        }
    }
}
