using FluentAssertions;
using MappingAssertionDemo.Model;

namespace MappingAssertionDemo.Test.Unit;

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
    public void Map_FluentAssertions_AssertEverythingManually()
    {
        // Act
        var result = SimpleObjectMapper.Map(_simpleObject);

        // Assert
        result.Shape.Should().Be(_simpleObject.Shape);
        result.Color.Should().Be(_simpleObject.Color);
    }

    [TestMethod]
    public void Map_FluentAssertions_AssertWithEquivalentTo()
    {
        // Act
        var result = SimpleObjectMapper.Map(_simpleObject);

        // Assert
        result.Should().BeEquivalentTo(_simpleObject);
    }
}
