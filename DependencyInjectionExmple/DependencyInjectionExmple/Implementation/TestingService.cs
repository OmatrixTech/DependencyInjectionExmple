using DependencyInjectionExmple.Interfaces;
using System.Windows;

namespace DependencyInjectionExmple.Implementation
{
    internal class TestingService : ITestingService
    {
        public void TestService()
        {
            MessageBox.Show("Dependency Injection Service implementation");
        }
    }
}
