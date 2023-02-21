namespace GestioneSagre.SharedKernel.Models.Auth;

public class RefreshTokenRequest
{
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }
}