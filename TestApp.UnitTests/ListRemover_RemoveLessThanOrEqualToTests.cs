using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveLessThanOrEqualToTests
{
    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_EmptyListParameter_ReturnsEmtyList()
    {
        // Arrange
        List<int> numbers = new List<int>();
        int threshold = 5;

        // Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(numbers, threshold);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanOrEqualToThresholdElements_ReturnsEmtyList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
        int threshold = 5;

        // Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(numbers, threshold);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithOnlyGreaterThanThresholdElements_ReturnsSameList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 6, 42, 8, 13, 10 };
        int threshold = 5;

        // Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(numbers, threshold);

        // Assert
        Assert.That(result, Is.EqualTo(numbers));
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyGreaterThanThreshold()
    {
        // Arrange
        List<int> numbers = new List<int>() { 6, 42, 8, 13, 10, 3 };
        int threshold = 10;

        List<int> expected = new List<int>() { 42, 13 };

        // Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(numbers, threshold);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}