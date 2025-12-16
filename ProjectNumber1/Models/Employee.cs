using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectNumber1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string JopTitle { get; set; }
        public string ImageUrt { get; set; }
        public string ?Address { get; set; }
        [ForeignKey("Departement")]
        public int DepartementID { get; set; }
        public Departement Departement { get; set; }
    }
}
