using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systory.Models
{
    public class SubjectResponse
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string TeacherName { get; set; }
        public int MajorId { get; set; }
        public int Year { get; set; }
    }
}
