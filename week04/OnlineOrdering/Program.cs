using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Order> _orders = new List<Order>();
        
        Address address1 = new Address("Cra 66 # 1 AA - 10","Medellin","Antioquia","Colombia");
        Customer customer1= new Customer("Brian Calderon",address1);
        Order _order1 = new Order(customer1);
        addhardcodeProducts(_order1,"Book of Mormon",85975,2.45,4);
        addhardcodeProducts(_order1,"Doctrine and covenants",879462,3.45,2);
        addhardcodeProducts(_order1,"Bible in gold page",986254,4.45,3);
        _orders.Add(_order1);

        Order _order2 = new Order(customer1);
        addhardcodeProducts(_order2,"Book to childrens",822215,1.45,2);
        addhardcodeProducts(_order2,"Tie for men",649458,5.20,1);
        addhardcodeProducts(_order2,"Jesus christ book",5287511,10.45,3);
        _orders.Add(_order2);


        Address address2 = new Address("Leakpoint 87458","Murray","Utah","USA");
        Customer customer2= new Customer("Tatiana Calderon",address2);
        Order _order3 = new Order(customer2);
        addhardcodeProducts(_order3,"Joseph Smith history",458487,4.45,1);
        addhardcodeProducts(_order3,"Hymns book",699987,2.45,2);
        addhardcodeProducts(_order3,"Bible in gold page",986254,4.45,3);
        _orders.Add(_order3);

        Console.WriteLine("\nList of Orders:");
        
        int Index = 1;
        foreach (Order order in _orders)
        {
            Console.WriteLine($"\n--------------Order n° {Index}---------------");
            order.GetPackingLabel();
            order.GetShippingLabel();
            Console.WriteLine($"Total prices + shipping: ${Math.Round(order.calculateTotalPrice(),2)}");
            Index++;
        }

    }

    public static void addhardcodeProducts (Order _order, string name, int productid, double amount, int count){
        Product _Product = new Product(name,productid,amount,count);          
        _order.addProduct(_Product);
    }

}