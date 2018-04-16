using System;
using System.Windows.Forms;
/// <summary>
///  esercizio di polimorfismo
/// </summary>
class ClsForm : Form
{
    Button btnLength,btnArea,SaveXml,btnLoadXml,btnDraw;

    Shape line = new Line(0, 0, 10, 0, "Linea");
    Shape rect = new Rectagle(10,20, 40, 100, "rect");
    ListShapes listShape = new ListShapes();
    PictureBox pictureBox = new PictureBox();
    public ClsForm()
    {
        listShape.Add(line);
        listShape.Add(rect);
        rect = new Rectagle(50, 30, 100, 100, "rect");
       
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
}

class Program
{ 


    static void Main(string[] args)
    {
        Application.Run(new ClsForm());
    }
}

