using AN_Family_Task_Management.Core;
using AN_Family_Task_Management.EFManagement;
using AN_Family_Task_Management.MVVM.Models;
using AN_Family_Task_Management.MVVM.Views;
using System;
using System.Collections.ObjectModel;

namespace AN_Family_Task_Management.MVVM.ViewModels
{
    public class TaskListViewModel : ObservableObject
    {
        public CustomRepository CustomRepository;

        public Task SelectedTask { get; set; }

        public RelayCommand DeleteSelectedTaskCommand { get; set; }
        public RelayCommand EditSelectedTaskCommand { get; set; }
        public RelayCommand NewTaskCommand { get; set; }

        public ObservableCollection<Task> ListTask { get; set; }

        public TaskListViewModel()
        {
            CustomRepository = new CustomRepository();

            ListTask = GetObservableCollection();

            DeleteSelectedTaskCommand = new RelayCommand(o =>
            {
                try
                {
                    CustomRepository.DeleteTask(SelectedTask);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            });

            NewTaskCommand = new RelayCommand(o =>
            {
                TaskDetail taskDetail = new TaskDetail();
                taskDetail.Show();
            });

            EditSelectedTaskCommand = new RelayCommand(o =>
            {
                TaskDetail taskDetail = new TaskDetail();
                taskDetail.Show();
            });
        }

        private ObservableCollection<Task> GetObservableCollection()
        {
            return new ObservableCollection<Task>(CustomRepository.GetTasks());
        }
    }
}
