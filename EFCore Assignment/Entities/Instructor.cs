using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Assignment.Entities
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Bonus { get; set; }
        public decimal Salary { get; set; }
        public string? Address { get; set; }
        public decimal HoureRate { get; set; }

        [InverseProperty(nameof(Department.Manager))]
        public Department ManageDepartment { get; set; } // Navigational Property => ONE

        [ForeignKey(nameof(WorkForDepartment))]
        public int? DepartmentId { get; set; } // FK
        [InverseProperty(nameof(Department.Instructors))]
        public Department WorkForDepartment { get; set; } // Navigational Property => ONE

        public ICollection<InstructorCourse> InstructorCourses { get; set; } = new HashSet<InstructorCourse>();
    }
}
