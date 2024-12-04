using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }

        // Collection to store students associated with the grade
        public ICollection<Student> Students { get; set; }
    }
}
