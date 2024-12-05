namespace antoanthongtin_levantien
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            btnCaesar.BackColor = Color.FromArgb(0, 123, 255);
            btnPlayfair.BackColor = Color.FromArgb(0, 123, 255);
            btnAffine.BackColor = Color.FromArgb(0, 123, 255);
            btnVigenere.BackColor = Color.FromArgb(0, 123, 255);
            btnHill.BackColor = Color.FromArgb(0, 123, 255);
            btnHang.BackColor = Color.FromArgb(0, 123, 255);
        }

        private void btnCaesar_Click(object sender, EventArgs e)
        {
            Caesar caesar = new Caesar();
            this.Hide();
            caesar.ShowDialog();
            this.Show();
        }

        private void btnPlayfair_Click(object sender, EventArgs e)
        {
            Playfair playfair = new Playfair();
            this.Hide();
            playfair.ShowDialog();
            this.Show();
        }

        private void btnAffine_Click(object sender, EventArgs e)
        {
            Affine affine = new Affine();
            this.Hide();
            affine.ShowDialog();
            this.Show();
        }

        private void btnVigenere_Click(object sender, EventArgs e)
        {
            Vigenere vigenere = new Vigenere();
            this.Hide();
            vigenere.ShowDialog();
            this.Show();
        }

        private void btnHill_Click(object sender, EventArgs e)
        {
            //Hill hill = new Hill();
            Hill_Elite_ hill = new Hill_Elite_();
            this.Hide();
            hill.ShowDialog();
            this.Show();
        }

        private void btnHang_Click(object sender, EventArgs e)
        {
            Hang hang = new Hang();
            this.Hide();
            hang.ShowDialog();
            this.Show();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int x = btnChon.Location.X;
            int y = btnChon.Location.Y;
            if (btnChon.Text == "Chọn")
            {
                btnCaesar.Location = new Point(x - 120, y - 107);
                btnPlayfair.Location = new Point(x + 120, y - 107);
                btnAffine.Location = new Point(x + 240, y);
                btnVigenere.Location = new Point(x + 120, y + 107);
                btnHill.Location = new Point(x - 120, y + 107);
                btnHang.Location = new Point(x - 240, y);

                btnChon.Text = "Hủy";
            }
            else
            {
                btnCaesar.Location = new Point(x, y);
                btnPlayfair.Location = new Point(x, y);
                btnAffine.Location = new Point(x, y);
                btnVigenere.Location = new Point(x, y);
                btnHill.Location = new Point(x, y);
                btnHang.Location = new Point(x, y);

                btnChon.Text = "Chọn";
            }

            btnCaesar.BackColor = Color.FromArgb(0, 123, 255);
            btnPlayfair.BackColor = Color.FromArgb(0, 123, 255);
            btnAffine.BackColor = Color.FromArgb(0, 123, 255);
            btnVigenere.BackColor = Color.FromArgb(0, 123, 255);
            btnHill.BackColor = Color.FromArgb(0, 123, 255);
            btnHang.BackColor = Color.FromArgb(0, 123, 255);
        }

        private void btnCaesar_MouseEnter(object sender, EventArgs e)
        {
            if (btnCaesar.BackColor == Color.FromArgb(0, 123, 255))
            {
                btnCaesar.BackColor = Color.FromArgb(40, 167, 69);
            }
            else
            {
                btnCaesar.BackColor = Color.FromArgb(0, 123, 255);
            }
        }

        private void btnPlayfair_MouseEnter(object sender, EventArgs e)
        {
            if (btnPlayfair.BackColor == Color.FromArgb(0, 123, 255))
            {
                btnPlayfair.BackColor = Color.FromArgb(40, 167, 69);
            }
            else
            {
                btnPlayfair.BackColor = Color.FromArgb(0, 123, 255);
            }
        }

        private void btnAffine_MouseEnter(object sender, EventArgs e)
        {
            if (btnAffine.BackColor == Color.FromArgb(0, 123, 255))
            {
                btnAffine.BackColor = Color.FromArgb(40, 167, 69);
            }
            else
            {
                btnAffine.BackColor = Color.FromArgb(0, 123, 255);
            }
        }

        private void btnVigenere_MouseEnter(object sender, EventArgs e)
        {
            if (btnVigenere.BackColor == Color.FromArgb(0, 123, 255))
            {
                btnVigenere.BackColor = Color.FromArgb(40, 167, 69);
            }
            else
            {
                btnVigenere.BackColor = Color.FromArgb(0, 123, 255);
            }
        }

        private void btnHill_MouseEnter(object sender, EventArgs e)
        {
            if (btnHill.BackColor == Color.FromArgb(0, 123, 255))
            {
                btnHill.BackColor = Color.FromArgb(40, 167, 69);
            }
            else
            {
                btnHill.BackColor = Color.FromArgb(0, 123, 255);
            }
        }

        private void btnHang_MouseEnter(object sender, EventArgs e)
        {
            if (btnHang.BackColor == Color.FromArgb(0, 123, 255))
            {
                btnHang.BackColor = Color.FromArgb(40, 167, 69);
            }
            else
            {
                btnHang.BackColor = Color.FromArgb(0, 123, 255);
            }
        }

        private void btnChon_Resize(object sender, EventArgs e)
        {
            btnCaesar.Size = new Size(120, 40);
            btnPlayfair.Size = new Size(120, 40);
            btnAffine.Size = new Size(120, 40);
            btnVigenere.Size = new Size(120, 40);
            btnHill.Size = new Size(120, 40);
            btnHang.Size = new Size(120, 40);
            btnChon.Size = new Size(120, 40);


            btnCaesar.Location = new Point(this.Width / 2, this.Height / 2);
            btnPlayfair.Location = new Point(this.Width / 2, this.Height / 2);
            btnAffine.Location = new Point(this.Width / 2, this.Height / 2);
            btnVigenere.Location = new Point(this.Width / 2, this.Height / 2);
            btnHill.Location = new Point(this.Width / 2, this.Height / 2);
            btnHang.Location = new Point(this.Width / 2, this.Height / 2);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void caesarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caesar caesar = new Caesar();
            this.Hide();
            caesar.ShowDialog();
            this.Show();
        }

        private void playfairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Playfair playfair = new Playfair();
            this.Hide();
            playfair.ShowDialog();
            this.Show();
        }

        private void affineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Affine affine = new Affine();
            this.Hide();
            affine.ShowDialog();
            this.Show();
        }

        private void vigenèreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vigenere vigenere = new Vigenere();
            this.Hide();
            vigenere.ShowDialog();
            this.Show();
        }

        private void hillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hill hill = new Hill();
            Hill_Elite_ hill = new Hill_Elite_();
            this.Hide();
            hill.ShowDialog();
            this.Show();
        }

        private void hàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hang hang = new Hang();
            this.Hide();
            hang.ShowDialog();
            this.Show();
        }

        private void rSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RSA rsa = new RSA();
            this.Hide();
            rsa.ShowDialog();
            this.Show();
        }

        private void deffineHellmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void dESToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
