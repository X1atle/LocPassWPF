using System.Windows.Controls;
using LocPassWPF.MVVM.ViewModel;

namespace LocPassWPF.MVVM.View
{
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
            DataContext = new HomeViewModel();
        }
    }
}