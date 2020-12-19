using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria
{
    public partial class Livro
    {
        public void registarlivros()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Registar Novo Livro");
            Console.Write("Título: ");
            titulo = Convert.ToString(Console.ReadLine());
            Console.Write("Ano da publicação: ");
            ano = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gênero: ");
            genero = Convert.ToString(Console.ReadLine());
            Console.Write("Preço: ");
            preco = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Quantidade: ");
            quantidade = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
        }

        public void MostrarLivros()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Título...........:" + titulo);
            Console.WriteLine("Ano da publicação:" + ano);
            Console.WriteLine("Gênero:........ .:" + genero);
            Console.WriteLine("Preço:...........:" + preco);
            Console.WriteLine("Quantidade:......:" + quantidade);
        }

        
    }

}