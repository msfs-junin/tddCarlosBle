using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using EjemplosTDDBle;

namespace UnitTestEjemplosTDDBle
{
    [TestClass]
    public class CalendarTest
    {
        [TestMethod]
        public void ClientAsksCalendarService()
        {
            int year = 2009;
            int month = 2;
            string townCode = "b002";
            ICalendarService serviceMock = MockRepository.GenerateStrictMock<ICalendarService>();
            serviceMock.Expect(
                x => x.GetHolidays(
                year, month, townCode)).Return(new int[] { 3, 5 });
            Calendar calendar = new Calendar(serviceMock);
            calendar.CurrentTown = townCode;
            calendar.CurrentYear = year;
            calendar.CurrentMonth = month;
            calendar.DrawMonth(); // the SUT
            serviceMock.VerifyAllExpectations();
        }

        [TestMethod]
        public void DrawHolidaysWithStub()
        {
            int year = 2009;
            int month = 2;
            string townCode = "b002";
            ICalendarService serviceStub =
            MockRepository.GenerateStub<ICalendarService>();
            serviceStub.Stub(
                x => x.GetHolidays(year, month, townCode)).Return(
                    new int[] { 1, 5 });
            Calendar calendar = new Calendar(serviceStub);
            calendar.CurrentTown = townCode;
            calendar.CurrentYear = year;
            calendar.CurrentMonth = month;
            calendar.DrawMonth();
            Assert.AreEqual(1, calendar.Holidays[0]);
            Assert.AreEqual(5, calendar.Holidays[1]);
        }
    }
}
