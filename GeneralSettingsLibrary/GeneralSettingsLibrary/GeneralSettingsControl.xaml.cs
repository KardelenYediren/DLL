using System.Windows;
using System.Windows.Controls;

namespace GeneralSettingsLibrary
{
    public partial class GeneralSettingsControl : UserControl
    {
        public GeneralSettingsControl()
        {
            InitializeComponent();
        }

        // Event handler for the Minimize button
        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            // Logic to minimize the parent window
            if (Window.GetWindow(this) is Window parentWindow)
            {
                parentWindow.WindowState = WindowState.Minimized;
            }
        }

        // Event handler for the Maximize/Restore button
        private void WindowStateButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic to toggle between Maximize and Normal window states
            if (Window.GetWindow(this) is Window parentWindow)
            {
                parentWindow.WindowState = parentWindow.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
            }
        }

        // Event handler for the Close button
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic to close the parent window
            if (Window.GetWindow(this) is Window parentWindow)
            {
                parentWindow.Close();
            }
        }
    }
}
