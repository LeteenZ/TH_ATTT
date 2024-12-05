using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace antoanthongtin_levantien
{
    public partial class Hill : Form
    {
        //biến thông báo lỗi
        string loi = "";
        public Hill()
        {
            InitializeComponent();
            //tắt phóng to, thu nhỏ của form
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            bac3(false);
        }

        public void bac3(bool tg)
        {
            txtK13.Visible = tg;
            txtK23.Visible = tg;
            txtK31.Visible = tg;
            txtK32.Visible = tg;
            txtK33.Visible = tg;
        }

        private void mởFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bậc3ToolStripMenuItem.Text == "Bậc 3")
            {
                try
                {
                    openFileDialog1.Filter = "Text Files|*.txt";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        StreamReader sr = new StreamReader(openFileDialog1.FileName);
                        txtBan1.Text = sr.ReadLine();
                        string[] line1 = sr.ReadLine().Split(' ');
                        string[] line2 = sr.ReadLine().Split(' ');
                        txtK11.Text = line1[0];
                        txtK12.Text = line1[1];
                        txtK21.Text = line2[0];
                        txtK22.Text = line2[1];
                        sr.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Đọc thất bại!");
                }
            }
            else
            {
                try
                {
                    openFileDialog1.Filter = "Text Files|*.txt";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        StreamReader sr = new StreamReader(openFileDialog1.FileName);
                        txtBan1.Text = sr.ReadLine();
                        string[] line1 = sr.ReadLine().Split(' ');
                        string[] line2 = sr.ReadLine().Split(' ');
                        string[] line3 = sr.ReadLine().Split(' ');
                        txtK11.Text = line1[0];
                        txtK12.Text = line1[1];
                        txtK13.Text = line1[2];
                        txtK21.Text = line2[0];
                        txtK22.Text = line2[1];
                        txtK23.Text = line2[2];
                        txtK31.Text = line3[0];
                        txtK32.Text = line3[1];
                        txtK33.Text = line3[2];
                        sr.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Đọc thất bại!");
                }
            }
        }

        private void lưuFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bậc3ToolStripMenuItem.Text == "Bậc 3")
            {
                try
                {
                    saveFileDialog1.Filter = "Text Files | *.txt";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter sw = File.CreateText(saveFileDialog1.FileName);
                        sw.WriteLine(txtBan1.Text);
                        sw.WriteLine(txtK11.Text + " " + txtK12.Text);
                        sw.WriteLine(txtK21.Text + " " + txtK22.Text);
                        sw.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lưu thất bại!");
                }
            }
            else
            {
                try
                {
                    saveFileDialog1.Filter = "Text Files | *.txt";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter sw = File.CreateText(saveFileDialog1.FileName);
                        sw.WriteLine(txtBan1.Text);
                        sw.WriteLine(txtK11.Text + " " + txtK12.Text + " " + txtK13.Text);
                        sw.WriteLine(txtK21.Text + " " + txtK22.Text + " " + txtK23.Text);
                        sw.WriteLine(txtK31.Text + " " + txtK32.Text + " " + txtK33.Text);
                        sw.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lưu thất bại!");
                }
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //về lại menu
            this.Close();
        }
        public bool kiemTra()
        {
            //kiểm tra nếu đầu vào rỗng
            if (bậc3ToolStripMenuItem.Text == "Bậc 3")
            {
                if (string.IsNullOrEmpty(txtBan1.Text) || string.IsNullOrEmpty(txtK11.Text) || string.IsNullOrEmpty(txtK12.Text) || string.IsNullOrEmpty(txtK21.Text) || string.IsNullOrEmpty(txtK22.Text))
                {
                    loi = "Vui lòng nhập đầy đủ thông tin";
                    return false;
                }
                try
                {
                    //kiểm tra nếu khóa không phải số nguyên
                    int a = Convert.ToInt32(txtK11.Text);
                    a = Convert.ToInt32(txtK12.Text);
                    a = Convert.ToInt32(txtK21.Text);
                    a = Convert.ToInt32(txtK22.Text);
                    return true;
                }
                catch (Exception)
                {
                    loi = "Vui lòng nhập lại khóa theo kiểu số nguyên";
                    return false;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtBan1.Text) || string.IsNullOrEmpty(txtK11.Text) || string.IsNullOrEmpty(txtK12.Text) || string.IsNullOrEmpty(txtK21.Text) || string.IsNullOrEmpty(txtK22.Text) || string.IsNullOrEmpty(txtK23.Text) || string.IsNullOrEmpty(txtK13.Text) || string.IsNullOrEmpty(txtK31.Text) || string.IsNullOrEmpty(txtK32.Text) || string.IsNullOrEmpty(txtK33.Text))
                {
                    loi = "Vui lòng nhập đầy đủ thông tin";
                    return false;
                }
                try
                {
                    //kiểm tra nếu khóa không phải số nguyên
                    int a = Convert.ToInt32(txtK11.Text);
                    a = Convert.ToInt32(txtK12.Text);
                    a = Convert.ToInt32(txtK21.Text);
                    a = Convert.ToInt32(txtK22.Text);
                    a = Convert.ToInt32(txtK23.Text);
                    a = Convert.ToInt32(txtK13.Text);
                    a = Convert.ToInt32(txtK31.Text);
                    a = Convert.ToInt32(txtK32.Text);
                    a = Convert.ToInt32(txtK33.Text);
                    return true;
                }
                catch (Exception)
                {
                    loi = "Vui lòng nhập lại khóa theo kiểu số nguyên";
                    return false;
                }
            }
        }

        public void xoaText()
        {
            //xóa dữ liệu đã nhập vào
            txtBan1.Text = "";
            txtBan2.Text = "";
            if (bậc3ToolStripMenuItem.Text == "Bậc 3")
            {
                txtK11.Text = "";
                txtK21.Text = "";
                txtK12.Text = "";
                txtK22.Text = "";
            }
            else
            {
                txtK11.Text = "";
                txtK21.Text = "";
                txtK12.Text = "";
                txtK22.Text = "";
                txtK13.Text = "";
                txtK23.Text = "";
                txtK31.Text = "";
                txtK32.Text = "";
                txtK33.Text = "";
            }
        }
        public int gcd(int x, int y)
        {
            //tìm ước chung lớn nhất
            while (x != y)
            {
                if (x > y)
                    x -= y;
                else
                    y -= x;
            }
            return x;
        }
        public int euclide(int a, int b)
        {
            int q1 = a, q2 = b, t1 = 0, t2 = 1, r = 0, temp = 0;
            while (q2 != 0)
            {
                r = q1 / q2;
                temp = q2;
                q2 = q1 - q2 * r;
                q1 = temp;

                temp = t2;
                t2 = t1 - t2 * r;
                t1 = temp;
            }
            if (t1 < 0)
                t1 += 26;
            return t1;
        }
        private void btnDo_Click(object sender, EventArgs e)
        {
            txtBan2.Text = "";
            if (bậc3ToolStripMenuItem.Text == "Bậc 3")
            {
                //chức năng mã hóa
                if (btnDo.Text == "Mã hóa")
                {
                    //kiểm tra
                    if (kiemTra())
                    {
                        //lấy dữ liệu
                        string banro = txtBan1.Text.Trim().Replace(" ", "");
                        int k11 = Convert.ToInt32(txtK11.Text.Trim());
                        int k12 = Convert.ToInt32(txtK12.Text.Trim());
                        int k21 = Convert.ToInt32(txtK21.Text.Trim());
                        int k22 = Convert.ToInt32(txtK22.Text.Trim());
                        //thêm X vào cuối chuỗi nếu độ dài của chuỗi không phù hợp
                        if (banro.Length % 2 != 0)
                            banro += "X";

                        //k1, k2 để dùng để xét th in hoa/thường của bản rõ ban đầu, a,b để lưu dạng số của bản rõ cho mã
                        int a = 0, b = 0, k1 = 0, k2 = 0;
                        for (int i = 0; i < banro.Length; i += 2)
                        {
                            a = Convert.ToInt32(banro[i]);
                            b = Convert.ToInt32(banro[i + 1]);
                            if (char.IsUpper(banro[i]))
                                k1 = 65;
                            else
                                k1 = 97;
                            if (char.IsUpper(banro[i + 1]))
                                k2 = 65;
                            else
                                k2 = 97;
                            a -= k1;
                            b -= k2;

                            txtBan2.Text += Convert.ToChar((a * k11 + b * k21) % 26 + k1).ToString();
                            txtBan2.Text += Convert.ToChar((a * k12 + b * k22) % 26 + k2).ToString();
                        }

                    }
                    else
                    {
                        //thông báo lỗi
                        MessageBox.Show(loi);
                    }
                }
                else
                {
                    //kiểm tra
                    if (kiemTra())
                    {
                        //lấy dữ liệu
                        string banma = txtBan1.Text.Trim().Replace(" ", "");
                        int k11 = Convert.ToInt32(txtK11.Text.Trim());
                        int k12 = Convert.ToInt32(txtK12.Text.Trim());
                        int k21 = Convert.ToInt32(txtK21.Text.Trim());
                        int k22 = Convert.ToInt32(txtK22.Text.Trim());
                        //kiểm tra xem khóa có thỏa mãn điều kiện không
                        int detK = (k11 * k22 - k12 * k21) % 26;
                        if (gcd(detK, 26) != 1)
                        {
                            MessageBox.Show("Hãy nhập lại ma trận sao cho det(K) có ước số chung với 26");
                            return;
                        }

                        //thực hiện tìm K^-1
                        //thực hiện tìm nghịch đảo của det(K) trên miền 26 bằng thuật toán euclide mở rộng
                        int t1 = euclide(26, detK);

                        //thực hiện tính toán cho k^-1
                        // K^-1 = det(k)^-1 * ( k22  -k12)
                        //                    (-k21   k11)
                        int k1 = (t1 * k22 + 26 * 2) % 26;
                        int k2 = (t1 * -k12 + 26 * 2) % 26;
                        int k3 = (t1 * -k21 + 26 * 2) % 26;
                        int k4 = (t1 * k11 + 26 * 2) % 26;

                        //c1, c2 để dùng để xét th in hoa/thường của bản mã ban đầu, a,b để lưu dạng số của bản mã cho rõ
                        int a = 0, b = 0, c1 = 0, c2 = 0;
                        for (int i = 0; i < banma.Length; i += 2)
                        {
                            a = Convert.ToInt32(banma[i]);
                            b = Convert.ToInt32(banma[i + 1]);
                            if (char.IsUpper(banma[i]))
                                c1 = 65;
                            else
                                c1 = 97;
                            if (char.IsUpper(banma[i + 1]))
                                c2 = 65;
                            else
                                c2 = 97;
                            a -= c1;
                            b -= c2;

                            txtBan2.Text += Convert.ToChar((a * k1 + b * k3) % 26 + c1).ToString();
                            txtBan2.Text += Convert.ToChar((a * k2 + b * k4) % 26 + c2).ToString();
                        }
                    }
                    else
                    {
                        //thông báo lỗi
                        MessageBox.Show(loi);
                    }
                }
            }
            else
            {
                //chức năng mã hóa
                if (btnDo.Text == "Mã hóa")
                {
                    //kiểm tra
                    if (kiemTra())
                    {
                        //lấy dữ liệu
                        string banro = txtBan1.Text.Trim();
                        int k11 = Convert.ToInt32(txtK11.Text.Trim());
                        int k12 = Convert.ToInt32(txtK12.Text.Trim());
                        int k13 = Convert.ToInt32(txtK13.Text.Trim());
                        int k21 = Convert.ToInt32(txtK21.Text.Trim());
                        int k22 = Convert.ToInt32(txtK22.Text.Trim());
                        int k23 = Convert.ToInt32(txtK23.Text.Trim());
                        int k31 = Convert.ToInt32(txtK31.Text.Trim());
                        int k32 = Convert.ToInt32(txtK32.Text.Trim());
                        int k33 = Convert.ToInt32(txtK33.Text.Trim());
                        //thêm X vào cuối chuỗi nếu độ dài của chuỗi không phù hợp
                        if (banro.Length % 3 == 1)
                            banro += "XX";
                        else if (banro.Length % 3 == 2)
                            banro += "X";

                        //k1, k2, k3 để dùng để xét th in hoa/thường của bản rõ ban đầu, a,b,c để lưu dạng số của bản rõ cho mã
                        int a = 0, b = 0, c = 0, k1 = 0, k2 = 0, k3 = 0;
                        for (int i = 0; i < banro.Length; i += 3)
                        {
                            a = Convert.ToInt32(banro[i]);
                            b = Convert.ToInt32(banro[i + 1]);
                            c = Convert.ToInt32(banro[i + 2]);
                            if (char.IsUpper(banro[i]))
                                k1 = 65;
                            else
                                k1 = 97;
                            if (char.IsUpper(banro[i + 1]))
                                k2 = 65;
                            else
                                k2 = 97;
                            if (char.IsUpper(banro[i + 2]))
                                k3 = 65;
                            else
                                k3 = 97;
                            a -= k1;
                            b -= k2;
                            c -= k3;

                            txtBan2.Text += Convert.ToChar((a * k11 + b * k12 + c * k13) % 26 + k1).ToString();
                            txtBan2.Text += Convert.ToChar((a * k21 + b * k22 + c * k23) % 26 + k2).ToString();
                            txtBan2.Text += Convert.ToChar((a * k31 + b * k32 + c * k33) % 26 + k3).ToString();
                        }
                    }
                    else
                    {
                        //thông báo lỗi
                        MessageBox.Show(loi);
                    }
                }
                else
                {
                    //kiểm tra
                    if (kiemTra())
                    {
                        //lấy dữ liệu
                        string banma = txtBan1.Text.Trim();
                        int k11 = Convert.ToInt32(txtK11.Text.Trim());
                        int k12 = Convert.ToInt32(txtK12.Text.Trim());
                        int k13 = Convert.ToInt32(txtK13.Text.Trim());
                        int k21 = Convert.ToInt32(txtK21.Text.Trim());
                        int k22 = Convert.ToInt32(txtK22.Text.Trim());
                        int k23 = Convert.ToInt32(txtK23.Text.Trim());
                        int k31 = Convert.ToInt32(txtK31.Text.Trim());
                        int k32 = Convert.ToInt32(txtK32.Text.Trim());
                        int k33 = Convert.ToInt32(txtK33.Text.Trim());
                        ////kiểm tra xem khóa có thỏa mãn điều kiện không
                        int detK = k11 * (k22 * k33 - k23 * k32) - k12 * (k21 * k33 - k23 * k31) + k13 * (k21 * k32 - k22 * k31); 
                        //thường khả năng detK âm có xh
                        while(detK < 0)
                        {
                            detK += 26;
                        }
                        detK %= 26;
                        if (gcd(detK, 26) != 1)
                        {
                            MessageBox.Show("Hãy nhập lại ma trận sao cho det(K) có ước số chung với 26");
                            return;
                        }

                        ////thực hiện tìm K^-1
                        ////thực hiện tìm nghịch đảo của det(K) trên miền 26 bằng thuật toán euclide mở rộng
                        int t1 = euclide(26, detK);

                        //Tìm ma trận Aij = (-1)^(i+j) * ma trận loại đi hàng i cột j
                        int a11 = (((k22 * k33 - k23 * k32) % 26) + 26) % 26;
                        int a12 = ((-(k12 * k33 - k13 * k32) % 26) + 26) % 26;
                        int a13 = (((k12 * k23 - k13 * k22) % 26) + 26) % 26;
                        int a21 = ((-(k21 * k33 - k23 * k31) % 26) + 26) % 26;
                        int a22 = (((k11 * k33 - k13 * k31) % 26) + 26) % 26;
                        int a23 = ((-(k11 * k23 - k13 * k21) % 26) + 26) % 26;
                        int a31 = (((k21 * k32 - k22 * k31) % 26) + 26) % 26;
                        int a32 = ((-(k11 * k32 - k12 * k31) % 26) + 26) % 26;
                        int a33 = (((k11 * k22 - k12 * k21) % 26) + 26) % 26;


                        // Kij^-1 = det(k)^-1 * Aij
                        k11 = (((a11 * t1) % 26) + 26) % 26;
                        k12 = (((a12 * t1) % 26) + 26) % 26;
                        k13 = (((a13 * t1) % 26) + 26) % 26;
                        k21 = (((a21 * t1) % 26) + 26) % 26;
                        k22 = (((a22 * t1) % 26) + 26) % 26;
                        k23 = (((a23 * t1) % 26) + 26) % 26;
                        k31 = (((a31 * t1) % 26) + 26) % 26;
                        k32 = (((a32 * t1) % 26) + 26) % 26;
                        k33 = (((a33 * t1) % 26) + 26) % 26;


                        //c1, c2, c3 để dùng để xét th in hoa/thường của bản rõ ban đầu, a,b,c để lưu dạng số của bản rõ cho mã
                        int a = 0, b = 0, c = 0, c1 = 0, c2 = 0, c3 = 0;
                        string kq = "";
                        for (int i = 0; i < banma.Length; i += 3)
                        {
                            if (i + 2 >= banma.Length)
                                break;
                            a = Convert.ToInt32(banma[i]);
                            b = Convert.ToInt32(banma[i + 1]);
                            c = Convert.ToInt32(banma[i + 2]);
                            if (char.IsUpper(banma[i]))
                                c1 = 65;
                            else
                                c1 = 97;
                            if (char.IsUpper(banma[i + 1]))
                                c2 = 65;
                            else
                                c2 = 97;
                            if (char.IsUpper(banma[i + 2]))
                                c3 = 65;
                            else
                                c3 = 97;
                            a -= c1;
                            b -= c2;
                            c -= c3;

                            kq += Convert.ToChar((a * k11 + b * k12 + c * k13) % 26 + c1).ToString();
                            kq += Convert.ToChar((a * k21 + b * k22 + c * k23) % 26 + c2).ToString();
                            kq += Convert.ToChar((a * k31 + b * k32 + c * k33) % 26 + c3).ToString();
                        }
                        foreach (char s in kq)
                        {
                            txtBan2.Text += s.ToString();
                        }

                    }
                    else
                    {
                        //thông báo lỗi
                        MessageBox.Show(loi);
                    }
                }
            }
        }

        private void sWITCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chuyển đổi chức năng mã hóa và giải mã của form
            if (giảiMãToolStripMenuItem.Text == "Giải mã")
            {
                btnDo.Text = "Giải mã";
                label1.Text = "Bản mã";
                label3.Text = "Bản rõ";
                giảiMãToolStripMenuItem.Text = "Mã hóa";
            }
            else
            {
                btnDo.Text = "Mã hóa";
                label1.Text = "Bản rõ";
                label3.Text = "Bản mã";
                giảiMãToolStripMenuItem.Text = "Giải mã";
            }
            xoaText();
        }

        private void bậc3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xoaText();
            //chuyển đổi chức năng bậc 2 và bậc 3 của form
            if (bậc3ToolStripMenuItem.Text == "Bậc 3")
            {
                bac3(true);
                bậc3ToolStripMenuItem.Text = "Bậc 2";
            }
            else
            {
                bac3(false);
                bậc3ToolStripMenuItem.Text = "Bậc 3";
            }
        }

        private void txtK11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Thực hiện hành động khi nhấn Enter
                txtK12.Focus();
                // Ngăn không cho âm thanh "beep" vang lên
                e.SuppressKeyPress = true;
            }
        }

        private void txtK12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Thực hiện hành động khi nhấn Enter
                if (bậc3ToolStripMenuItem.Text == "Bậc 3")
                    txtK21.Focus();
                else
                    txtK13.Focus();
                // Ngăn không cho âm thanh "beep" vang lên
                e.SuppressKeyPress = true;
            }
        }

        private void txtK13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Thực hiện hành động khi nhấn Enter
                txtK21.Focus();
                // Ngăn không cho âm thanh "beep" vang lên
                e.SuppressKeyPress = true;
            }
        }

        private void txtK21_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Thực hiện hành động khi nhấn Enter
                txtK22.Focus();
                // Ngăn không cho âm thanh "beep" vang lên
                e.SuppressKeyPress = true;
            }
        }

        private void txtK22_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Thực hiện hành động khi nhấn Enter
                if (bậc3ToolStripMenuItem.Text != "Bậc 3")
                    txtK23.Focus();
                // Ngăn không cho âm thanh "beep" vang lên
                e.SuppressKeyPress = true;
            }
        }

        private void txtK23_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Thực hiện hành động khi nhấn Enter
                txtK31.Focus();
                // Ngăn không cho âm thanh "beep" vang lên
                e.SuppressKeyPress = true;
            }
        }

        private void txtK31_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Thực hiện hành động khi nhấn Enter
                txtK32.Focus();
                // Ngăn không cho âm thanh "beep" vang lên
                e.SuppressKeyPress = true;
            }
        }

        private void txtK32_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Thực hiện hành động khi nhấn Enter
                txtK33.Focus();
                // Ngăn không cho âm thanh "beep" vang lên
                e.SuppressKeyPress = true;
            }
        }
    }
}