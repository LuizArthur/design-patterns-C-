using System;
using design_patterns_dotnet.factoryPatternShape;

namespace design_patterns_dotnet.factoryPatternRectangle
{
    public class Rectangle : Shape
    {
        public void draw() {
            Console.WriteLine("This is a Rectangle");
        }
    }
}