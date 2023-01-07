namespace Drawing;
public class Rectangle : Shape
{
    public Point StartPoint { get; set; }
    public Point EndPoint { get; set; }
    public Rectangle(Point startPoint, Point endPoint, string shapeColor) : base(shapeColor)
    {
        this.StartPoint = startPoint;
        this.EndPoint = endPoint;
    }
    public override string Draw()
    {
        Point p1 = new Point(StartPoint.X, StartPoint.Y);
        Point p2 = new Point(EndPoint.X, StartPoint.Y);
        Point p3 = new Point(StartPoint.X, EndPoint.Y);
        Point p4 = new Point(EndPoint.X, EndPoint.Y);
        return "Rectangle: (p1=" + p1 + "), " + "(p2=" + p2 + "), " + "(p3=" + p3 + "), " + "(p4=" + p4 + ") ";
    }

    public override float Area()
    {
        int length = EndPoint.X - StartPoint.X;
        int breadth = EndPoint.Y - StartPoint.Y;
        return (length*breadth);
    }
    
}