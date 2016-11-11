using System.ComponentModel.Design;
using Prism.Modularity;
using Microsoft.Practices.Unity;
namespace HelloWorldModule
{
    public class HelloWorldModule : IModule
    {
        private readonly IUnityContainer _container;

        public HelloWorldModule(IUnityContainer container)
        {
            _container = container;
        }

        public void Initialize()
        {
            _container.RegisterType<IHelloService, HelloService>();
        }
    }

    public interface IHelloService
    {
        string SayHello();
    }

    public class HelloService : IHelloService
    {
        public string SayHello()
        {
            return "Hello";
        }
    }
}
