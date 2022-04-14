using System.Windows;

namespace AN_Family_Task_Management
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FamilyPersonSubMenu_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Family Person Menu Clicked");
        }

        private void TaskSubMenu_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Task Menu Clicked");

        }
    }
}
