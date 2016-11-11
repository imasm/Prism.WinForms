

using Prism.Modularity;

namespace Prism.WinForms.Tests.Mocks.Modules
{
    public class MockModuleReferencingAssembly : IModule
    {
        public void Initialize()
        {
            MockReferencedModule instance = new MockReferencedModule();
        }
    }
}