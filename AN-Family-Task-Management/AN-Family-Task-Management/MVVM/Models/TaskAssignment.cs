namespace AN_Family_Task_Management.MVVM.Models
{
    public class TaskAssignment
    {
        public TaskAssignment()
        {

        }

        public int ID { get; set; }
        public FamilyPerson FamilyPerson { get; set; }
        public Task Task { get; set; }
    }
}
