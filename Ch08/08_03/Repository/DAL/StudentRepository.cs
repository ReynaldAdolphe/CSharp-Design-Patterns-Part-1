using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repository.Models;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Repository.DAL
{
    public class StudentRepository : IStudentRepository, IDisposable
    {
        // Part 1 - Context
        private RepositoryContext _context;

        // Constructor
        public StudentRepository(RepositoryContext context)
        {
            this._context = context;
        }

        // Part 2 - CRUD
        public void InsertStudent(Student student)
        {
            _context.Students.Add(student);
        }

        public Task<Student> GetStudentByID(int? studentId)
        {
            return _context.Students.FindAsync(studentId);
        }

        public Task<List<Student>> GetStudents()
        {
            return _context.Students.ToListAsync();
        }

        public void UpdateStudent(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
        }
                
        public void DeleteStudent(int studentID)
        {
            Student student = _context.Students.Find(studentID);
            _context.Students.Remove(student);
        }

        public Task<int> Save()
        {
            return _context.SaveChangesAsync();
        }

        // Part 3 - Clean up
        private bool disposed = false;

        protected virtual void Dispose(bool disposing) {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            // Prevent the GC from calling Object.Finalize on an 
            // object that does not require it
            GC.SuppressFinalize(this);
        }
        
    }
}