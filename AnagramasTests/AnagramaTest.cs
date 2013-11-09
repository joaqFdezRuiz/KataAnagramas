using Anagramas;
using NUnit.Framework;

namespace AnagramasTests
{
  [TestFixture]
  public class AnagramaTest
  {
    [Test]
    public void Primer_Test()
    {
      var anagrama = new Anagrama();
      Assert.AreEqual(0, anagrama.Game());
    }
  }
}
