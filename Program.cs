using System;
using design_patterns_dotnet.factoryPatternShapeFactory;
using design_patterns_dotnet.factoryPatternShape;

namespace design_patterns_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            Shape circle = shapeFactory.getShape("Circle");
            circle.draw();

            Shape rectangle = shapeFactory.getShape("Rectangle");
            rectangle.draw();

            Shape square = shapeFactory.getShape("Square");
            square.draw();
        }
    }
}
