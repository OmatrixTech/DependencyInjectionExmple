using DependencyInjectionExmple.Interfaces;
using System.Windows.Input;

namespace DependencyInjectionExmple
{
    internal class MainWindowViewModel
    {
        ITestingService testingService = null;
        public ICommand ShowDependencyInjectionCommand { get; }
        public MainWindowViewModel(ITestingService testingService)
        {
            this.testingService = testingService;
            ShowDependencyInjectionCommand = new RelayCommand((obj)=>ShowDependencyInjection(obj));
        }

        private void ShowDependencyInjection(object parameter)
        {
            // Handle the command logic here
            testingService.TestService();
        }
    }
}
