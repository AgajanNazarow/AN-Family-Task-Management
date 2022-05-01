using System.Collections.Generic;

namespace AN_Family_Task_Management.MVVM.Models
{
    public class Task
    {
        public Task()
        {
            TaskAssignments = new HashSet<TaskAssignment>();
        }

        public int ID { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TaskAssignment> TaskAssignments { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
