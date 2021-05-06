using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using MoveInPlan.Models;

namespace MoveInPlan.Controllers
{
  public class RoomsController : Controller
  {
    [HttpGet("/rooms")]
    public ActionResult Index()
    {
      List<Room> allRooms = Room.GetAll();
      return View(allRooms);
    }

    [HttpGet("/rooms/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/rooms")]
    public ActionResult Create(string roomName)
    {
      Room newRoom = new Room(roomName);
      return RedirectToAction("Index");
    }

    [HttpGet("/rooms/{id}")]
    public ActionResult Show(int id) 
    {
      Room selectedRoom = Room.Find(id);
      return View(selectedRoom);
    }

    [HttpPost("rooms/{roomId}/furniture")]
    public ActionResult Create(int roomId, string furnitureName)
    {
      Room chosenRoom = Room.Find(roomId);
      Furniture newFurniture = new Furniture(furnitureName);
      chosenRoom.AddRoom(newFurniture);
      return View("Show", chosenRoom);
    }
  }
}