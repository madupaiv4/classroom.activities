using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nao_sei_ainda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado;

            Console.WriteLine("Calculadora ;D");
            Console.Write("Digite dois números inteiros: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
        again:
            Console.WriteLine("digite o número da Operaçãos desejada");
            Console.WriteLine("1 - Mutiplicação");
            Console.WriteLine("2 - Adição");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Subtração");
            Console.WriteLine("5 - fim do processo");
           int operacao = int.Parse(Console.ReadLine());

            #region if else
            if (operacao == 1)
            { 
                resultado = a * b;
                Console.WriteLine(" resultado de {0} * {1}: {2} ",a,b,resultado);

            }
            else
                if (operacao == 2)
                    {
                    resultado = a + b;
                    Console.WriteLine(" resultado de {0} + {1}: {2} ", a, b, resultado);
                    }
                 else 
                        if (operacao == 3)
                            { if (b == 0)
                                            {
                                                Console.WriteLine("não é possivel dividir os valores atribuidos");
                                                Console.WriteLine("Aperte Enter e tente novamente");
                                                Console.ReadKey();
                                                Console.Clear();
                                                goto again;
                                            }
                             else
                                {
                                    resultado = a / b;
                                    Console.WriteLine(" resultado de {0} / {1}: {2} ", a, b, resultado);
                                }
       
                        }
                       else 
                        
                            if (operacao == 4)       
                              {
                                 resultado = a - b;
                                Console.WriteLine(" resultado de {0} - {1}: {2} ", a, b, resultado);               
                              }
                            else 
                            
                                if (operacao == 5) 
                           
                                {
                                    Console.WriteLine(a);
                                }
                                else 
                                   { Console.WriteLine("Esta opção não existe no seletor. Aperte Enter e tente novamente");
                                    Console.ReadKey();
                                    Console.Clear();
                                    goto again;                          
                                   }
            #endregion if else
            Console.WriteLine("Deseja continuar a operação");
            
            
                
                
                
                Console.ReadKey();   
        }
    }
}
