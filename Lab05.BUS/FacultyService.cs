using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab05.DAL.Entities;

namespace Lab05.BUS
{
    public class FacultyService
    {
        public List<Faculty> GetAll()
        {
            using (StudentModel context = new StudentModel())
            {
                return context.Faculties.ToList();
            }
        }

        public void Add(Faculty faculty)
        {
            using (StudentModel context = new StudentModel())
            {
                context.Faculties.Add(faculty);
                context.SaveChanges();
            }
        }

        public void Update(Faculty faculty)
        {
            using (StudentModel context = new StudentModel())
            {
                context.Entry(faculty).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(int facultyId)
        {
            using (StudentModel context = new StudentModel())
            {
                var faculty = context.Faculties.Find(facultyId);
                if (faculty != null)
                {
                    context.Faculties.Remove(faculty);
                    context.SaveChanges();
                }
            }
        }
    }
}
