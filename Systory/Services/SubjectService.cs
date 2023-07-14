using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systory.Enums;
using Systory.Models;
using Systory.Repository;

namespace Systory.Services
{
    public class SubjectService
    {
        private readonly DbDataRepo _dbDataRepo = new DbDataRepo();
        public List<StudentListBySubject> GetStudentListBySubject(SubjectResponse response, EnumShift shift)
        {
            var studentListSubject = new List<StudentListBySubject>();
            var studentsList = _dbDataRepo.GetStudentsList();
            var scoreList = _dbDataRepo.GetScores();

            foreach (var student in studentsList)
            {
                studentListSubject.Add(new StudentListBySubject()
                {
                    StudentId = student.StudentId,
                    StudentName = student.StudentName,
                    Sex = student.Sex,
                    Homework = scoreList.Where(s => s.SubjectId == response.SubjectId && s.SubjectId == student.StudentId).Select(s => s.Homework).FirstOrDefault(),
                    Quiz = scoreList.Where(s => s.SubjectId == response.SubjectId && s.StudentId == student.StudentId).Select(s => s.Quiz).FirstOrDefault(),
                    MidTerm = scoreList.Where(s => s.SubjectId == response.SubjectId && s.StudentId == student.StudentId).Select(s => s.MidTerm).FirstOrDefault(),
                    Final = scoreList.Where(s => s.SubjectId == response.SubjectId && s.StudentId == student.StudentId).Select(s => s.Final).FirstOrDefault()
                });
            }
            return studentListSubject;
        }
    }
}
