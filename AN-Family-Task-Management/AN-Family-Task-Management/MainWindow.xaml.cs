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

        private void FamilyPersonStackPanel_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Family Person Menu Clicked");
        }

        private void TaskStackPanel_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Task Menu Clicked");
        }
    }
}
