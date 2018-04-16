using System;
using System.Drawing;
using System.Windows.Forms;


public class Circle : Shape
{
    public Circle() { }
    public Circle(int x0, int y0, int radius, string s, Color color, float thickness) : base(s, color, thickness) {
        this.X0 = x0;
        this.Y0 = y0;
        this.Radius = radius;
    }

    public int Radius { get; set; }
    public int X1 { get; set; }
    public int Y1 { get; set; }

    public override double Area
    {
        get { return 0; }
    }

    public override double Length
    {
        get
        {
            return 0;
        }
    }
    public override string ToString()
    {
        return base.ToString() ;
    }
    public override void Draw(PictureBox pictureBox)
    {
        Graphics g = pictureBox.CreateGraphics();
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        g.DrawEllipse(new Pen(Colour, Thickness), X0, Y0, Radius * 2, Radius * 2);
        g.Dispose();
    }

}