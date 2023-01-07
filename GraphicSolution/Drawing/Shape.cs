namespace Drawing;
public abstract class Shape{
    public enum Color
    {
        RED,
        BLUE,
        WHITE,
        BLACK,
        BROWN
    }

    public Color ShapeColor { get; set; }

    public Shape(string shapeColor)
    {
        this.ShapeColor = (Color)Enum.Parse(typeof(Color), shapeColor, true);
    }
    public abstract string Draw();

    public abstract float Area();
}