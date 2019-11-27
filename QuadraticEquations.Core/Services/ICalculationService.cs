using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquations.Core.Services
{
    public interface ICalculationService
    {
        double CalculateQuadraticEquations(double a, double b, double c, double X1, double X2);
    }
}
