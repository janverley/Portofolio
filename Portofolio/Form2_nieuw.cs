using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Globalization;
using System.Threading;

namespace Portofolio
{
    public partial class Form2_nieuw : Form
    {
        const int maxfoto = 25;
        int aantalfotos = 0;
        string[] fotos = new string[maxfoto];
        const int maxbijlage = 25;
        int aantalbijlages = 0;
        string[] bijlages = new string[maxbijlage];
        public Form2_nieuw()
        {
            CultureInfo ci = new CultureInfo("nl-BE");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            InitializeComponent();
            //tekst inlezen
            if (!File.Exists(".\\standaardtekst.txt"))
                File.WriteAllText(".\\standaardtekst.txt", String.Empty);
            textBox1.Text = File.ReadAllText(".\\standaardtekst.txt");

            //gebruiken inlezen
            XmlDocument xgebruiken = new XmlDocument();
            if (!File.Exists(".\\gebruiken.xml"))
            {
                XmlNode Node = xgebruiken.CreateXmlDeclaration("1.0", "UTF-8", null);
                xgebruiken.AppendChild(Node);
                Node = xgebruiken.CreateElement("gebruiken");
                xgebruiken.AppendChild(Node);
                xgebruiken.Save(".\\gebruiken.xml");
            }
            else
            {
                xgebruiken.Load(".\\gebruiken.xml");
                foreach (XmlNode node in xgebruiken.DocumentElement.ChildNodes)
                {
                    checkedListBox_gebruik.Items.Add(node.InnerText);
                }
            }

            //themas inlezen
            XmlDocument xthemas = new XmlDocument();
            if (!System.IO.File.Exists(".\\themas.xml"))
            {
                XmlNode Node = xthemas.CreateXmlDeclaration("1.0", "UTF-8", null);
                xthemas.AppendChild(Node);
                Node = xthemas.CreateElement("themas");
                xthemas.AppendChild(Node);
                xthemas.Save(".\\themas.xml");
            }
            else
            {
                xthemas.Load(".\\themas.xml");
                foreach (XmlNode node in xthemas.DocumentElement.ChildNodes)
                {
                    checkedListBox_thema.Items.Add(node.InnerText);
                }
            }

            //types inlezen
            XmlDocument xtypes = new XmlDocument();
            if (!System.IO.File.Exists(".\\types.xml"))
            {
                XmlNode Node = xtypes.CreateXmlDeclaration("1.0", "UTF-8", null);
                xtypes.AppendChild(Node);
                Node = xtypes.CreateElement("types");
                xtypes.AppendChild(Node);
                xtypes.Save(".\\types.xml");
            }
            else
            {
                xtypes.Load(".\\types.xml");
                foreach (XmlNode node in xtypes.DocumentElement.ChildNodes)
                {
                    checkedListBox_type.Items.Add(node.InnerText);
                }
            }


        }

