using System;
using System.Windows.Forms;
class ClsForm : Form
{
    Button btnLength,btnArea,SaveXml,btnLoadXml,btnDraw;

    Shape poly3 = new Polygon(3);
    Shape poly4 = new Polygon(4);
    Shape poly5 = new Polygon(5);
    Shape poly6 = new Polygon(6);
    Shape poly7 = new Polygon(7);
    Shape poly8 = new Polygon(8);
    Shape poly9 = new Polygon(9);
    Shape poly10 = new Polygon(10);
    Shape poly11 = new Polygon(11);




    ListShapes listShape = new ListShapes();
    PictureBox pictureBox = new PictureBox();
    public ClsForm()
    {
        pictureBox.Height = 1000;
        pictureBox.Width = 1000;
        //listShape.Add(line);
        //listShape.Add(rect);
        //listShape.Add(poly5);
        listShape.Add(poly6);
        //listShape.Add(poly7);
        listShape.Add(poly8);
        //listShape.Add(poly9);
        listShape.Add(poly10);
        //listShape.Add(poly11);

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
        //this.btnArea.Text=rect.Area.ToString();
    }

    private void Btn_Click(object sender, EventArgs e)
    {
        // line.X0 = 0; line.X1 = 10;
        // line.Y0 = 0; line.Y1 = 0;
        //this.Text = line.ToString()+"Length="+ line.Length;
    }
}

class Program
{ 


    static void Main(string[] args)
    {
        Application.Run(new ClsForm());
    }
}

