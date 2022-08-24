using NUnit.Framework;

namespace TestProject.UnitTests;

[TestFixture]
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.AreEqual(10, 10, "Expect result to evaluate to 10");
    }
}