using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systory.Models;
using Systory.Repository;

namespace Systory.Controller
{
    internal class FacultyController
    {
        DbDataRepo _dbDataRepo = new DbDataRepo();
        public List<FacultyModel> GetFacultyLish()
        {
            return _dbDataRepo.GetListOfFaculty();
        }
    }
}
