using jmsudar.DotNet.CICDTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNet.CICDTest.Tests
{

    /// <summary>
    /// This class contains unit tests for the TestMethods class.
    /// It is important to verify failure state for `dotnet-ci` so 
    /// there are several values you can comment in or out below
    /// in order to manipulate the tests to pass or fail.
    /// </summary>
    [TestClass]
    public class TestMethodsTests
    {
        [TestMethod]
        public void TestGetGreeting()
        {
            // Arrange, successful test case
            string expected = "Hello, World!";

            // Arrange, failure test case
            // string expected = "Hello, Universe!";

            // Act
            string actual = TestMethods.GetGreeting();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// This test method verifies the Add method of the TestMethods class.
        /// </summary>
        [TestMethod]
        public void TestAdd()
        {
            // Arrange, successful test case
            int a = 5;
            int b = 10;
            int expected = 15;

            // Arrange, failure test case
            // int expected = 20;

            // Act
            int actual = TestMethods.Add(a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        /// <summary>
        /// This test method verifies the Concat method of the TestMethods class.
        /// </summary>
        [TestMethod]
        public void TestConcat()
        {
            // Arrange, successful test case
            string str1 = "Hello";
            string str2 = "World";
            string expected = "Hello World";

            // Arrange, failure test case
            // string expected = "Hello Universe";

            // Act
            string actual = TestMethods.Concat(str1, str2);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}