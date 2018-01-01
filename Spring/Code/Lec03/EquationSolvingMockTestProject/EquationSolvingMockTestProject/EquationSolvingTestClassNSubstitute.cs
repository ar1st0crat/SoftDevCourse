using EquationSolvingApplication;
using NSubstitute;
using NUnit.Framework;

namespace EquationSolvingMockTestProject
{
    [TestFixture]
    public class EquationSolvingTestClassNSubstitute
    {
        private readonly IRoots _mockRoots = Substitute.For<IRoots>();

        [Test]
        public void TestMoreThatThreeCoefficients()
        {
            double[] coeffs = { 1, 3, -5, -15, 4, 12 };
            double[] validRoots = { -3, -2, -1, 1, 2 };

            _mockRoots.Calculate(coeffs).Returns(validRoots);

            var solver = new EquationSolver(_mockRoots);

            double[] roots = solver.Solve(coeffs);

            Assert.That(roots, Is.EquivalentTo(validRoots));
        }

        [Test]
        public void TestPolynomialRootsGetCalled()
        {
            var solver = new EquationSolver(_mockRoots);

            double[] coeffs = { 1, 3, -5, -15, 4, 12 };
            double[] roots = solver.Solve(coeffs);

            _mockRoots.Received().Calculate(coeffs);

            // equivalent to:
            // _mockRoots.Received(1).Calculate(coeffs);
        }
    }
}
