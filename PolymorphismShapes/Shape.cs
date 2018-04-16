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

public abstract class Shape 
{
    private string name;
    private Color color;
    private float thickness;
    public int X0 { get; set; }
    public int Y0 { get; set; }
    public Shape(string s, Color color, float thickness)
    {
        Id = s;
        this.color = color;
        this.thickness = thickness;
    }

    protected Shape()
    {
    }
    public float Thickness
    {
        get
        {
            return thickness;
        }

        set
        {
            thickness = value;
        }
    }

    public string Id
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }
    public Color Colour
    {
        get
        {
            return color;
        }

        set
        {
            color = value;
        }
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

