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
    public partial class form_zoeken : Form
    {
        public form_zoeken()
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
            //startdatum
            DateTime example = Convert.ToDateTime("18/10/1974");
            monthCalendar_start.SetDate(example);



        }

        private void button_zoek_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("nl-BE");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
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

            //resultaten opschonen
            listBox_result.Items.Clear();
            listBox_bijlages.Items.Clear();
            textBox_info.Clear();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;

            //op naam testen
            foreach (XmlNode node in xprojecten.DocumentElement.ChildNodes)
            {
                XmlNode naam = node.SelectSingleNode("./naam");
                if (naam.InnerText.Contains(textBox_naam.Text))
                {
                    //gebruik testen
                    XmlNodeList xgebruiklijst = node.SelectNodes("./gebruik");
                    bool match = true;
                    int i = 0;
                    while (match && i < checkedListBox_gebruik.CheckedItems.Count)
                        {
                            match = false;
                        if (xgebruiklijst.Count == 0 && checkBox_inverteer.Checked)
                            match = true;
                            foreach (XmlNode subnode in xgebruiklijst)
                            {
                                if (!checkBox_inverteer.Checked)
                                {
                                    if (checkedListBox_gebruik.CheckedItems[i].ToString() == subnode.InnerText)
                                    {
                                        match = true;
                                    }
                                }
                                else
                                {
                                    if (checkedListBox_gebruik.CheckedItems[i].ToString() == subnode.InnerText)
                                    {
                                        break;
                                    }
                                    match = true;
                                }
                            }
                            i++;
                        }
                    //thema testen
                    XmlNodeList xthemalijst = node.SelectNodes("./thema");
                    i = 0;
                    while (match && i < checkedListBox_thema.CheckedItems.Count)
                    {
                        match = false;
                        foreach (XmlNode subnode in xthemalijst)
                        {
                            if (checkedListBox_thema.CheckedItems[i].ToString() == subnode.InnerText)
                            {
                                match = true;
                            }
                        }
                        i++;
                    }
                    //type testen
                    XmlNodeList xtypelijst = node.SelectNodes("./type");
                    i = 0;
                    while (match && i < checkedListBox_type.CheckedItems.Count)
                    {
                        match = false;
                        foreach (XmlNode subnode in xtypelijst)
                        {
                            if (checkedListBox_type.CheckedItems[i].ToString() == subnode.InnerText)
                            {
                                match = true;
                            }
                        }
                        i++;
                    }


                    //datum testen
                    XmlNode xdatum = node.SelectSingleNode("./datum");
                    DateTime datum = Convert.ToDateTime(xdatum.InnerText);
                    if (DateTime.Compare(datum, monthCalendar_start.SelectionRange.Start) < 0 || DateTime.Compare(datum, monthCalendar_stop.SelectionRange.Start) > 0)
                        match = false;
                    //alles ok
                    if (match)
                        listBox_result.Items.Add(naam.InnerText);
                }
                
            }


        }

        

        private void listBox_result_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            listBox_bijlages.Items.Clear();
            textBox_info.Text = "";
            for (int i = 0; i < checkedListBox_gebruik.Items.Count; i++)
                checkedListBox_gebruik.SetItemChecked(i, false);
            for (int i = 0; i < checkedListBox_thema.Items.Count; i++)
                checkedListBox_thema.SetItemChecked(i, false);
            for (int i = 0; i < checkedListBox_type.Items.Count; i++)
                checkedListBox_type.SetItemChecked(i, false);

            if (listBox_result.SelectedItem != null)
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

                string selectedNaam = listBox_result.SelectedItem.ToString();
                foreach (XmlNode node in xprojecten.DocumentElement.ChildNodes)
                {
                    XmlNode naam = node.SelectSingleNode("./naam");
                    if (naam.InnerText == selectedNaam)
                    {
                        string fotoDir = Path.Combine(".\\fotos", selectedNaam);
                        if (Directory.Exists(fotoDir))
                        {
                            string[] fotos = Directory.GetFiles(fotoDir);
                            var foto = 0;
                            var kader = 1;
                            while (foto < fotos.Length && kader < 5)
                            {
                                switch (kader)
                                {
                                    case 1:
                                        try
                                        {
                                            pictureBox1.Load(fotos[foto]);
                                        }
                                        catch
                                        {
                                            kader--;
                                        }
                                        kader++;
                                        foto++;
                                        break;
                                    case 2:
                                        try
                                        {
                                            pictureBox2.Load(fotos[foto]);
                                        }
                                        catch
                                        {
                                            kader--;
                                        }
                                        kader++;
                                        foto++;
                                        break;
                                    case 3:
                                        try
                                        {
                                            pictureBox3.Load(fotos[foto]);
                                        }
                                        catch
                                        {
                                            kader--;
                                        }
                                        kader++;
                                        foto++;
                                        break;
                                    case 4:
                                        try
                                        {
                                            pictureBox4.Load(fotos[foto]);
                                        }
                                        catch
                                        {
                                            kader--;
                                        }
                                        kader++;
                                        foto++;
                                        break;
                                    default:
                                        MessageBox.Show("Er een probleempje. Mail William");
                                        break;
                                }
                            }
                        }
                        //datum tonen


                        //bijlages tonen
                        string bijlageDir = Path.Combine(".\\bijlages", selectedNaam);
                        if (Directory.Exists(bijlageDir))
                        {
                            string[] bijlages = Directory.GetFiles(bijlageDir);
                            for (int i = 0; i < bijlages.Length; i++)
                            {
                                listBox_bijlages.Items.Add(Path.GetFileName(bijlages[i]));
                            }
                        }
                        //gebruik tonen
                        XmlNodeList gebruiken = node.SelectNodes("./gebruik");
                        foreach (XmlNode Used in gebruiken)
                        {
                            for (int i = 0; i < checkedListBox_gebruik.Items.Count; i++)
                            {
                                if (Used.InnerText == checkedListBox_gebruik.Items[i].ToString())
                                    checkedListBox_gebruik.SetItemChecked(i, true);
                            }
                        }
                        //thema tonen
                        XmlNodeList themas = node.SelectNodes("./thema");
                        foreach (XmlNode Used in themas)
                        {
                            for (int i = 0; i < checkedListBox_thema.Items.Count; i++)
                            {
                                if (Used.InnerText == checkedListBox_thema.Items[i].ToString())
                                    checkedListBox_thema.SetItemChecked(i, true);
                            }
                        }
                        //types tonen
                        XmlNodeList types = node.SelectNodes("./type");
                        foreach (XmlNode Used in types)
                        {
                            for (int i = 0; i < checkedListBox_type.Items.Count; i++)
                            {
                                if (Used.InnerText == checkedListBox_type.Items[i].ToString())
                                    checkedListBox_type.SetItemChecked(i, true);
                            }
                        }

                        //infotekst tonen
                        XmlNodeList infoList = node.SelectNodes("./info");
                        textBox_info.Clear();
                        foreach (XmlNode lineNode in infoList)
                        {
                            textBox_info.AppendText(lineNode.InnerText + Environment.NewLine);
                        }

                        //naam tonen
                        textBox_naam.Text = listBox_result.SelectedItem.ToString();
                        textBox_nieuwe_naam.Text = listBox_result.SelectedItem.ToString();
                        return;
                    }
                }
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_bijlages.SelectedItem != null)
            {
                System.Diagnostics.Process.Start(Path.Combine(".\\fotos", listBox_result.SelectedItem.ToString(), listBox_bijlages.SelectedItem.ToString()));
            }
            else
            {
                System.Diagnostics.Process.Start(Path.Combine(".\\fotos", listBox_result.SelectedItem.ToString()));
            }
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_bijlages.SelectedItem != null)
            {
                System.Diagnostics.Process.Start(Path.Combine(".\\fotos", listBox_result.SelectedItem.ToString(), listBox_bijlages.SelectedItem.ToString()));
            }
            else
            {
                System.Diagnostics.Process.Start(Path.Combine(".\\fotos", listBox_result.SelectedItem.ToString()));
            }
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_bijlages.SelectedItem != null)
            {
                System.Diagnostics.Process.Start(Path.Combine(".\\fotos", listBox_result.SelectedItem.ToString(), listBox_bijlages.SelectedItem.ToString()));
            }
            else
            {
                System.Diagnostics.Process.Start(Path.Combine(".\\fotos", listBox_result.SelectedItem.ToString()));
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (listBox_bijlages.SelectedItem != null)
            {
                System.Diagnostics.Process.Start(Path.Combine(".\\fotos", listBox_result.SelectedItem.ToString(), listBox_bijlages.SelectedItem.ToString()));
            }
            else
            {
                System.Diagnostics.Process.Start(Path.Combine(".\\fotos", listBox_result.SelectedItem.ToString()));
            }
        }

        private void listBox_bijlages_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_bijlages.SelectedItem!=null)
            {
                try
                { System.Diagnostics.Process.Start(Path.Combine(".\\bijlages", listBox_result.SelectedItem.ToString(), listBox_bijlages.SelectedItem.ToString())); }
                catch { System.Diagnostics.Process.Start(Path.Combine(".\\bijlages", listBox_result.SelectedItem.ToString())); }
            }
            else
            {
                System.Diagnostics.Process.Start(Path.Combine(".\\bijlages", listBox_result.SelectedItem.ToString()));
            }
            
        }

        private void button_wijzig_Click(object sender, EventArgs e)
        {
            //bestaan van projecten testen
            XmlDocument xprojecten = new XmlDocument();
            xprojecten.Load(".\\projecten.xml");
            XmlNode projecten = xprojecten.SelectSingleNode("projecten");
            string selectedNaam = listBox_result.SelectedItem.ToString();
            foreach (XmlNode node in xprojecten.DocumentElement.ChildNodes)
            {
                XmlNode naam = node.SelectSingleNode("./naam");
                if (naam.InnerText == selectedNaam)
                {
                    //unieke naam?
                    foreach (XmlNode testnode in xprojecten.DocumentElement.ChildNodes)
                    {
                        XmlNode testnaam = testnode.SelectSingleNode("./naam");
                        if ((testnaam.InnerText == textBox_nieuwe_naam.Text) && (textBox_naam.Text!= textBox_nieuwe_naam.Text))
                        {
                            MessageBox.Show("sorry, die naam is al in gebruik");
                            return;
                        }
                    }

                    node.ParentNode.RemoveChild(node);
 
                    XmlNode project = xprojecten.CreateNode(XmlNodeType.Element, "project", null);
                    XmlNode invoeger = xprojecten.CreateNode(XmlNodeType.Element, "naam", null);


                    invoeger.InnerText = textBox_nieuwe_naam.Text;


                    project.AppendChild(invoeger);
                                        
                    invoeger = xprojecten.CreateNode(XmlNodeType.Element, "datum", null);
                    invoeger.InnerText = monthCalendar_stop.SelectionRange.Start.ToLongDateString();
                    project.AppendChild(invoeger);

                    foreach (var item in checkedListBox_gebruik.CheckedItems)
                    {
                        invoeger = xprojecten.CreateNode(XmlNodeType.Element, "gebruik", null);
                        invoeger.InnerText = item.ToString();
                        project.AppendChild(invoeger);
                    }

                    foreach (var item in checkedListBox_thema.CheckedItems)
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

                    string[] hulp = textBox_info.Lines.ToArray();
                    for (int i = 0; i < hulp.Length; i++)
                    {
                        invoeger = xprojecten.CreateNode(XmlNodeType.Element, "info", null);
                        invoeger.InnerText = hulp[i];
                        project.AppendChild(invoeger);
                    }
                    projecten.AppendChild(project);
                    xprojecten.Save(".\\projecten.xml");

                    pictureBox1.Dispose();
                    pictureBox2.Dispose();
                    pictureBox3.Dispose();
                    pictureBox4.Dispose();

                    if (textBox_naam.Text != textBox_nieuwe_naam.Text)
                    {
                        string dest = System.IO.Path.Combine(".\\fotos", textBox_nieuwe_naam.Text);
                        string source = System.IO.Path.Combine(".\\fotos", textBox_naam.Text);
                        Directory.Move(@source, @dest);

                        dest = System.IO.Path.Combine(".\\bijlages", textBox_nieuwe_naam.Text);
                        source = System.IO.Path.Combine(".\\bijlages", textBox_naam.Text);
                        Directory.Move(@source, @dest);
                    }
                    this.Close();

                    
                }
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_naam.Text = "";
            textBox_nieuwe_naam.Text = "";
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            listBox_bijlages.Items.Clear();
            listBox_result.Items.Clear();
            textBox_info.Text = "";
            for (int i = 0; i < checkedListBox_gebruik.Items.Count; i++)
                checkedListBox_gebruik.SetItemChecked(i, false);
            for (int i = 0; i < checkedListBox_thema.Items.Count; i++)
                checkedListBox_thema.SetItemChecked(i, false);
            for (int i = 0; i < checkedListBox_type.Items.Count; i++)
                checkedListBox_type.SetItemChecked(i, false);
        }

        private void textBox_naam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_zoek_Click(this, new EventArgs());
            }
         }

        private void button_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Heel zeker?", "controle", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            else
            {
                XmlDocument xprojecten = new XmlDocument();
                xprojecten.Load(".\\projecten.xml");
                XmlNode projecten = xprojecten.SelectSingleNode("projecten");
                string selectedNaam = listBox_result.SelectedItem.ToString();
                foreach (XmlNode node in xprojecten.DocumentElement.ChildNodes)
                {
                    XmlNode naam = node.SelectSingleNode("./naam");
                    if (naam.InnerText == selectedNaam)
                    {
                        node.ParentNode.RemoveChild(node);
                        xprojecten.Save(".\\projecten.xml");

                        pictureBox1.Dispose();
                        pictureBox2.Dispose();
                        pictureBox3.Dispose();
                        pictureBox4.Dispose();

                        string source = System.IO.Path.Combine(".\\fotos", textBox_naam.Text);
                        if (System.IO.File.Exists(source))
                            Directory.Delete(source,true);
                        
                        source = System.IO.Path.Combine(".\\bijlages", textBox_naam.Text);
                        if (System.IO.File.Exists(source))
                            Directory.Delete(source, true);

                        this.Close();
                    }
                }
            }
        }
    }
}
