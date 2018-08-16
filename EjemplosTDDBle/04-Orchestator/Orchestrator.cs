using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosTDDBle._04_Orchestator
{
    public class Orchestrator
    {
        private IServices _services;

        public Orchestrator(IServices services)
        {
            _services = services;
        }

        public void Orchestrate()
        {
            _services.MethodA();
            _services.MethodB();
        }
    }
}