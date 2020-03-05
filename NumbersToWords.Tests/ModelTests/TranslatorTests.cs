using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;

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
      Assert.AreEqual("eight", result);
    }    

    [TestMethod]
    public void GetOnes_GetWordsOfTeesPosition_WordsOfTeensNumber()
    {
      //Arragne
      Translator newTranslator = new Translator(16);
      //Act
      string result = Translator.GetTeens();
      //Assert
      Assert.AreEqual("sixteen", result);
    }  
  }
}



