
namespace InstagramGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKadi = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instagram Giriş Ekranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre: ";
            // 
            // tbKadi
            // 
            this.tbKadi.Location = new System.Drawing.Point(113, 78);
            this.tbKadi.Name = "tbKadi";
            this.tbKadi.Size = new System.Drawing.Size(100, 20);
            this.tbKadi.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(112, 119);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // btnGiris
            // 
            this.btnGiris.Image = global::InstagramGiris.Properties.Resources.Ekran_görüntüsü_2024_08_02_155442;
            this.btnGiris.Location = new System.Drawing.Point(35, 145);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnGiris.Size = new System.Drawing.Size(144, 70);
            this.btnGiris.TabIndex = 6;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InstagramGiris.Properties.Resources.kilit;
            this.pictureBox1.Location = new System.Drawing.Point(227, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 164);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 357);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbKadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKadi;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGiris;
    }
}

