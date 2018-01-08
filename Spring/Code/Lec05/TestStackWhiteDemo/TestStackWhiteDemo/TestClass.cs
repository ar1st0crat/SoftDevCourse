using NUnit.Framework;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;
using System.Windows.Automation;

namespace TestStackWhiteDemo
{
    [TestFixture]
    public class TestClass
    {
        // check http://teststackwhite.readthedocs.io/en/latest/ScreenObjects/ScreenRepository/
        // for examples of Screen Object pattern (similar to Page Object pattern)

        private Application _app;
        private Window _window;
        private TextBox _regex;
        private TextBox _testString;
        private Button _okButton;

        [OneTimeSetUp]
        public void Init()
        {
            // we'll work with the same instances of app and window for all tests
            // (it is safe, since NUnit tests run NOT in parallel by default)

            _app = Application.Launch(@"E:\Projects\Simple\Students\RegExTester\RegExTester\bin\Release\RegExTester.exe");
            _window = _app.GetWindow("RegExTester", InitializeOption.NoCache);

            var searchCriteria = SearchCriteria.ByControlType(ControlType.Edit).AndIndex(0);
            _regex = (TextBox)_window.Get(searchCriteria);

            searchCriteria = SearchCriteria.ByControlType(ControlType.Edit).AndIndex(1);
            _testString = (TextBox)_window.Get(searchCriteria);
            
            searchCriteria = SearchCriteria.ByText("Go!");
            _okButton = (Button)_window.Get(searchCriteria);
        }

        [Test]
        public void TestNormalRegEx()
        {
            _testString.Text = "user23 and user45";
            _regex.Text = @"user\d{2}";
            _okButton.Click();
            
            Assert.That(_window.Get<ListBox>("listBoxResults").Items.Count, Is.EqualTo(2));
        }

        [Test]
        public void TestNoMatch()
        {
            _testString.Text = "hello world!";
            _regex.Text = @"vas\d{2}";
            _okButton.Click();
            
            Assert.That(_window.Get<ListBox>("listBoxResults").Items.Count, Is.EqualTo(0));
        }

        [OneTimeTearDown]
        public void Quit()
        {
            _app.Close();
        }
    }
}
