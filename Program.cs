class Program
    {
        static void Main(string[] args)
    {
        Console.WriteLine("\n\nPlease select one of the shipping: \n");
        Console.WriteLine("1. StandardShipping\n2. ExpressShipping\n3. OvernightShipping\n4. Free Shipping\n\n");

        int n = 0;
        IShippingStrategy shippingStrategy = null;

        do{
            n = Convert.ToInt32(Console.ReadLine());
        }while(n < 0 && n > 4);

        Console.WriteLine("Enter package weigt:");
        int weight = Convert.ToInt32(Console.ReadLine());

        switch(n){
            case 1: 
                shippingStrategy = new StandardShipping();
                break;
            case 2:
                shippingStrategy = new ExpressShipping();
                break;
            case 3:
                shippingStrategy = new OvernightShipping();
                break;
            case 4:
                shippingStrategy = new FreeShipping();
                break;
        }
       
       var order = new Order(shippingStrategy, weight);
       order.CalculateShipping();
    }
}



