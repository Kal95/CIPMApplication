using CIPMApplication.Data;
using CIPMApplication.Models;
using CIPMApplication.Repo.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CIPMApplication.Repo.Repo
{
    public class StudentsRepo : IStudentRepo
    {
        private readonly ApplicationDbContext _context;

        public StudentsRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async void AddStudent(Students model)
        {

            await _context.Students.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public async Task<IAsyncResult> DeleteStudent(int Id)
        {
            var student = await _context.Students.FindAsync(Id);

            string ret = string.Empty;
            if (student != null)
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
                ret = $"The student with id = {student.Id} has been succesfully removed";
            }
            else
            {
                ret = $"Student with id = {Id} was not found";
            }
            return Task.FromResult(ret);
        }


        public async Task<IEnumerable<Students>> GetAllStudentsAsync()
        {
            var students = await _context.Students.ToListAsync();
            return (IEnumerable<Students>)Task.FromResult(students);
        }

        public async Task<IAsyncResult> GetStudentsByEmailAsync(string email)
        {
            var student = await _context.Students.Select(c => c.Email == email).FirstOrDefaultAsync();
            return Task.FromResult(student);
        }

        public async Task<IAsyncResult> GetStudentsByIdAsync(int Id)
        {
            var student = await _context.Students.Select(c => c.Id == Id).FirstOrDefaultAsync();
            return Task.FromResult(student);
        }

        public async Task<IAsyncResult> UpdateStudent(int Id, Students model)
        {
            if (Id == model.Id)
            {
                var student = await _context.Students.Select(c => c.Id == model.Id).FirstOrDefaultAsync();
                if (student != null)
                {
                    _context.Entry(model).State = EntityState.Modified;
                    _context.Update(model);
                    await _context.SaveChangesAsync();

                }
               
            }

            return Task.FromResult(model);
        }
    }
}
