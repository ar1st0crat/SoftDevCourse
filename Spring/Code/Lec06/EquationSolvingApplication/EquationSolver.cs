using System;

namespace EquationSolvingApplication
{
    public class EquationSolver
    {
        private readonly IRoots _rootsEvaluator;

        public EquationSolver(IRoots rootsEvaluator)
        {
            _rootsEvaluator = rootsEvaluator;
        }

        public double[] Solve(double[] coeffs)
        {
            if (coeffs.Length > 3)
            {
                // PolynomialRoots r = new PolynomialRoots();
                // return r.Calculate(coeffs);

                return _rootsEvaluator.Calculate(coeffs);
            }

            double a = coeffs[0];
            double b = coeffs[1];
            double c = coeffs[2];

            if (Math.Abs(a) < 1e-10)    // if (a == 0.0)
            {
                if (Math.Abs(b) < 1e-10)
                {
                    throw new ArgumentException("No unknowns!");
                }

                return new[] { -c / b };
            }

            var d = b * b - 4 * a * c;

            if (d < 0)
            {
                throw new ArithmeticException("No real roots!");
            }

            d = Math.Sqrt(d);

            var roots = new double[2];
            roots[0] = (-b + d) / (2 * a);
            roots[1] = (-b - d) / (2 * a);

            return roots;
        }
    }
}
