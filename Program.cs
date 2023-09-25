using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is a Mad Libs word game. Mad Libs are short stories with blanks for the player to fill in that represent different parts of speech. The end result is a really hilarious and strange story.
      Author: Benett Viszokai
      */

      // Let the user know that the program is starting:
      Console.WriteLine("Mad Libs has started.");

      // Give the Mad Lib a title:
      string title = "A strange story";

      Console.WriteLine(title);
      // Define user input and variables:

      // Name
      Console.WriteLine("Enter a name: ");
      string name = Console.ReadLine();

      // Adjectives
      Console.WriteLine("Please enter 3 adjectives. First adjective: ");
      string adj1 = Console.ReadLine();
      Console.WriteLine("Second adjective: ");
      string adj2 = Console.ReadLine();
      Console.WriteLine("Third adjective: ");
      string adj3 = Console.ReadLine();

      // Verb
      Console.WriteLine("Please enter a verb: ");
      string verb = Console.ReadLine();


      // Nouns
      Console.WriteLine("Please enter 2 nouns. First noun: ");
      string noun1 = Console.ReadLine();
      Console.WriteLine("Second noun: ");
      string noun2 = Console.ReadLine();

      // Random things the user to type:
      Console.WriteLine("Please enter an animal: ");
      string animal = Console.ReadLine();

      Console.WriteLine("Please enter a food: ");
      string food = Console.ReadLine();

      Console.WriteLine("Please enter a fruit: ");
      string fruit = Console.ReadLine();

      Console.WriteLine("Please enter a superhero: ");
      string superhero = Console.ReadLine();

      Console.WriteLine("Please enter a country: ");
      string country = Console.ReadLine();

      Console.WriteLine("Please enter a dessert: ");
      string dessert = Console.ReadLine();

      Console.WriteLine("Please enter a year: ");
      string year = Console.ReadLine();

      // The template for the story:     
      string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
    }
  }
}
