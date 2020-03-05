using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;
using System;
using System.Collections.Generic;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class TranslatorTests
  {
    [TestMethod]
    public void Translator_CreateInstance_NewInstance()
    {
      Translator newTranslator = new Translator(358);
      Assert.AreEqual(typeof(Translator), newTranslator.GetType());
    }

    [TestMethod]
    public void GetOnes_GetWordsOfOnesPosition_WordsOfOnesNumber()
    {
      //Arragne
      Translator newTranslator = new Translator(7);
      //Act
      string result = Translator.GetOnes();
      //Assert
      Assert.AreEqual("seven", result);
    }    

    [TestMethod]
    public void GetTeens_GetWordsOfTeensPosition_WordsOfTeensNumber()
    {
      //Arragne
      Translator newTranslator = new Translator(16);
      //Act
      string result = Translator.GetTeens();
      //Assert
      Assert.AreEqual("sixteen", result);
    }  

    [TestMethod]
    public void GetTens_GetWordsOfTensPosition_WordsOfTensNumber()
    {
      //Arragne
      Translator newTranslator = new Translator(7);
      //Act
      string result = Translator.GetTens();
      //Assert
      Assert.AreEqual("seventy", result);
    }  


    [TestMethod]
    public void GetNumArr_GetNumberArray_NumberArray()
    {
      //Arragne
      Translator newTranslator = new Translator(123);
      //Act
      int[] result = Translator.GetNumArr();
      int[] expected = { 1, 2, 3};
      foreach (int number in expected) 
      {
        Console.WriteLine(number);
      }
      foreach (int number in result)
      {
        Console.WriteLine(number);
      }
      //Assert
      CollectionAssert.AreEqual(expected, result);
    }  
  }
}



