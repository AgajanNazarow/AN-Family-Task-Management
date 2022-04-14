using AN_Family_Task_Management.Models;
using System.Collections.Generic;
using System.Linq;

namespace AN_Family_Task_Management.EFManagement
{
    public class CustomRepository
    {
        public List<FamilyPerson> GetFamilyPersons()
        {
            CustomDBContext customDBContext = new CustomDBContext();
            return customDBContext.FamilyPersons.ToList();
        }

        public List<Task> GetTasks()
        {
            CustomDBContext customDBContext = new CustomDBContext();
            return customDBContext.Tasks.ToList();
        }
    }
}
