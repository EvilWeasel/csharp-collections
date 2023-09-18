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
  public void FindClosestNumbersTest()
  {
    var list = new List<int> { 1, 3, 7, 8, 20, 21 };
    var result = CollectionsHelper.FindClosestNumbers(list);

    Assert.Equal((20, 21), result);

    // Test edge case with negative numbers
    var list2 = new List<int> { -10, -5, -2, 0, 3 };
    var result2 = CollectionsHelper.FindClosestNumbers(list2);

    Assert.Equal((-2, 0), result2);
  }

  [Fact]
  public void FindLongestConsecutiveSequenceTest()
  {
    var list = new List<int> { 1, 2, 3, 5, 6, 7, 10, 11 };
    var result = CollectionsHelper.FindLongestConsecutiveSequence(list);

    Assert.Equal(new List<int> { 5, 6, 7 }, result);

    // Test edge case with negative numbers and zeros
    var list2 = new List<int> { -3, -2, -1, 0, 1, 2 };
    var result2 = CollectionsHelper.FindLongestConsecutiveSequence(list2);

    Assert.Equal(new List<int> { -3, -2, -1, 0, 1, 2 }, result2);
  }
}
