using EquationSolvingApplication;

namespace EquationSolvingMockTestProject
{
    class FakeRoots : IRoots
    {
        public bool SolvedState { get; private set; }

        public double[] Calculate(double[] p)
        {
            SolvedState = true;

            return new double[] { -3, -2, -1, 1, 2 };
        }
    }
}
