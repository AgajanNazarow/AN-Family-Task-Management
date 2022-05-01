using AN_Family_Task_Management.Core;
using AN_Family_Task_Management.EFManagement;
using AN_Family_Task_Management.MVVM.Models;
using AN_Family_Task_Management.MVVM.Views;
using System;
using System.Collections.ObjectModel;
using System.Windows;

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
                try
                {
                    CustomRepository.DeleteTaskAssignment(SelectedTaskAssignment);
                    MessageBox.Show("Delete Process Completed");
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            });

            NewTaskAssignmentCommand = new RelayCommand(o =>
            {
                TaskAssignmentDetail taskAssignmentDetail = new TaskAssignmentDetail();
                taskAssignmentDetail.Show();
            });

            EditSelectedTaskAssignmentCommand = new RelayCommand(o =>
            {
                TaskAssignmentDetail taskAssignmentDetail = new TaskAssignmentDetail();
                taskAssignmentDetail.Show();
            });
        }

        private ObservableCollection<TaskAssignment> GetObservableCollection()
        {
            return new ObservableCollection<TaskAssignment>(CustomRepository.GetTaskAssignments());
        }
    }
}
