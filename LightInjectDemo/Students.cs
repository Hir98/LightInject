using LightInject;
using System;

namespace LightInjectDemo
{
    class Students
    {
        static void Main()
        {
            var container = new ServiceContainer();
            container.Register<IRollno, Rollno>();
            container.Register<IName, Name>();
            container.Register<IAddress, Address>();
            var student = container.GetInstance<IRollno>();
            student.DisplayRollno();
            Console.ReadKey();
        }
    }
}
