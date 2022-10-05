using CIPMApplication.Models;
using CIPMApplication.Repo.Repo;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CIPMApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentsRepo _studentRepo;
        public StudentsController(StudentsRepo studentRepo)
        {
            _studentRepo = studentRepo; 
        }

        
        [HttpGet]
        public async Task<IEnumerable<Students>> GetAllStudents()
        {
            var students = await _studentRepo.GetAllStudentsAsync();

            if (students == null)
            {
                return (IEnumerable<Students>)NotFound();
            }  
            return (IEnumerable<Students>)Ok(students);
        }

        [HttpGet("{Id}")]

        public async Task<IAsyncResult> GetStudentByIdAsync(int Id)
        {
            var student = await _studentRepo.GetStudentsByIdAsync(Id);
            return (IAsyncResult)Ok(student);
        }

        [HttpGet]

        public async Task<IAsyncResult> GetStudentByEmailAsync([FromBody] string email)
        {
            var student = await _studentRepo.GetStudentsByEmailAsync(email);
            return (IAsyncResult)Ok(student);
        }

        [HttpPost]

        public void AddStudent([FromBody] Students model)
        {
            _studentRepo.AddStudent(model);

        }

        [HttpPut("{Id}")]

        public async Task<IAsyncResult> UpdateStudent(int Id, [FromBody] Students model)
        {
            await _studentRepo.UpdateStudent(Id, model);

            return (IAsyncResult)Ok();
        }

        [HttpDelete]

        public async Task<IAsyncResult> DeleteStudent(int Id)
        {
            return await _studentRepo.DeleteStudent(Id);
        }

       
    }
}
