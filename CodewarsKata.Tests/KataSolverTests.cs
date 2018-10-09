using Codewars_Kata;
using System;
using Xunit;

namespace CodewarsKata.Tests
{
    public class KataSolverTests
    {
        // level 8-1 https://www.codewars.com/kata/even-or-odd
        [Theory]
        [InlineData(1, "Odd")]
        [InlineData(2, "Even")]
        [InlineData(-1, "Even")]
        [InlineData(0, "Even")]
        public void EvenOrOdd(int a, string expected)
        {
            // Arange
            KataSolver solver = new KataSolver();

            // Act
            string actual = solver.EvenOrOdd(a);


            // Assert
            Assert.Equal(expected, actual);
        }


        // level 8-2 https://www.codewars.com/kata/get-the-mean-of-an-array/train/csharp
        [Theory]
        [InlineData(new double[] { 1, 1, 1, 1, 1 }, 1)]
        [InlineData(new double[] { 2, 2, 2, 2, 2 }, 2)]
        [InlineData(new double[] { 1, 2, 3, 4, 5 }, 3)]
        [InlineData(new double[] { 0 }, 0)]
        public void GetAverage(double[] numbers, double expected)
        {
            // Arange
            KataSolver solver = new KataSolver();

            // Act
            double actual = solver.GetAverage(numbers);
            
            // Assert
            Assert.Equal(expected, actual);
        }


        // level 8-3 https://www.codewars.com/kata/convert-a-string-to-a-number/train/csharp
        [Theory]
        [InlineData("7", 7)]
        [InlineData("-1", -1)]
        [InlineData("150", 150)]
        [InlineData("0", 0)]
        public void StringToNumber(string number, int expected)
        {
            // Arange
            KataSolver solver = new KataSolver();

            // Act
            int actual = solver.StringToNumber(number);

            // Assert
            Assert.Equal(expected, actual);
        }


        // level 8-4 https://www.codewars.com/kata/convert-boolean-values-to-strings-yes-or-no/train/csharp
        [Theory]
        [InlineData(true, "yes")]
        [InlineData(false, "no")]
        public void BoolToWord(bool value, string expected)
        {
            // Arange
            KataSolver solver = new KataSolver();

            // Act
            string actual = solver.BoolToWord(value);

            // Assert
            Assert.Equal(expected, actual);
        }


        // level 8-5 https://www.codewars.com/kata/counting-sheep-dot-dot-dot/train/csharp
        [Theory]
        [InlineData(new bool[] { true, true, false}, 2)]
        [InlineData(new bool[] { false, false, false }, 0)]
        public void CountSheeps(bool[] sheeps, int expected)
        {
            // Arange
            KataSolver solver = new KataSolver();

            // Act
            int actual = solver.CountSheeps(sheeps);

            // Assert
            Assert.Equal(expected, actual);
        }


        // level 8-6 https://www.codewars.com/kata/find-the-smallest-integer-in-the-array/train/csharp
        [Theory]
        [InlineData(new int[] { 1, 5, 10 }, 1)]
        [InlineData(new int[] { 10, 5, 1 }, 1)]
        [InlineData(new int[] { 1, 5, -10}, -10)]
        public void FindSmallestInt(int[] args, int expected)
        {
            // Arange
            KataSolver solver = new KataSolver();

            // Act
            int actual = solver.FindSmallestInt(args);

            // Assert
            Assert.Equal(expected, actual);
        }


        // level 8-7 https://www.codewars.com/kata/return-negative/train/csharp
        [Theory]
        [InlineData(7, -7)]
        [InlineData(-7, -7)]
        public void MakeNegative(int number, int expected)
        {
            // Arange
            KataSolver solver = new KataSolver();

            // Act
            int actual = solver.MakeNegative(number);

            // Assert
            Assert.Equal(expected, actual);
        }


        // level 8-8 https://www.codewars.com/kata/remove-first-and-last-character/train/csharp
        [Theory]
        [InlineData("ell", "hello")]
        [InlineData("elcom", "welcome")]
        [InlineData("", "hi")]
        [InlineData("", "")]
        public void Remove_char(string s, string expected)
        {
            // Arange
            KataSolver solver = new KataSolver();

            // Act
            string actual = solver.Remove_char(s);

            // Assert
            Assert.Equal(expected, actual);
        }

        // level 6-1 https://www.codewars.com/kata/multiples-of-3-or-5/train/csharp
        [Theory]
        [InlineData(23, 10)]
        [InlineData(8, 5)]
        [InlineData(14, 7)]
        [InlineData(93, 20)]
        public void MultiplesOfThreeOrFive(int value, int expected)
        {
            // Arange
            KataSolver solver = new KataSolver();

            // Act
            int actual = solver.MultiplesOfThreeOrFive(value);

            // Assert
            Assert.Equal(expected, actual);
        }

        // level 6-2 https://www.codewars.com/kata/find-the-odd-int/train/csharp
        [Theory]
        [InlineData(new[] { 1, 1, 2, 2, 3, 4, 4 }, 3)]
        [InlineData(new[] { 1, 2, 1 }, 2)]
        [InlineData(new[] { 1 }, 1)]
        public void FindOddInt(int[] seq, int expected)
        {
            // Arange
            KataSolver solver = new KataSolver();

            // Act
            int actual = solver.FindOddInt(seq);

            // Assert
            Assert.Equal(expected, actual);
        }

        // level 6-3 https://www.codewars.com/kata/persistent-bugger/train/csharp
        [Theory]
        [InlineData(23, 1)]
        [InlineData(99, 2)]
        [InlineData(5, 0)]
        [InlineData(84, 4)]
        public void Persistence(long n, int expected)
        {
            // Arange
            KataSolver solver = new KataSolver();

            // Act
            int actual = solver.Persistence(n);

            // Assert
            Assert.Equal(expected, actual);
        }


        // level 6-4 https://www.codewars.com/kata/find-the-parity-outlier/train/csharp
        [Theory]
        [InlineData(new int[] { 2, 4, 6, 8, 9, 10 }, 9 )]
        [InlineData(new int[] { 1, 3, 5, 6, 7, 9 }, 6 )]
        public void FindOutlier(int[] integers, int expected)
        {
            // Arange
            KataSolver solver = new KataSolver();

            // Act
            int actual = solver.FindOutlier(integers);

            // Assert
            Assert.Equal(expected, actual);
        }



        // level 5-1 https://www.codewars.com/kata/double-cola/train/csharp
        [Theory]
        [InlineData(new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" }, 1, "Sheldon")]
        [InlineData(new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" }, 6, "Sheldon")]
        [InlineData(new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" }, 4, "Rajesh")]
        [InlineData(new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" }, 8, "Leonard")]
        [InlineData(new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" }, 20, "Leonard")]
        public void WhoIsNext(string[] values, long n, string expected)
        {
            // Arrange
            KataSolver solver = new KataSolver();

            // Act
            string actual = solver.WhoIsNext(values, n);

            // Assert
            Assert.Equal(expected, actual);

        }

    }
}
