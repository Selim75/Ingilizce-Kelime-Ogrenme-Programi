namespace Kelime_Ogren
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIngilizce = new System.Windows.Forms.TextBox();
            this.TxtTurkce = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.LblSure = new System.Windows.Forms.Label();
            this.LblKelime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblCevap = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce:";
            // 
            // TxtIngilizce
            // 
            this.TxtIngilizce.Location = new System.Drawing.Point(116, 35);
            this.TxtIngilizce.Name = "TxtIngilizce";
            this.TxtIngilizce.Size = new System.Drawing.Size(189, 26);
            this.TxtIngilizce.TabIndex = 10;
            // 
            // TxtTurkce
            // 
            this.TxtTurkce.Location = new System.Drawing.Point(116, 78);
            this.TxtTurkce.Name = "TxtTurkce";
            this.TxtTurkce.Size = new System.Drawing.Size(189, 26);
            this.TxtTurkce.TabIndex = 1;
            this.TxtTurkce.TextChanged += new System.EventHandler(this.TxtTurkce_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Türkçe:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(82, 142);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(46, 18);
            this.Label10.TabIndex = 4;
            this.Label10.Text = "Süre:";
            // 
            // LblSure
            // 
            this.LblSure.AutoSize = true;
            this.LblSure.Location = new System.Drawing.Point(131, 142);
            this.LblSure.Name = "LblSure";
            this.LblSure.Size = new System.Drawing.Size(27, 18);
            this.LblSure.TabIndex = 5;
            this.LblSure.Text = "90";
            // 
            // LblKelime
            // 
            this.LblKelime.AutoSize = true;
            this.LblKelime.Location = new System.Drawing.Point(278, 142);
            this.LblKelime.Name = "LblKelime";
            this.LblKelime.Size = new System.Drawing.Size(18, 18);
            this.LblKelime.TabIndex = 7;
            this.LblKelime.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kelime:";
            // 
            // LblCevap
            // 
            this.LblCevap.AutoSize = true;
            this.LblCevap.Location = new System.Drawing.Point(92, 186);
            this.LblCevap.Name = "LblCevap";
            this.LblCevap.Size = new System.Drawing.Size(50, 18);
            this.LblCevap.TabIndex = 8;
            this.LblCevap.Text = "label3";
            this.LblCevap.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 246);
            this.Controls.Add(this.LblCevap);
            this.Controls.Add(this.LblKelime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblSure);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.TxtTurkce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIngilizce);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Kelime Öğren";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIngilizce;
        private System.Windows.Forms.TextBox TxtTurkce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label LblSure;
        private System.Windows.Forms.Label LblKelime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblCevap;
        private System.Windows.Forms.Timer timer1;
    }
}

