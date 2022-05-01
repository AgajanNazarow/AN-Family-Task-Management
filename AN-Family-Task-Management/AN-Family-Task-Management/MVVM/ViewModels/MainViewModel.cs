using AN_Family_Task_Management.Core;

namespace AN_Family_Task_Management.MVVM.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public RelayCommand FamilyPersonViewCommand { get; set; }
        public RelayCommand TaskViewCommand { get; set; }

        public FamilyPersonViewModel FamilyPersonVM { get; set; }
        public TaskViewModel TaskVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            FamilyPersonVM = new FamilyPersonViewModel();
            TaskVM = new TaskViewModel();
            CurrentView = FamilyPersonVM;

            FamilyPersonViewCommand = new RelayCommand(a =>
            {
                CurrentView = FamilyPersonVM;
            });

            TaskViewCommand = new RelayCommand(a =>
            {
                CurrentView = TaskVM;
            });
        }
    }
}
