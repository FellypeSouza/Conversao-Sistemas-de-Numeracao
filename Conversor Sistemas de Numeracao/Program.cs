using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_Sistemas_de_Numeracao
{
    internal class Program
    {
        public class Conversor
        {
            
            public void BinarioParaDecimal()
            {
                Console.Write("\nDigite o número binário: ");
                string valor = Console.ReadLine();

                int resultado = 0;

                // Itera sobre cada caractere da string, da direita para a esquerda
                for (int i = 0; i < valor.Length; i++)
                {
                    // Converte o caractere para o número 0 ou 1
                    int numero = valor[valor.Length - 1 - i] - '0';

                    // Adiciona o valor ao resultado considerando a posição binária
                    resultado += numero * (int)Math.Pow(2, i);
                }

                // Exibe o resultado final
                Console.WriteLine($"O número decimal é: {resultado}");
            }
            

            public void OctalParaDecimal()
            {
                Console.Write("\nDigite o número octal: ");
                string valor = Console.ReadLine();

                int resultado = 0;

                // O For percorre todos os algarismos do número digitado pelo usuario
                for (int i = 0; i < valor.Length; i++)
                {
                    // Acessa o valor e converte para Int
                    int numero = valor[valor.Length - 1 - i] - '0';
      
                    // Realiza a operação de conversão e atribui a resultado
                    resultado += numero * (int)Math.Pow(8, i);
                }

                // Exibe o resultado final
                Console.WriteLine($"O número decimal é: {resultado}");
            }
            public void HexadecimalParaDecimal()
            {
                Console.Write("\nDigite o número hexadecimal: ");
                string valor = Console.ReadLine();

                int resultado = 0;

                // O For percorre todos os algarismos do número digitado pelo usuario
                for (int i = 0; i < valor.Length; i++)
                {
                    // Acessa o valor
                    int numero = valor[valor.Length - 1 - i];
                    
                    //Se o valor for alguma letra entre A e F, converte para o respectivo valor
                    if(numero == 'A')
                    {
                        numero = 10;
                    }
                    else if(numero == 'B')
                    {
                        numero = 11;
                    }
                    else if (numero == 'C')
                    {
                        numero = 12;
                    }
                    else if (numero == 'D')
                    {
                        numero = 13;
                    }
                    else if (numero == 'E')
                    {
                        numero = 14;
                    }
                    else if (numero == 'F')
                    {
                        numero = 15;
                    }
                    //Se nao for nenhuma letra, converte o numero para inteiro
                    else
                    {
                        numero = numero - '0';
                    }

                    // Realiza a operação de conversão e atribui a resultado
                    resultado += numero * (int)Math.Pow(16, i);
                }

                // Exibe o resultado final
                Console.WriteLine($"O número decimal é: {resultado}");
            }
        }
        static void Main(string[] args)
        {
            Conversor c = new Conversor();
            Console.Write("Sistemas de Numeração\n\nBinário para Decimal (1)\nOctal para Decimal (2)\nHexadecimal para Decimal (3)\n\nSelecione a opção desejada: ");
            string op = Console.ReadLine();

            if(op == "1")
            {
                c.BinarioParaDecimal();
            }
            else if(op == "2")
            {
                c.OctalParaDecimal();
            }
            else if(op == "3")
            {
                c.HexadecimalParaDecimal();
            }
            else
            {
                Console.WriteLine("Opção Inválida");
            }
        }
    }
}
