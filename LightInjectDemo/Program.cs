//using System;
//using LightInject;


//namespace LightInjectDemo
//{
//    public interface IFoo { }
//    public interface IBar { }

//    public class Foo : IFoo
//    {
//        public Foo(IBar bar)
//        {
//            Bar = bar;
//        }

//        public IBar Bar { get; private set; }
//    }

//    public class Bar : IBar { }

//    class Program
//    {
        

//        static void Main(string[] args)
//        {
//            var container = new ServiceContainer();
//            Console.WriteLine("Constructor Injection\n");

//            container.Register<IFoo, Foo>();
//            container.Register<IBar, Bar>();
//            var foo = (Foo)container.GetInstance<IFoo>();
//            Assert.IsInstanceOfType(foo.Bar, typeof(Bar));

//            container.RegisterConstructorDependency<IBar>((factory, parameterInfo) => new Bar());

//            Console.ReadLine();
//        }
//    }
//}
