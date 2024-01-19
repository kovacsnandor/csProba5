using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.ReadAllText("valami.txt"));

            Console.ReadLine();
        }
    }
}
