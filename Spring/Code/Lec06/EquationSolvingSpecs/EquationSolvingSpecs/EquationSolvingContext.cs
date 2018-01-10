using System;
using System.Collections.Generic;
using EquationSolvingApplication;

namespace EquationSolvingSpecs
{
    public class EquationSolvingContext
    {
        public EquationSolver Solver { get; set; } = new EquationSolver(new FakeRoots());

        public List<double> Coefficients { get; set; } = new List<double>();
        public double[] Roots { get; set; }

        public Exception Exception { get; set; }
    }
}