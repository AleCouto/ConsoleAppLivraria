using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria
{
    public partial class Autor
    {
        public void registarAutores()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Registar Novo Autor");
            Console.Write("Nome do Autor: ");
            nomeautor = Convert.ToString(Console.ReadLine());
            Console.Write("País: ");
            pais = Convert.ToString(Console.ReadLine());
            Console.Write("Língua: ");
            lingua = Convert.ToString(Console.ReadLine());
            Console.ReadLine();
        }

        public void MostrarAutores()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Nome do Autor:" + nomeautor);
            Console.WriteLine("País.........:" + pais);
            Console.WriteLine("Língua:......:" + lingua);
        }
    }
}

