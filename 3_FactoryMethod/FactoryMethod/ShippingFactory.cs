using System;
using FactoryMethod.Services;

namespace FactoryMethod.FactoryMethod;

public class ShippingServiceFactory
{
    public static IShippingService CreateShippingService(string type)
    {
        return type switch
        {
            "DHL" => new DHLShippingService(),
            "GHTK" => new GHTKShippingService(),
            _ => throw new ArgumentException("Invalid shipping type"),
        };
    }
}


