using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveGreaterThanTests
{
    [Test]
    public void Test_RemoveElementsGreaterThan_EmptyListParameter_ReturnsEmtyList()
    {
        // Arrange
        List<int> numbers = new List<int>();
        int threshold = 5;

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(numbers, threshold);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithGreaterThanThresholdElements_ReturnsEmtyList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 6, 42, 8, 13, 10 };
        int threshold = 5;

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(numbers, threshold);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanOrEqualToThresholdElements_ReturnsSameList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 6, 42, 8, 13, 10 };
        int threshold = 42;

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(numbers, threshold);

        // Assert
        Assert.That(result, Is.EqualTo(numbers));
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyLessThanOrEqualToThreshold()
    {
        // Arrange
        List<int> numbers = new List<int>() { 6, 42, 8, 13, 10, 3 };
        int threshold = 10;

        List<int> expected = new List<int>() { 6, 8, 10, 3 };

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(numbers, threshold);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}