// https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem
// dotnet test --filter BreakingBestWorstRecords
using System.Collections.Generic;
using System.Linq;

namespace Challenges;

public class BreakingBestWorstRecords
{
    public static List<int> breakingRecords(List<int> scores)
    {
        var first = scores.First();

        int high = first;
        int highChanged = 0;

        int low = first;
        int lowChanged = 0;

        foreach (var score in scores) {
            if (score > high) {
                highChanged++;
                high = score;
            } else if (score < low) {
                lowChanged++;
                low = score;
            }
        }

        return new List<int>{ highChanged, lowChanged };
    }
}

/*
Scores are in the same order as the games played. She tabulates her results as follows:
                                     Count
    Game  Score  Minimum  Maximum   Min Max
     0      12     12       12       0   0
     1      24     12       24       0   1
     2      10     10       24       1   1
     3      24     10       24       1   1
*/