using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using EjemplosTDDBle._03_Student;

namespace UnitTestEjemplosTDDBle
{
    /// <summary>
    /// Descripción resumida de StudentTests
    /// </summary>
    [TestClass]
    public class StudentTests
    {

        [TestMethod]
        public void AddStudentScore()
        { 
            string studentId = "23145";
            float score = 8.5f;
            Student dummyStudent = new Student();
            IDataManager dataManagerMock =
            MockRepository.GenerateStrictMock<IDataManager>();
            dataManagerMock.Expect(
                x => x.GetByKey(studentId)).Return(dummyStudent);
            dataManagerMock.Expect(
                x => x.Save(dummyStudent));
            ScoreManager smanager = new ScoreManager(dataManagerMock);
            smanager.AddScore(studentId, score);
            dataManagerMock.VerifyAllExpectations();
        }

        [TestMethod]
        public void ScoreUpdaterWorks()
        {
            ScoreUpdater updater = new ScoreUpdater();
            Student student = updater.UpdateScore(
            new Student(), 5f);
            Assert.AreEqual(student.Score, 5f);
        }

        [TestMethod]
        public void AddStudentScore2()
        {
            string studentId = "23145";
            float score = 8.5f;
            Student dummyStudent = new Student();
            IDataManager dataManagerMock = MockRepository.GenerateStrictMock<IDataManager>();
            dataManagerMock.Expect(x => x.GetByKey(studentId)).Return(dummyStudent);
            dataManagerMock.Expect(x => x.Save(dummyStudent));
            IScoreUpdater scoreUpdaterMock = MockRepository.GenerateMock<IScoreUpdater>();
            scoreUpdaterMock.Expect(y => y.UpdateScore(dummyStudent, score)).Return(dummyStudent);
            ScoreManager smanager = new ScoreManager(dataManagerMock, scoreUpdaterMock);
            smanager.AddScore2(studentId, score);
            dataManagerMock.VerifyAllExpectations();
            scoreUpdaterMock.VerifyAllExpectations();
        }

        [TestMethod]
        public void AddStudentScore3()
        {
            float score = 8.5f;
            Student dummyStudent = new Student();
            IScoreUpdater scoreUpdaterMock =
            MockRepository.GenerateStrictMock<IScoreUpdater>();
            scoreUpdaterMock.Expect(y => y.UpdateScore(dummyStudent, score)).Return(dummyStudent);
            IDataManager dataManagerMock = MockRepository.GenerateMock<IDataManager>();
            dataManagerMock.Expect(x => x.Save(dummyStudent));
            ScoreManager smanager = new ScoreManager(dataManagerMock, scoreUpdaterMock);
            smanager.AddScore3(dummyStudent, score);
            dataManagerMock.VerifyAllExpectations();
            scoreUpdaterMock.VerifyAllExpectations();
        }
    }
}