using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Livraria
{
    public partial class Usuario
    {
        public void registarUsuarios()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Registar Novo Usuário");
            Console.Write("Nome Completo: ");
            nomeUsuario = Convert.ToString(Console.ReadLine());
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
            Console.Write("Data de Nascimento: ");
            dataNascimento = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Bilhete de Identidade: ");
            bilheteIdentidade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Número de Contribuinte: ");
            contribuinte = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
        }

        public void MostrarUsuarios()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Nome..................:" + nomeUsuario);
            Console.WriteLine("Telefone..............:" + telefone);
            Console.WriteLine("Email:................:" + email);
            Console.WriteLine("Morada:...............:" + morada);
            Console.WriteLine("Número de Porta.......:" + numeroPorta);
            Console.WriteLine("Fração................:" + fracao);
            Console.WriteLine("Código Postal.........:" + codigoPostal);
            Console.WriteLine("Data de Nascimento....:" + dataNascimento);
            Console.WriteLine("Bilhete de Identidade.:" + bilheteIdentidade);
            Console.WriteLine("Número de Contribuinte:" + bilheteIdentidade);
        }
    }
}
