using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

[TestFixture]
public class SameValuesTests
{
    [Test]
    public void Test_FindSameValues_EmptyFirstList_ReturnsEmptyList()
    {
        // Arrange
        List<int> firstList = new();
        List<int> secondList = new() { 1, 2, 3, 4 };

        // Act
        List<int> actual = SameValues.FindSameValues(firstList, secondList);

        // Assert
        CollectionAssert.IsEmpty(actual);
    }

    [Test]
    public void Test_FindSameValues_EmptySecondList_ReturnsEmptyList()
    {
        // Arrange
        List<int> firstList = new() { 1, 2, 3, 4 };
        List<int> secondList = new();

        // Act
        List<int> actual = SameValues.FindSameValues(firstList, secondList);

        // Assert
        CollectionAssert.IsEmpty(actual);
    }

    [Test]
    public void Test_FindSameValues_NoSameValuesInBothLists_ReturnsEmptyList()
    {
        // Arrange
        List<int> firstList = new() { 1, 2, 3 };
        List<int> secondList = new() { 4, 5, 6 };

        // Act
        List<int> actual = SameValues.FindSameValues(firstList, secondList);

        // Assert
        CollectionAssert.IsEmpty(actual);
    }

    [Test]
    public void Test_FindSameValues_BothListWithSameValues_ReturnsListWithSameValues()
    {
        // Arrange
        List<int> firstList = new() { 1, 2, 3, 4, 5 };
        List<int> secondList = new() { 3, 4, 5, 6, 7 };
        List<int> expected = new() { 3, 4, 5 };

        // Act
        List<int> actual = SameValues.FindSameValues(firstList, secondList);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }
}