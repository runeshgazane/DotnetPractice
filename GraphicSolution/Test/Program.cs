using Drawing;
Shape rectangle = new Rectangle(new Point(25, 65), new Point(95, 175), "red");
Console.WriteLine(rectangle.ShapeColor);
Console.WriteLine(rectangle.Draw());
Console.WriteLine(rectangle.Area());