using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

class Polygon:Shape
{
    int _sides;
    Point[] _points;

    public Polygon(int Sides)
    {
        _sides = Sides;
        _points = new Point[_sides];
        findPoints();
    }
    public Polygon()
    {

    }

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
    public override void Draw(PictureBox pictureBox)
    {
        Graphics g = pictureBox.CreateGraphics();
        g.DrawPolygon(new Pen(_backgroundColor, _thickness),_points);

    }

    public void findPoints()
    {
        int radius = 50;
        for (int i = 0; i < _sides; i++)
        {
            _points[i].X = Convert.ToInt32(100 + radius * Math.Cos(2 * Math.PI * i / _sides));
            _points[i].Y = Convert.ToInt32(100 + radius * Math.Sin(2 * Math.PI * i / _sides));
        }
    }
}