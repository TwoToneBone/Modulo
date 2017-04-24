using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> nbrs = new HashSet<int>();

            for (int i = 0; i < 10; i++)
            {
                int input = int.Parse(Console.ReadLine());
                nbrs.Add((input % 42));                
            }
            Console.WriteLine(nbrs.Count);

        }
    }
}
