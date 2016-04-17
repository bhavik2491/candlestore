using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MVC_2.Models
{
    public class Student
    {
        public Student()
        {

        }
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public string no { get; set; }

  //      [DataType(DataType.EmailAddress)]
   //     public string EmailId { get; set; }

        public Standard Standard { get; set; }
        public Teacher Teacher { get; set; }
    }
    public class Teacher
    {
        public Teacher()
        {

        }
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string no { get; set; }
        public string grade { get; set; }
    }
    public class Standard
    {
        public Standard()
        {

        }
        public int StandardId { get; set; }
        public string StandardName { get; set; }

        public ICollection<Student> Students { get; set; }
    }

   /* public class candlestore : System.Data.Entity.DbContext
    {
        public candlestore() : base()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
        
    }*/
}
      
