using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaTestCenterDialog.Views;

namespace AvaloniaTestCenterDialog
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void PopupButton_Click(object sender, RoutedEventArgs e)
        {
            Popup pp = new Popup();
            pp.ShowDialog(this);


        }
    }
}
