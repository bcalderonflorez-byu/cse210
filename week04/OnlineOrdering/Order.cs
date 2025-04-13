using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer){
        
        _customer = customer;      
    }
    
    public void addProduct (Product product){
        _products.Add(product);
    }

    public void deleteProduct (Product product){
        _products.Remove(product);
    }

    public double calculateTotalPrice() {
        double TotalPrice = 0;
        double ShippingPrice = 5;

        foreach (Product product in _products){
            TotalPrice = TotalPrice + product.GetTotalCost();
        }

        if( !_customer.liveinUsa()){
            ShippingPrice = 35;
        }

        return TotalPrice + ShippingPrice;
    }

    public void GetPackingLabel(){
        Console.WriteLine($"\nPacking label should : ");
        foreach (Product product in _products){
            Console.WriteLine($"Product name : {product.GetName()}");
            Console.WriteLine($"Product ID : {product.GetProductId()}");
        }
    }
    public void GetShippingLabel(){
        Console.WriteLine($"\nShipping label should : ");
        Console.WriteLine($"Customer name : {_customer.GetName()}");
        Console.WriteLine($"Address : {_customer.GetAddress()}");        
    }

}