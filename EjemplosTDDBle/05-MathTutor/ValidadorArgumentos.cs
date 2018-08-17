using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosTDDBle._05_MathTutor
{
    public class ValidadorArgumentos : ILimitsValidator
    {
        int _limiteInferior;
        int _limiteSuperior;

        public ValidadorArgumentos(int limiteInferior, int limiteSuperior)
        {
            _limiteInferior = limiteInferior;
            _limiteSuperior = limiteSuperior;
        }

        public void validarLimitesDeArgumento(int v1, int v2)
        {
            if (v1 > _limiteSuperior || v2 > _limiteSuperior) throw new OverflowException("First argument exceeds upper limit");
            if (v1 < _limiteInferior || v2 < _limiteInferior) throw new OverflowException("Second argument exceeds lower limit");
        }
    }
}
