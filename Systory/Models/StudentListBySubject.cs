using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systory.Models
{
    public class StudentListBySubject
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Sex { get; set; }
        public int Homework { get; set; }
        public int Quiz { get; set; }
        public int MidTerm { get; set; }
        public int Final { get; set; }
    }
}
