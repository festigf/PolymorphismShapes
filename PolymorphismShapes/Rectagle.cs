using System.Drawing;
using System.Windows.Forms;
public class Rectagle : Shape
{
    public int Height { get; set; }
    public int Width { get; set; }
    public Rectagle(int x0,int y0, int Height,int Width, string id, Color BackgroundColor, float Thickness) : base(id, BackgroundColor, Thickness)
    {
        this.X0 = x0;
        this.Y0 = y0;
        this.Height = Height;
        this.Width = Width;
    }

    public Rectagle(){}
    public Rectagle(string s, Color BackgroundColor, float Thickness) : base(s, BackgroundColor, Thickness) { }
    public override  double Area
    {
        get { return Width * Height; }
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
        Graphics g = pictureBox.CreateGraphics();
        g.DrawRectangle(new Pen(Color.Blue, Thickness), X0, Y0, Width, Height);

    }

}

