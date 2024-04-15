using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest.Model
{
    public class Student
    {
        public Student(int studentId, string studentName, int rollno, string faculty, string address, long fees, DateTime joinedDate)
        {
            StudentId = studentId;
            StudentName = studentName;
            Rollno = rollno;
            Faculty = faculty;
            Address = address;
            Fees = fees;
            JoinedDate = joinedDate;
        }

        public int StudentId { get; set; }
        public string StudentName { get; set; } = String.Empty;
        public int Rollno { get; set; } 
        public string Faculty { get; set; } = String.Empty;
        public string Address { get; set; } = String.Empty;
        public long  Fees { get; set; } 
        public DateTime JoinedDate { get; set;}

    }
}
