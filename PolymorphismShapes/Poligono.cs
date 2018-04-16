using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PolymorphismSpapes09
{
    public class Poligono : Shape
    {
        private int nLati;
        private List<Point> listPoint = new List<Point>();
        protected int NLati { get => nLati; set => nLati = value; }
        public Poligono()
        {

        }
        public Poligono(string s, double origine, int nLati): base(s)
        {

        }

        

        public override double Area
        {
            get
            {
                return 0;
            }
        }
        public override double Length
        {
            get
            {
                return 0;
            }
        }
        //public List<Point> calcoloPunti(int nLati, double origine, double raggio)
        //{
        //    double alfa = 360 / nLati;
        //    for (int i = 0; i < nLati * 2; i++)
        //    {
        //        listPoint[i]

        //    }
        //}
        public override void Draw(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            g.DrawPolygon(new Pen(Color.Red), 
        }
    }
}
