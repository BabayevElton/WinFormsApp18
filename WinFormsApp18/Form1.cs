
using System;
using System.Windows.Forms;

namespace WinFormsApp18
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer(), timer2 = new System.Windows.Forms.Timer();
        int[] r = new int[8];
        int xal = 0, reng1 = 0;
        PictureBox p1, p2;
        bool bekle = false;

        string yol = @"C:\Users\M1605YA\Desktop\c#\WinFormsApp18\WinFormsApp18\NewFolder\";

        PictureBox[] pb => new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            YeniOyun();
        }

        string Sekil(int n) => yol + new[] { "", "mavi.png", "qirmizi.png", "sari.jpg", "yasil.png" }[n];

        void YeniOyun()
        {
            int[,] a = {
                {1,2,3,4,4,3,2,1},
                {2,1,4,3,1,4,3,2},
                {3,4,1,2,2,1,4,3}
            };

            int n = new Random().Next(0, 3);
            xal = reng1 = 0;
            p1 = p2 = null;
            bekle = true;
            label2.Text = "0";
            label3.Text = "";

            for (int i = 0; i < 8; i++)
            {
                r[i] = a[n, i];
                pb[i].Enabled = true;
                pb[i].ImageLocation = Sekil(r[i]);
            }

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (var p in pb) p.ImageLocation = yol + "images.jpg";
            bekle = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            p1.ImageLocation = p2.ImageLocation = yol + "images.jpg";
            p1 = p2 = null;
            reng1 = 0;
            label3.Text = "";
            bekle = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            YeniOyun();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Oyundan çıxış edilsinmi?", "Sual",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        void KartAc(PictureBox p, int i)
        {
            if (bekle || p == p1) return;

            p.ImageLocation = Sekil(r[i]);

            if (p1 == null)
            {
                label3.Text = "";
                p1 = p;
                reng1 = r[i];
            }
            else if (reng1 == r[i])
            {
                xal++;
                label2.Text = xal.ToString();
                label3.Text = "✅";
                p1.Enabled = p.Enabled = false;
                p1 = null;

                if (xal == 4)
                    MessageBox.Show("Oyun bitdi! Xalınız: " + xal);
            }
            else
            {
                label3.Text = "❌";
                p2 = p;
                bekle = true;
                timer2.Start();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) => KartAc(pictureBox1, 0);
        private void pictureBox2_Click(object sender, EventArgs e) => KartAc(pictureBox2, 1);
        private void pictureBox3_Click(object sender, EventArgs e) => KartAc(pictureBox3, 2);
        private void pictureBox4_Click(object sender, EventArgs e) => KartAc(pictureBox4, 3);
        private void pictureBox5_Click(object sender, EventArgs e) => KartAc(pictureBox5, 4);
        private void pictureBox6_Click(object sender, EventArgs e) => KartAc(pictureBox6, 5);
        private void pictureBox7_Click(object sender, EventArgs e) => KartAc(pictureBox7, 6);
        private void pictureBox8_Click(object sender, EventArgs e) => KartAc(pictureBox8, 7);
    }
}
