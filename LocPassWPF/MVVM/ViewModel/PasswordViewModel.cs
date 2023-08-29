using System.Windows;
using System.Windows.Input;
using LocPassWPF.Core;

namespace LocPassWPF.MVVM.ViewModel
{
    public class PasswordCreatingViewModel : ObservableObject
    {
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand GeneratePasswordCommand { get; private set; }
        public ICommand CopyToClipboardCommand { get; private set; }

        public PasswordCreatingViewModel()
        {
            GeneratePasswordCommand = new RelayCommand(GeneratePassword);
            CopyToClipboardCommand = new RelayCommand(CopyToClipboard, CanCopyToClipboard);
        }

        private void GeneratePassword(object parameter)
        {
            Password = PasswordGenerator.GeneratePassword();
        }

        private void CopyToClipboard(object parameter)
        {
            if (!string.IsNullOrEmpty(Password))
                Clipboard.SetText(Password);
        }

        private bool CanCopyToClipboard(object parameter)
        {
            return !string.IsNullOrEmpty(Password);
        }
    }
}