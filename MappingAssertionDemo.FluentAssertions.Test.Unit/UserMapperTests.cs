using FluentAssertions;
using MappingAssertionDemo.Model;

namespace MappingAssertionDemo.Test.Unit;

[TestClass]
public class UserMapperTests
{
    private User _user;

    [TestInitialize]
    public void TestInitialize()
    {
        _user = new User
        {
            Username = "bvkeersop",
            FirstName = "Bart",
            LastName = "van Keersop",
            Email = "bart123@email.com",
            Country = "The Netherlands",
            Gender = "Male",
            FavoriteAssertionFramework = "FluentAssertions",
        };
    }

    [TestMethod]
    public void Map_FluentAssertions_AssertEverythingManually()
    {
        // Act
        var result = UserMapper.Map(_user);

        // Assert
        result.DisplayName.Should().Be(_user.Username);
        result.FullName.Should().Be($"{_user.FirstName} {_user.LastName}");
        result.Email.Should().Be(_user.Email);
        result.DateOfBirth.Should().Be(_user.DateOfBirth);
        result.Country.Should().Be(_user.Country);
        result.Gender.Should().Be(_user.Gender);
        result.FavoriteAssertionFramework.Should().Be(_user.FavoriteAssertionFramework);
    }

    [TestMethod]
    public void Map_FluentAssertions_AssertWithEquivalentTo()
    {
        // Act
        var result = UserMapper.Map(_user);

        // Assert
        result
            .Should()
            .BeEquivalentTo(_user, options => options
                .ExcludingMissingMembers() // Exclude properties that are not present on BOTH objects (FirstName, LastName, Fullname)
                .WithMapping<UserDto>(e => e.Username, s => s.DisplayName)); // Property names are different

        result.FullName.Should().Be($"{_user.FirstName} {_user.LastName}");
    }
}