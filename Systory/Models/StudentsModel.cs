using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systory.Models
{
    internal class StudentsModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Sex { get; set; }
        public string StudySift { get; set; }
        public int MajorId { get; set; }
    }
}
