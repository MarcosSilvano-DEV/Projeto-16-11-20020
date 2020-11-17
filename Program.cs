using System;

namespace Projeto_16_11_20020
{
    class Program
    {
        static void Main(string[] args)
        {
            //PEDIR A OPERAÇÃO
            //PEDIR O PRIMEIRO NÚMERO
            //PEDIR O SEGUNDO NÚMERO

            Console.Write("Digite a operção que deseja fazer \nSoma ,Subtracao, Multiplicacao, Divisao: ");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o primeiro número");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = 0;
            
                switch(operacao){

                    case "Soma":
                    resultado = num1+num2;
                    break;

                    case "Subtracao":
                    resultado = num1-num2;
                    break;

                    case "Multiplicacao":
                    resultado = num1*num2;
                    break;

                    case "Divisao":
                    resultado = num1/num2;
                    break;

                    default:
                    Console.WriteLine("OPERAÇÃO IVÁLIDA");
                    break;

                }

            Console.WriteLine($"Resultado : {resultado}");
        }
    }
}
