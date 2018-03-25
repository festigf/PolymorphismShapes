using System.Drawing;
using System.Windows.Forms;
public class Square : Shape
{
    private int side;
    public int Side { get => side; set => side = value; }
    public Square(){}

    public Square(int side, string id)
        : base(id)
    {
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
    }

}

