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
            char first = 'B';
            char second = 'H';
            float hej = 4.5F;
            int nej = 5;
            int[] paj = new int[10];
            for (int i = 0; i < 10; i++)
            {
                paj[i] = i;         }
            foreach(int numbers in paj)
            {
                Console.WriteLine(numbers);
            }
            if(hej<4)
            {
                Console.WriteLine("kaskeloten är ett väldigt fult djur");
            }
            else if(hej==4.5F)
            {
                Console.WriteLine("niopfjqqpmg");
            }
            else {
                Console.WriteLine("hhhehhhehes");
            }
            Console.Write(first);
            Console.Write(second);
           
            Console.ReadLine();
        }
    }
}
