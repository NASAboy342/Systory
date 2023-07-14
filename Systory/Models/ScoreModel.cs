using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systory.Models
{
    public class ScoreModel
    {
        public int SubjectId { get; set; }
        public int StudentId { get; set; }
        public int Homework { get; set; }
        public int Quiz { get; set; }
        public int MidTerm { get; set; }
        public int Final { get; set; }
    }
}
