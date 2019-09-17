using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzKataTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [DataRow(2, "1 2")]
        [DataRow(3, "1 2 Fizz")]
        [DataTestMethod ]
        
        public void Should_Return_FizzBuzz_When_Passed_Number(int number,string expectedResult)
        {
            //arrange
                        string actualResult = "";
            FizzBuzz fizzBuzz = new FizzBuzz();

            //act
            actualResult = fizzBuzz.Convert(number);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Should_Return_1_2_When_Passed_2()
        {
            //arrange
            int number = 2;
            string expectedResult = "1 2";
            string actualResult = "";
            FizzBuzz fizzBuzz = new FizzBuzz();

            //act
            actualResult = fizzBuzz.Convert(number);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Should_Return_1_2_Fizz_When_Passed_3()
        {
            //arrange
            int number = 3;
            string expectedResult = "1 2 Fizz";
            string actualResult = "";
            FizzBuzz fizzBuzz = new FizzBuzz();

            //act
            actualResult = fizzBuzz.Convert(number);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Should_Return_1_2_Fizz_4_Buzz_When_Passed_5()
        {
            //arrange
            int number = 5;
            string expectedResult = "1 2 Fizz 4 Buzz";
            string actualResult = "";
            FizzBuzz fizzBuzz = new FizzBuzz();

            //act
            actualResult = fizzBuzz.Convert(number);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Should_Return_1_2_Fizz_4_Buzz_Fizz_7_8_Fizz_Buzz_11_Fizz_13_14_FizzBuzz_When_Passed_5()
        {
            //arrange
            int number = 15;
            string expectedResult = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz";
            string actualResult = "";
            FizzBuzz fizzBuzz = new FizzBuzz();

            //act
            actualResult = fizzBuzz.Convert(number);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
