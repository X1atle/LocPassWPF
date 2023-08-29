using System.Windows;
using System.Windows.Controls;
using LocPassWPF.Core;
using LocPassWPF.MVVM.ViewModel;

namespace LocPassWPF.MVVM.View
{
    public partial class PasswordCreating : WindowControlling
    {
        public PasswordCreating()
        {
            InitializeComponent();
            DataContext = new PasswordCreatingViewModel();
        }

    }
}