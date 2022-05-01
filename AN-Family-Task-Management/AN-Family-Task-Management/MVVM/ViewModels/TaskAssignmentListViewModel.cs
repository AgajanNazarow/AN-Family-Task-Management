using AN_Family_Task_Management.Core;
using AN_Family_Task_Management.EFManagement;
using AN_Family_Task_Management.MVVM.Models;
using AN_Family_Task_Management.MVVM.Views;
using System.Collections.ObjectModel;

namespace AN_Family_Task_Management.MVVM.ViewModels
{
    public class TaskAssignmentListViewModel : ObservableObject
    {
        public CustomRepository CustomRepository;

        public TaskAssignment SelectedTaskAssignment { get; set; }

        public RelayCommand DeleteSelectedTaskAssignmentCommand { get; set; }
        public RelayCommand EditSelectedTaskAssignmentCommand { get; set; }
        public RelayCommand NewTaskAssignmentCommand { get; set; }

        public ObservableCollection<TaskAssignment> ListTaskAssignment { get; set; }

        public TaskAssignmentListViewModel()
        {
            CustomRepository = new CustomRepository();

            ListTaskAssignment = GetObservableCollection();

            DeleteSelectedTaskAssignmentCommand = new RelayCommand(o =>
            {
                CustomRepository.DeleteTaskAssignment(SelectedTaskAssignment);
                ListTaskAssignment = GetObservableCollection();
            });

            NewTaskAssignmentCommand = new RelayCommand(o =>
            {
                TaskAssignmentDetail taskAssignmentDetail = new TaskAssignmentDetail();
                taskAssignmentDetail.Show();
                taskAssignmentDetail.Closed += TaskAssignmentDetail_Closed;
            });

            EditSelectedTaskAssignmentCommand = new RelayCommand(o =>
            {
                TaskAssignmentDetail taskAssignmentDetail = new TaskAssignmentDetail();
                taskAssignmentDetail.Show();
                taskAssignmentDetail.Closed += TaskAssignmentDetail_Closed;
            });
        }

        private void TaskAssignmentDetail_Closed(object sender, System.EventArgs e)
        {
            ListTaskAssignment = GetObservableCollection();
        }

        private ObservableCollection<TaskAssignment> GetObservableCollection()
        {
            return new ObservableCollection<TaskAssignment>(CustomRepository.GetTaskAssignments());
        }
    }
}
