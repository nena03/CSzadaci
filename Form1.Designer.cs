namespace proizvod
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
            this.tbProizvod = new System.Windows.Forms.TextBox();
            this.tbNovaCena = new System.Windows.Forms.TextBox();
            this.tbNaziv2 = new System.Windows.Forms.TextBox();
            this.tbProizvodjac2 = new System.Windows.Forms.TextBox();
            this.tbCena2 = new System.Windows.Forms.TextBox();
            this.tbPoruka = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbProizvod
            // 
            this.tbProizvod.Location = new System.Drawing.Point(12, 53);
            this.tbProizvod.Name = "tbProizvod";
            this.tbProizvod.Size = new System.Drawing.Size(319, 20);
            this.tbProizvod.TabIndex = 0;
            // 
            // tbNovaCena
            // 
            this.tbNovaCena.Location = new System.Drawing.Point(21, 113);
            this.tbNovaCena.Name = "tbNovaCena";
            this.tbNovaCena.Size = new System.Drawing.Size(100, 20);
            this.tbNovaCena.TabIndex = 1;
            // 
            // tbNaziv2
            // 
            this.tbNaziv2.Location = new System.Drawing.Point(21, 180);
            this.tbNaziv2.Name = "tbNaziv2";
            this.tbNaziv2.Size = new System.Drawing.Size(100, 20);
            this.tbNaziv2.TabIndex = 2;
            // 
            // tbProizvodjac2
            // 
            this.tbProizvodjac2.Location = new System.Drawing.Point(21, 207);
            this.tbProizvodjac2.Name = "tbProizvodjac2";
            this.tbProizvodjac2.Size = new System.Drawing.Size(100, 20);
            this.tbProizvodjac2.TabIndex = 3;
            // 
            // tbCena2
            // 
            this.tbCena2.Location = new System.Drawing.Point(21, 233);
            this.tbCena2.Name = "tbCena2";
            this.tbCena2.Size = new System.Drawing.Size(100, 20);
            this.tbCena2.TabIndex = 4;
            // 
            // tbPoruka
            // 
            this.tbPoruka.Location = new System.Drawing.Point(21, 296);
            this.tbPoruka.Name = "tbPoruka";
            this.tbPoruka.Size = new System.Drawing.Size(100, 20);
            this.tbPoruka.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Promeni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 53);
            this.button2.TabIndex = 7;
            this.button2.Text = "Koji je skuplji prozvod";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPoruka);
            this.Controls.Add(this.tbCena2);
            this.Controls.Add(this.tbProizvodjac2);
            this.Controls.Add(this.tbNaziv2);
            this.Controls.Add(this.tbNovaCena);
            this.Controls.Add(this.tbProizvod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProizvod;
        private System.Windows.Forms.TextBox tbNovaCena;
        private System.Windows.Forms.TextBox tbNaziv2;
        private System.Windows.Forms.TextBox tbProizvodjac2;
        private System.Windows.Forms.TextBox tbCena2;
        private System.Windows.Forms.TextBox tbPoruka;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

