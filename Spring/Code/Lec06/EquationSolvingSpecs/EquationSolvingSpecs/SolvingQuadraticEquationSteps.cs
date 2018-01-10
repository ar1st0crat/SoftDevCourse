using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace EquationSolvingSpecs
{
    [Binding]
    public class SolvingQuadraticEquationSteps
    {
        private readonly EquationSolvingContext _context;

        public SolvingQuadraticEquationSteps(EquationSolvingContext context)
        {
            _context = context;
        }

        [Given(@"I have set (.*)")]
        public void GivenIHaveSet(double coeff)
        {
            _context.Coefficients.Add(coeff);
        }

        [When(@"I press Solve")]
        public void WhenIPressSolve()
        {
            // 1-ый способ обработки исключения
            try
            {
                _context.Roots = _context.Solver.Solve(_context.Coefficients.ToArray());
            }
            catch (Exception ex)
            {
                _context.Exception = ex;
            }

            // 2-ой способ - Assert.Catch() и использовать Scope в атрибуте When
        }
        
        [Then(@"the roots should be (.*) and (.*)")]
        public void ThenTheRootsShouldBe(double r1, double r2)
        {
            Assert.That(_context.Roots, Is.EquivalentTo(new [] { r1, r2 }));
        }

        [Then(@"exception must occur")]
        public void ThenExceptionMustOccur()
        {
            Assert.That(_context.Exception, Is.Not.Null);
            Assert.That(_context.Exception, Is.TypeOf<ArithmeticException>());
        }
    }
}
