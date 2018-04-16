using System;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Drawing;


[Serializable]
[XmlInclude(typeof(Shape))]
[XmlInclude(typeof(Line))]
[XmlInclude(typeof(Rectagle))]
[XmlInclude(typeof(Square))]
[XmlInclude(typeof(Circle))]
[XmlInclude(typeof(Polygon))]


public abstract class Shape 
{
    protected string _id;
    public string Id
    {
        get{ return _id; }
        set{ _id = value; }
    }

    public int X0 { get; set; }
    public int Y0 { get; set; }

    protected float _thickness;
    public float Thickness
    {
        get { return _thickness; }
        set { _thickness = value; }
    }

    protected Color _backgroundColor;
    public Color BackgroundColor
    {
        get { return _backgroundColor; }
        set { _backgroundColor = value; }
    }


    public Shape(string s, Color BackgroundColor, float Thickness )
    {
        Id = s;
        _backgroundColor = BackgroundColor;
        _thickness = Thickness;
    }

    public Shape(string s, Color BackgroundColor)
    {
        Id = s;
        _backgroundColor = BackgroundColor;
        _thickness = 1;
    }
    public Shape(string s, float Thickness)
    {
        Id = s;
        _backgroundColor = Color.Blue;
    }
    public Shape(string s)
    {
        Id = s;
        _backgroundColor = Color.Blue;
        _thickness = 1;
    }
    protected Shape()
    {
        _backgroundColor = Color.Blue;
        _thickness = 1;
    }


    public abstract double Area
    {
        get;
    }
    public abstract double Length
    {
        get;
    }
       

    public override string ToString()
    {
        return Id + " Area = " + string.Format("{0:F2}", Area);
    }
    public abstract void Draw(PictureBox pictureBox);
        

    
}

