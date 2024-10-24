
namespace Testing2.Repo
{
    public class IStudent : Student
    {
        public Task<Student> CreateStudent(int id,string name)
        {
            
        }

        public Task<Student> DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetAllStudent()
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Student> UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
