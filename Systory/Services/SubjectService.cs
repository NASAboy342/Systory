using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systory.Models;
using Systory.Repository;

namespace Systory.Services
{
    public class SubjectService
    {
        private readonly DbDataRepo _dbDataRepo = new DbDataRepo();
        public List<StudentListBySubject> GetStudentListBySubject(SubjectResponse response)
        {
            var studentsList = _dbDataRepo.
            var scoreList = _dbDataRepo.
        }
    }
}
