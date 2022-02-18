// https://www.hackerrank.com/challenges/grading/problem
namespace Challenges;
public class GradingStudents
{
    /// <summary>
    /// Grades lower than this value remain failing
    /// </summary>
    const int MINIMUM = 38;
    /// <summary>
    /// Maximum allowed difference in which grades can still be rounded
    /// </summary>
    const int DIFF_TOLERANCE = 3;

    private static int NextMultiple(int grade) {
        while (true)
        {
            grade++;
            if (grade % 5 == 0)
                return grade;
        }
    }

    public static List<int> gradingStudents(List<int> grades)
    {
        for (var offset = 0; offset < grades.Count(); offset++)
        {
            var grade = grades[offset];

            if (grade >= MINIMUM)
            {
                var nextMultiple = NextMultiple(grade);
                var diff = nextMultiple - grade;
                if (diff < DIFF_TOLERANCE)
                    grades[offset] = nextMultiple;
            }
        }

        return grades;
    }
}

/*
student receives grade 0 to 100
any grade less than 40 is Failing

if diff between grade and next multiple of 5 is less than 3,
    round up to next multiple of 5

if grade is less than 38, no rounding, grade remains Fail

// well im sure there's some fun way to quickly find next multiple
// BRUTE FORCE
nextMultiple(grade)
    attempt = grade
    while true
        attempt++
        if (attempt % 5 == 0)
            return attempt


foreach grade in grades
    if grade < 38
        return grade

    nextMultiple = 0

    diff = nextMultiple - grade
    if diff < 3
        roundUp; grade = nextMultiple

    return grade

*/