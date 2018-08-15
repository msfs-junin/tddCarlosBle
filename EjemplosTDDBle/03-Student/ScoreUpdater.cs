using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosTDDBle._03_Student
{
    public class ScoreUpdater : IScoreUpdater
    {
        public Student UpdateScore(Student student, float score)
        {
            student.Score = student.Score + score;
            return student;
        }
    }

}