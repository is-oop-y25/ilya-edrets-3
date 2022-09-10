namespace Isu.Entities;

// firstName, lastName, id, dateBirth, email, group
public class Student
{
    private int _id;

    public Student(string firstName, string lastName, DateTime dateBirth)
    {
        if (string.IsNullOrWhiteSpace(firstName))
        {
            throw new ArgumentException(nameof(firstName));
        }

        if (string.IsNullOrWhiteSpace(lastName))
        {
            throw new ArgumentException(nameof(lastName));
        }

        if (dateBirth > DateTime.Now)
        {
            throw new ArgumentException(nameof(dateBirth));
        }

        FirstName = firstName;
        LastName = lastName;
        DateBirth = dateBirth;
    }

    public int Id
    {
        get
        {
            return _id;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Id");
            }

            _id = value;
        }
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string? Email { get; set; }

    public string? GroupName { get; set; }

    public DateTime DateBirth { get; set; }
}
