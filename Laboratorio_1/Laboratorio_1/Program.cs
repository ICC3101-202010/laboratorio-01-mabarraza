using System;

namespace Laboratorio_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Human bob = new Human("Bob" , "Kunga");
            Console.WriteLine(bob.RPS());
        }
    }
}
