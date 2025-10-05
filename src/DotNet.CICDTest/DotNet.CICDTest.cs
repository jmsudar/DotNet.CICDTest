namespace jmsudar.DotNet.CICDTest
{
    /// <summary>
    /// This class contains methods that can be used for testing purposes.
    /// </summary>
    public static class TestMethods
    {
        /// <summary>
        /// Returns a greeting message.
        /// </summary>
        /// <returns>A simple Hello, World statement</returns>
        public static string GetGreeting()
        {
            // To test presentation of warnings, uncomment the line below to set an unused variable
            string unusedVariable = "This variable is not used anywhere";

            return "Hello, World!";
        }

        /// <summary>
        /// Adds two integers and returns the result.
        /// </summary>
        /// <param name="a">The first integer</param>
        /// <param name="b">The second integer</param>
        /// <returns>The sum of the two integers</returns>
        public static int Add(int a, int b)
        {
            // To test presentation of errors, comment out the line below so that a value is not returned
            //return a + b;
        }

        /// <summary>
        /// Concatenates two strings with a space in between.
        /// </summary>
        /// <param name="str1">The first string</param>
        /// <param name="str2">The second string</param>
        /// <returns>The concatenated string</returns>
        public static string Concat(string str1, string str2)
        {
            return $"{str1} {str2}";
        }
    }
}