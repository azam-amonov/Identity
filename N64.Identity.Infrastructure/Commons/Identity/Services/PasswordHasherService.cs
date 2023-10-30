using N64.Identity.Application.Common.Identity.Services;

namespace N64.Identity.Infrastructure.Commons.Identity.Services;

public class PasswordHasherService : IPasswordHasherService
{
    public string HashPassword(string password) => 
                    BCrypt.Net.BCrypt.HashPassword(password);

    public bool ValidatePassword(string password, string hashedPassword)=>
                    BCrypt.Net.BCrypt.Verify(password, hashedPassword);
}

