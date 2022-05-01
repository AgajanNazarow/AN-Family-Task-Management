using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AN_Family_Task_Management.Core
{
    /// <summary>
    /// In WPF communication between UI and Model can done with this
    /// </summary>
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
