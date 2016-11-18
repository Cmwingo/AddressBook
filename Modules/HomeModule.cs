using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        var allContacts = Contact.GetAll();
        return View["index.cshtml", allContacts];
      };
      Get["/contacts/new"] = _ => {
        return View["contact_form.cshtml"];
      };
      Post["/contact"] = _ => {
        Address newAddress = new Address(Request.Form["street"], Request.Form["city"], Request.Form["state"], Request.Form["zip"]);
        Contact newContact = new Contact(Request.Form["first-name"], Request.Form["last-name"], Request.Form["phone"], newAddress);
        return View["contact_added.cshtml", newContact];
      };
      Get["/contacts/{id}"] = parameters => {
        Contact requestedContact = Contact.Find(parameters.id);
        return View["contact.cshtml", requestedContact];
      };
      Post["/contacts/clear"] = _ => {
        Contact.ClearAll();
        return View["address_book_clear.cshtml"];
      };
    }
  }
}
