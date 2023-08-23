﻿using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using LocPassWPF.Core;

namespace LocPassWPF.MVVM.ViewModel
{
    public class CategoryViewModel : ObservableObject
    {
        private ObservableCollection<ExpanderItemViewModel> _expanderItems;
        public ICommand AddExpanderCommand { get; private set; }

        public ObservableCollection<ExpanderItemViewModel> ExpanderItems
        {
            get => _expanderItems;
            set
            {
                _expanderItems = value;
                OnPropertyChanged();
            }
        }

        public CategoryViewModel()
        {
            // Здесь вы можете добавить элементы Expander по умолчанию или из другого источника данных.
            ExpanderItems = new ObservableCollection<ExpanderItemViewModel>
            {
                new ExpanderItemViewModel { Header = "Expander 1", Content = "Content 1" },
                new ExpanderItemViewModel { Header = "Expander 2", Content = "Content 2" }
            };
            AddExpanderCommand = new RelayCommand(AddExpander);
        }
        private void AddExpander(object parameter)
        {
            ExpanderItems.Add(new ExpanderItemViewModel { Header = "New Expander", Content = "New Content" });
        }
    }
    public class ExpanderItemViewModel : ObservableObject
    {
        private string _header;
        private string _content;

        public string Header
        {
            get => _header;
            set
            {
                _header = value;
                OnPropertyChanged();
            }
        }

        public string Content
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged();
            }
        }
    }
}
