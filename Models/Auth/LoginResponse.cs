namespace Api.Models.Auth
{
  public class LoginResponse
  {
    public required string Token { get; set; }
    public DateTime ExpiresAt { get; set; }
    public required string RefreshToken { get; set; }
  }
}