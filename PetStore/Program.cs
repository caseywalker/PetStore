using System;
using PetStore.Pets;

namespace PetStore
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var ryder = new Dog("Ryder", 87, "Chunky");
      ryder.Bark();

      var melba = new Dog("Melba", 60, "Medium");
      melba.Bark();

      Console.WriteLine($"What type of food should {melba.Name} eat?");
      var typeOfFoodForMelba = Console.ReadLine();
      melba.Eat(typeOfFoodForMelba);

      ryder.Eat("healthy food");
    }
  }
}
