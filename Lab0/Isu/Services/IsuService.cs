using Isu.Entities;
using Isu.Exceptions;
using Isu.Models;

namespace Isu.Services
{
    public class IsuService : IIsuService
    {
        private readonly Dictionary<string, Group> _groups;

        public IsuService()
        {
            _groups = new Dictionary<string, Group>();
        }

        public Group AddGroup(string groupName)
        {
            bool result = Group.TryParse(groupName, out Group? group);

            if (result)
            {
                _groups.Add(groupName, group!);
                return group!;
            }
            else
            {
                throw new InvalidGroupNameException(groupName);
            }
        }

        public Student AddStudent(Group group, string groupName)
        {
            throw new NotImplementedException();
        }

        public void ChangeStudentGroup(Student student, Group newGroup)
        {
            throw new NotImplementedException();
        }

        public Group? FindGroup(string groupName)
        {
            bool result = _groups.ContainsKey(groupName);

            if (result)
            {
                return _groups[groupName];
            }
            else
            {
                return null;
            }
        }

        public List<Group> FindGroups(CourseNumber courseNumber)
        {
            throw new NotImplementedException();
        }

        public Student? FindStudent(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> FindStudents(string groupName)
        {
            throw new NotImplementedException();
        }

        public List<Student> FindStudents(CourseNumber courseNumber)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }
    }
}
