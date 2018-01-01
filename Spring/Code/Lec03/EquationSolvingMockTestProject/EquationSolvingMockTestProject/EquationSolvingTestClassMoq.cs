using EquationSolvingApplication;
using Moq;
using NUnit.Framework;

namespace EquationSolvingMockTestProject
{
    [TestFixture]
    public class EquationSolvingTestClassMoq
    {
        private readonly Mock<IRoots> _mockRoots = new Mock<IRoots>();

        [Test]
        public void TestMoreThatThreeCoefficients()
        {
            double[] coeffs = { 1, 3, -5, -15, 4, 12 };
            double[] validRoots = { -3, -2, -1, 1, 2 };

            _mockRoots.Setup(r => r.Calculate(coeffs)).Returns(validRoots);

            var solver = new EquationSolver(_mockRoots.Object);

            double[] roots = solver.Solve(coeffs);

            Assert.That(roots, Is.EquivalentTo(validRoots));
        }

        [Test]
        public void TestPolynomialRootsGetCalled()
        {
            var solver = new EquationSolver(_mockRoots.Object);

            double[] coeffs = { 1, 3, -5, -15, 4, 12 };
            double[] roots = solver.Solve(coeffs);

            _mockRoots.Verify(r => r.Calculate(coeffs));

            // more checks:

            // _mockRoots.Verify(r => r.Calculate(coeffs), Times.Once());
            // _mockRoots.VerifyNoOtherCalls();
        }
    }
}
