using System;
using System.Collections;

namespace problema_bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = {50, 10, 5, 1};
            int value = Convert.ToInt32(Console.ReadLine());
            int count = 1;            

            while(value != 0)
            {
                Console.WriteLine("Teste {0}",count);                    
                
                foreach(int nota in notas){
                    int quantidade = value/nota;
                    value = value % nota;
                    Console.Write(quantidade + " ");                    
                }                
                Console.WriteLine("");
                value = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            
        }
    }
}
