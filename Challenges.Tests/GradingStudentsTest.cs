using System.Collections.Generic;
using Challenges;
using Xunit;

namespace Challenges.Tests;

public class GradingStudentsTest
{
    [Fact]
    public void ExampleTest()
    {
        var input = new List<int>() { 73, 67, 38, 33 };
        var expected = new List<int>() { 75, 67, 40, 33 };
        Assert.Equal(expected, GradingStudents.gradingStudents(input));
    }

    [Fact]
    public void Case1Test()
    {
        var input = new List<int>() { 37, 38 };
        var expected = new List<int>() { 37, 40 };
        Assert.Equal(expected, GradingStudents.gradingStudents(input));
    }
}