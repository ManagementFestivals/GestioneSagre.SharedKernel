﻿namespace GestioneSagre.SharedKernel.Models.Auth;

public class RegisterResponse
{
    public bool Succeeded { get; set; }
    public IEnumerable<string> Errors { get; set; }
}