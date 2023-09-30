using MappingAssertionDemo;
using MappingAssertionDemo.Model;
using Shouldly;

namespace MappingAssertion.Shouldly.Test.Unit;

[TestClass]
public class SimpleObjectMapperTests
{
    private SimpleObject _simpleObject;

    [TestInitialize]
    public void TestInitialize()
    {
        _simpleObject = new SimpleObject
        {
            Shape = "Circle",
            Color = "Blue"
        };
    }

    [TestMethod]
    public void Map_AssertEverythingManually()
    {
        // Act
        var result = SimpleObjectMapper.Map(_simpleObject);

        // Assert
        result.Shape.ShouldBe(_simpleObject.Shape);
        result.Color.ShouldBe(_simpleObject.Color);
    }

    [TestMethod] // This test will fail, done for demo purposes
    public void Map_AssertWithEquivalentTo()
    {
        // Act
        var result = SimpleObjectMapper.Map(_simpleObject);

        // Assert
        result.ShouldBeEquivalentTo(_simpleObject); // This does not work, as Shouldly expecteds the objects to be of the same type
    }
}