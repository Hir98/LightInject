using System;

namespace LightInjectDemo
{
    class Name : IName
    {
        public IAddress GetAddress { get; set; }
        public void DisplayName()
        {
            Console.WriteLine("Name : Hiral");
            GetAddress.GetAddress();
        }
    }
}
