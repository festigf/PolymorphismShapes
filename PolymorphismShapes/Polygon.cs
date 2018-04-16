using System.Drawing;
using System.Windows.Forms;
using System;
public class Polygon : Shape
{
    public int Height { get; set; }
    public int Width { get; set; }
    public Polygon(int x0, int y0, int sides, int radius, string id, Color color, float thickness) : base(id, color, thickness)
    {
        this.X0 = x0;
        this.Y0 = y0;
        this.Sides = sides;
        this.Radius = radius;
    }

    public Polygon() { }
    public Polygon(string s, Color color, float thickness) : base(s, color, thickness) { }
    public int Sides { get; set; }
    public int Radius { get; set; }
    public override double Area
    {
        get { return 0; }
    }
    public override double Length
    {
        get
        {
            return Width * 2 + Height * 2;
        }
    }
    public override void Draw(PictureBox pictureBox)
    {
        if (Sides > 1)
        {
            Graphics g = pictureBox.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //g.DrawRectangle(new Pen(Colour, Thickness), X0, Y0, Width, Height);
            Point[] points = new Point[Sides];
            for (int i = 0; i < Sides; i++)
            {
                int x = X0 + Radius + (int)(Math.Cos(Math.PI * 2.0 / Sides * i) * Radius);
                int y = Y0 + Radius + (int)(Math.Sin(Math.PI * 2.0 / Sides * i) * Radius);
                points[i] = new Point(x, y);
            }

            g.DrawPolygon(new Pen(Colour, Thickness), points);
            g.Dispose();
        }
    }

}

