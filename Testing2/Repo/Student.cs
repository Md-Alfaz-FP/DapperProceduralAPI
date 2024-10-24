namespace Testing2.Repo
{
    public interface Student
    {
        Task<Student> GetAllStudent();
        Task<Student> GetStudentById(int id);
        Task<Student> CreateStudent(string name);
        Task<Student> UpdateStudent(Student student);
        Task<Student> DeleteStudent(int id);

        
    }
}
