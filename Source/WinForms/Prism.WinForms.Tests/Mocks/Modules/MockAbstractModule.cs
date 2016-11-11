

using Prism.Modularity;

namespace Prism.WinForms.Tests.Mocks.Modules
{
    public abstract class MockAbstractModule : IModule
    {
        public void Initialize()
        {
        }
    }

    public class MockInheritingModule : MockAbstractModule
    {
    }
}
