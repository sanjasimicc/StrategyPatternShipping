public class StandardShipping : IShippingStrategy
{
    private float _shippingCost = 5;
    private float _weightCost = 10;
    public float Calculate(int weight)
    {
        if (weight > 1)
            return _shippingCost + _weightCost * weight;

        return _shippingCost;
    }
}