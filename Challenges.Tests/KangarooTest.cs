using System.Collections.Generic;
using Challenges;
using Xunit;

using static Challenges.Kangaroo;

namespace Challenges.Tests;

public class KangarooTest
{
    [Fact]
    public void Example() => Assert.Equal("YES", kangaroo(2, 1, 1, 2));

    [Fact]
    public void SampleInput0() => Assert.Equal("YES", kangaroo(0, 3, 4, 2));

    [Fact]
    public void SampleInput1() => Assert.Equal("NO", kangaroo(0, 2, 5, 3));
}