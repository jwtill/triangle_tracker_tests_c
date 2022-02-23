using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace Shapes.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsTriangle_HasThreeSides_False()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual("Not a triangle", testTriangle.TriangleType(0,1,1));
    }

    [TestMethod]
    public void IsTriangle_Side1Largest_True()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual("Not a triangle", testTriangle.TriangleType(5,1,1));
    }

    [TestMethod]
    public void IsTriangle_Side2Largest_True()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual("Not a triangle", testTriangle.TriangleType(1,5,1));
    }

    [TestMethod]
    public void IsTriangle_Side3Largest_True()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual("Not a triangle", testTriangle.TriangleType(1,1,5));
    }

    [TestMethod]
    public void IsTriangle_IsEquilateral_Equilateral()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual("This is an equilateral triangle", testTriangle.TriangleType(5,5,5));
    }

    [TestMethod]
    public void IsTriangle_IsIsosceles_IsIsosceles()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual("This is an isosceles triangle", testTriangle.TriangleType(5,5,8));
    }

    [TestMethod]
    public void IsTriangle_IsScalene_IsScalene()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual("This is an scalene triangle", testTriangle.TriangleType(5,6,8));
    }
  }
}