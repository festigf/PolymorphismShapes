using System.Drawing;
using System.Windows.Forms;
public class Square : Shape
{
    private int _side;
    public int Side { get => _side; set => _side = value; }
    public Square(){}

    public Square(int Side, string Id, Color BackgroundColor, float Thickness) : base(Id, BackgroundColor, Thickness)
    {
        _side = Side;
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
    }

}

