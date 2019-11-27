using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquations.Core.Services
{
    public class CalculationService : ICalculationService
    {
        
        public double CalculateQuadraticEquations(double a, double b, double c, double X1, double X2)
        {
            return
             X1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
             X2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
        }
    }
}
