namespace Lab_02.Models
{
    public class DepartmentList
    {
        static List<Department> departmentList = new List<Department>()
        {
            new Department(){Id = 1, Name = "SD"},
            new Department(){Id = 2, Name = "ES"},
            new Department(){Id = 3, Name = "OS"},
        };

        public List<Department> GetAll()
        {
            return departmentList;
        }

        public void Add(Department dept)
        {
            departmentList.Add(dept);
        }
    }
}
