namespace Portofolio
{
    partial class Form_beheer
    {
        private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_gebruik = new System.Windows.Forms.ListBox();
            this.label_gebruik = new System.Windows.Forms.Label();
            this.textBox_toevoegen = new System.Windows.Forms.TextBox();
            this.button_toevoegen = new System.Windows.Forms.Button();
            this.button_verwijderen = new System.Windows.Forms.Button();
            this.label_thema = new System.Windows.Forms.Label();
            this.listBox_thema = new System.Windows.Forms.ListBox();
            this.button_tverwijderen = new System.Windows.Forms.Button();
            this.textBox_ttoevoegen = new System.Windows.Forms.TextBox();
            this.button_ttvoegen = new System.Windows.Forms.Button();
            this.button_nee = new System.Windows.Forms.Button();
            this.button_ja = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox_type = new System.Windows.Forms.ListBox();
            this.TYPE = new System.Windows.Forms.Label();
            this.button_typeverw = new System.Windows.Forms.Button();
            this.button_typetoev = new System.Windows.Forms.Button();
            this.textBox_typetoev = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox_gebruik
            // 
            this.listBox_gebruik.FormattingEnabled = true;
            this.listBox_gebruik.Location = new System.Drawing.Point(33, 51);
            this.listBox_gebruik.Name = "listBox_gebruik";
            this.listBox_gebruik.Size = new System.Drawing.Size(126, 108);
            this.listBox_gebruik.TabIndex = 0;
            // 
            // label_gebruik
            // 
            this.label_gebruik.AutoSize = true;
            this.label_gebruik.Location = new System.Drawing.Point(30, 35);
            this.label_gebruik.Name = "label_gebruik";
            this.label_gebruik.Size = new System.Drawing.Size(55, 13);
            this.label_gebruik.TabIndex = 1;
            this.label_gebruik.Text = "GEBRUIK";
            // 
            // textBox_toevoegen
            // 
            this.textBox_toevoegen.Location = new System.Drawing.Point(34, 219);
            this.textBox_toevoegen.Name = "textBox_toevoegen";
            this.textBox_toevoegen.Size = new System.Drawing.Size(124, 20);
            this.textBox_toevoegen.TabIndex = 2;
            // 
            // button_toevoegen
            // 
            this.button_toevoegen.Location = new System.Drawing.Point(34, 245);
            this.button_toevoegen.Name = "button_toevoegen";
            this.button_toevoegen.Size = new System.Drawing.Size(125, 33);
            this.button_toevoegen.TabIndex = 3;
            this.button_toevoegen.Text = "Toevoegen";
            this.button_toevoegen.UseVisualStyleBackColor = true;
            this.button_toevoegen.Click += new System.EventHandler(this.button_toevoegen_Click);
            // 
            // button_verwijderen
            // 
            this.button_verwijderen.Location = new System.Drawing.Point(36, 164);
            this.button_verwijderen.Name = "button_verwijderen";
            this.button_verwijderen.Size = new System.Drawing.Size(121, 27);
            this.button_verwijderen.TabIndex = 4;
            this.button_verwijderen.Text = "Verwijderen";
            this.button_verwijderen.UseVisualStyleBackColor = true;
            this.button_verwijderen.Click += new System.EventHandler(this.button_verwijderen_Click);
            // 
            // label_thema
            // 
            this.label_thema.AutoSize = true;
            this.label_thema.Location = new System.Drawing.Point(353, 35);
            this.label_thema.Name = "label_thema";
            this.label_thema.Size = new System.Drawing.Size(45, 13);
            this.label_thema.TabIndex = 5;
            this.label_thema.Text = "THEMA";
            // 
            // listBox_thema
            // 
            this.listBox_thema.FormattingEnabled = true;
            this.listBox_thema.Location = new System.Drawing.Point(356, 51);
            this.listBox_thema.Name = "listBox_thema";
            this.listBox_thema.Size = new System.Drawing.Size(126, 108);
            this.listBox_thema.TabIndex = 6;
            // 
            // button_tverwijderen
            // 
            this.button_tverwijderen.Location = new System.Drawing.Point(356, 164);
            this.button_tverwijderen.Name = "button_tverwijderen";
            this.button_tverwijderen.Size = new System.Drawing.Size(126, 27);
            this.button_tverwijderen.TabIndex = 7;
            this.button_tverwijderen.Text = "Verwijderen";
            this.button_tverwijderen.UseVisualStyleBackColor = true;
            this.button_tverwijderen.Click += new System.EventHandler(this.button_tverwijderen_Click);
            // 
            // textBox_ttoevoegen
            // 
            this.textBox_ttoevoegen.Location = new System.Drawing.Point(356, 219);
            this.textBox_ttoevoegen.Name = "textBox_ttoevoegen";
            this.textBox_ttoevoegen.Size = new System.Drawing.Size(126, 20);
            this.textBox_ttoevoegen.TabIndex = 8;
            // 
            // button_ttvoegen
            // 
            this.button_ttvoegen.Location = new System.Drawing.Point(358, 248);
            this.button_ttvoegen.Name = "button_ttvoegen";
            this.button_ttvoegen.Size = new System.Drawing.Size(123, 29);
            this.button_ttvoegen.TabIndex = 9;
            this.button_ttvoegen.Text = "Toevoegen";
            this.button_ttvoegen.UseVisualStyleBackColor = true;
            this.button_ttvoegen.Click += new System.EventHandler(this.button_ttvoegen_Click);
            // 
            // button_nee
            // 
            this.button_nee.Location = new System.Drawing.Point(89, 343);
            this.button_nee.Name = "button_nee";
            this.button_nee.Size = new System.Drawing.Size(119, 47);
            this.button_nee.TabIndex = 10;
            this.button_nee.Text = "Nee toch niet";
            this.button_nee.UseVisualStyleBackColor = true;
            this.button_nee.Click += new System.EventHandler(this.button_nee_Click);
            // 
            // button_ja
            // 
            this.button_ja.Location = new System.Drawing.Point(312, 343);
            this.button_ja.Name = "button_ja";
            this.button_ja.Size = new System.Drawing.Size(119, 46);
            this.button_ja.TabIndex = 11;
            this.button_ja.Text = "Ja zo wil ik het";
            this.button_ja.UseVisualStyleBackColor = true;
            this.button_ja.Click += new System.EventHandler(this.button_ja_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(512, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 226);
            this.textBox1.TabIndex = 12;
            // 
            // listBox_type
            // 
            this.listBox_type.FormattingEnabled = true;
            this.listBox_type.Location = new System.Drawing.Point(197, 51);
            this.listBox_type.Name = "listBox_type";
            this.listBox_type.Size = new System.Drawing.Size(126, 108);
            this.listBox_type.TabIndex = 13;
            // 
            // TYPE
            // 
            this.TYPE.AutoSize = true;
            this.TYPE.Location = new System.Drawing.Point(194, 35);
            this.TYPE.Name = "TYPE";
            this.TYPE.Size = new System.Drawing.Size(35, 13);
            this.TYPE.TabIndex = 14;
            this.TYPE.Text = "TYPE";
            // 
            // button_typeverw
            // 
            this.button_typeverw.Location = new System.Drawing.Point(197, 164);
            this.button_typeverw.Name = "button_typeverw";
            this.button_typeverw.Size = new System.Drawing.Size(123, 27);
            this.button_typeverw.TabIndex = 15;
            this.button_typeverw.Text = "Verwijderen";
            this.button_typeverw.UseVisualStyleBackColor = true;
            this.button_typeverw.Click += new System.EventHandler(this.button_typeverw_Click);
            // 
            // button_typetoev
            // 
            this.button_typetoev.Location = new System.Drawing.Point(197, 245);
            this.button_typetoev.Name = "button_typetoev";
            this.button_typetoev.Size = new System.Drawing.Size(123, 32);
            this.button_typetoev.TabIndex = 16;
            this.button_typetoev.Text = "Toevoegen";
            this.button_typetoev.UseVisualStyleBackColor = true;
            this.button_typetoev.Click += new System.EventHandler(this.button_typetoev_Click);
            // 
            // textBox_typetoev
            // 
            this.textBox_typetoev.Location = new System.Drawing.Point(197, 219);
            this.textBox_typetoev.Name = "textBox_typetoev";
            this.textBox_typetoev.Size = new System.Drawing.Size(123, 20);
            this.textBox_typetoev.TabIndex = 17;
            // 
            // Form_beheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 433);
            this.Controls.Add(this.textBox_typetoev);
            this.Controls.Add(this.button_typetoev);
            this.Controls.Add(this.button_typeverw);
            this.Controls.Add(this.TYPE);
            this.Controls.Add(this.listBox_type);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_ja);
            this.Controls.Add(this.button_nee);
            this.Controls.Add(this.button_ttvoegen);
            this.Controls.Add(this.textBox_ttoevoegen);
            this.Controls.Add(this.button_tverwijderen);
            this.Controls.Add(this.listBox_thema);
            this.Controls.Add(this.label_thema);
            this.Controls.Add(this.button_verwijderen);
            this.Controls.Add(this.button_toevoegen);
            this.Controls.Add(this.textBox_toevoegen);
            this.Controls.Add(this.label_gebruik);
            this.Controls.Add(this.listBox_gebruik);
            this.Name = "Form_beheer";
            this.Text = "beheer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_gebruik;
        private System.Windows.Forms.Label label_gebruik;
        private System.Windows.Forms.TextBox textBox_toevoegen;
        private System.Windows.Forms.Button button_toevoegen;
        private System.Windows.Forms.Button button_verwijderen;
        private System.Windows.Forms.Label label_thema;
        private System.Windows.Forms.ListBox listBox_thema;
        private System.Windows.Forms.Button button_tverwijderen;
        private System.Windows.Forms.TextBox textBox_ttoevoegen;
        private System.Windows.Forms.Button button_ttvoegen;
        private System.Windows.Forms.Button button_nee;
        private System.Windows.Forms.Button button_ja;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox_type;
        private System.Windows.Forms.Label TYPE;
        private System.Windows.Forms.Button button_typeverw;
        private System.Windows.Forms.Button button_typetoev;
        private System.Windows.Forms.TextBox textBox_typetoev;
    }
}