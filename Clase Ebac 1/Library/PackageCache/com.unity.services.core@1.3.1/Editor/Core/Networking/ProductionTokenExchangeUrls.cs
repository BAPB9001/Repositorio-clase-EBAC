using System;

namespace Unity.Services.Core.Editor
{
    internal class ProductionTokenExchangeUrls : ITokenExchangeUrls
    {
        public string ServicesGatewayTokenExchangeUrl => "https://services.unity.com/api/auth/v1/genesis-token-exchange/unity";
    }
}
