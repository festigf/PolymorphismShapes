using System;
using System.Drawing;
using System.Windows.Forms;

namespace PolymorphismShapes
{
    public class Poligono : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Poligono(int x0, int y0, int Height, int Width, string id) : base(id)
        {
            this.X0 = x0;
            this.Y0 = y0;
            this.Height = Height;
            this.Width = Width;
        }

        public Poligono() { }
        public Poligono(string s) : base(s) { }
        public override double Area
        {
            get { return Width * Height; }
        }
        public override double Length
        {
            get
            {
                return Width * 2 + Height * 2;
            }
        }

        public override void Draw(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            g.DrawRectangle(new Pen(Color.Blue), X0, Y0, Width, Height);
        }




        //public static double AreaPoligono(double[] listaPoint1,double[] listaPoint2, int n)
        //{
        //    double area = 0;
        //    int j = n - 1;
        //    for (int i = 0; i < n; i++)
        //    {
        //        area += (listaPoint1[j] + listaPoint1[i]) * (listaPoint2[j] - listaPoint2[i]);
        //        j = i;
        //    }
        //    return Math.Abs(area / 2.0); //valore assoluto
        //}
    }
}
