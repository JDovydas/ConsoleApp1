namespace JWTAuthenticationAndAuthorization.Services
{
    public interface IJWTService
    {
        string GetJWT(string user, string role);
    }
}