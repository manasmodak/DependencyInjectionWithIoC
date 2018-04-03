using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDIWithUnity
{
    class Program
    {
        //Install Unity from NuGet
        static IUnityContainer container = new UnityContainer();

        static void Main(string[] args)
        {
            // Start : Conventional Way

            ISubject subject = new Math(); //Or like below line
            //ISubject subject = new Physics();

            Console.WriteLine("Subject Desc: " + subject.GetDescription());
            Console.WriteLine("Reference Book: " + subject.GetReferenceBookName());

            // End : Conventional Way


            // Start : Dependency Injection with IoC container  
            SetUpContainer();
            ISubject sub = container.Resolve<ISubject>();

            Console.WriteLine();
            Console.WriteLine(".............Using DI Unity.............................");
            Console.WriteLine();
            Console.WriteLine("Unity : Subject Desc: " + sub.GetDescription());
            Console.WriteLine("Unity: Reference Book: " + sub.GetReferenceBookName());
            Console.WriteLine();

            // End : Dependency Injection with IoC container  
        }

        static void SetUpContainer()
        {
            container.RegisterType<ISubject, Math>();

            //Or use the below if you want Physics instance
            //container.RegisterType<ISubject, Physics>();
        }
    }
}
