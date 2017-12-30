using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace EquationSolvingTestProjectNUnit
{
    [TestFixture]
    public class NUnitDemosTestClass
    {
        [Test]
        public void Test2Plus2()
        {
            Assert.That(2 + 2, Is.EqualTo(4));
            Assert.That(2 + 2 == 4);
            Assert.That(2 + 2 + 1, Is.Not.EqualTo(4));
            Assert.That(2 + 2 + 1 != 4);
        }

        [Test]
        public void TestSimpleStringConstraints()
        {
            Assert.That("Hello", Is.EqualTo("HELLO").IgnoreCase);

            // equivalent to:
            // Assert.That("Hello", new EqualConstraint("HELLO").IgnoreCase);

            string[] expected = { "hello", "world" };
            string[] actual = { "HELLO", "World" };
            Assert.That(actual, Is.EqualTo(expected).IgnoreCase);
        }

        [Test]
        public void TestMoreStringConstraints()
        {
            Assert.That("Donetsk", Does.Contain("net"));
            Assert.That("Donetsk", Does.StartWith("Do"));
            Assert.That("Donetsk", Does.EndWith("sk"));
        }

        [Test]
        public void TestCollectionConstraints()
        {
            int[] array = { 1, 2, 3, 4, 5 };

            Assert.Multiple(() =>
            {
                Assert.That(array, Is.Unique);
                Assert.That(array, Has.Length.LessThan(10));
                Assert.That(array, Is.Ordered);
                Assert.That(array, Is.All.LessThan(6));
                Assert.That(array, Has.Exactly(1).EqualTo(3));
                Assert.That(array, Has.Exactly(2).GreaterThan(3));
            });
        }

        [Test]
        public void TestRange()
        {
            Assert.That(4, Is.InRange(1, 10));
        }

        [Test]
        public void TestPersonCollection()
        {
            Person[] persons = 
            {
                new Person {Id = 1, Lastname = "Emerson"},
                new Person {Id = 3, Lastname = "Lake"},
                new Person {Id = 2, Lastname = "Palmer"}
            };

            Assert.That(persons, Is.Ordered.By("Lastname"));
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Lastname { get; set; }
    }
}
