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
        /* 
        private string _categoryName;

        public string CategoryName
        {
            get => _categoryName;
            set
            {
                _categoryName = value;
                OnPropertyChanged();
            }
        }

        private ICommand _createCommand;

        public ICommand CreateCommand
        {
            get
            {
                if (_createCommand == null)
                    _createCommand = new RelayCommand(CreateExpander, CanCreateExpander);
                return _createCommand;
            }
        }

        private bool CanCreateExpander(object parameter)
        {
            // Enable the CreateCommand only when CategoryName is not empty
            return !string.IsNullOrWhiteSpace(CategoryName);
        }

        private void CreateExpander(object parameter)
        {
            // Create the Expander only if CategoryName is not empty
            if (!string.IsNullOrWhiteSpace(CategoryName))
            {
                Expander newExpander = new Expander
                {
                    Header = CategoryName,
                    Foreground = Brushes.White,
                    Background = Brushes.Transparent
                };

                TextBox contentTextBox = new TextBox
                {
                    Background = Brushes.Transparent,
                    BorderThickness = new System.Windows.Thickness(0),
                    FontSize = 14,
                    Foreground = Brushes.White,
                    TextAlignment = System.Windows.TextAlignment.Center,
                    Padding = new System.Windows.Thickness(0, 10, 0, 0),
                    IsReadOnly = false
                };

                newExpander.Content = contentTextBox;

                // Add the Expander to the ExpanderCollection in your UserControl
                App.Current.Dispatcher.Invoke(() =>
                {
                    ExpanderCollection.Add(newExpander);
                });

                // Clear the CategoryName after creating the Expander
                CategoryName = string.Empty;
            }
        }

        private ObservableCollection<Expander> _expanderCollection;

        public ObservableCollection<Expander> ExpanderCollection
        {
            get
            {
                if (_expanderCollection == null)
                    _expanderCollection = new ObservableCollection<Expander>();
                return _expanderCollection;
            }
            set
            {
                _expanderCollection = value;
                OnPropertyChanged();
            }
        }
        */
    }
}
