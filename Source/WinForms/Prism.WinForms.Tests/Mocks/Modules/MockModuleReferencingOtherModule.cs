

using Prism.Modularity;

namespace Prism.WinForms.Tests.Mocks.Modules
{
    public class MockModuleReferencingOtherModule : IModule
    {
        public void Initialize()
        {
            throw new System.NotImplementedException();
        }
    }

    public class MyDummyClass : DummyClass {}
}
