using System.Data.Entity;

namespace CrudOperationApp.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext()
            : base("name=MySqlConnection")
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}