using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            var edges = new string[]
            {
                "E","KA","KU","KO",
                "O","SE","SU",/*"SI",*/
                "TA","TE","TO","TI",
                "NA","NE","NO","NI",
                "A","HE","HU","HI",
                "I","MA","MU"/*,"MO"*/,
            };

            var waitTime = 6000;
            var r = new Random();
            var i = 0;
            while (!Console.KeyAvailable)
            {
                var idx = r.Next(edges.Length);
                Console.Write(edges[idx]+" ");
                i++;
                if (i%2 == 0)
                {
                    Console.WriteLine();
                    Thread.Sleep(waitTime);
                }
            }
        }
    }
}
