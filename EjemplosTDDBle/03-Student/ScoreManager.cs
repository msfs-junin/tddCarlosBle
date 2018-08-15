using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosTDDBle._03_Student
{
    public class ScoreManager
    {
        IDataManager _dataManager;
        public ScoreManager(IDataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public void AddScore(string studentId, float score)
        {
            Student student = _dataManager.GetByKey(studentId);
            //Student studentUpdated = _dataManager.UpdateScore((Student)student, score);
            _dataManager.Save(student);

            }


    }
}
