using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosTDDBle._05_MathTutor
{
    public class Calculator
    {
        public int limiteInferior;
        public int limiteSuperior;
        ILimitsValidator _validador;

        public Calculator(int limiteInferior, int limiteSuperior)
        {
            this.limiteInferior = limiteInferior;
            this.limiteSuperior = limiteSuperior;
            _validador = new ValidadorArgumentos(this.limiteInferior, this.limiteSuperior);
        }

        public Calculator(ILimitsValidator validador)
        {
            _validador = validador;
        }

        public ILimitsValidator validador()
        {
            return this._validador; 
        }

        public int Add(int v1, int v2)
        {
            _validador.validarLimitesDeArgumento(v1, v2);
            int resultado = v1 + v2;
            if (resultado > limiteSuperior) { throw new OverflowException("Upper limit exceeded"); }
            return resultado; //v1 + v2;//4
        }

        public int Substract(int v1, int v2)
        {
            _validador.validarLimitesDeArgumento(v1, v2);
            int resultado = v1 - v2;
            if (resultado < limiteInferior) { throw new OverflowException("Lower limit exceeded"); }
            return resultado; //v1 - v2 //2
        }


    }
}
