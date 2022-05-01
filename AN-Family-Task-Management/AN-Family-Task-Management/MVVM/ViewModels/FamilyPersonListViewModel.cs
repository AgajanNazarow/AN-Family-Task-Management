using AN_Family_Task_Management.Core;
using AN_Family_Task_Management.EFManagement;
using AN_Family_Task_Management.MVVM.Models;
using AN_Family_Task_Management.MVVM.Views;
using System.Collections.ObjectModel;

namespace AN_Family_Task_Management.MVVM.ViewModels
{
    public class FamilyPersonListViewModel : ObservableObject
    {
        public CustomRepository CustomRepository;

        public FamilyPerson SelectedFamilyPerson { get; set; }

        public RelayCommand DeleteSelectedFamilyPersonCommand { get; set; }
        public RelayCommand EditSelectedFamilyPersonCommand { get; set; }
        public RelayCommand NewFamilyPersonCommand { get; set; }

        public ObservableCollection<FamilyPerson> ListFamilyPerson { get; set; }

        public FamilyPersonListViewModel()
        {
            CustomRepository = new CustomRepository();

            ListFamilyPerson = GetObservableCollection();

            DeleteSelectedFamilyPersonCommand = new RelayCommand(o =>
            {
                CustomRepository.DeleteFamilyPerson(SelectedFamilyPerson);
                ListFamilyPerson = GetObservableCollection();
            });

            NewFamilyPersonCommand = new RelayCommand(o =>
            {
                FamilyPersonDetail familyPersonDetail = new FamilyPersonDetail();
                familyPersonDetail.Show();
                familyPersonDetail.Closed += FamilyPersonDetail_Closed;
            });

            EditSelectedFamilyPersonCommand = new RelayCommand(o =>
            {
                FamilyPersonDetail familyPersonDetail = new FamilyPersonDetail();
                familyPersonDetail.Show();
                familyPersonDetail.Closed += FamilyPersonDetail_Closed;
            });
        }

        private void FamilyPersonDetail_Closed(object sender, System.EventArgs e)
        {
            ListFamilyPerson = GetObservableCollection();
        }

        private ObservableCollection<FamilyPerson> GetObservableCollection()
        {
            return new ObservableCollection<FamilyPerson>(CustomRepository.GetFamilyPersons());
        }
    }
}
