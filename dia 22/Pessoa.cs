using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pessoa
    {
        private string nome;
        private double salario;

        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        public string Nome
        {
            get
            {
                return this.nome.ToUpper(); ;
            }
            set
            {
                this.nome = value;
            }

        }

        public double Salario
        {
            get
            {
                return this.salario;
            }

            set
            {
                if (this.salario > value)
                {
                    Console.WriteLine("Salario atual maior que o informado");
                }
                else
                {
                    this.salario = value;
                    Console.WriteLine("Salario atualizado");
                }
            }

        }
        public string Email { get; set; }
    }
            
        
        
        
    
}
