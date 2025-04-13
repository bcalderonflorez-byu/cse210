using System;
using System.Collections.Immutable;

public class Address
{
    private string _street;
    private string _city;
    private string _stateprovince;
    private string _country;


    public Address(string street, string city,string stateprovince,string country){
        _street = street;
        _city = city;
        _stateprovince = stateprovince;
        _country = country;
    }    
    public bool IsInEEUU()
    {
        bool isEeuu = false;
        if (_country.ToUpper() == "EEUU" ||  _country.ToUpper() == "UNITED STATES" || _country.ToUpper() == "USA" ){
            isEeuu = true;
        }
        return isEeuu;
    }

    public string GetAddress() {
        string fullAddress = "";
        fullAddress = $"{_street}, {_city}, {_stateprovince}, {_country} ";
        return fullAddress; 
    }

}