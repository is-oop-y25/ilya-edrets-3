using Isu.Models;

namespace Isu.Entities;

public class Group
{
    private Group(string groupName, CourseNumber courseNumber)
    {
        MaxStudents = 50;
        Students = new List<Student>();
        GroupName = groupName;
        CourseNumber = courseNumber;
    }

    public string GroupName { get; set; }

    public CourseNumber CourseNumber { get; set; }

    public List<Student> Students { get; set; }

    public int MaxStudents { get; }

    public static bool TryParse(string groupName, out Group? group)
    {
        group = null;

        if (!groupName.StartsWith("M"))
        {
            return false;
        }

        group = new Group(groupName, CourseNumber.First);

        return true;
    }
}
