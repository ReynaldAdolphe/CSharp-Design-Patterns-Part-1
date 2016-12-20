using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository.DAL
{
    public class UnitOfWork : IDisposable
    {
        // Part 1
        private RepositoryContext context = new RepositoryContext();
        private GenericRepository<Faculty> facultyRepository;
        private GenericRepository<Student> studentRepository;

        public GenericRepository<Faculty> FacultyRepository
        {
            get
            {
                if (this.facultyRepository == null)
                {
                    this.facultyRepository = new GenericRepository<Faculty>(context);
                }
                return facultyRepository;
            }
        }

        public GenericRepository<Student> StudentRepository
        {
            get
            {
                if (this.studentRepository == null)
                {
                    this.studentRepository = new GenericRepository<Student>(context);
                }
                return studentRepository;
            }
        }

        // Part 2
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}