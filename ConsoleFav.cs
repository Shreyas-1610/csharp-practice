using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ConsoleFav
    {
        public string FavConsole="";
        public string FavModel = "";
        public void Print()
        {
            Console.WriteLine($"Your favorite console is {FavConsole} and model is {FavModel}");
        }


    }
}
