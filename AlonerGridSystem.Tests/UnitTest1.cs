namespace AlonerGridSystem.Tests;

[TestFixture]
public class AlonerGridSystem_Tests
{
    private Grid grid;
    
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(3, 5)]
    [TestCase(25, 99)]
    public void CreatedGridWidthHeightShouldCorrect(int width, int height)
    {
        grid = new Grid(width, height);
        var expectedGridWH = new []{ width, height };
        var actualGridWH = new []{ grid.width, grid.height };
        Assert.AreEqual(expectedGridWH, actualGridWH);

    }
}