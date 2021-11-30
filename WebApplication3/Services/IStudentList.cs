using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Model;

namespace WebApplication3.Services
{
    public interface IStudentList
    {
        public List<Student> GetStudents();

        public Student AddStudent(Student student);

        public Student UpdateStudent(string id, Student student);

        public string DeleteStudent(string id);
    }
}
