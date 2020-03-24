using System;

namespace Laboratorio_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*string username = Console.ReadLine();
            string userlastname = Console.ReadLine();
            Human anyone = new Human(username, userlastname);  */  // code to create a person with users input
            Human bob = new Human("Bob","Kunga");
            Console.WriteLine(bob.RPS());
            //Console.WriteLine("his name is: {0} and his last name is: {1}", bob.Name, bob.Lastname);    //code to check builder output
            //Console.WriteLine("his name is: {0} and his last name is: {1}", anyone.Name, anyone.Lastname);    // code to check users builder output
        }
    }
}
