using System;
using design_patterns_dotnet.factoryPatternShape;

namespace design_patterns_dotnet.factoryPatternCircle
{
    public class Circle : Shape
    {
        public void draw() {
            Console.WriteLine("This is a Circle");
        }
    }
}