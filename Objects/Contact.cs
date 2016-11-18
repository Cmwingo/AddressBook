using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _firstName;
    private string _lastName;
    private string _phone;
    private Address _address;
    private int _id;
    private static List<Contact> _instances = new List<Contact>();

    public Contact(string firstName, string lastName, string phone, Address address)
    {
      _firstName = firstName;
      _lastName = lastName;
      _phone = phone;
      _address = address;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetFirstName()
    {
      return _firstName;
    }
    public void SetFirstName(string newFirstName)
    {
      _firstName = newFirstName;
    }
    public string GetLastName()
    {
      return _lastName;
    }
    public void SetLastName(string newLastName)
    {
      _lastName = newLastName;
    }
    public string GetPhone()
    {
      return _phone;
    }
    public void SetPhone(string newPhone)
    {
      _phone = newPhone;
    }
    public Address GetAddress()
    {
      return _address;
    }
    public void SetAddress(Address newAddress)
    {
      _address = newAddress;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Contact Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
  public class Address
  {
    private string _street;
    private string _city;
    private string _state;
    private string _zip;

    public Address(string street, string city, string state, string zip)
    {
      _street = street;
      _city = city;
      _state = state;
      _zip = zip;
    }

    public string GetStreet()
    {
      return _street;
    }
    public void SetStreet(string newStreet)
    {
      _street = newStreet;
    }
    public string GetCity()
    {
      return _city;
    }
    public void SetCity(string newCity)
    {
      _city = newCity;
    }
    public string GetState()
    {
      return _state;
    }
    public void SetState(string newState)
    {
      _state = newState;
    }
    public string GetZip()
    {
      return _zip;
    }
    public void SetZip(string newZip)
    {
      _zip = newZip;
    }

  }
}
