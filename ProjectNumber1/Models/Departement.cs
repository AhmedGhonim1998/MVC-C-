namespace ProjectNumber1.Models
{
    public class Departement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ManagerName { get; set; }
        public List<Employee>? Emps { get; set; }
    }
}
