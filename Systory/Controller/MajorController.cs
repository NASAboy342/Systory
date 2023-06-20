using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systory.Models;
using Systory.Repository;

namespace Systory.Controller
{
   public class MajorController
   {
        DbDataRepo _dbDataRepo = new DbDataRepo();
        public List<YearModel> GetYearList()
        {
            return _dbDataRepo.GetYearList();
        }

        public List<SubjectResponse> GetSubjectList(string year)
        {
            return _dbDataRepo.GetSubjectList(year);
        }
   }
}
