using System;

using DAL.Entities.Common;
using DAL.Entities.Courses;
using DAL.Entities.Students;

namespace DAL.Entities.StudentCourses
{
    public class StudentCourse : BaseEntity
    {
        public DateTime RegistDate { get; set; }
        public virtual Student Student { get; set; }
        public int StudentId { get; set; }
        public virtual Course Course { get; set; }
        public int CourseId { get; set; }
    }
}