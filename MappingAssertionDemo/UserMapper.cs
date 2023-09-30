using MappingAssertionDemo.Model;

namespace MappingAssertionDemo;

public class UserMapper
{
    public static UserDto Map(User user) => new()
    {
        DisplayName =  user.Username,
        FullName = $"{user.FirstName} {user.LastName}",
        Email = user.Email,
        DateOfBirth = user.DateOfBirth,
        Country = user.Country,
        Gender = user.Gender,
        FavoriteAssertionFramework = user.FavoriteAssertionFramework,
    };
}
