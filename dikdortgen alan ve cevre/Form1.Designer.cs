namespace dikdortgen_alan_ve_cevre
{
    partial class lblKenar2
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
            this.lblKenar1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAlan = new System.Windows.Forms.Label();
            this.lblCevre = new System.Windows.Forms.Label();
            this.txtKenar1 = new System.Windows.Forms.TextBox();
            this.txtKenar2 = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKenar1
            // 
            this.lblKenar1.AutoSize = true;
            this.lblKenar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKenar1.Location = new System.Drawing.Point(46, 83);
            this.lblKenar1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKenar1.Name = "lblKenar1";
            this.lblKenar1.Size = new System.Drawing.Size(111, 25);
            this.lblKenar1.TabIndex = 0;
            this.lblKenar1.Text = "kısa kenar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "uzun kenar";
            // 
            // lblAlan
            // 
            this.lblAlan.AutoSize = true;
            this.lblAlan.Location = new System.Drawing.Point(46, 423);
            this.lblAlan.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(53, 25);
            this.lblAlan.TabIndex = 2;
            this.lblAlan.Text = "alan";
            // 
            // lblCevre
            // 
            this.lblCevre.AutoSize = true;
            this.lblCevre.Location = new System.Drawing.Point(46, 368);
            this.lblCevre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCevre.Name = "lblCevre";
            this.lblCevre.Size = new System.Drawing.Size(65, 25);
            this.lblCevre.TabIndex = 3;
            this.lblCevre.Text = "cevre";
            // 
            // txtKenar1
            // 
            this.txtKenar1.Location = new System.Drawing.Point(179, 80);
            this.txtKenar1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtKenar1.Name = "txtKenar1";
            this.txtKenar1.Size = new System.Drawing.Size(196, 31);
            this.txtKenar1.TabIndex = 4;
            this.txtKenar1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKenar2
            // 
            this.txtKenar2.Location = new System.Drawing.Point(177, 156);
            this.txtKenar2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtKenar2.Name = "txtKenar2";
            this.txtKenar2.Size = new System.Drawing.Size(196, 31);
            this.txtKenar2.TabIndex = 5;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(27, 254);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(348, 47);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "alan ve cevre hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblKenar2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtKenar2);
            this.Controls.Add(this.txtKenar1);
            this.Controls.Add(this.lblCevre);
            this.Controls.Add(this.lblAlan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKenar1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "lblKenar2";
            this.Text = "uzun kenar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKenar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAlan;
        private System.Windows.Forms.Label lblCevre;
        private System.Windows.Forms.TextBox txtKenar1;
        private System.Windows.Forms.TextBox txtKenar2;
        private System.Windows.Forms.Button btnHesapla;
    }
}

