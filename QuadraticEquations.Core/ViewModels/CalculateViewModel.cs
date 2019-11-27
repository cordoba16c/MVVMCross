using MvvmCross.Commands;
using MvvmCross.ViewModels;
using QuadraticEquations.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuadraticEquations.Core.ViewModels
{
    public class CalculateViewModel  :  MvxViewModel
    {
        private readonly ICalculationService _calculationService;
        private double _a;
        private double _b;
        private double _c;
        private double _X1;
        private double _X2;
        private MvxCommand _calculateCommand;

        public CalculateViewModel(ICalculationService calculationService)
        {
            _calculationService = calculationService;

        }

        public double a
        {
            get => _a;
            set => SetProperty(ref _a, value);
        }
        public double b
        {
            get => _b;
            set => SetProperty(ref _b, value);
        }
        public double c
        {
            get => _c;
            set => SetProperty(ref _c, value);
        }
        public double X1
        {
            get => _X1;
            set => SetProperty(ref _X1, value);
        }

        public double X2
        {
            get => _X2;
            set => SetProperty(ref _X2, value);
        }



        public ICommand CalculateCommand
        {
            get
            {
                _calculateCommand = _calculateCommand ?? new MvxCommand(Calculate);
                return _calculateCommand;
            }


        }
       

        private void Calculate()
        {
            X1 = _calculationService.CalculateQuadraticEquations(a,b,c,X1,X2);
        }
    }
}
