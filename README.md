# DependencyInjectionWithIoC
Dependency Injection using Unity Container
 
This demo is about how we can use dependency injection and get it resolved with the help of unity.

Interface - ISubject has two method 
  string GetDescription();
  string GetReferenceBookName();
  
  Math and Physics class are implementing ISubject according to their need.
  
  In Program.cs --

  Using the container: 
  static IUnityContainer container = new UnityContainer();
  
  and Register the Isubject:
        static void SetUpContainer()
        {
            container.RegisterType<ISubject, Math>();    // This means -- when you get ISubject, use Math

            //Or use the below if you want Physics instance  
            //container.RegisterType<ISubject, Physics>(); //// This means -- when you get ISubject, use Physics
        }
  
  From main, we can use in convention way like:
  
            ISubject subject = new Math(); //Or like below line
            //ISubject subject = new Physics();

            Console.WriteLine("Subject Desc: " + subject.GetDescription());
            Console.WriteLine("Reference Book: " + subject.GetReferenceBookName());

  With Unity, same can be achieved as :
            SetUpContainer();
            ISubject sub = container.Resolve<ISubject>();
            Console.WriteLine("Unity : Subject Desc: " + sub.GetDescription());
            Console.WriteLine("Unity: Reference Book: " + sub.GetReferenceBookName());
  
    
