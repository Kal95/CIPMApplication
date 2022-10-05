using CIPMApplication.Models;

namespace CIPMApplication.Repo.Interface
{
    public interface IStudentRepo { 
        Task<IEnumerable<Students>> GetAllStudentsAsync();

        Task<IAsyncResult> GetStudentsByIdAsync(int Id);
        Task<IAsyncResult> GetStudentsByEmailAsync(string email);

        void AddStudent(Students model);
        Task<IAsyncResult> DeleteStudent(int Id);
        Task<IAsyncResult> UpdateStudent(int Id, Students model);
    }
}
