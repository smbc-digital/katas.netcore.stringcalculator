using Xunit;

namespace Katas.NetCore.StringCalculator.Tests
{
    public class StringCalculatorTests
    {
        /*
         *  Your Mission....
         *  -----------------
         *  
         *  Create a STRING CALCULATOR that takes a delimited set of numbers and returns the sum.
         *  
         *  E.g. "2,4,9" = 15!
         *  
         *  Complete the mission by making the tests go GREEN!
         * 
         *  Aside from the standard functionality you should try to:
         *  
         *  - Allow any delimiter to be used, not just a comma
         *  - Ignore any numbers more than 100
         *  - Return 0 if a non numeric value is entered
         *  - Throw a custom exception if the first 7 numbers match the Fibonacci Sequence
         *  
         *  DON'T WORRY if you can't complete all tests!
         */

        [Fact]
        public void Calculate_EmptyString_ReturnsZero()
        {
            StringCalculator calculator = new();
            int result = calculator.Calculate(string.Empty);
            Assert.Equal(0, result);
        }

        [Fact(Skip="complete previous test first")]
        public void Calculate_SingleNumber_ReturnsSameNumber()
        {
            // e.g. "1" = 1
        }

        [Fact (Skip="complete previous test first")]
        public void Calculate_TwoNumbers_ReturnsSum()
        {
            // e.g. "1,2" = 3
        }

        [Fact(Skip="complete previous test first")]
        public void Calculate_FiveNumbers_ReturnsSum()
        {
            // e.g. "1,2,3,4,5" = 15
        }

        [Fact(Skip="complete previous test first")]
        public void Calculate_CanUseAlternativeDelimiters_ReturnsSum()
        {
            // e.g. "1|2|3" = 6
        }

        [Fact(Skip="complete previous test first")]
        public void Calculate_NumbersLargerThan100_IgnoresOver100sInSum()
        {
            // e.g. "1,2,100" = 3
        }

        [Fact(Skip="complete previous test first")]
        public void Calculate_NonNumericValue_ReturnsZero()
        {
            // e.g. "1,Elephant,6" = 0
        }

        [Fact(Skip="complete previous test first")]
        public void Calculate_FirstSevenInFibonacciSequence_ThrowsCustomFibonacciAlertException()
        {
            // e.g. "0,1,1,2,3,5,8" = FibonacciAlertException!
        }
    }
}
