using System;

public class Product
{
    private string _name;
    private int _productid;
    private double _amount;
    private int _count;

    public Product(string name, int productid, double amount, int count){
        _name = name;
        _productid = productid;
        _amount = amount;
        _count = count;
    }
    public double GetTotalCost(){

        double TotalCost = _amount*_count;
        return TotalCost;
    }

    public string GetName(){
        return _name;
    }

    public string GetProductId(){
        return _productid.ToString();
    }

}