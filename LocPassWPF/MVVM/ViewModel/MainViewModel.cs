using LocPassWPF.Core;
using LocPassWPF.MVVM.View;

namespace LocPassWPF.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public HomeViewModel HomeVM { get; set; }
        public CategoryViewModel CategoryVM { get; set; }
        public static MainViewModel Instance { get; set; }
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        
        public MainViewModel()
        {
            Instance = this;
           
        
            CurrentView = new HomeView();
          
        }
    }
}