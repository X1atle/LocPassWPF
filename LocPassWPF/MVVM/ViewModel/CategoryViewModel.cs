using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using LocPassWPF.Core;

namespace LocPassWPF.MVVM.ViewModel
{
    public class CategoryViewModel : ObservableObject
    {
       
        public ICommand AddExpanderCommand { get; private set; }

       

      

        public CategoryViewModel()
        {
            // Здесь вы можете добавить элементы Expander по умолчанию или из другого источника данных.
           
            AddExpanderCommand = new RelayCommand(AddExpander);
        }
        private void AddExpander(object parameter)
        {
            
            MainViewModel.Instance.HomeVM.ExpanderItems.Add(new ExpanderItemViewModel { Header = "New Expander", Content = "New Content" });
           
        }
    }
    
}
