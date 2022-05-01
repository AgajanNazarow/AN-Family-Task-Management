using AN_Family_Task_Management.MVVM.Models;
using System.Collections.Generic;
using System.Linq;

namespace AN_Family_Task_Management.EFManagement
{
    public class CustomRepository
    {
        private CustomDBContext _customDBContext;

        public CustomRepository()
        {
            _customDBContext = new CustomDBContext();
        }

        public List<FamilyPerson> GetFamilyPersons()
        {
            return _customDBContext.FamilyPersons.ToList();
        }

        public FamilyPerson SaveFamilyPerson(FamilyPerson familyPersonToSave)
        {
            _customDBContext.FamilyPersons.Add(familyPersonToSave);
            _customDBContext.SaveChanges();
            return familyPersonToSave;
        }

        public void DeleteFamilyPerson(FamilyPerson familyPerson)
        {
            if (familyPerson == null)
            {
                return;
            }

            _customDBContext.FamilyPersons.Remove(familyPerson);
            _customDBContext.SaveChanges();
        }

        public List<Task> GetTasks()
        {
            return _customDBContext.Tasks.ToList();
        }

        public Task SaveTask(Task taskToSave)
        {
            _customDBContext.Tasks.Add(taskToSave);
            _customDBContext.SaveChanges();
            return taskToSave;
        }

        public void DeleteTask(Task task)
        {
            if (task == null)
            {
                return;
            }

            _customDBContext.Tasks.Remove(task);
            _customDBContext.SaveChanges();
        }
    }
}
