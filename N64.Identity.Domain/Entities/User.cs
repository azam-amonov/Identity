namespace N64.Identity.Domain.Entites;

public class User
{
    public Guid Id { get; set; }
    
    public string FirstName { get; set; } = string.Empty;
    
    public string LastName { get; set; } = string.Empty;
    
    public int Age { get; set; }
    
    public string EmailAddress { get; set;} = string.Empty;
    
    public string Password { get; set; } = string.Empty;
    
}