using MvvmCross.ViewModels;
using QuadraticEquations.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquations.Core.ViewModels
{
    public class CalculateViewModel  :  MvxViewModel
    {
        private readonly ICalculationService _calculationService;
        private double _X1;
        private double _X2;

        public CalculateViewModel(ICalculationService calculationService)
        {
            _calculationService = calculationService;

        }
        public double X1
        {
            get => _X1;
            set
            {
                _X1 = value;
                RaisePropertyChanged(() => X1);
                Recalculate();

            }
        }
        public double X2
        {
            get => _X2;
            set
            {
                _X2= value;
                RaisePropertyChanged(() => X2);
                Recalculate();

            }
        }

       

        private void Recalculate()
        {
            X1 = _calculationService.CalculateQuadraticEquations(X1, X2);
        }

    }
}
