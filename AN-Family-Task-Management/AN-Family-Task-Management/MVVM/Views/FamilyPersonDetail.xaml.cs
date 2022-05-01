using System.Text.RegularExpressions;
using System.Windows;

namespace AN_Family_Task_Management.MVVM.Views
{
    /// <summary>
    /// Interaction logic for FamilyPersonDetail.xaml
    /// </summary>
    public partial class FamilyPersonDetail : Window
    {
        public FamilyPersonDetail()
        {
            InitializeComponent();
        }

        private static readonly Regex _regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
        private void txtAge_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = _regex.IsMatch(e.Text);
        }
    }
}
