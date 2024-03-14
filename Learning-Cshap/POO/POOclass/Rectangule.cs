using system;
// a class in C# is like a mold, 
// the class is a layout that you gonna use in the future
class Rectangule
{
    double height;
    double width;
    string color;

    public Rectangule()
    {
        this.height = 12;
        this.width = 3;
        this.color = "White";
    }

    public double calculateArea()
    {
        return height * width;
    }

    public double calculatePerimeter()
    {

        return height * width;
    }
}