//*Define an abstract class Shape with abstract method CalculateSurface() and fields width and height. 
//*Define two additional classes for a triangle and a rectangle, which implement CalculateSurface(). 
//*This method has to return the areas of the rectangle (height*width) and the triangle (height*width/2).
//*Define a class for a circle with an appropriate constructor, 
//*which initializes the two fields (height and width) with the same value (the radius) and implement the abstract method for calculating the area. 
//Create an array of different shapes and calculate the area of each shape in another array.

using Shapes;

Shape [] shapes = new Shape[] {
    new Triangle(5 , 10),
    new Rectangle(5 , 8),
    new Circle(5)
};
int count = 1;
foreach (var item in shapes)
{
    Console.WriteLine($"Shape {count}: {item.CalculateSurface()}");
    count ++;
}