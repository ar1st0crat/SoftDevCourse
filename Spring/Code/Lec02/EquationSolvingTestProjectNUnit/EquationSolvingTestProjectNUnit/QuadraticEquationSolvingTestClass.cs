using System;
using EquationSolvingApplication;
using NUnit.Framework;

namespace EquationSolvingTestProjectNUnit
{
    [TestFixture]
    public class QuadraticEquationSolvingTestClass
    {
        readonly EquationSolver _solver = new EquationSolver();

        [SetUp]
        public void QuadraticEquationTestInitialize()
        {
            // additional test setup logic
        }

        [TestCase(1,  1, -6,  2, -3)]
        [TestCase(1,  5,  4, -4, -1)]
        [TestCase(1, -3,  0,  3,  0)]
        [TestCase(1, -5, -6,  3,  2)]
        public void TestTwoDifferentRoots(double a, double b, double c, double r1, double r2)
        {
            // ACT
            double[] roots = _solver.Solve(a, b, c);

            // ASSERT
            CollectionAssert.AreEquivalent(new[] { r1, r2 }, roots);

            // we could also test:

            // 1) CollectionAssert.AllItemsAreNotNull(roots);
            // 2) CollectionAssert.AllItemsAreUnique(roots);
        }

        [Test]
        public void TestOneRoot()
        {
            // ACT
            double[] roots = _solver.Solve(1, 2, 1);

            // ASSERT
            Assert.Multiple(() =>
            {
                Assert.AreEqual(-1, roots[0], "Root value");
                Assert.AreEqual(1, roots.Length, "Number of roots");
            });
        }

        [Test]
        public void TestZeroCoefficients()
        {
            double[] roots = _solver.Solve(0, 1, 2);

            // ASSERT
            Assert.AreEqual(-2, roots[0]);
        }

        [Test]
        public void TestNoRealRoots()
        {
            Assert.Throws<Exception>(() => _solver.Solve(1, 1, 1));
        }

        [Test]
        public void TestNoUnknowns()
        {
            Assert.That(() => _solver.Solve(0, 0, 1), 
                        Throws.InstanceOf<ArgumentException>()
                              .And
                              .Message.Contains("unknowns"));
        }
    }
}
