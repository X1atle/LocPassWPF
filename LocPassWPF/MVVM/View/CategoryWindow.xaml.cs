using System.Windows;
using LocPassWPF.Core;
using LocPassWPF.MVVM.ViewModel;

namespace LocPassWPF.MVVM.View
{
    public partial class CategoryWindow : WindowControlling
    {
        public CategoryWindow()
        {
            InitializeComponent();
            DataContext = new CategoryViewModel();
        }
    }
}