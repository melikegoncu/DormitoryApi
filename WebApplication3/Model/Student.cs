using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Model
{
    public class Student
    {
        public string StudentID { get; set; }

        public string StudentName { get; set; }

        public bool LastCovidResult { get; set; }

        public DateTime LastCovidTestDate { get; set; }

        public string RoomId { get; set; }
    }
}
