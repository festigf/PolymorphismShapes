using System.Drawing;
using System.Windows.Forms;

class Assi:Shape
{
    public int X1 { get; set; }
    public int Y1 { get; set; }

    public Assi(int x0, int y0, int x1, int y1, string id, string colorePenna) : base(id)
    {
        this.X0 = x0;
        this.Y0 = y0;
        this.X1 = x1;
        this.Y1 = y1;
        this.ColorePenna = colorePenna;
    }
    public Assi() { }
    public Assi(string s) : base(s) { }
    public override  double Area
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
    public override void Draw(PictureBox pictureBox)
    { 
        Graphics g = pictureBox.CreateGraphics();
        g.DrawLine(new Pen(Color.FromName(ColorePenna)), X0, Y0, X1,Y1);
        //g.DrawLine(new Pen(Color.FromName(ColorePenna)), -X0, -Y0, X1, Y1);
    }
}