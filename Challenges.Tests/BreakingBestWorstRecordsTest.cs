using System.Collections.Generic;
using System.Linq;
using Xunit;
using static Challenges.BreakingBestWorstRecords;

namespace Challenges;

public class BreakingBestWorstRecordsTest
{
    public class Examples : List<Examples.Example>
    {
        public class Example
        {
            public List<int>? Input { get; set; }
            public List<int>? Output { get; set; }
        }
    }

    [Fact]
    public void Result_handles_input00()
    {
        var example = new Examples.Example {
            Input = new List<int> { 12, 24, 10, 24 },
            Output = new List<int> { 1, 1 },
        };
        var output = breakingRecords(example.Input);
        Assert.True(example.Output.SequenceEqual(output));
    }

    [Fact]
    public void Input00()
    {
        var example = new Examples.Example {
            Input = new List<int>() { 10, 5, 20, 20, 4, 5, 2, 25, 1 },
            Output = new List<int> { 2, 4 }
        };
        var output = breakingRecords(example.Input);
        Assert.True(example.Output.SequenceEqual(output));
    }


    [Fact]
    public void Input01()
    {
        var example = new Examples.Example {
            Input = new List<int>() { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 },
            Output = new List<int> { 4, 0 }
        };
        var output = breakingRecords(example.Input);
        Assert.True(example.Output.SequenceEqual(output));

    }
}