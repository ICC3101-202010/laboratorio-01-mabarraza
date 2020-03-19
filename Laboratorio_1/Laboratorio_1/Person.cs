using System;
namespace Laboratorio_1
{
    public class Human
    {
        public string name;
        public string lastname;
        public int RPS()
        {
            Random _throw = new Random();
            return _throw.Next(0, 3);
        }
    }
}
