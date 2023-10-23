using CrudUsingEF.Data;
using Microsoft.Data.SqlClient;

namespace CrudUsingEF.Models
{
    public class StudentDAL
    {
        ApplicationDbContext db;
        public StudentDAL(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Student> GetStudents()
        {
            return db.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            var result = db.Students.Where(x => x.Id == id).SingleOrDefault();
            return result;

            
        }

        public int AddStudent(Student student)
        {
            // added the book object in the DBSet
            db.Students.Add(student);
            // SaveChages() reflect the changes from Dbset to DB
            int result = db.SaveChanges();
            return result;
        }

        public int UpdateStudent(Student student)
        {
            int res = 0;

            var result = db.Students.Where(x => x.Id == student.Id).FirstOrDefault();

            if (result != null)
            {
                result.Name = student.Name; 
                result.City = student.City;
                result.Percentage = student.Percentage;

                res = db.SaveChanges();// update those changes in DB
            }

            return res;
        }


        public int DeleteStudent(int id)
        {
            int res = 0;
            var result = db.Students.Where(x => x.Id == id).FirstOrDefault();
            if (result != null)
            {
                db.Students.Remove(result); // remove from DbSet
                res = db.SaveChanges();
            }

            return res;
        }

    }
}
