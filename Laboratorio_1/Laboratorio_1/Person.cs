using System;
namespace Laboratorio_1
{
    public class Human
    {
        private string name;
        private string lastname;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Lastname
        {
            get => lastname;
            set => lastname = value;
        }
        public Human(string name,string lastname)
        {
            this.name = name;
            this.lastname = lastname;
        }
        public int RPS()
        {
            Random _throw = new Random();
            return _throw.Next(0, 3);
        }
    }
}           

                    