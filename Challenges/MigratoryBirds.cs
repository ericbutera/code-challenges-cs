namespace Challenges;
public class MigratoryBirds
{
    public static int migratoryBirds(List<int> birds)
    {
        // quick port from ts version
        var counter = new Dictionary<int, int>();
        int maxSighting = 0;
        int minBird = 0;

        foreach (var bird in birds)
        {
            var count = 1;
            if (counter.ContainsKey(bird))
            {
                count = counter[bird]++;
            }
            else
            {
                counter[bird] = count;
            }

            if (minBird == 0)
            {
                minBird = bird;
            }
            else if (count > maxSighting)
            {
                minBird = bird;
                maxSighting = count;
            }
            else if (count == maxSighting && bird < minBird)
            {
                minBird = bird;
            }

        }
        return minBird;
    }
}