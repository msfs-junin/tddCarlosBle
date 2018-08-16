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
        IScoreUpdater _scoreUpdaterMock;

        public ScoreManager(IDataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public ScoreManager(IDataManager dataManager, IScoreUpdater scoreUpdaterMock)
        {
            _dataManager = dataManager;
            _scoreUpdaterMock = scoreUpdaterMock;
        }

        public void AddScore(string studentId, float score)
        {
            Student student = _dataManager.GetByKey(studentId);
            //Student studentUpdated = _scoreUpdaterMock.UpdateScore((Student)student, score);
            _dataManager.Save(student);
        }

        public void AddScore2(string studentId, float score)
        {
            Student student = _dataManager.GetByKey(studentId);
            Student studentUpdated = _scoreUpdaterMock.UpdateScore((Student)student, score);
            _dataManager.Save(student);
        }

        public void AddScore3(Student student, float score)
        {
            Student studentUpdated = _scoreUpdaterMock.UpdateScore(student, score);
            _dataManager.Save(studentUpdated);
        }

    }
}
