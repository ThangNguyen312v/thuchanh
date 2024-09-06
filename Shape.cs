namespace baitap{
    class Shape{
        public string color {get;set;}
        public bool filled {get; set;}
        public Shape(){
            color = "green";
            filled = true;
        }
        public Shape(string color, bool filled){
            this.color = color;
            this.filled = filled;
        }
        public override string ToString()
        {
            return $"A Shape with color of {color} and {(filled ? "filled" : "not filled")}";
        }

    }
    class Circle : Shape
    {
        public double radius = 1.0;
        
        public Circle(){}

        public Circle(double radius){
            this.radius = radius;
        }
        public Circle (double radius, string color, bool filled):base(color, filled){
           this.radius = radius;
        }
        public double Getarena(){
            return Math.PI * radius * radius;
        }
        public  double GetPerimeter(){
            return 2 * Math.PI * radius;
        }
        public virtual string ToString(){
            return $"A Circle with radius={radius}, which is a subclass of {base.ToString()}";
        }
        }
    class Rectangle : Shape
    {
        public double width = 1.0;
        public double length = 1.0;
        public Rectangle(){}
        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }
        public Rectangle(double width, double length, string color, bool filled):base(color,filled)
        {
           this.width = width;
           this.length = length;
        }
        public double Getwidth()
        {
           return this.width;
        }
        public virtual void Setwidth(double width)
        {
            this.width = width;
        }
        public double Getlength()
        {
            return this.length;
        }
        public virtual void Setlength(double length)
        {
            this.length = length;
        }
        public double GetArea()
        {
           return width * length;
        }
        public double GetPerimeter()
        {
            return 2 * (width + length);
        }
        public virtual string ToString()
        {
            return $"A Rectangle with width={width} and length={length}, which is a subclass of {base.ToString()}";
        }
    }
    class Square : Rectangle
    {
        public double side;

        public Square(){}
      public Square(double side):base(side,side){}
      public Square(double side, String color, bool filled) : base(side, side, color, filled){}
      public double Getside()
      {
        return Getwidth();
      }
      public void SetSide(double side)

        {
            Setwidth(side);
            Setlength(side);
        }
         public override void Setwidth(double width)
        {
            SetSide(width);
        }
         public override void Setlength(double length)
        {
            SetSide(length);
        }
        public virtual string ToString()
        {
            return $"A Square with side={ side }, which is a subclass of {base.ToString()}";
        }
    }
    }
