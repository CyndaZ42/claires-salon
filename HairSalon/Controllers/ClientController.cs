using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ClientController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> model = _db.Client.Include(client => client.Stylist).ToList();
      ViewBag.PageTitle = "View All Clients";
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.ClientId = new SelectList(_db.Client, "ClientId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylist.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Stylist thisStylist = _db.Stylist.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(thisStylist);
    }
    
    public ActionResult Edit(int id)
    {
      var thisStylist = _db.Stylist.FirstOrDefault(stylist => stylist.StylistId == id);
      ViewBag.ClientId = new SelectList(_db.Client, "ClientId", "Name");
      return View(thisStylist);
    }

    [HttpPost]
    public ActionResult Edit(Stylist stylist)
    {
      _db.Entry(stylist).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisStylist = _db.Stylist.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(thisStylist);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisStylist = _db.Stylist.FirstOrDefault(stylist => stylist.StylistId == id);
      _db.Stylist.Remove(thisStylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}