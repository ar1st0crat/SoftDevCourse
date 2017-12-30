using System;

namespace EquationSolvingApplication
{
    public class EquationSolver
    {
        public double[] Solve(double a, double b, double c)
        {
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
                throw new Exception("No real roots!");
            }

            d = Math.Sqrt(d);

            var roots = new double[2];
            roots[0] = (-b + d) / (2 * a);
            roots[1] = (-b - d) / (2 * a);

            return roots;
        }
    }
}
