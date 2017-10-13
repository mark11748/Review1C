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
      return View();
    }
    [HttpGet("/contact/list")]
    public ActionResult ContactList()
    {
      Contact myContacts = new Contact();
      return View(myContacts);
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
  }
}
