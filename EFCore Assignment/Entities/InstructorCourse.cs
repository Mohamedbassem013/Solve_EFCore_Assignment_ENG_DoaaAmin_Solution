using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Assignment.Entities
{
    //[PrimaryKey(nameof(InstructorId), nameof(CourseId))]
    internal class InstructorCourse
    {
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public string? Evaluation { get; set; }
    }
}
