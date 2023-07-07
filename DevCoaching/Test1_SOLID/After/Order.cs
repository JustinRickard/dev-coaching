namespace DevCoaching.Test1_SOLID.After.PaymentProviders;


public interface IOrder
{
    string Id { get; set; }
    string Sku { get; set; }
    decimal Amount { get; set; }
}

public abstract class Order : IOrder
{
    public string Id { get; set; }
    public string Sku { get; set; }
    public decimal Amount { get; set; }
}