public class OvernightShipping : IShippingStrategy
{    
    private float _shippingCost = 20;
    private int _weightCost = 10;
   
    public float Calculate(int weight)
    {
        if (weight > 1)
            return _shippingCost + _weightCost* weight;

        return _shippingCost;
    }
}