
namespace HuisBerekenen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLengte = new System.Windows.Forms.Label();
            this.lblBreedte = new System.Windows.Forms.Label();
            this.lblHoogte = new System.Windows.Forms.Label();
            this.lblVerdiepingen = new System.Windows.Forms.Label();
            this.lblOppervlakte = new System.Windows.Forms.Label();
            this.lblTotaleOppervlakte = new System.Windows.Forms.Label();
            this.lblInhoud = new System.Windows.Forms.Label();
            this.lblTotaleInhoud = new System.Windows.Forms.Label();
            this.lblResultaatOppervlakte = new System.Windows.Forms.Label();
            this.lblResultaatTotaleOppervlakte = new System.Windows.Forms.Label();
            this.lblResultaatInhoud = new System.Windows.Forms.Label();
            this.lblResultaatTotaleInhoud = new System.Windows.Forms.Label();
            this.txbLengte = new System.Windows.Forms.TextBox();
            this.txbBreedte = new System.Windows.Forms.TextBox();
            this.txbHoogte = new System.Windows.Forms.TextBox();
            this.txbVerdiepingen = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLengte
            // 
            this.lblLengte.AutoSize = true;
            this.lblLengte.Location = new System.Drawing.Point(82, 122);
            this.lblLengte.Name = "lblLengte";
            this.lblLengte.Size = new System.Drawing.Size(114, 15);
            this.lblLengte.TabIndex = 0;
            this.lblLengte.Text = "Lengte Woonkamer:";
            // 
            // lblBreedte
            // 
            this.lblBreedte.AutoSize = true;
            this.lblBreedte.Location = new System.Drawing.Point(78, 163);
            this.lblBreedte.Name = "lblBreedte";
            this.lblBreedte.Size = new System.Drawing.Size(118, 15);
            this.lblBreedte.TabIndex = 1;
            this.lblBreedte.Text = "Breedte Woonkamer:";
            // 
            // lblHoogte
            // 
            this.lblHoogte.AutoSize = true;
            this.lblHoogte.Location = new System.Drawing.Point(82, 206);
            this.lblHoogte.Name = "lblHoogte";
            this.lblHoogte.Size = new System.Drawing.Size(118, 15);
            this.lblHoogte.TabIndex = 2;
            this.lblHoogte.Text = "Hoogte Woonkamer:";
            // 
            // lblVerdiepingen
            // 
            this.lblVerdiepingen.AutoSize = true;
            this.lblVerdiepingen.Location = new System.Drawing.Point(82, 243);
            this.lblVerdiepingen.Name = "lblVerdiepingen";
            this.lblVerdiepingen.Size = new System.Drawing.Size(116, 15);
            this.lblVerdiepingen.TabIndex = 3;
            this.lblVerdiepingen.Text = "Aantal Verdiepingen:";
            // 
            // lblOppervlakte
            // 
            this.lblOppervlakte.AutoSize = true;
            this.lblOppervlakte.Location = new System.Drawing.Point(443, 122);
            this.lblOppervlakte.Name = "lblOppervlakte";
            this.lblOppervlakte.Size = new System.Drawing.Size(153, 15);
            this.lblOppervlakte.TabIndex = 4;
            this.lblOppervlakte.Text = "Oppervlakte per verdieping:";
            // 
            // lblTotaleOppervlakte
            // 
            this.lblTotaleOppervlakte.AutoSize = true;
            this.lblTotaleOppervlakte.Location = new System.Drawing.Point(426, 163);
            this.lblTotaleOppervlakte.Name = "lblTotaleOppervlakte";
            this.lblTotaleOppervlakte.Size = new System.Drawing.Size(170, 15);
            this.lblTotaleOppervlakte.TabIndex = 5;
            this.lblTotaleOppervlakte.Text = "Totale oppervlakte van het huis";
            // 
            // lblInhoud
            // 
            this.lblInhoud.AutoSize = true;
            this.lblInhoud.Location = new System.Drawing.Point(428, 206);
            this.lblInhoud.Name = "lblInhoud";
            this.lblInhoud.Size = new System.Drawing.Size(168, 15);
            this.lblInhoud.TabIndex = 6;
            this.lblInhoud.Text = "De inhoud van een verdieping:";
            // 
            // lblTotaleInhoud
            // 
            this.lblTotaleInhoud.AutoSize = true;
            this.lblTotaleInhoud.Location = new System.Drawing.Point(439, 243);
            this.lblTotaleInhoud.Name = "lblTotaleInhoud";
            this.lblTotaleInhoud.Size = new System.Drawing.Size(157, 15);
            this.lblTotaleInhoud.TabIndex = 7;
            this.lblTotaleInhoud.Text = "De inhoud van de woning is:";
            // 
            // lblResultaatOppervlakte
            // 
            this.lblResultaatOppervlakte.AutoSize = true;
            this.lblResultaatOppervlakte.Location = new System.Drawing.Point(629, 122);
            this.lblResultaatOppervlakte.Name = "lblResultaatOppervlakte";
            this.lblResultaatOppervlakte.Size = new System.Drawing.Size(43, 15);
            this.lblResultaatOppervlakte.TabIndex = 8;
            this.lblResultaatOppervlakte.Text = "000000";
            // 
            // lblResultaatTotaleOppervlakte
            // 
            this.lblResultaatTotaleOppervlakte.AutoSize = true;
            this.lblResultaatTotaleOppervlakte.Location = new System.Drawing.Point(629, 163);
            this.lblResultaatTotaleOppervlakte.Name = "lblResultaatTotaleOppervlakte";
            this.lblResultaatTotaleOppervlakte.Size = new System.Drawing.Size(43, 15);
            this.lblResultaatTotaleOppervlakte.TabIndex = 9;
            this.lblResultaatTotaleOppervlakte.Text = "000000";
            // 
            // lblResultaatInhoud
            // 
            this.lblResultaatInhoud.AutoSize = true;
            this.lblResultaatInhoud.Location = new System.Drawing.Point(629, 206);
            this.lblResultaatInhoud.Name = "lblResultaatInhoud";
            this.lblResultaatInhoud.Size = new System.Drawing.Size(43, 15);
            this.lblResultaatInhoud.TabIndex = 10;
            this.lblResultaatInhoud.Text = "000000";
            // 
            // lblResultaatTotaleInhoud
            // 
            this.lblResultaatTotaleInhoud.AutoSize = true;
            this.lblResultaatTotaleInhoud.Location = new System.Drawing.Point(629, 243);
            this.lblResultaatTotaleInhoud.Name = "lblResultaatTotaleInhoud";
            this.lblResultaatTotaleInhoud.Size = new System.Drawing.Size(43, 15);
            this.lblResultaatTotaleInhoud.TabIndex = 11;
            this.lblResultaatTotaleInhoud.Text = "000000";
            // 
            // txbLengte
            // 
            this.txbLengte.Location = new System.Drawing.Point(209, 119);
            this.txbLengte.Name = "txbLengte";
            this.txbLengte.Size = new System.Drawing.Size(100, 23);
            this.txbLengte.TabIndex = 12;
            // 
            // txbBreedte
            // 
            this.txbBreedte.Location = new System.Drawing.Point(209, 160);
            this.txbBreedte.Name = "txbBreedte";
            this.txbBreedte.Size = new System.Drawing.Size(100, 23);
            this.txbBreedte.TabIndex = 13;
            // 
            // txbHoogte
            // 
            this.txbHoogte.Location = new System.Drawing.Point(209, 203);
            this.txbHoogte.Name = "txbHoogte";
            this.txbHoogte.Size = new System.Drawing.Size(100, 23);
            this.txbHoogte.TabIndex = 14;
            // 
            // txbVerdiepingen
            // 
            this.txbVerdiepingen.Location = new System.Drawing.Point(209, 240);
            this.txbVerdiepingen.Name = "txbVerdiepingen";
            this.txbVerdiepingen.Size = new System.Drawing.Size(100, 23);
            this.txbVerdiepingen.TabIndex = 15;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(209, 292);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(75, 23);
            this.btnBereken.TabIndex = 16;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.BtnBereken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txbVerdiepingen);
            this.Controls.Add(this.txbHoogte);
            this.Controls.Add(this.txbBreedte);
            this.Controls.Add(this.txbLengte);
            this.Controls.Add(this.lblResultaatTotaleInhoud);
            this.Controls.Add(this.lblResultaatInhoud);
            this.Controls.Add(this.lblResultaatTotaleOppervlakte);
            this.Controls.Add(this.lblResultaatOppervlakte);
            this.Controls.Add(this.lblTotaleInhoud);
            this.Controls.Add(this.lblInhoud);
            this.Controls.Add(this.lblTotaleOppervlakte);
            this.Controls.Add(this.lblOppervlakte);
            this.Controls.Add(this.lblVerdiepingen);
            this.Controls.Add(this.lblHoogte);
            this.Controls.Add(this.lblBreedte);
            this.Controls.Add(this.lblLengte);
            this.Name = "Form1";
            this.Text = "Berekenen Huis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLengte;
        private System.Windows.Forms.Label lblBreedte;
        private System.Windows.Forms.Label lblHoogte;
        private System.Windows.Forms.Label lblVerdiepingen;
        private System.Windows.Forms.Label lblOppervlakte;
        private System.Windows.Forms.Label lblTotaleOppervlakte;
        private System.Windows.Forms.Label lblInhoud;
        private System.Windows.Forms.Label lblTotaleInhoud;
        private System.Windows.Forms.Label lblResultaatOppervlakte;
        private System.Windows.Forms.Label lblResultaatTotaleOppervlakte;
        private System.Windows.Forms.Label lblResultaatInhoud;
        private System.Windows.Forms.Label lblResultaatTotaleInhoud;
        private System.Windows.Forms.TextBox txbLengte;
        private System.Windows.Forms.TextBox txbBreedte;
        private System.Windows.Forms.TextBox txbHoogte;
        private System.Windows.Forms.TextBox txbVerdiepingen;
        private System.Windows.Forms.Button btnBereken;
    }
}

