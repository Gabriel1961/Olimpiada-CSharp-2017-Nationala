namespace Olimpiada_CSharp_2017_Nationala
{
    partial class FrmVacanta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVacanta));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labDesc = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.labPret = new System.Windows.Forms.Label();
            this.labLocuri = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(930, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.labLocuri);
            this.panel1.Controls.Add(this.labPret);
            this.panel1.Controls.Add(this.labTitle);
            this.panel1.Controls.Add(this.labDesc);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(148, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 560);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(449, 389);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 36);
            this.button4.TabIndex = 8;
            this.button4.Text = "Poster";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Poster);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(25, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 36);
            this.button3.TabIndex = 7;
            this.button3.Text = "Rezerva acum";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.RezervaClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkBox1.Location = new System.Drawing.Point(799, 584);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Autoplay";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.AutoplayChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(27, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 96);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Prev);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(788, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 96);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Next);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labDesc
            // 
            this.labDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labDesc.ForeColor = System.Drawing.Color.White;
            this.labDesc.Location = new System.Drawing.Point(0, 443);
            this.labDesc.Name = "labDesc";
            this.labDesc.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.labDesc.Size = new System.Drawing.Size(622, 117);
            this.labDesc.TabIndex = 9;
            this.labDesc.Text = "label1";
            this.labDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labTitle.ForeColor = System.Drawing.Color.White;
            this.labTitle.Location = new System.Drawing.Point(21, 14);
            this.labTitle.Name = "labTitle";
            this.labTitle.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.labTitle.Size = new System.Drawing.Size(65, 32);
            this.labTitle.TabIndex = 10;
            this.labTitle.Text = "Titlu";
            // 
            // labPret
            // 
            this.labPret.AutoSize = true;
            this.labPret.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labPret.ForeColor = System.Drawing.Color.White;
            this.labPret.Location = new System.Drawing.Point(21, 55);
            this.labPret.Name = "labPret";
            this.labPret.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.labPret.Size = new System.Drawing.Size(63, 32);
            this.labPret.TabIndex = 11;
            this.labPret.Text = "Pret";
            // 
            // labLocuri
            // 
            this.labLocuri.AutoSize = true;
            this.labLocuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labLocuri.ForeColor = System.Drawing.Color.White;
            this.labLocuri.Location = new System.Drawing.Point(21, 94);
            this.labLocuri.Name = "labLocuri";
            this.labLocuri.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.labLocuri.Size = new System.Drawing.Size(82, 32);
            this.labLocuri.TabIndex = 12;
            this.labLocuri.Text = "Locuri";
            // 
            // FrmVacanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 620);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmVacanta";
            this.Text = "FrmVacanta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labDesc;
        private System.Windows.Forms.Label labLocuri;
        private System.Windows.Forms.Label labPret;
        private System.Windows.Forms.Label labTitle;
    }
}