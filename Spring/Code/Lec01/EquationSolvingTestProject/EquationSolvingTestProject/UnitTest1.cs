using System;
using EquationSolvingApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquationSolvingTestProject
{
    [TestClass]
    public class QuadraticEquationUnitTest
    {
        readonly EquationSolver _solver = new EquationSolver();

        [TestInitialize]
        public void QuadraticEquationTestInitialize()
        {
            // additional test setup logic
        }

        [TestMethod]
        public void TestTwoDifferentRoots()     // "AAA" : Triple A
        {
            // ACT
            double[] roots = _solver.Solve(1, 1, -6);

            // ASSERT
            CollectionAssert.AreEquivalent(roots, new [] { 2.0, -3.0 });

            // we could also test:

            // 1) CollectionAssert.AllItemsAreNotNull(roots);
            // 2) CollectionAssert.AllItemsAreUnique(roots);
        }

        [TestMethod]
        public void TestOneRoot()
        {
            // ACT
            double[] roots = _solver.Solve(1, 2, 1);

            // ASSERT
            Assert.AreEqual(roots[0], -1);
        }

        [TestMethod]
        public void TestZeroCoefficients()
        {
            double[] roots = _solver.Solve(0, 1, 2);

            // ASSERT
            Assert.AreEqual(roots[0], -2);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestNoRealRoots()
        {
            // ARRANGE, ACT, ASSERT in one line
            _solver.Solve(1, 1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNoUnknowns()
        {
            // ARRANGE, ACT, ASSERT in one line
            _solver.Solve(0, 0, 1);
        }
    }
}
