namespace svgprototype.LookHere;

public class SvgModels
{
}

public class Polygon
{
    public List<Point> points { get; set; } = new List<Point>();

    public Polygon(List<Point> points)
    {
        this.points = points;
    }

    public string toString()
    {
        string s = "";
        for (int i = 0; i < points.Count; i++)
        {
            s += $"{points[i].x},{points[i].y} ";
        }
        return s;
    }
}

public class Point
{
    public int x { get; set; }
    public int y { get; set; }

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

public class ViewBox
{
    public double x { get; set; }
    public double y { get; set; }
    public double width { get; set; }
    public double height { get; set; }

    public string toString()
    {
        return $"{x} {y} {width} {height}";
    }
}

public class BoundingClientRect
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public double Top { get; set; }
    public double Right { get; set; }
    public double Bottom { get; set; }
    public double Left { get; set; }
}