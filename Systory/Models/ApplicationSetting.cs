using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systory.Models
{
    class ServerInfo
    {
        public string ServerName { get; set; }
        public string DataBaseName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
    }

    class DbInfoPath
    {
        public static string Path => "DbInfo.config";
    }

    class StoredProcedureInsertNewBatch
    {
        public static string SpName => "dbo.InsertNewBatch";
        public static string ParaName => "@newBatch";
    }
    class StoredProcedureInsertNewMajor
    {
        public static string SpName => "dbo.InsertNewMajor";
        public static string ParaName => "@newMajor";
    }
    class StoredProcedureGetSubjectsByYearAndMajor
    {
        public static string SpName => "[dbo].[GetSubjectsByYearAndMajor]";
        public static string ParaMajor => "@Major";
        public static string ParaYear => "@Year";
    }

    class StoredProcedureInsertSubject
    {
        public static string SpName => "[dbo].[InsertSubject]";
        public static string ParaSubjectName => "@SubjectName";
        public static string ParaMajor => "@Major";
        public static string ParaYear => "@Year";
        public static string ParaTeacherName => "@TeacherName";
    }

    class StoredProcedureGetStudents
    {
        public static string SpName => "[dbo].[GetStudents]";
        public static string StudentId => "StudentId";
        public static string StudentName => "StudentName";
        public static string Sex => "Sex";
        public static string StudySift => "StudySift";
        public static string MajorId => "MajorId";
    }
    class StoredProcudureGetScore
    {
        public static string SpName => "[dbo].[GetScore]";
        public static string SubjectId => "SubjectId";
        public static string StudentId => "StudentId";
        public static string Homework => "Homework";
        public static string Quiz => "Quiz";
        public static string MidTerm => "MidTerm";
        public static string Final => "Final";
    }
}
