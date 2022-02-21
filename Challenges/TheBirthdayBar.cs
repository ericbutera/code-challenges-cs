// https://www.hackerrank.com/challenges/the-birthday-bar/problem
// dotnet test --filter TheBirthdayBar

namespace Challenges;
public class TheBirthdayBar
{
    /// <summary>
    ///
    /// </summary>
    /// <param name="squares">numbers on each of the squares of chocolate</param>
    /// <param name="birthday">Total sum to aim for</param>
    /// <param name="birthMonth">Number of squares to group</param>
    /// <returns>number of ways the bar can be divided</returns>
    public static int birthday(List<int> squares, int birthday, int birthMonth)
    {
        int chunkSize = birthMonth - 1; // TODO: bounds check
        int splitsFound = 0,
            sum = 0,
            attempt = 0;

        for (var x = 0; x <= squares.Count; x++)  // iterate bar squares
        {
            sum = 0;
            for (var y = 0; y <= chunkSize; y++)
            { // iterate contiguous squares as a group of `chunkSize`
                attempt = y + x;
                if (attempt >= squares.Count)
                    break;

                sum += squares[attempt];
            }

            if (sum == birthday)
                splitsFound++;
        }

        return splitsFound;
    }

    public static int birthday2(List<int> squares, int birthday, int birthMonth)
    {
        int chunkSize = birthMonth
            , sum = 0
            , splitsFound = 0;

        for (var x = 0; x <= squares.Count; x++)
        {
            sum = squares.Skip(x)
                .Take(chunkSize)
                .Sum();

            if (sum == birthday)
                splitsFound++;
        }

        return splitsFound;
    }
}