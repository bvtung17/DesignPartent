using System;

namespace FactoryMethod;

public interface IShippingService
{
    string Operation(string orderId);
}
