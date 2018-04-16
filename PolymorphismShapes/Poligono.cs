using System.Drawing;
using System.Collections.Generic;

class Poligono:List<Line>
{
    public int Height { get; set; }
    public int Width { get; set; }

    public Poligono(int x0, int y0, int Height, int Width, string id,string colorePenna) : base(id)
    {
        
    }
    public Poligono(){}
    public Poligono(string s){ }

    /*public override  double Area
    {
        get { return; }
    }*/

    /*public override double Length
    {
        get
        {
            return Width * 2+ Height*2;
        }
    }*/
    public override void Draw(PictureBox pictureBox)
    { 
        Graphics g = pictureBox.CreateGraphics();
        g.DrawPolygon(new Pen(Color.FromName(ColorePenna)), X0, Y0, Width, Height);
    }
}
