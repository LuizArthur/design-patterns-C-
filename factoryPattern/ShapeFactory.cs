using design_patterns_dotnet.factoryPatternShape;
using design_patterns_dotnet.factoryPatternCircle;
using design_patterns_dotnet.factoryPatternRectangle;
using design_patterns_dotnet.factoryPatternSquare;

namespace design_patterns_dotnet.factoryPatternShapeFactory
{
    public class ShapeFactory
    {
        public Shape getShape(string shapetype) {
            if(shapetype.ToLower().Equals("circle")) {
                return new Circle();
            }

            if(shapetype.ToLower().Equals("rectangle")) {
                return new Rectangle();
            }

            if(shapetype.ToLower().Equals("square")) {
                return new Square();
            }

            return null;
        }
    }
}