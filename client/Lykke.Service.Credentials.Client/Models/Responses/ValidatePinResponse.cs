﻿using Lykke.Service.Credentials.Client.Enums;

namespace Lykke.Service.Credentials.Client.Models.Responses
{
    public class ValidatePinResponse
    {
        /// <summary>
        /// Error code
        /// </summary>
        public PinCodeErrorCodes Error { get; set; }
    }
}
