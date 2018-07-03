using System.Collections.Generic;

namespace CarDealership.Models
{
  public class NewCar
  {
    private string Make;
    private string Model;
    private string Color;
    private int Year;
    private int Price;
    private static List<NewCar> Instances = new List<NewCar> {};

    public NewCar (string newMake = "Unknown", string newModel = "Unknown", string newColor = "Unknown", string newYear = "0", string newPrice = "0")
    {
      Make = newMake;
      Model = newModel;
      Color = newColor;
      Year = int.Parse(newYear);
      Price = int.Parse(newPrice);
    }
    public string GetMake()
    {
      return Make;
    }
    public void SetMake(string newMake)
    {
      Make = newMake;
    }
    public string GetModel()
    {
      return Model;
    }
    public void SetModel(string newModel)
    {
      Model = newModel;
    }
    public string GetColor()
    {
      return Color;
    }
    public void SetColor(string newColor)
    {
      Color = newColor;
    }
    public int GetYear()
    {
      return Year;
    }
    public void SetYear(int newYear)
    {
      Year = newYear;
    }
    public int GetPrice()
    {
      return Price;
    }
    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public static List<NewCar> GetAll()
    {
      return Instances;
    }
    public void Save()
    {
      Instances.Add(this);
    }
    // public string ShowAll()
    // {
    //   string output = "";
    //   foreach(NewCar car in Instances)
    //   {
    //     output = output + car.GetYear() + " " + car.GetMake() + " " + car.GetModel() + ", " + car.GetColor() + ", Price: $" + car.GetPrice() + "/r/n";
    //   }
    //   return output;
    // }
    public static void ClearAll()
    {
      Instances.Clear();
    }
  }
}
