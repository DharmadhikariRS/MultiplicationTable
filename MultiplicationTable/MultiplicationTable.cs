using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    internal class MultiplicationTable
    {
        public void MultiplyTable()
        {

            Console.WriteLine("Enter the number to find Table= ");

            int Num = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number till  you want to find tabl= ");

            int Limit = int.Parse(Console.ReadLine());

            Console.WriteLine("Table of Number{0} = ", Num);

            for (int i = 1; i <= Limit; i++)
            {
                Console.WriteLine(Num * i);
            }

        }
    }
}
