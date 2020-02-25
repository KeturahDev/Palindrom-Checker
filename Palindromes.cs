using System;
using System.Collections.Generic;


public class Palindromes 
{
  static void Main()
  {
    Console.WriteLine("Enter a word and find out if its a palindrome:");
    string palInput = Console.ReadLine();
    char[] palArr = palInput.ToCharArray();    
    char[] reversedArr = new char[palArr.GetLength(0)];
    int j = 0;
    for(int i = reversedArr.GetLength(0)-1; i >= 0; i-- )
    {
      reversedArr[j] = palArr[i];
      Console.WriteLine(reversedArr[j]);
      j++;
    }
    // Array.Reverse(palArr);
     string reversed = new string(reversedArr);
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