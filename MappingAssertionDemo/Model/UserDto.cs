namespace MappingAssertionDemo.Model;

public class UserDto
{
    public string DisplayName { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateOnly DateOfBirth { get; set; }
    public string Country { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public string FavoriteAssertionFramework { get; set; } = string.Empty;
}
