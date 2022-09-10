using Isu.Exceptions;
using Isu.Services;
using Xunit;

namespace Isu.Test;

public class IsuServiceTests
{
    [Fact]
    public void AddStudentToGroup_StudentHasGroupAndGroupContainsStudent() { }

    [Fact]
    public void ReachMaxStudentPerGroup_ThrowException() { }

    [Fact]
    public void CreateGroupWithInvalidName_ThrowException()
    {
        var service = new IsuService();
        string invalidGroupName = "123";

        try
        {
            service.AddGroup(invalidGroupName);
        }
        catch (InvalidGroupNameException)
        {
            return;
        }

        Assert.True(false);
    }

    [Fact]
    public void TransferStudentToAnotherGroup_GroupChanged() { }
}