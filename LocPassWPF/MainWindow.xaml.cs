using System.Windows;
using System.Windows.Input;
using LocPassWPF.Core;
using LocPassWPF.MVVM.View;

namespace LocPassWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : WindowControlling
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Window category = new CategoryWindow();
            category.Show();
        }
    }
}