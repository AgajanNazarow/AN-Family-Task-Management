using System.Collections.Generic;

namespace AN_Family_Task_Management.MVVM.Models
{
    public class FamilyPerson
    {
        public FamilyPerson()
        {
            TaskAssignments = new HashSet<TaskAssignment>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual ICollection<TaskAssignment> TaskAssignments { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
