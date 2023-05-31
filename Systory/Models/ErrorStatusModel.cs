using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systory.Models
{
    internal class ErrorStatusModel
    {
        public int ErrorCode { get; set; }
    }

    class ErrorCode
    {
        public static int Error => 0;
        public static int Success => 1;
    }
}
