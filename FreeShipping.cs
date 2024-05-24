public class FreeShipping : IShippingStrategy
{
    private float _shippingCost = 0;

    public float Calculate(int weight)
    {   
        return _shippingCost;
    }
}