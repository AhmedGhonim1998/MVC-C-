namespace ProjectNumber1.Models
{
    public class StudentBL
    {
        List<Student> students;
        public StudentBL()
        {
            students = new List<Student>();
            students.Add(new Student() { Id = 1, Name = "Ahmed", Faculty = "Computer Science" });
            students.Add(new Student() { Id = 2, Name = "Monir", Faculty = "Bio Informatics" });
            students.Add(new Student() { Id = 3, Name = "Youssef", Faculty = "Bussines" });
        }

        public List<Student> GetAll() {
            return students;
        }

        public Student GetById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }
    }
}
