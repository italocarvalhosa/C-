using System;

namespace Aula_dia_18
{
    class Operacao
    {
        static void Main(string[] args)
        {
            int num1, num2;
            float result = 0;
            string operacao;


            Console.WriteLine("digite o numero: \n");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero: \n");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operacao:\n");
            operacao = Console.ReadLine();

            switch
            (operacao)
            {
                case " soma":
                    result = num1 + num2;
                    break;

                case " subtracao":
                    result = num1 - num2;
                    break;

                case " multiplicacao":
                    result = num1 * num2;
                    break;

                case "divisao":
                    result = num1 / num2;
                    break;

            }
            {
                Console.WriteLine(" Resultado sera:", result);
                Console.ReadKey(false);
            }
        }
    }
}