        private void button1_foto_Click(object sender, EventArgs e)
        {
            DialogResult gekozenFoto = openFileDialog1.ShowDialog();
            if (gekozenFoto == DialogResult.OK)
            {
                if (aantalfotos < maxfoto)
                {
                    pictureBox4.Image = pictureBox3.Image;
                    pictureBox3.Image = pictureBox2.Image;
                    pictureBox2.Image = pictureBox1.Image;
                    pictureBox1.Load(openFileDialog1.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
                    fotos[aantalfotos] = openFileDialog1.FileName;
                    aantalfotos++;
                }
                else
                    MessageBox.Show("maximum aantal fotos gekozen");
            }
        }

        private void button_oops_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_opslaan_Click(object sender, EventArgs e)
        {
            //bestaan van projecten testen
            XmlDocument xprojecten = new XmlDocument();
            if (!System.IO.File.Exists(".\\projecten.xml"))
            {
                XmlNode Node = xprojecten.CreateXmlDeclaration("1.0", "UTF-8", null);
                xprojecten.AppendChild(Node);
                Node = xprojecten.CreateElement("projecten");
                xprojecten.AppendChild(Node);
                xprojecten.Save(".\\projecten.xml");
            }
            xprojecten.Load(".\\projecten.xml");

            //naam ingevuld?
            if (textBox1_naam.Text == "")
            {
                MessageBox.Show("gelieve een naam te verzinnen");
            }
            else
            {
                //unieke naam?
                foreach (XmlNode node in xprojecten.DocumentElement.ChildNodes)
                {
                    XmlNode naam = node.SelectSingleNode("./naam");
                    if (naam.InnerText == textBox1_naam.Text)
                    {
                        MessageBox.Show("sorry, die naam is al in gebruik");
                        return;
                    }
                }

                XmlNode projecten = xprojecten.SelectSingleNode("projecten");
                XmlNode project = xprojecten.CreateNode(XmlNodeType.Element, "project", null);
                XmlNode invoeger = xprojecten.CreateNode(XmlNodeType.Element, "naam", null);
                invoeger.InnerText = textBox1_naam.Text;
                project.AppendChild(invoeger);

                invoeger = xprojecten.CreateNode(XmlNodeType.Element, "datum", null);
                invoeger.InnerText = monthCalendar1.SelectionRange.Start.ToLongDateString();
                project.AppendChild(invoeger);

                foreach (var item in checkedListBox_gebruik.CheckedItems)
                {
                    invoeger = xprojecten.CreateNode(XmlNodeType.Element, "gebruik", null);
                    invoeger.InnerText = item.ToString();
                    project.AppendChild(invoeger);                    
                }

                foreach ( var item in checkedListBox_thema.CheckedItems)
                {
                    invoeger = xprojecten.CreateNode(XmlNodeType.Element, "thema", null);
                    invoeger.InnerText = item.ToString();
                    project.AppendChild(invoeger);
                }

                foreach (var item in checkedListBox_type.CheckedItems)
                {
                    invoeger = xprojecten.CreateNode(XmlNodeType.Element, "type", null);
                    invoeger.InnerText = item.ToString();
                    project.AppendChild(invoeger);
                }



                string[] hulp = textBox1.Lines.ToArray();
                for (int i=0; i<hulp.Length; i++)
                {
                    invoeger = xprojecten.CreateNode(XmlNodeType.Element, "info", null);
                    invoeger.InnerText = hulp[i];
                    project.AppendChild(invoeger);
                }
                projecten.AppendChild(project);
                xprojecten.Save(".\\projecten.xml");

                if (!Directory.Exists(".\\fotos"))
                    Directory.CreateDirectory(".\\fotos");
                string dest = System.IO.Path.Combine(".\\fotos", textBox1_naam.Text);
                if (!Directory.Exists(dest))
                    Directory.CreateDirectory(dest);
                for (int i= 0;i<aantalfotos;i++)
                {
                    string destFile = Path.Combine(dest, Path.GetFileName(fotos[i]));
                    File.Copy(fotos[i], destFile, true);
                }

                if (!Directory.Exists(".\\bijlages"))
                    Directory.CreateDirectory(".\\bijlages");
                dest = Path.Combine(".\\bijlages", textBox1_naam.Text);
                if (!Directory.Exists(dest))
                    Directory.CreateDirectory(dest);

                for (int i = 0; i < aantalbijlages; i++)
                {
                    string destFile = Path.Combine(dest, Path.GetFileName(bijlages[i]));
                    System.IO.File.Copy(bijlages[i], destFile, true);
                }


                this.Close();
            }
        }

        private void button_bijlage_Click(object sender, EventArgs e)
        {
            DialogResult gekozenBijlage = openFileDialog2.ShowDialog();
            if (gekozenBijlage == DialogResult.OK)
            {
                if (aantalbijlages < maxbijlage)
                {
                    bijlages[aantalbijlages] = openFileDialog2.FileName;
                    aantalbijlages++;
                    listBox_bijlages.Items.Add(Path.GetFileName(openFileDialog2.FileName));
                }
                else
                    MessageBox.Show("maximum aantal bijlages gekozen");
            }
        }
    }
}
