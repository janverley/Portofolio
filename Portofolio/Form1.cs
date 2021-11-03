using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portofolio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_nieuw_Click(object sender, EventArgs e)
        {
            Form2_nieuw toevoegen = new Form2_nieuw();
            toevoegen.Show();
        }

        private void button_beheer_Click(object sender, EventArgs e)
        {
            Form_beheer beheren = new Form_beheer();
            beheren.Show();
        }

        private void button_zoeken_Click(object sender, EventArgs e)
        {
            form_zoeken zoeken = new form_zoeken();
            zoeken.Show();
        }
    }
}
