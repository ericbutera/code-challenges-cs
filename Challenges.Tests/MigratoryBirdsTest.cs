using System.Collections.Generic;
using Challenges;
using Xunit;

namespace Challenges.Tests;

public class MigratoryBirdsTest
{
    [Fact]
    public void ExampleTest()
    {
        var birds = new List<int>() { 1, 1, 2, 2, 3 };
        Assert.Equal(1, MigratoryBirds.migratoryBirds(birds));
    }
}