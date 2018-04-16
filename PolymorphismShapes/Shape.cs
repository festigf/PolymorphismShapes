using System;
using System.Windows.Forms;
using System.Xml.Serialization;


[Serializable]
[XmlInclude(typeof(Shape))]
[XmlInclude(typeof(Line))]
[XmlInclude(typeof(Rectagle))]
[XmlInclude(typeof(Square))]
[XmlInclude(typeof(Circle))]

//Clase base
public abstract class Shape 
{
    private string name;
    public int X0 { get; set; }
    public int Y0 { get; set; }
    public Shape(string s)
    {
        Id = s;
    }

    protected Shape()
    {
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
    public abstract double Area
    {
        get;
    } //Area ritorna nulla
    public abstract double Length
    {
        get;
    } //Lunheza ritorna nulla
       

    public override string ToString()
    {
        return Id + " Area = " + string.Format("{0:F2}", Area);
    }
    public abstract void Draw(PictureBox pictureBox);
        

    
}

