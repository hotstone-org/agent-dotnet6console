namespace Dotnet6Console.UnitTests;

public class MessageCreatorTests
{
    [SetUp]
    public void Setup() { }

    [Test]
    public void Test1()
    {
        var dotnetVersion = 6;
        var expectedMessage = "Hello world from dotnet version 6";

        var sut = new MessageCreator();

        var actualMessage = sut.Create(dotnetVersion);

        Assert.That(actualMessage, Is.EqualTo(expectedMessage));
    }
}
