﻿namespace Lykke.Service.Credentials.Domain.Services
{
    public interface IPasswordValidator
    {
        bool IsValidPassword(string password);

        string BuildValidationMessage();
    }
}
