

using Prism.Modularity;

namespace Prism.WinForms.Tests.Mocks.Modules
{
    public class MockModuleThrowingException : IModule
    {
        public void Initialize()
        {
            throw new System.NotImplementedException();
        }
    }
}
