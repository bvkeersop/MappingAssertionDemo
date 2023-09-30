namespace MappingAssertionDemo.Model;

public class User
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateOnly DateOfBirth { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public string FavoriteAssertionFramework { get; set; } = string.Empty;
}
