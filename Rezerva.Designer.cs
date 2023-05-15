namespace Olimpiada_CSharp_2017_Nationala
{
    partial class Rezerva
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
            this.labLocuri = new System.Windows.Forms.Label();
            this.labPret = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.labDesc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labPretTotal = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labLocuri
            // 
            this.labLocuri.AutoSize = true;
            this.labLocuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labLocuri.ForeColor = System.Drawing.Color.Black;
            this.labLocuri.Location = new System.Drawing.Point(367, 29);
            this.labLocuri.Name = "labLocuri";
            this.labLocuri.Size = new System.Drawing.Size(62, 24);
            this.labLocuri.TabIndex = 16;
            this.labLocuri.Text = "Locuri";
            // 
            // labPret
            // 
            this.labPret.AutoSize = true;
            this.labPret.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labPret.ForeColor = System.Drawing.Color.Black;
            this.labPret.Location = new System.Drawing.Point(205, 29);
            this.labPret.Name = "labPret";
            this.labPret.Size = new System.Drawing.Size(43, 24);
            this.labPret.TabIndex = 15;
            this.labPret.Text = "Pret";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labTitle.ForeColor = System.Drawing.Color.Black;
            this.labTitle.Location = new System.Drawing.Point(33, 29);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(45, 24);
            this.labTitle.TabIndex = 14;
            this.labTitle.Text = "Titlu";
            // 
            // labDesc
            // 
            this.labDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labDesc.ForeColor = System.Drawing.Color.Black;
            this.labDesc.Location = new System.Drawing.Point(33, 156);
            this.labDesc.Name = "labDesc";
            this.labDesc.Size = new System.Drawing.Size(748, 111);
            this.labDesc.TabIndex = 13;
            this.labDesc.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox1.Location = new System.Drawing.Point(232, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 29);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nr locuri de rezervat";
            // 
            // labPretTotal
            // 
            this.labPretTotal.AutoSize = true;
            this.labPretTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labPretTotal.ForeColor = System.Drawing.Color.Black;
            this.labPretTotal.Location = new System.Drawing.Point(33, 113);
            this.labPretTotal.Name = "labPretTotal";
            this.labPretTotal.Size = new System.Drawing.Size(81, 24);
            this.labPretTotal.TabIndex = 19;
            this.labPretTotal.Text = "Pret total";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(441, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 20;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(719, 102);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 21;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(489, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Data Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(777, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Data Final";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.Location = new System.Drawing.Point(806, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 36);
            this.button1.TabIndex = 24;
            this.button1.Text = "Confirma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Confirma);
            // 
            // Rezerva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 267);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labPretTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labLocuri);
            this.Controls.Add(this.labPret);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.labDesc);
            this.Name = "Rezerva";
            this.Text = "Rezerva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLocuri;
        private System.Windows.Forms.Label labPret;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labDesc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labPretTotal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}