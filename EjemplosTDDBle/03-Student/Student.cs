using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosTDDBle._03_Student
{
    public class Student
    {
        public float Score { get; set; }

        internal void setScore(float score)
        {
            Score = score;
        }
    }
}
