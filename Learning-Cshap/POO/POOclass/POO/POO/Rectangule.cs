namespace POO
{
    class Rectangule
    {
        // a class in C# is like a mold, 
        // the class is a layout that you gonna use in the future
        double height;
        double width;
        string color;

        public Rectangule()
        {
            this.height = 12;
            this.width = 3;
            this.color = "White";
        }

        public Rectangule( 
            double width, 
            double height)
        {
            this.width = height;
            this.height = width;
        }

        public Rectangule(
            double width,
            double height,
            string color)
        {
            this.width = height;
            this.height = width ;
            this.color = color;
        }

        public double calculateArea()
        {
            return height * width;
        }

        public double calculatePerimeter()
        {
            return (height * 2) + (width * 2);
        }

    }
}
