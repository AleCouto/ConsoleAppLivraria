using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria
{
    public partial class Editora
    {
        public void registarEditoras()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Registar Nova Editora");
            Console.Write("Editora: ");
            nomeEditora = Convert.ToString(Console.ReadLine());
            Console.Write("Telefone: ");
            telefone = Convert.ToInt32(Console.ReadLine());
            Console.Write("Email: ");
            email = Convert.ToString(Console.ReadLine());
            Console.Write("Morada: ");
            morada = Convert.ToString(Console.ReadLine());
            Console.Write("Número de Porta: ");
            numeroPorta = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fração: ");
            fracao = Convert.ToString(Console.ReadLine());
            Console.Write("Código Postal: ");
            codigoPostal = Convert.ToInt32(Console.ReadLine());
            Console.Write("WebSite: ");
            fracao = Convert.ToString(Console.ReadLine());
            Console.ReadLine();
        }

        public void MostrarEditoras()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Editora..........:" + nomeEditora);
            Console.WriteLine("Telefone.........:" + telefone);
            Console.WriteLine("Email:...........:" + email);
            Console.WriteLine("Morada:..........:" + morada);
            Console.WriteLine("Número de Porta..:" + numeroPorta);
            Console.WriteLine("Fração...........:" + fracao);
            Console.WriteLine("Código Postal....:" + codigoPostal);
            Console.WriteLine("WebSite..........:" + webSite);
        }
    }
}
