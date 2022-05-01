using AN_Family_Task_Management.Core;
using AN_Family_Task_Management.EFManagement;
using AN_Family_Task_Management.MVVM.Models;

namespace AN_Family_Task_Management.MVVM.ViewModels
{
    public class FamilyPersonDetailViewModel : ObservableObject
    {
        public RelayCommand SaveFamilyPersonCommand { get; set; }

        public FamilyPersonDetailViewModel()
        {
            FamilyPerson = new FamilyPerson();
            SaveFamilyPersonCommand = new RelayCommand(o =>
            {
                CustomRepository customRepository = new CustomRepository();
                customRepository.SaveFamilyPerson(FamilyPerson);
                OnPropertyChanged(nameof(FamilyPerson));
            });
        }

        private FamilyPerson _familyPerson;

        public FamilyPerson FamilyPerson
        {
            get { return _familyPerson; }
            set 
            { 
                _familyPerson = value;
                OnPropertyChanged();
            }
        }
    }
}
