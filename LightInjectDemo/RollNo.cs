using System;

namespace LightInjectDemo
{
    class Rollno : IRollno
    {
        public IName DisplayName { get; set; }

        public void DisplayRollno()
        {
            Console.WriteLine("Roll No : 87");
            DisplayName.DisplayName();
        }
    }
}
