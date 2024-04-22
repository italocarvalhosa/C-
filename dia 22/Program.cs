using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
 class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa("Italo");
           // p.Nome = "Italo";
            Console.WriteLine("Nome; {0}", p.Nome);
            p.Salario = 2500;
            p.Salario = 1500;
            p.Salario = 3000;
            Console.WriteLine("Salario;{0}", p.Salario);
            Console.ReadKey();
        }
    }
}
