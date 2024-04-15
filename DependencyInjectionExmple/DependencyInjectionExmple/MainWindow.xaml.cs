using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace DependencyInjectionExmple
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = App.serviceProvider.GetRequiredService<MainWindowViewModel>();
        }
    }
}