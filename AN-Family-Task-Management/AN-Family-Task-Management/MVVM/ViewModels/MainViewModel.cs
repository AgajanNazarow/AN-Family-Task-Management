using AN_Family_Task_Management.Core;

namespace AN_Family_Task_Management.MVVM.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public RelayCommand FamilyPersonListViewCommand { get; set; }
        public RelayCommand TaskListViewCommand { get; set; }
        public RelayCommand TaskAssignmentListViewCommand { get; set; }

        public FamilyPersonListViewModel FamilyPersonListVM { get; set; }
        public TaskListViewModel TaskListVM { get; set; }
        public TaskAssignmentListViewModel TaskAssignmentListVM { get; set; }

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
            FamilyPersonListVM = new FamilyPersonListViewModel();
            TaskListVM = new TaskListViewModel();
            TaskAssignmentListVM = new TaskAssignmentListViewModel();

            CurrentView = FamilyPersonListVM;

            FamilyPersonListViewCommand = new RelayCommand(a =>
            {
                CurrentView = FamilyPersonListVM;
            });

            TaskListViewCommand = new RelayCommand(a =>
            {
                CurrentView = TaskListVM;
            });

            TaskAssignmentListViewCommand = new RelayCommand(a =>
            {
                CurrentView = TaskAssignmentListVM;
            });
        }
    }
}
