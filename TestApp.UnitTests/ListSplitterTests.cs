using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListSplitterTests
{
    [Test]
    public void Test_SplitEvenAndOdd_EmptyListParameter_ReturnsEmptyEvenAndOddLists()
    {
        // Arrange
        List<int> numbers = new List<int>();

        // Act
        (List<int> evens, List<int> odds) = ListSplitter.SplitEvenAndOdd(numbers);

        // Assert
        Assert.That(evens, Is.Empty);
        Assert.That(odds, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyEvenValues_ReturnsEmptyOddList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 6, 42, 8, 12, 10 };
        List<int> expectedEvens = new List<int>() { 6, 42, 8, 12, 10 };

        // Act
        (List<int> evens, List<int> odds) = ListSplitter.SplitEvenAndOdd(numbers);

        // Assert
        Assert.That(evens, Is.EqualTo(expectedEvens));
        Assert.That(odds, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyOddValues_ReturnsEmptyEvenList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 5, 13, 7, 15, 3 };
        List<int> expectedOdds = new List<int>() { 5, 13, 7, 15, 3 };

        // Act
        (List<int> evens, List<int> odds) = ListSplitter.SplitEvenAndOdd(numbers);

        // Assert
        Assert.That(evens, Is.Empty);
        Assert.That(odds, Is.EqualTo(expectedOdds));
    }

    [Test]
    public void Test_SplitEvenAndOdd_EvenAndOddValues_ReturnsListWithCorrectValues()
    {
        // Arrange
        List<int> numbers = new List<int>() { 6, 42, 8, 13, 10, 3 };
        List<int> expectedEvens = new List<int>() { 6, 42, 8, 10 };
        List<int> expectedOdds = new List<int>() { 13, 3 };

        // Act
        (List<int> evens, List<int> odds) = ListSplitter.SplitEvenAndOdd(numbers);

        // Assert
        Assert.That(evens, Is.EqualTo(expectedEvens));
        Assert.That(odds, Is.EqualTo(expectedOdds));
    }
}