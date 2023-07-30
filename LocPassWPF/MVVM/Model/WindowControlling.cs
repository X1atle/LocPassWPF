using System.Windows;
using System.Windows.Input;

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
    }
}