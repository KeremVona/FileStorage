namespace Server.DTOs;

public record RegisterRequest(string Email, string Password);
public record LoginRequest(string Email, string Password);
public record AuthResponse(string Token, Guid Id, string Email, DateTime MadeAt);
