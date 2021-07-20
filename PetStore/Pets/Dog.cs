using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Pets
{
  class Dog
  {
    //Access Modifiers: 
    // private: only things within this specific class can use/modify it. default, implicit if not explicitly defined. 
    // public: Can be called and modified by everything, other classes. 
    // internal: anything in this project can access it. Test driven development or creating tools for other developers to use. 
    // protected: anything that inherits from me can access 

    //Properties
    //access modifier - public. //type of prop - string. //name of property - Size
    public string Size { get; set; } //auto-property
    public short Weight { get; private set; } // setter is private, can only modify within this class.
    public string Name { get; set; }

    //constructor, constructor method. name of constructor must be same as class
    public Dog(string name, short weight, string size)
    {
      Size = size;
      Name = name;
      Weight = weight;
    } 



    //Method Signature - access modifier, return type, name, parameters. 
    //access modifier - public. //type is the return type. //name of method. //paramaters, must define the type of paramater. 
    //void means not returning anything
    //static means shared across all instances, so you don't have access to it within specific instances. Here this is an instance method, so each instance of class dog.
    public void Bark()
    {
      Console.WriteLine($"{Name} barks loudly.");
    } 

    //parameters are camelCase
    public void Eat(string typeOfFood)
    {
      if (typeOfFood.ToLower() == "healthy food")
      {
        Weight -= 1;
      }

      Console.WriteLine($"{Name} just ate {typeOfFood}. \n{Name} weighs {Weight} pounds.");
    }
  }
}
