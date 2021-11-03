namespace Portofolio
{
    partial class form_zoeken
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_naam = new System.Windows.Forms.TextBox();
            this.listBox_result = new System.Windows.Forms.ListBox();
            this.button_zoek = new System.Windows.Forms.Button();
            this.checkedListBox_gebruik = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_thema = new System.Windows.Forms.CheckedListBox();
            this.checkBox_inverteer = new System.Windows.Forms.CheckBox();
            this.monthCalendar_start = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar_stop = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_info = new System.Windows.Forms.TextBox();
            this.listBox_bijlages = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox_type = new System.Windows.Forms.CheckedListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button_wijzig = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nieuwe_naam = new System.Windows.Forms.TextBox();
            this.button_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAAM";
            // 
            // textBox_naam
            // 
            this.textBox_naam.Location = new System.Drawing.Point(10, 26);
            this.textBox_naam.Name = "textBox_naam";
            this.textBox_naam.Size = new System.Drawing.Size(185, 20);
            this.textBox_naam.TabIndex = 1;
            this.textBox_naam.Enter += new System.EventHandler(this.button_zoek_Click);
            this.textBox_naam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_naam_KeyDown);
            // 
            // listBox_result
            // 
            this.listBox_result.FormattingEnabled = true;
            this.listBox_result.Location = new System.Drawing.Point(10, 426);
            this.listBox_result.Name = "listBox_result";
            this.listBox_result.Size = new System.Drawing.Size(184, 394);
            this.listBox_result.TabIndex = 2;
            this.listBox_result.SelectedIndexChanged += new System.EventHandler(this.listBox_result_SelectedIndexChanged);
            // 
            // button_zoek
            // 
            this.button_zoek.Location = new System.Drawing.Point(9, 141);
            this.button_zoek.Name = "button_zoek";
            this.button_zoek.Size = new System.Drawing.Size(183, 37);
            this.button_zoek.TabIndex = 3;
            this.button_zoek.Text = "ZOEK";
            this.button_zoek.UseVisualStyleBackColor = true;
            this.button_zoek.Click += new System.EventHandler(this.button_zoek_Click);
            // 
            // checkedListBox_gebruik
            // 
            this.checkedListBox_gebruik.FormattingEnabled = true;
            this.checkedListBox_gebruik.Location = new System.Drawing.Point(201, 18);
            this.checkedListBox_gebruik.Name = "checkedListBox_gebruik";
            this.checkedListBox_gebruik.Size = new System.Drawing.Size(183, 364);
            this.checkedListBox_gebruik.TabIndex = 4;
            // 
            // checkedListBox_thema
            // 
            this.checkedListBox_thema.FormattingEnabled = true;
            this.checkedListBox_thema.Location = new System.Drawing.Point(592, 18);
            this.checkedListBox_thema.Name = "checkedListBox_thema";
            this.checkedListBox_thema.Size = new System.Drawing.Size(183, 364);
            this.checkedListBox_thema.TabIndex = 5;
            // 
            // checkBox_inverteer
            // 
            this.checkBox_inverteer.AutoSize = true;
            this.checkBox_inverteer.Location = new System.Drawing.Point(207, 388);
            this.checkBox_inverteer.Name = "checkBox_inverteer";
            this.checkBox_inverteer.Size = new System.Drawing.Size(67, 17);
            this.checkBox_inverteer.TabIndex = 6;
            this.checkBox_inverteer.Text = "inverteer";
            this.checkBox_inverteer.UseVisualStyleBackColor = true;
            // 
            // monthCalendar_start
            // 
            this.monthCalendar_start.Location = new System.Drawing.Point(787, 18);
            this.monthCalendar_start.MaxSelectionCount = 1;
            this.monthCalendar_start.Name = "monthCalendar_start";
            this.monthCalendar_start.TabIndex = 7;
            this.monthCalendar_start.TodayDate = new System.DateTime(2016, 3, 4, 0, 0, 0, 0);
            // 
            // monthCalendar_stop
            // 
            this.monthCalendar_stop.Location = new System.Drawing.Point(1017, 18);
            this.monthCalendar_stop.MaxSelectionCount = 1;
            this.monthCalendar_stop.Name = "monthCalendar_stop";
            this.monthCalendar_stop.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(427, 449);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // textBox_info
            // 
            this.textBox_info.Location = new System.Drawing.Point(828, 280);
            this.textBox_info.Multiline = true;
            this.textBox_info.Name = "textBox_info";
            this.textBox_info.Size = new System.Drawing.Size(402, 540);
            this.textBox_info.TabIndex = 10;
            // 
            // listBox_bijlages
            // 
            this.listBox_bijlages.FormattingEnabled = true;
            this.listBox_bijlages.Location = new System.Drawing.Point(220, 449);
            this.listBox_bijlages.Name = "listBox_bijlages";
            this.listBox_bijlages.Size = new System.Drawing.Size(183, 355);
            this.listBox_bijlages.TabIndex = 12;
            this.listBox_bijlages.DoubleClick += new System.EventHandler(this.listBox_bijlages_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "BIJLAGES";
            // 
            // checkedListBox_type
            // 
            this.checkedListBox_type.FormattingEnabled = true;
            this.checkedListBox_type.Location = new System.Drawing.Point(390, 18);
            this.checkedListBox_type.Name = "checkedListBox_type";
            this.checkedListBox_type.Size = new System.Drawing.Size(196, 364);
            this.checkedListBox_type.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(621, 449);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(188, 173);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.DoubleClick += new System.EventHandler(this.pictureBox2_DoubleClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(427, 628);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(188, 173);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.DoubleClick += new System.EventHandler(this.pictureBox3_DoubleClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(621, 628);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(188, 173);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // button_wijzig
            // 
            this.button_wijzig.Location = new System.Drawing.Point(47, 250);
            this.button_wijzig.Name = "button_wijzig";
            this.button_wijzig.Size = new System.Drawing.Size(92, 49);
            this.button_wijzig.TabIndex = 18;
            this.button_wijzig.Text = "WIJZIG";
            this.button_wijzig.UseVisualStyleBackColor = true;
            this.button_wijzig.Click += new System.EventHandler(this.button_wijzig_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(8, 194);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(184, 40);
            this.button_reset.TabIndex = 19;
            this.button_reset.Text = "RESET";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "NIEUWE NAAM";
            // 
            // textBox_nieuwe_naam
            // 
            this.textBox_nieuwe_naam.Location = new System.Drawing.Point(10, 105);
            this.textBox_nieuwe_naam.Name = "textBox_nieuwe_naam";
            this.textBox_nieuwe_naam.Size = new System.Drawing.Size(182, 20);
            this.textBox_nieuwe_naam.TabIndex = 21;
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(58, 345);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(65, 37);
            this.button_del.TabIndex = 22;
            this.button_del.Text = "DELETE";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // form_zoeken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 832);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.textBox_nieuwe_naam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_wijzig);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.checkedListBox_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_bijlages);
            this.Controls.Add(this.textBox_info);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.monthCalendar_stop);
            this.Controls.Add(this.monthCalendar_start);
            this.Controls.Add(this.checkBox_inverteer);
            this.Controls.Add(this.checkedListBox_thema);
            this.Controls.Add(this.checkedListBox_gebruik);
            this.Controls.Add(this.button_zoek);
            this.Controls.Add(this.listBox_result);
            this.Controls.Add(this.textBox_naam);
            this.Controls.Add(this.label1);
            this.Name = "form_zoeken";
            this.Text = "ZOEKEN ETC.";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_naam;
        private System.Windows.Forms.ListBox listBox_result;
        private System.Windows.Forms.Button button_zoek;
        private System.Windows.Forms.CheckedListBox checkedListBox_gebruik;
        private System.Windows.Forms.CheckedListBox checkedListBox_thema;
        private System.Windows.Forms.CheckBox checkBox_inverteer;
        private System.Windows.Forms.MonthCalendar monthCalendar_start;
        private System.Windows.Forms.MonthCalendar monthCalendar_stop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_info;
        private System.Windows.Forms.ListBox listBox_bijlages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox_type;
        private System.Windows.Forms.Button button_wijzig;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_nieuwe_naam;
        private System.Windows.Forms.Button button_del;
    }
}