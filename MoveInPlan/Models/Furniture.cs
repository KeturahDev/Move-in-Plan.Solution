using System.Collections.Generic;

namespace MoveInPlan.Models 
{
  public class Furniture
  {
    private static List<Furniture> _instances = new List<Furniture> {};
    public int Id {get;}
    public string Name {get;set;}

    public Furniture (string furnitureName)
    {
      _instances.Add(this);
      Id = _instances.Count;
      Name = furnitureName;
    }

    public void ClearAll()
    {
      _instances.Clear();
    }
    public List<Furniture> GetAll()
    {
      return _instances;
    }
    public Furniture Find(int searchId)
    {
      return _instances[searchId -1];
    }
  }
}