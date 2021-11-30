using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Model;

namespace WebApplication3.Services
{
    public class StudentService : IStudentList
    {
        private List<Student> _studentItem;

        public StudentService()
        {
            _studentItem = new List<Student>();
        }

        public List<Student> GetStudents()
        {


            return _studentItem;
        }
        
        public Student AddStudent(Student student)
        {
            _studentItem.Add(student);
            return student;
        }

        public Student UpdateStudent(string id, Student student)
        {
            for (var index = _studentItem.Count - 1; index >= 0; index--)
            {
                if (_studentItem[index].StudentID == id)
                {
                    _studentItem[index] = student;
                }
            }
            return student;
        }
        
        public string DeleteStudent(string id)
        {
            for (var index = _studentItem.Count - 1; index >= 0; index--)
            {
                if (_studentItem[index].StudentID == id)
                {
                    _studentItem.RemoveAt(index);
                }
            }
            return id;
        }

    }
    //SOAP
    /*
    [ServiceContract]
    public interface IStuSOAP
    {

        [OperationContract]
        List<Student> GetStudents();

        [OperationContract]
        Student AddStudent(Student student);


        [OperationContract]
        Student UpdateStudent(string id, Student student);

        [OperationContract]
        string DeleteStudent(string id);

    }


    //REST
    [ServiceContract]
    public interface IStuREST
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "List")]
        List<Student> GetStudents();

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Add/{x}")]
        Student AddStudent(Student student);

        [OperationContract]
        [WebInvoke(Method = "PUT", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Upt/{x}")]
        Student UpdateStudent(string id, Student student);

        [OperationContract]
        [WebInvoke(Method = "DELETE", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Del/{x}")]
        string DeleteStudent(string id);

    }
    */
}
