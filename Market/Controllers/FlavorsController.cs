    
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Linq;
using System.Collections.Generic;
using Market.Models;
using System.Security.Claims;

namespace Market.Controllers
{
  public class FlavorsController : Controller
  {
    
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult Create()
    {
      
      return View();
    }

    [HttpPost]
    public ActionResult Create(Flavor flavor, int TreatId)
    {
      
    
      return RedirectToAction("Index");
    }

  }
}
