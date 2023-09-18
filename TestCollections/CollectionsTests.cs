namespace TestCollections;
using Collections;
using Xunit;
using System.Collections.Generic;

public class CollectionsTests
{
  [Fact]
  public void AddRandomNumbersToListTest()
  {
    var list = new List<int> { 1, 2, 3 };
    var newList = CollectionsHelper.AddRandomNumbersToList(list, 2);

    Assert.Equal(5, newList.Count);
  }

  [Fact]
  public void RemoveElementFromListTest()
  {
    var list = new List<int> { 1, 2, 3, 4, 5 };
    var (updatedList, message) = CollectionsHelper.RemoveElementFromList(list, 3);

    Assert.Equal(4, updatedList.Count);
    Assert.Equal("Element removed successfully", message);

    // Test edge case where element is not in the list
    var (updatedList2, message2) = CollectionsHelper.RemoveElementFromList(list, 6);
    Assert.Equal("Element not found", message2);
  }

  [Fact]
  public void CheckElementInListTest()
  {
    var list = new List<int> { 1, 2, 3, 4, 5 };

    Assert.True(CollectionsHelper.CheckElementInList(list, 3));

    // Test edge case where element is not in the list
    Assert.False(CollectionsHelper.CheckElementInList(list, 6));
  }

  [Fact]
  public void FindMaxTest()
  {
    var list = new List<int> { 3, 5, 2, 8, 1 };
    var result = CollectionsHelper.FindMax(list);

    Assert.Equal(8, result);

    var emptyList = new List<int>();
    var resultForEmptyList = CollectionsHelper.FindMax(emptyList);

    Assert.Equal(0, resultForEmptyList);
  }

  [Fact]
  public void FindMinTest()
  {
    var list = new List<int> { 3, 5, 2, 8, 1 };
    var result = CollectionsHelper.FindMin(list);

    Assert.Equal(1, result);

    var emptyList = new List<int>();
    var resultForEmptyList = CollectionsHelper.FindMin(emptyList);

    Assert.Equal(0, resultForEmptyList);
  }

  [Fact]
  public void CalculateAverageTest()
  {
    var list = new List<int> { 1, 2, 3, 4, 5 };
    var result = CollectionsHelper.CalculateAverage(list);

    Assert.Equal(3.0, result);

    var emptyList = new List<int>();
    var resultForEmptyList = CollectionsHelper.CalculateAverage(emptyList);

    Assert.Equal(0.0, resultForEmptyList);
  }
}
