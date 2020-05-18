using System;
using design_patterns_dotnet.factoryPatternShape;

namespace design_patterns_dotnet.factoryPatternSquare
{
    public class Square : Shape
    {
        public void draw() {
            Console.WriteLine("This is a Square");
        }
    }
}