using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using LocPassWPF.MVVM.View;

namespace LocPassWPF.Core
{
    public class WindowControlling : Window
    {
        public bool isDragging = false;
        public void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                isDragging = true;
                this.DragMove();
            }
        }

        public void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        public void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            isDragging = false;
        }

        public void CloseButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void MinimizeButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        public void CreateCategory_OnClick(object sender, RoutedEventArgs e)
        {
            Window category = new CategoryWindow();
            
            category.Show();
        }
        public void CreateNote_OnClick(object sender, RoutedEventArgs e)
        {
            Window note = new NoteWindow();
            note.Show();
        }
        public void CreatePassword_OnClick(object sender, RoutedEventArgs e)
        {
            Window passwordCreating = new PasswordCreating();
            passwordCreating.Show();
        }

        public void CopyTextFromTextBoxByButton(TextBox textBox)
        {
            if (textBox != null)
            {
                string textToCopy = textBox.Text;
                Clipboard.SetText(textToCopy);
            }
        }
    }
}