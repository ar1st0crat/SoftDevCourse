using EquationSolvingApplication;

namespace EquationSolvingSpecs
{
    public class FakeRoots : IRoots
    {
        public double[] Calculate(double[] coeffs)
        {
            return new double[] {-3, -2, -1, 1, 2};
        }
    }
}