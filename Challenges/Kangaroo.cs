// https://www.hackerrank.com/challenges/kangaroo
namespace Challenges;

public class Kangaroo
{
    /// <summary>
    ///
    /// </summary>
    /// <param name="x1">first kangaroo start position</param>
    /// <param name="v1">first kangaroo jump rate</param>
    /// <param name="x2">second kangaroo start position</param>
    /// <param name="v2">second kangaroo jump rate</param>
    /// <returns></returns>
    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        var roo1_pos = x1;
        var roo1_jump = v1;
        var roo2_pos = x2;
        var roo2_jump = v2;

        for (var x = 0; x <= 10_000; x++)
        {
            roo1_pos += roo1_jump;
            roo2_pos += roo2_jump;

            if (roo1_pos == roo2_pos)
                return "YES";
        }

        return "NO";
    }
}

/*
two kangaroos

animals jump in the same direction (unlimited moves)

first - starts at x1, moves at rate of v1
second - starts at x2, moves at rate of v2

GOAL: find a way to get both kangaroos at the same location and time
return YES if possible, else NO

x1 = 2
v1 = 1
x2 = 1
v2 = 2

one jump
x1(2) + v1(1) = 3
x2(1) + v2(2) = 3
3 == 3, YES

0 3 4 2
1
    1_pos0 + 1_jump3 = 3, 1_pos=3
    2_pos4 + 2_jump2 = 6, 2_pos=6
2
    1_pos3 + 1_jump3 = 6, 1_pos=6
    2_pos6 + 2_jump2 = 8, 2_pos=8
3
    first = 1_pos += 1_jump; 9
    second = 2_pos += 2_jump; 10
4
    first = 1_pos += 3; 12
    second = 2_pos += 2; 12
12 == 12, YES

0 2 5 3
roo1: 0 + 2 = 2
roo2: 5 + 3 = 8
roo1: 2 + 2 = 4
roo2: 8 + 3 = 11
roo1: 4 + 2 = 6
roo2: 11 + 3 = 14

roo1_pos = x1;
roo1_jump = v1
roo2_pos = x2
roo2_jump = v2

for x = 0; x < 10_000; x++
    roo1_pos += roo1_jump
    roo2_pos += roo2_jump

    if roo1_pos == roo2_pos
        return YES

return NO
*/