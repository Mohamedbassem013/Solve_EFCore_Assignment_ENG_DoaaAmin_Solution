using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Assignment.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Duaration { get; set; }
        public string? Description { get; set; }
        public int? TopicId { get; set; } // FK
        public Topic Topic { get; set; } // Navigational Property => ONE
        public ICollection<StudentCourse> CourseStudents { get; set; } = new HashSet<StudentCourse>();
        public ICollection<InstructorCourse> CourseInstructors { get; set; } = new HashSet<InstructorCourse>();
    }
}
