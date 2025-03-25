using System;

namespace FactoryMethod.Services;

public class GHTKShippingService : IShippingService
{
    public string Operation(string orderId)
    {
        return $"GHTK: {orderId}";
    }
}

