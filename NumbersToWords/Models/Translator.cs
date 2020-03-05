using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class Translator
  {
    public static int Number { get; set; }

    public Translator(int number)
    {
      Number = number;
    }
      
    public static Dictionary<int, string> onesPosition = new Dictionary<int, string>() { {0, ""}, {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"} };
    public static Dictionary<int, string> teensPosition = new Dictionary<int, string>() { {10, "ten"}, {11, "eleven"}, {12, "twelve"}, {13, "thirteen"}, {14, "fourteen"}, {15, "fifteen"}, {16, "sixteen"}, {17, "seventeen"}, {18, "eighteen"}, {19, "nineteen"} };
    public static Dictionary<int, string> tensPosition = new Dictionary<int, string>() { {2, "twenty"}, {3, "thirty"}, {4, "fourty"}, {5, "fifty"}, {6, "sixty"}, {7, "seventy"}, {8, "eighty"}, {9, "ninety"} };
    
    public static string GetOnes()
    {
      string result = "";
      foreach (KeyValuePair<int, string> ones in onesPosition)
      {
        if(ones.Key == Translator.Number)
        {
          result = ones.Value;
        } 
      } 
      return result;
    }

    public static string GetTeens()
    {
      string result = "";
      foreach (KeyValuePair<int, string> teens in teensPosition)
      {
        if(teens.Key == Translator.Number)
        {
          result = teens.Value;
        } 
      } 
      return result;
    }

    public static string GetTens()
    {
      string result = "";
      foreach (KeyValuePair<int, string> tens in tensPosition)
      {
        if(tens.Key == Translator.Number)
        {
          result = tens.Value;
        } 
      } 
      return result;
    }

    public static int[] GetNumArr()
    {
      List<int> listOfInts = new List<int>();
      while(Translator.Number > 0)
      {
        listOfInts.Add(Translator.Number % 10);
        Translator.Number = Translator.Number / 10;
      }
      listOfInts.Reverse();
      return listOfInts.ToArray();
    }

    public static string GetWords()
    {
      string result = "";
      if (Translator.Number < 10)
      {
        result = GetOnes();
      }
      return result;
    }

  }  
}
  

