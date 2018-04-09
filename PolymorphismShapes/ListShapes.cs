using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Drawing;
using System.Windows.Forms;
public class ListShapes : List<Shape>//lista di oggeti di tipo polimorfico
{
    public bool SaveXml(String fileName)
    {
        try
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Shape>));//preleva i nomi dgli attributi di ogni oggetto da sola 
            //classe xmlserializer
            StreamWriter sw = new StreamWriter(fileName);
            xs.Serialize(sw, this);
            sw.Close();
        }
        catch (Exception e)
        {
            return false;
        }
        return true;
    }
    public bool LoadXml(string fileName)
    {
        if (File.Exists(fileName))
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Shape>));
            StreamReader sr = new StreamReader(fileName);
           
            //ricarica nella lista le figure geometriche salvate nel file XML
            //serial e deserial allocazione dati sequenziali
            //in memoria dipende dalla architettura della macchina

            this.AddRange((List<Shape>)xs.Deserialize(sr));
            sr.Close();
            return true;
        }
        else
            return false;
    }

    public void Draw(PictureBox pictureBox)
    {
        foreach (Shape item in this)
        {
            item.Draw(pictureBox);
        }
    }
}

