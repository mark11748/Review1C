using System.Collections.Generic;
using System;

namespace Review1C.Models
{
  public class Contact
  {
    private static List<Contact> _contacts=new List<Contact> {};
    private int    _id=-1;
    private string _name;
    private string _phone;
    private string _address;

    public List<Contact> GetAll(){return _contacts;}
    public void AddContact()     {_contacts.Add(this);_id=_contacts.Count;} //Add to list and set id to index+1
    public void ClearContacts()  {_contacts.Clear(); _id=0;}  /*Removes entries and resets id*/
    public int  GetId()          {return _id;}

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
