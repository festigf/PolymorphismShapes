using System.Drawing;
using System.Windows.Forms;
public class Rectagle : Shape
{
    public int Height { get; set; }
    public int Width { get; set; }

    public Rectagle(int x0, int y0, int Height, int Width, string id,string colorePenna) : base(id)
    {
        this.X0 = x0;
        this.Y0 = y0;
        this.Height = Height;
        this.Width = Width;
        this.ColorePenna = colorePenna;
    }
    public Rectagle(){}
    public Rectagle(string s) : base(s) { }
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
        g.DrawRectangle(new Pen(Color.FromName(ColorePenna)), X0, Y0, Width, Height);
    }
}