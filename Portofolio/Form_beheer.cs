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

namespace Portofolio
{
    public partial class Form_beheer : Form
    {
        public Form_beheer()
        {
            InitializeComponent();
            
            //gebruiken inlezen
            XmlDocument xgebruiken = new XmlDocument();
            if (!System.IO.File.Exists(".\\gebruiken.xml"))
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
                    listBox_gebruik.Items.Add(node.InnerText);
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
                    listBox_type.Items.Add(node.InnerText);
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
                    listBox_thema.Items.Add(node.InnerText);
                }
            }

            //tekst inlezen
            textBox1.Text = File.ReadAllText(".\\standaardtekst.txt");
        }

        private void button_toevoegen_Click(object sender, EventArgs e)
        {
            listBox_gebruik.Items.Add(textBox_toevoegen.Text);
            textBox_toevoegen.Text = "";
        }

        private void button_verwijderen_Click(object sender, EventArgs e)
        {
            if (listBox_gebruik.SelectedIndex >= 0)
                listBox_gebruik.Items.RemoveAt(listBox_gebruik.SelectedIndex);
        }

        private void button_ja_Click(object sender, EventArgs e)
        {
            //gebruiken wegschrijven
            XmlDocument xgebruiken = new XmlDocument();
            XmlNode Node = xgebruiken.CreateXmlDeclaration("1.0", "UTF-8", null);
            xgebruiken.AppendChild(Node);
            Node = xgebruiken.CreateElement("gebruiken");
            xgebruiken.AppendChild(Node);
            XmlNode gebruiken = xgebruiken.SelectSingleNode("gebruiken");
            foreach (var item in listBox_gebruik.Items)
            {
                XmlNode newSub = xgebruiken.CreateNode(XmlNodeType.Element, "gebruik", null);
                newSub.InnerText = item.ToString();
                gebruiken.AppendChild(newSub);
            }
            xgebruiken.Save(".\\gebruiken.xml");

            //themas wegschrijven
            XmlDocument xthemas = new XmlDocument();
            Node = xthemas.CreateXmlDeclaration("1.0", "UTF-8", null);
            xthemas.AppendChild(Node);
            Node = xthemas.CreateElement("themas");
            xthemas.AppendChild(Node);
            XmlNode themas = xthemas.SelectSingleNode("themas");
            foreach (var item in listBox_thema.Items)
            {
                XmlNode newSub = xthemas.CreateNode(XmlNodeType.Element, "thema", null);
                newSub.InnerText = item.ToString();
                themas.AppendChild(newSub);
            }
            xthemas.Save(".\\themas.xml");

            //types wegschrijven
            XmlDocument xtypes = new XmlDocument();
            Node = xtypes.CreateXmlDeclaration("1.0", "UTF-8", null);
            xtypes.AppendChild(Node);
            Node = xtypes.CreateElement("types");
            xtypes.AppendChild(Node);
            XmlNode types = xtypes.SelectSingleNode("types");
            foreach (var item in listBox_type.Items)
            {
                XmlNode newSub = xtypes.CreateNode(XmlNodeType.Element, "type", null);
                newSub.InnerText = item.ToString();
                types.AppendChild(newSub);
            }
            xtypes.Save(".\\types.xml");

            File.WriteAllText(".\\standaardtekst.txt", textBox1.Text);
            this.Close();
        }

        private void button_nee_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_ttvoegen_Click(object sender, EventArgs e)
        {
            listBox_thema.Items.Add(textBox_ttoevoegen.Text);
            textBox_ttoevoegen.Text = "";
        }

        private void button_tverwijderen_Click(object sender, EventArgs e)
        {
            if (listBox_thema.SelectedIndex >= 0)
                listBox_thema.Items.RemoveAt(listBox_thema.SelectedIndex);
        }

        private void button_typetoev_Click(object sender, EventArgs e)
        {
            listBox_type.Items.Add(textBox_typetoev.Text);
            textBox_typetoev.Text = "";
        }

        private void button_typeverw_Click(object sender, EventArgs e)
        {
            if (listBox_type.SelectedIndex >= 0)
                listBox_type.Items.RemoveAt(listBox_type.SelectedIndex);
        }
    }
}
