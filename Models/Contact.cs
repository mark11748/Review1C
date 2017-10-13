using System.Collections.Generic;
using System;

namespace Review1C.Models
{
  public class Contact
  {
    private static List<Contact> _contacts=new List<Contact> {};
    private string _name;
    private string _phone;
    private string _address;

    public List<Contact> GetAll() {return _contacts;}
    public void AddContact(){ _contacts.Add(this);}

    public string GetName ()  {return _name;}
    public string GetPhone()  {return _phone;}
    public string GetAddress(){return _address;}

    public void SetName   (string newName)   {_name =newName;}
    public void SetPhone  (string newNumb)   {_phone=newNumb;}
    public void SetAddress(string newAddress){_address=newAddress;}

    public Contact ()
    {
      _name   = "";
      _phone  = "";
      _address= "";
    }
  }
}
