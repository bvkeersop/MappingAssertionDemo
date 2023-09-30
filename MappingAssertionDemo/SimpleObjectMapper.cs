using MappingAssertionDemo.Model;

namespace MappingAssertionDemo;

public class SimpleObjectMapper
{
    public static SimpleObjectDto Map(SimpleObject simpleObject) => new()
    {
        Shape = simpleObject.Shape,
        Color = simpleObject.Color,
    };
}
