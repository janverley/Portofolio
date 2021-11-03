namespace Portofolio
{
    partial class Form1
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
            this.button1_nieuw = new System.Windows.Forms.Button();
            this.button_beheer = new System.Windows.Forms.Button();
            this.button_zoeken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_nieuw
            // 
            this.button1_nieuw.Location = new System.Drawing.Point(65, 59);
            this.button1_nieuw.Name = "button1_nieuw";
            this.button1_nieuw.Size = new System.Drawing.Size(170, 95);
            this.button1_nieuw.TabIndex = 0;
            this.button1_nieuw.Text = "NIEUW";
            this.button1_nieuw.UseVisualStyleBackColor = true;
            this.button1_nieuw.Click += new System.EventHandler(this.button1_nieuw_Click);
            // 
            // button_beheer
            // 
            this.button_beheer.Location = new System.Drawing.Point(65, 183);
            this.button_beheer.Name = "button_beheer";
            this.button_beheer.Size = new System.Drawing.Size(169, 95);
            this.button_beheer.TabIndex = 1;
            this.button_beheer.Text = "BEHEER";
            this.button_beheer.UseVisualStyleBackColor = true;
            this.button_beheer.Click += new System.EventHandler(this.button_beheer_Click);
            // 
            // button_zoeken
            // 
            this.button_zoeken.Location = new System.Drawing.Point(263, 59);
            this.button_zoeken.Name = "button_zoeken";
            this.button_zoeken.Size = new System.Drawing.Size(170, 95);
            this.button_zoeken.TabIndex = 2;
            this.button_zoeken.Text = "Zoeken/aanpassen/verwijderen";
            this.button_zoeken.UseVisualStyleBackColor = true;
            this.button_zoeken.Click += new System.EventHandler(this.button_zoeken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 351);
            this.Controls.Add(this.button_zoeken);
            this.Controls.Add(this.button_beheer);
            this.Controls.Add(this.button1_nieuw);
            this.Name = "Form1";
            this.Text = "Hoofd";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1_nieuw;
        private System.Windows.Forms.Button button_beheer;
        private System.Windows.Forms.Button button_zoeken;
    }
}

