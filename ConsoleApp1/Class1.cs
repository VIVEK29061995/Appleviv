using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Class1
    {
        static void Main(string[] args)
        {
            int[]array = { 10, 20, 30 ,40,50,60,70,80};
            int sum = 0;
            for(int i = 0; i < array.Length-1; i=+2)
            {
                sum= array[i] + array[i+1];
                Console.WriteLine(sum);
            }
           
        }
    }
}
