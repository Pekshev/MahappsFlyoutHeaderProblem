using System.Windows;

namespace MahappsFlyoutHeaderProblem
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Flyout.IsOpen = !Flyout.IsOpen;
        }
    }
}
