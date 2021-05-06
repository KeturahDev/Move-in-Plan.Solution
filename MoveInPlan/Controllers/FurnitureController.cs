using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using MoveInPlan.Models;

namespace MoveInPlan.Controllers
{
  public class FurnitureController : Controller
  {
    [HttpGet("/room/{roomId}/furniture/new")]
    public ActionResult New(int roomId)
    {
      Room room = Room.Find(roomId);
      return View(room);
    }

    
  }
}