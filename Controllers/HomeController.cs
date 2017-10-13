using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

using Review1C.Models;

namespace Review1C.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      Contact myContacts = new Contact();
      return View(myContacts);
    }
    
    [HttpGet("/contact/{id}")]
    public ActionResult ContactDetails(int ID)
    {
      Contact myContacts = new Contact();
      return View(myContacts.GetAll()[ID-1]);
    }
    [HttpGet("/contact/add")]
    public ActionResult Contact()
    {
      return View();
    }
    [HttpPost("/contact/new")]
    public ActionResult NewContact()
    {
      Contact yourContact = new Contact();
      yourContact.SetName(Request.Form["contact-name"]);
      yourContact.SetPhone(Request.Form["contact-phone"]);
      yourContact.SetAddress(Request.Form["contact-address"]);
      yourContact.AddContact();
      return View(yourContact);
    }
    [HttpPost("/contact/clear")]
    public ActionResult ClearContacts()
    {
      Contact myContacts = new Contact();
      if(myContacts.GetAll().Count>0){myContacts.ClearContacts();}
      return View();
    }
  }
}
