using System;
using System.Collections.Generic;


class Phonebook
{
  public static Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();

  static void Main()
  {
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.BackgroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("MAIN MENU");
    Console.WriteLine("Would you like to add a person to your phone book? ['Y' for yes, 'Enter' for no]");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
      AddContact();
    }
    else
    {
      Console.WriteLine("Would you like to lookup a number in your phone book? ['Y' for yes, 'Enter' for no]");
      string lookUpAnswer = Console.ReadLine();
      if (lookUpAnswer == "Y" || lookUpAnswer == "y")
      {
        LookUpContact();
      }
      else
      {
        Console.WriteLine("Are you finished with this program? ['Y' for yes, 'Enter' for no]");
        string finishedAnswer = Console.ReadLine();
        if (finishedAnswer == "Y" || finishedAnswer == "y")
        {
          Console.WriteLine("Goodbye.");
        }
        else
        {
          Main();
        }
      }
    }
  }

  static void AddContact()
  {
    Console.WriteLine("NEW CONTACT");
    Console.WriteLine("Enter a new contacts name");
    string name = Console.ReadLine();
    Console.WriteLine("Enter a new contacts phone number");
    string number = Console.ReadLine();
    if (phoneNumbers.ContainsKey(name))
    {
      Console.WriteLine("That person is already in your phonebook. Their number is " + phoneNumbers[name]);
    }
    else
    {
      phoneNumbers.Add(name, number);
    }
    Main();
  }

  static void LookUpContact()
  {
    Console.WriteLine("CONTACT LOOKUP");
    Console.WriteLine("Whose number would you like to look up?");
    string friend = Console.ReadLine();
    if (phoneNumbers.ContainsKey(friend))
    {
      string value = phoneNumbers[friend];
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.White;
      Console.WriteLine(friend + "\'s phone number is " + value);
    }
    else
    {
      Console.WriteLine("That person is not in your phone book.");
    }
    Main();
  }
}
