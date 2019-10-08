using System;
using System.Collections.Generic;

namespace Hungry_ninja
{
  class Program
  {
    static void Main(string[] args)
    {
      Ninja New_Ninja = new Ninja();
      // Food MyFood = new Food("Pad Thai", 800, true, false);
      // Buffet Ninja_buffet = new Buffet();
      // System.Console.WriteLine(Ninja_buffet.Serve().Name);
      New_Ninja.Eat();

    }


    // Food Class
    public class Food
    {
      //Food variables defined
      public string Name;
      private int calories;
      // Can be spicy or sweet
      public bool IsSpicy;
      public bool IsSweet;

      public int Calories { get => calories; set => calories = value; }


      //Food Constructor
      public Food(string name, int calories, bool isSpicy, bool isSweet)
      {
        Name = name;
        Calories = calories;
        IsSpicy = isSpicy;
        IsSweet = isSweet;
      }
    }


    // Buffet class
    public class Buffet
    {
      public List<Food> Menu;

      // Buffet constructor
      public Buffet()
      {
        Menu = new List<Food>()
              {
                new Food("Pad Thai", 800, true, false),
                new Food("Spaghetti",1000, false, false),
                new Food("Tacos", 500, true, false),
                new Food("HotDogs",400,false, false),
                new Food("PotStickers",300, false,false),
                new Food("Salad", 200, false, false),
                new Food("Breadsticks", 250,false,false),
              };
      }
      // Serve method
      public Food Serve()
      {
        Random random = new Random();
        int myRandomNum = random.Next(0, 7);
        Food myRandomFood = Menu[myRandomNum];
        return myRandomFood;
      }

    }


    // Ninja class
    public class Ninja
    {

      // Ninja variables
      private int calorieIntake;
      public List<Food> FoodHistory;

      // Ninja constructor
      public Ninja()
      {
        calorieIntake = 0;
        FoodHistory = new List<Food>();
      }

      // getter IsFull
      public bool IsFull
      {
        get
        {

          if (calorieIntake > 1200)
          {
            return true;
          }
          else
          {
            return false;
          }
        }
      }

      public void Eat()
      {


        // Is Full
        if (!IsFull)
        {
          Buffet current_buffet = new Buffet();
          Food new_dish = current_buffet.Serve();
          calorieIntake += new_dish.Calories;
          FoodHistory.Add(new_dish);
          Console.WriteLine($"Ninja ate the {new_dish.Name}");

          if (new_dish.IsSpicy)
          {
            Console.WriteLine("Spicy!");
          }
          if (new_dish.IsSweet)
          {
            Console.WriteLine("Sweet!");
          }
          {
            System.Console.WriteLine($"This dish was {new_dish.Calories} calories");
            System.Console.WriteLine($"Ninja's current calorie count is {calorieIntake + new_dish.Calories}");
          }

        }
        else
        {
          Console.WriteLine("Ninja is full!");
        }

      }
    }
  }
}



