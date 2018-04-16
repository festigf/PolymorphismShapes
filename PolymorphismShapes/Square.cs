using System.Drawing;
using System.Windows.Forms;
public class Square : Shape
{
    private int side;
    public int Side { get => side; set => side = value; }
    public Square(){}

    public Square(int x0, int y0, int side, string id, Color color, float thickness)
        : base(id, color, thickness)
    {
        this.X0 = x0;
        this.Y0 = y0;
        this.Side = side;
    }

    public override double Area
    {
        get
        {
            return Side * Side;
        }
    }

    public override double Length
    {
        get
        {
            return Side*4;
        }
    }
    public override void Draw(PictureBox pictureBox)
    {
        Graphics g = pictureBox.CreateGraphics();
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        g.DrawRectangle(new Pen(Colour, Thickness), X0, Y0, Side, Side);
        g.Dispose();
    }

}

