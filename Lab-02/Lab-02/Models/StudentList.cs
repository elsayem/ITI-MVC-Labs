namespace Lab_02.Models
{
    public class StudentList
    {
        static List<Student> studentList = new List<Student>()
        {
            new Student(){Id=1,Name="Abdulrahman ElSayem",Age=25,Email="Abdulrahman.Elsayem@gmail.com"},
            new Student(){Id=2,Name="Ahmed Mohamed",Age=28,Email="ahmed.mohamed@gmail.com"},
            new Student(){Id=3,Name="Esmaiel Khaled",Age=23,Email="esmaiel.khaled@gmail.com"},
            new Student(){Id=4,Name="Hazem Abdullah",Age=24,Email="hazem.abdu@gmail.com"},
        };


        public List<Student> GetAll()
        {
            return studentList;
        }

        public void Add(Student std)
        {
            studentList.Add(std);
        }

            
    }
}
