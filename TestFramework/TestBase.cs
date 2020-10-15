using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestFramework
{
    [TestFixture]
    public class TestBase
    {
        [OneTimeSetUp]
        public static void Initialize()
        {
            Browser.Initialize();
        }

        [OneTimeTearDown]
        public static void TestFixtureTearDown()
        {
            Browser.Close();
        }

        [TearDown]
        public static void TearDown()
        {
            // Add code for teardown performed after each test.
        }
    }
}
