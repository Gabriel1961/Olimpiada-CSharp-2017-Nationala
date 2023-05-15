using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olimpiada_CSharp_2017_Nationala
{
    public partial class FrmVacanta : Form
    {
        Utilizator ut;
        public bool deconectat;
        List<(Bitmap, Vacanta)> vacante = new List<(Bitmap, Vacanta)>();
        Bitmap defaultImage;
        int idx = 0;

        
        float Luminozitate2(Color c)
        {
            return (float)(0.241f * c.R * c.R + 0.691f * c.G * c.G + 0.068f * c.B * c.B);
        }

        void SetDarkest(string text,Bitmap bmp)
        {
            int w = text.Length * 10;
            int h = 30;
            float mn = float.PositiveInfinity;
            int mnx=0, mny=0;

            float[,] img = new float[bmp.Width+1, bmp.Height+1];

            for (int x = 1; x <= bmp.Width; x++)
                for (int y = 1; y <= bmp.Height; y++)
                {
                    img[x,y] = img[x-1,y] + img[x,y-1] - img[x-1,y-1] + Luminozitate2(bmp.GetPixel(x-1, y-1));
                }

            for (int x = 1; x <= bmp.Width-w+1; x++)
                for (int y = 1; y <= bmp.Height-h+1; y++)
                {
                    int x1 = x + w - 1;
                    int y1 = y + h - 1;
                    float val = img[x1,y1] - img[x-1,y1] - img[x1,y-1] + img[x - 1,y-1];
                    if(mn > val)
                    {
                        mn = val;
                        mnx = x - 1;
                        mny = y - 1;
                        }
                }

            var cl = (Bitmap)bmp.Clone(new Rectangle(0,0,bmp.Width,bmp.Height),System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            var g = Graphics.FromImage(cl);
            g.DrawString(text,Font,Brushes.White,new RectangleF(mnx,mny,w,h), new StringFormat(StringFormatFlags.NoWrap));
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Image files (*.png)|*.png";
            sf.FileOk += (s, ev) =>
            {
                var f = sf.OpenFile();
                cl.Save(f, ImageFormat.Png);
                f.Close();
                f.Dispose();
            };
            sf.ShowDialog();
        }

        void LoadVacante()
        {
            vacante.Clear();
            var files = Directory.GetFiles("../../resurse/Imagini");
            Dictionary<string, Bitmap> poze = new Dictionary<string, Bitmap>();
            foreach(var f in files)
            {
                var tit = new FileInfo(f);
                poze.Add(tit.Name.Replace(tit.Extension,""),new Bitmap(f));
            }
            foreach(var v in Program.db.Vacante)
            {
                if (v.CaleFisier != null)
                    if (poze.ContainsKey(v.CaleFisier))
                    {
                        vacante.Add((poze[v.CaleFisier], v));
                        continue;
                    }
                
                vacante.Add((defaultImage, v));
            }
            idx = 0;
            SetIdxData();
        }

        public FrmVacanta(Utilizator ut)
        {
            defaultImage = new Bitmap("../../resurse/Imagini/implicit.jpg");
            this.ut = ut;
            InitializeComponent();
            if (ut.TipCont == 0)
            {
                var tsFile = new ToolStripMenuItem("File");
                var di1 = new ToolStripMenuItem("Adauga Admin Nou");
                di1.Click += (s, ev) => new TransformaAdmin().ShowDialog();
                var di2 = new ToolStripMenuItem("Adauga Vacante Noi");
                di2.Click += (s, ev) => { new ModificaVacante().ShowDialog(); this.LoadVacante(); Program.db.Rezervari.Clear(); };
                tsFile.DropDownItems.Add(di1);
                tsFile.DropDownItems.Add(di2);
                menuStrip1.Items.Add(tsFile);
            }

            var tsEm = new ToolStripMenuItem(ut.Email);
            var ddi1 = new ToolStripMenuItem("Deconectare");
            var ddi2 = new ToolStripMenuItem("Iesire");
            ddi1.Click += (s, ev) => { deconectat = true; this.Close(); } ;
            ddi2.Click += (s, ev) => this.Close();

            tsEm.DropDownItems.Add(ddi1);
            tsEm.DropDownItems.Add(ddi2);
            
            var tsVac = new ToolStripMenuItem("Vacantele Mele");
            tsVac.Click += (s, ev) => { new VacanteleMele(ut).ShowDialog(); };
            menuStrip1.Items.Add(tsVac);    
            menuStrip1.Items.Add(tsEm);

            tmr = new Timer();
            tmr.Tick += Tmr_Tick;
            tmr.Interval = 2000;
            LoadVacante();
            var semi = Color.FromArgb(170, Color.Black);
            labDesc.BackColor = semi;
            labLocuri.BackColor = semi;
            labPret.BackColor = semi;
            labTitle.BackColor = semi;
            button3.BackColor = semi;
            button4.BackColor = semi;

        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            Next(null, null);
        }

        Timer tmr;

        private void AutoplayChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tmr.Start();
            }
            else 
            {
                tmr.Stop();
            }
        }

        void SetIdxData()
        {
            var v = vacante[idx].Item2;
            panel1.BackgroundImage = vacante[idx].Item1;
            labTitle.Text = v.NumeVacanta;
            labDesc.Text = v.Descriere;
            labPret.Text = v.Pret.ToString("0.00");
            labLocuri.Text = $"{v.NrLocuri} Locuri";
        }

        private void Prev(object sender, EventArgs e)
        {
            idx--;
            idx = (idx + vacante.Count)%vacante.Count;
            SetIdxData();
        }

        private void Next(object sender, EventArgs e)
        {
            idx++;
            idx %= vacante.Count;
            SetIdxData();
        }

        private void RezervaClick(object sender, EventArgs e)
        {
            new Rezerva(ut, vacante[idx].Item2).ShowDialog();
        }

        private void Poster(object sender, EventArgs e)
        {
            SetDarkest(vacante[idx].Item2.NumeVacanta, vacante[idx].Item1);
        }
    }
}
