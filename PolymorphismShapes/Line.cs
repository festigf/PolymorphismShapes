using System;
using System.Drawing;
using System.Windows.Forms;
public class Line:Shape
{
    public Line() {}
    public Line(string s, Color BackgroundColor, float Thickness) :base(s, BackgroundColor, Thickness) { }
    public Line(string s) : base(s) { }

    public Line(int x0, int y0, int x1, int y1, string id, Color BackgroundColor, float Thickness) : base(id, BackgroundColor, Thickness)
    {
        this.X0 = x0;
        this.Y0 = y0;
        this.X1 = x1;
        this.Y1 = y1;
    }

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
            return Math.Sqrt(Math.Pow(X1 - X0, 2) + Math.Pow(Y1 - Y0, 2));
        }
    }
    public override string ToString()
    {
        return base.ToString()+"X1="+X1.ToString()+";Y1="+Y1.ToString();
    }
    public override void Draw(PictureBox pictureBox)
    {
        Graphics g = pictureBox.CreateGraphics();
        g.DrawLine(new Pen(Color.Blue), X0, Y0, X1, Y1);

    }

}
