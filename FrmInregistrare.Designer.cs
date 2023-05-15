namespace Olimpiada_CSharp_2017_Nationala
{
    partial class FrmInregistrare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInregistrare));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbParola = new System.Windows.Forms.TextBox();
            this.tbConfirmParola = new System.Windows.Forms.TextBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(67, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 170);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(33, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(33, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(33, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(33, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Parola";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(33, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 52);
            this.label5.TabIndex = 6;
            this.label5.Text = "Confirmare Parola:";
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(67, 460);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 104);
            this.panel2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(33, 583);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cod captcha:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.Location = new System.Drawing.Point(37, 628);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Renunta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Renunta);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button2.Location = new System.Drawing.Point(244, 628);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Inregistrare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Inregistrare);
            // 
            // tbNume
            // 
            this.tbNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbNume.Location = new System.Drawing.Point(148, 227);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(238, 29);
            this.tbNume.TabIndex = 10;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbPrenume.Location = new System.Drawing.Point(148, 267);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(238, 29);
            this.tbPrenume.TabIndex = 11;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbEmail.Location = new System.Drawing.Point(148, 307);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(238, 29);
            this.tbEmail.TabIndex = 12;
            // 
            // tbParola
            // 
            this.tbParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbParola.Location = new System.Drawing.Point(148, 347);
            this.tbParola.Name = "tbParola";
            this.tbParola.PasswordChar = '●';
            this.tbParola.Size = new System.Drawing.Size(238, 29);
            this.tbParola.TabIndex = 13;
            // 
            // tbConfirmParola
            // 
            this.tbConfirmParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbConfirmParola.Location = new System.Drawing.Point(148, 410);
            this.tbConfirmParola.Name = "tbConfirmParola";
            this.tbConfirmParola.PasswordChar = '●';
            this.tbConfirmParola.Size = new System.Drawing.Size(238, 29);
            this.tbConfirmParola.TabIndex = 14;
            // 
            // tbCod
            // 
            this.tbCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbCod.Location = new System.Drawing.Point(160, 580);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(226, 29);
            this.tbCod.TabIndex = 15;
            // 
            // FrmInregistrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 676);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.tbConfirmParola);
            this.Controls.Add(this.tbParola);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmInregistrare";
            this.Text = "FrmInregistrare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbParola;
        private System.Windows.Forms.TextBox tbConfirmParola;
        private System.Windows.Forms.TextBox tbCod;
    }
}