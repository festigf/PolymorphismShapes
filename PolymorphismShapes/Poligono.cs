using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

    public class Poligono : Shape
    {
        public Poligono() { }
        public Poligono(string s):base(s)
        { }

        PointF[] punti = new PointF[5]
        {   new PointF{X=150,Y=90},
            new PointF{X=170,Y=120},
            new PointF{X=180,Y=125},
            new PointF{X=200,Y=160},
            new PointF{X=150,Y=140}
        };



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
            return base.ToString() + "ciao";
        }

        public override void Draw(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            g.DrawPolygon(new Pen(Color.Blue),punti);           
        }

    }

