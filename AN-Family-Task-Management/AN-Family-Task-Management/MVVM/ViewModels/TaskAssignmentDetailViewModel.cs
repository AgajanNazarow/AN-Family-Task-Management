using AN_Family_Task_Management.Core;
using AN_Family_Task_Management.EFManagement;
using AN_Family_Task_Management.MVVM.Models;
using System.Collections.Generic;

namespace AN_Family_Task_Management.MVVM.ViewModels
{
    public class TaskAssignmentDetailViewModel : ObservableObject
    {
        CustomRepository CustomRepository;
        public List<Task> AvailableTasks { get; set; }

        private Task _SelectedTask;
        public Task SelectedTask
        {
            get
            {
                return _SelectedTask;
            }
            set
            {
                _SelectedTask = value;
                TaskAssignment.Task = _SelectedTask;
            }
        }
        public List<FamilyPerson> AvailableFamilyPersons { get; set; }

        private FamilyPerson _SelectedFamilyPerson;
        public FamilyPerson SelectedFamilyPerson
        {
            get
            {
                return _SelectedFamilyPerson;
            }
            set
            {
                _SelectedFamilyPerson = value;
                TaskAssignment.FamilyPerson = _SelectedFamilyPerson;
            }
        }

        public RelayCommand SaveTaskAssignmentCommand { get; set; }

        public TaskAssignmentDetailViewModel()
        {
            CustomRepository = new CustomRepository();
            AvailableTasks = CustomRepository.GetTasks();
            AvailableFamilyPersons = CustomRepository.GetFamilyPersons();

            TaskAssignment = new TaskAssignment();
            SaveTaskAssignmentCommand = new RelayCommand(o =>
            {
                CustomRepository.SaveTaskAssignment(TaskAssignment);
                OnPropertyChanged(nameof(TaskAssignment));
            });
        }

        private TaskAssignment _taskAssignment;

        public TaskAssignment TaskAssignment
        {
            get { return _taskAssignment; }
            set
            {
                _taskAssignment = value;
                OnPropertyChanged();
            }
        }
    }
}
