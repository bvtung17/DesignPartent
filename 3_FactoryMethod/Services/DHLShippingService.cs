using System;

namespace FactoryMethod;

public class DHLShippingService : IShippingService
{
    public string Operation(string orderId)
    {
        return $"DHL: {orderId}";
    }
}