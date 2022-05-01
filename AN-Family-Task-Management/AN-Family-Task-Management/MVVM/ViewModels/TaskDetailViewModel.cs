using AN_Family_Task_Management.Core;
using AN_Family_Task_Management.EFManagement;
using AN_Family_Task_Management.MVVM.Models;

namespace AN_Family_Task_Management.MVVM.ViewModels
{
    public class TaskDetailViewModel : ObservableObject
    {
        public RelayCommand SaveTaskCommand { get; set; }

        public TaskDetailViewModel()
        {
            Task = new Task();
            SaveTaskCommand = new RelayCommand(o =>
            {
                CustomRepository customRepository = new CustomRepository();
                customRepository.SaveTask(Task);
                OnPropertyChanged(nameof(Task));
            });
        }

        private Task _task;

        public Task Task
        {
            get { return _task; }
            set
            {
                _task = value;
                OnPropertyChanged();
            }
        }
    }
}
