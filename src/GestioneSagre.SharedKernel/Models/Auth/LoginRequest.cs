﻿namespace GestioneSagre.SharedKernel.Models.Auth;

public class LoginRequest
{
    public string UserName { get; set; }
    public string Password { get; set; }
}