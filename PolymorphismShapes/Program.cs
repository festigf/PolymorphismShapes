using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
//polimorfismo
class ClsForm : Form
{
    Button btnLength,btnArea,SaveXml,btnLoadXml,btnDraw, btnFilling;
    Shape line = new Line(0, 0, 10, 0, "Linea");
    Shape rect = new Rectagle(10,20, 20, 30, "rect");
    List<Shape> listaPoint1 = new List<Shape>();    
    List<Shape> listaPoint2 = new List<Shape>();
    ListShapes listShape = new ListShapes();
    PictureBox pictureBox = new PictureBox();
    public ClsForm()
    {
        listShape.Add(line);
        listShape.Add(rect);

        btnLength = new Button
        {
            Text = "Length"
        };
        this.Controls.Add(btnLength);
        this.btnLength.Click += Btn_Click;
        btnArea = new Button {
            Text = "area",
            Top=25
        };
        this.Controls.Add(btnArea);
        this.btnArea.Click += BtnArea_Click;
        SaveXml = new Button
        {
            Text = "Save",
            Top = 50
        };
        this.Controls.Add(SaveXml);
        this.SaveXml.Click += BtnSaveXml_Click;
        btnLoadXml = new Button
        {
            Text = "Load",
            Top = 75
        };
        this.Controls.Add(btnLoadXml);
        this.btnLoadXml.Click += BtnLoadXml_Click;
        btnDraw = new Button
        {
            Text = "Draw",
            Top = 100
        };
        this.Controls.Add(btnDraw);
        this.btnDraw.Click += BtnDraw_Click;
        btnFilling = new Button
        {
            Text = "DrawP",
            Top = 125
        };
        this.Controls.Add(btnFilling);

        this.btnFilling.Click += BtnFilling_Click;
        this.Controls.Add(pictureBox);
        pictureBox.Left = 50;
        pictureBox.Anchor = AnchorStyles.Bottom & AnchorStyles.Right;
        this.Width = 600;
        this.Height = 800;
    }

    private void BtnDraw_Click(object sender, EventArgs e)
    {
        listShape.Draw(this.pictureBox);
    }

    private void BtnLoadXml_Click(object sender, EventArgs e)
    {
        listShape.LoadXml("listShape.xml");
    }

    private void BtnSaveXml_Click(object sender, EventArgs e)
    {
        listShape.SaveXml("listShape.xml");
    }

    private void BtnArea_Click(object sender, EventArgs e)
    {
        //rect.X = 0; rect. = 10;
        //rect.Y = 0; rect.Y1 = 10;
        this.btnArea.Text=rect.Area.ToString();
    }

    private void Btn_Click(object sender, EventArgs e)
    {
        // line.X0 = 0; line.X1 = 10;
        // line.Y0 = 0; line.Y1 = 0;
        this.Text = line.ToString()+"Length="+ line.Length;
    }

    private void BtnFilling_Click(object sender, EventArgs e)
    {
    }

    private void BtnFilling_Click(object sender, PaintEventArgs e)
    {
        SolidBrush pennello = new SolidBrush(Color.Blue);
        PointF punto1 = new PointF(50.0F, 50.0F);
        PointF punto2 = new PointF(100.0F, 25.0F);
        PointF punto3 = new PointF(200.0F, 5.0F);
        PointF punto4 = new PointF(250.0F, 50.0F);
        PointF punto5 = new PointF(300.0F, 100.0F);
        PointF punto6 = new PointF(350.0F, 200.0F);
        PointF punto7 = new PointF(250.0F, 250.0F);
        PointF[] punti = { punto1, punto2, punto3, punto4, punto5, punto6, punto7 };

        FillMode tipoRiempimento = FillMode.Winding;

        e.Graphics.FillPolygon(pennello, punti, tipoRiempimento);
    }

    public void RiempimentoPoligono(Brush pennello, PointF[] punti, FillMode tiporiempimento)
    {}
}

class Program
{ 
    static void Main(string[] args)
    {
        Application.Run(new ClsForm());
    }
}

