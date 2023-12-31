namespace N64.Identity.Application.Common.Settings;

public class JwtSettings
{
    public bool ValidateIssuer { get; set; }

    public string ValidIssuer { get; set; } = string.Empty;
    
    public bool ValidateAudience { get; set; }
    
    public string ValidAudience { get; set; } = string.Empty;
    
    public bool ValidateLifeTime { get; set; }
    
    public int ExpirationTimeInMinutes { get; set; }
    
    public bool ValidateIssuerSigningKey { get; set; }
    
    public string SecretKey { get; set; } = string.Empty;
}