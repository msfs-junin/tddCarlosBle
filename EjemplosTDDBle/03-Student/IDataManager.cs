using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosTDDBle._03_Student
{
    public interface IDataManager
    {
        Student GetByKey(string id);
        void Save(Student dummyStudent);
    }
}
