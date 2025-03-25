using FactoryMethod.FactoryMethod;

var shippingService = ShippingServiceFactory.CreateShippingService("DHL");
Console.WriteLine(shippingService.Operation("12345"));