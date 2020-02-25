using System;
using System.Collections.Generic;


public class Palindromes 
{
  static void Main()
  {
    Console.WriteLine("Enter a word and find out if its a palindrome:");
    string palInput = Console.ReadLine();
    char[] palArr = palInput.ToCharArray();    
    Array.Reverse(palArr);
    string reversed = new string(palArr);
    if(palInput == reversed)
    {
      Console.WriteLine($"your word: '{palInput}' is '{reversed}' when is backwards so it works! ");
    }
    else
    {
      Console.WriteLine($"your word: '{palInput}' is '{reversed}' so you're pretty dumb huh? ");
    }
    
  }
}