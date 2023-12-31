namespace N64.Identity.Api.Configuration;

public static partial class HostConfiguration
{
    public static ValueTask<WebApplicationBuilder> ConfigureAsync(this WebApplicationBuilder builder)
    {
        builder.AddIdentityInfrastructure().AddDevTools().AddExposes();

        return new(builder);
    }

    public static ValueTask<WebApplication> ConfigureAsync(this WebApplication app)
    {
        app.UseIdentityInfrastructure().UseDevTools().UseExposers();
        
        return new (app);
    }
}