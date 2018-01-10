using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace EquationSolvingSpecs
{
    [Binding]
    public class SolvingCustomAlgebraicEquationSteps
    {
        private readonly EquationSolvingContext _context;

        public SolvingCustomAlgebraicEquationSteps(EquationSolvingContext context)
        {
            _context = context;
        }

        [Given(@"I have specified array of coefficients \{ ((?:.,\d+)*(?:.+)) }")]
        public void GivenIHaveSpecifiedArrayOfCoefficients(List<double> coeffs)
        {
            _context.Coefficients = coeffs;
        }

        [Then(@"the array of roots should be \{ ((?:.,\d+)*(?:.+)) }")]
        public void ThenTheArrayOfRootsShouldBe(List<double> roots)
        {
            Assert.That(_context.Roots, Is.EquivalentTo(roots));
        }

        [StepArgumentTransformation(@"((?:.,\d+)*(?:.+))")]
        public static List<double> ListIntTransform(string doubles)
        {
            return doubles.Split(',').Select(double.Parse).ToList();
        }

        [Then(@"argument exception must occur")]
        public void ThenArgumentExceptionMustOccur()
        {
            Assert.That(_context.Exception, Is.Not.Null);
            Assert.That(_context.Exception, Is.TypeOf<ArgumentException>());
        }
    }
}
