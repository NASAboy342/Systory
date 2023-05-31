using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systory.Models;
using Systory.Repository;

namespace Systory.Controller
{
    internal class BatchController
    {
        DbDataRepo _dbDataRepo = new DbDataRepo();
        public List<BatchModel> GetBatchLish()
        {
            return _dbDataRepo.GetListOfBatch();
        }

        public List<MajorModel> GetMajorList(int cell)
        {
            var majorList = _dbDataRepo.GetListOfMajor();
            return majorList.Where(i => i.Batch == cell).ToList();
        }
    }
}
