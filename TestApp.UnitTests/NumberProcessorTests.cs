using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class NumberProcessorTests
{
    [Test]
    public void Test_ProcessNumbers_SquareEvenNumbers()
    {
        // Arrange
        List<int> input = new() { 2, 4, 6 };
        List<double> expected = new() { 4, 16, 36 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    // TODO: finish test
    [Test]
    public void Test_ProcessNumbers_SquareRootOddNumbers()
    {
        // Arrange
        List<int> input = new() { 9, 49, 13 };
        List<double> expected = new() { 3, 7, 3.60 };

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);

        // Assert
        Assert.That(result.Count, Is.EqualTo(expected.Count));

        for (int i = 0; i < result.Count; i++)
        {
            Assert.That(result[i], Is.EqualTo(expected[i]).Within(0.01));
        }
    }

    // TODO: finish test
    [Test]
    public void Test_ProcessNumbers_HandleZero()
    {
        // Arrange
        List<int> input = new() { 0 };
        List<double> expected = new() { 0 };

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ProcessNumbers_EmptyInput()
    {
        // Arrange
        List<int> input = new();

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);

        // Assert
        Assert.That(result, Is.Empty);
    }
}