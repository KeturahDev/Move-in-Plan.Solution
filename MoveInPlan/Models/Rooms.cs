using System.Collections.Generic;

namespace MoveInPlan.Models 
{
  public class Room 
  {
    private static List<Room> _instances = new List<Room> {};
    public string Name {get; set;}
    public int Id {get;}

    public Room (string roomName)
    {
      Name = roomName;
      _instances.Add(this);
      Id = _instances.Count;

    }

    public static void ClearAll()
    {
      
      _instances.Clear();
    }
    public static List<Room> GetAll()
    {
      return _instances;
    }
    public static Room Find(int searchId)
    {
      return _instances[searchId -1];
    }
  } 
}