namespace WinFormsApp18
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();

            // pictureBox1
            pictureBox1.Location = new Point(60, 30);
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Click += pictureBox1_Click;
            // pictureBox2
            pictureBox2.Location = new Point(280, 30);
            pictureBox2.Size = new Size(150, 150);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Click += pictureBox2_Click;
            // pictureBox3
            pictureBox3.Location = new Point(500, 30);
            pictureBox3.Size = new Size(150, 150);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Click += pictureBox3_Click;
            // pictureBox4
            pictureBox4.Location = new Point(720, 30);
            pictureBox4.Size = new Size(150, 150);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Click += pictureBox4_Click;
            // pictureBox5
            pictureBox5.Location = new Point(60, 210);
            pictureBox5.Size = new Size(150, 150);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Click += pictureBox5_Click;
            // pictureBox6
            pictureBox6.Location = new Point(280, 210);
            pictureBox6.Size = new Size(150, 150);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Click += pictureBox6_Click;
            // pictureBox7
            pictureBox7.Location = new Point(500, 210);
            pictureBox7.Size = new Size(150, 150);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.Click += pictureBox7_Click;
            // pictureBox8
            pictureBox8.Location = new Point(720, 210);
            pictureBox8.Size = new Size(150, 150);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.Click += pictureBox8_Click;

            // label1 (Xal:)
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(60, 400);
            label1.Text = "Xal:";
            // label2 (xal rəqəmi)
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(140, 400);
            label2.Text = "0";
            // label3 (✅ / ❌)
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 28F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(330, 385);
            label3.Text = "";

            // button1 (Yeni oyun)
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(500, 395);
            button1.Size = new Size(150, 45);
            button1.Text = "Yeni oyun";
            button1.Click += button1_Click;
            // button2 (Çıxış)
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(720, 395);
            button2.Size = new Size(150, 45);
            button2.Text = "Çıxış";
            button2.Click += button2_Click;

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(930, 480);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox8);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Memory game";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}