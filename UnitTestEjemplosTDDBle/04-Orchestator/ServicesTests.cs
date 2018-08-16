using System;
using EjemplosTDDBle._04_Orchestator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace UnitTestEjemplosTDDBle._04_Orchestator
{
    [TestClass]
    public class ServicesTests
    {
        [TestMethod]
        public void OrchestratorCallsA()
        {
            IServices servicesMock = MockRepository.GenerateStrictMock<IServices>();
            servicesMock.Expect( a => a.MethodA());
            servicesMock.Stub( b => b.MethodB());
            Orchestrator orchestrator = new Orchestrator(servicesMock);
            orchestrator.Orchestrate();
            servicesMock.VerifyAllExpectations();
        }

        [TestMethod]
        public void OrchestratorCallsB()
        {
            IServices servicesMock = MockRepository.GenerateStrictMock<IServices>();
            servicesMock.Expect( b => b.MethodB());
            servicesMock.Stub(  a => a.MethodA());
            Orchestrator orchestrator =  new Orchestrator(servicesMock);
            orchestrator.Orchestrate();
            servicesMock.VerifyAllExpectations();
        }

        [TestMethod]
        public void OrchestratorCalls2A()
        {
            IServices servicesMock = MockRepository.GenerateMock<IServices>();
            servicesMock.Expect(a => a.MethodA());
            Orchestrator orchestrator = new Orchestrator(servicesMock);
            orchestrator.Orchestrate();
            servicesMock.VerifyAllExpectations();
        }

        [TestMethod]
        public void OrchestratorCalls2B()
        {
            IServices servicesMock = MockRepository.GenerateMock<IServices>();
            servicesMock.Expect(b => b.MethodB());
            Orchestrator orchestrator = new Orchestrator(servicesMock);
            orchestrator.Orchestrate();
            servicesMock.VerifyAllExpectations();
        }
    }
}
