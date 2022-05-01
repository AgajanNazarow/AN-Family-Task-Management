using AN_Family_Task_Management.MVVM.Models;
using System.Data.Entity;

namespace AN_Family_Task_Management.EFManagement
{
    public class CustomDBContext : DbContext
    {
        public CustomDBContext() : base("name=EFConnectionString")
        {
        }

        public DbSet<FamilyPerson> FamilyPersons { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
