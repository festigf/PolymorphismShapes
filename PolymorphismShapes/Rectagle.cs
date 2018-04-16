using System.Drawing;
using System.Windows.Forms;
public class Rectagle : Shape
{
    public int Height { get; set; }
    public int Width { get; set; }
    public Rectagle(int x0,int y0, int Height,int Width, string id, Color color, float thickness) : base(id, color, thickness)
    {
        this.X0 = x0;
        this.Y0 = y0;
        this.Height = Height;
        this.Width = Width;
    }

    public Rectagle(){}
    public Rectagle(string s, Color color, float thickness) : base(s, color, thickness) { }
    public override  double Area
    {
        get { return Width * Height; }
    }
    public override double Length
    {
        get
        {
            return Width * 2+ Height*2;
        }
    }
    public override void Draw(PictureBox pictureBox)
    {
        Graphics g = pictureBox.CreateGraphics();
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        g.DrawRectangle(new Pen(Colour, Thickness), X0, Y0, Width, Height);
        g.Dispose();
    }

}

