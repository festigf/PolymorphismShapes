using System;
using System.Drawing;
using System.Windows.Forms;


public class Circle : Shape
{
    public Circle() { }
    public Circle(string s) : base(s) { }

   
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

    }
}