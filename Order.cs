public class Order
{
    private IShippingStrategy _shippingStrategy;
    private int _weight;

    public Order(IShippingStrategy shippingStrategy, int weight = 0)
    {
        _shippingStrategy = shippingStrategy;
        _weight = weight;
    }

    public float CalculateShipping()
    {
        var cost = _shippingStrategy.Calculate(_weight);

        Console.WriteLine($"Shipping cost: {cost}");
        return cost;
    }
}