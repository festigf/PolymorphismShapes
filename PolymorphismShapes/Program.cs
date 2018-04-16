using System;
using System.Windows.Forms;
class ClsForm : Form
{
    Button btnLength,btnArea,SaveXml,btnLoadXml,btnDraw,axis;
    TextBox dato = new TextBox();
    Shape line = new Line(0, 0, 10, 0, "Linea","blue");
    Shape rect = new Rectagle(10,20, 40, 100, "rect","yellow");

    Shape assiX;
    Shape assiY;

    //classe base shape
    //polimorfismo dinamico proprietà comuni

    ListShapes listShape = new ListShapes();

    PictureBox pictureBox = new PictureBox();
    public ClsForm()
    {     
        assiY = new Assi();
        /*listShape.Add(line);
        listShape.Add(rect);*/
    
        this.Width = 800;
        this.Height = 800;
        assiX = new Assi(0, this.Height / 2, this.Width, this.Height / 2, "Assi", "red");
        assiY = new Assi(this.Width / 2,0,this.Width / 2,this.Height,"Assi","blue");
        listShape.Add(assiX);
        listShape.Add(assiY);

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


        axis = new Button
        {
            Text = "X/Y",
            Top = 180,
            Width = 50
        };
        this.Controls.Add(axis);
        this.axis.Click += Axis_Click;

        this.Controls.Add(dato);
        dato.Height = 50;
        dato.Width = 50;
        dato.Top = 130;

        this.Controls.Add(btnDraw);
        this.btnDraw.Click += BtnDraw_Click;
        this.Controls.Add(pictureBox);
       
        //pictureBox.Anchor = AnchorStyles.Bottom & AnchorStyles.Right;
       
        //pictureBox.Left = 50;
        pictureBox.Height = this.Height;
        pictureBox.Width = this.Width;
    }
    private void Axis_Click(object sender, EventArgs e)
    {
        listShape.Draw(this.pictureBox);
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

