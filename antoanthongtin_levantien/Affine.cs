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
    public partial class Affine : Form
    {
        //biến thông báo lỗi
        string loi = "";
        //biến lấy giá trị a^-1
        int d = 0;
        public Affine()
        {
            InitializeComponent();
            //tắt phóng to, thu nhỏ của form
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //thiết kế giao diện datagridview
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            //thêm cột
            dataGridView1.Columns.Add("r", "R");
            dataGridView1.Columns.Add("q1", "Q1");
            dataGridView1.Columns.Add("q2", "Q2");
            dataGridView1.Columns.Add("t1", "T1");
            dataGridView1.Columns.Add("t2", "T2");
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //về lại menu
            this.Close();
        }
        public bool kiemTra()
        {
            //kiểm tra nếu đầu vào rỗng
            if (string.IsNullOrEmpty(txtBan1.Text) || string.IsNullOrEmpty(txtKhoa1.Text) || string.IsNullOrEmpty(txtKhoa2.Text))
            {
                loi = "Vui lòng nhập đầy đủ thông tin";
                return false;
            }
            //kiểm tra nếu dữ liệu nhập vào không thuộc kiểu số nguyên
            try
            {
                int a = Convert.ToInt32(txtKhoa1.Text);
                int b = Convert.ToInt32(txtKhoa2.Text);
                if (gcd(a, 26) != 1)
                {
                    loi = "Hãy nhập lại a chia hết cho 26!";
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                loi = "Vui lòng nhập khóa thuộc kiểu số nguyên";
                return false;
            }
        }

        public void xoaText()
        {
            //xóa dữ liệu đã nhập vào
            txtBan1.Text = "";
            txtKhoa1.Text = "";
            txtKhoa2.Text = "";
            txtBan2.Text = "";
        }
        public int gcd(int x, int y)
        {
            //tìm ucln
            while (x != y)
            {
                if (x > y)
                    x -= y;
                else
                    y -= x;
            }
            return x;
        }
        public int euclide(int x, int y)
        {
            //thực hiện dùng thuật toán euclide mở rộng để tính toán và in ra datagridview
            dataGridView1.Rows.Clear();
            int q1 = x, q2 = y, t1 = 0, t2 = 1, r = 0, temp;
            while (q2 != 0)
            {
                r = q1 / q2;
                dataGridView1.Rows.Add(r, q1, q2, t1, t2);
                temp = q2;
                q2 = q1 - q2 * r;
                q1 = temp;

                temp = t2;
                t2 = t1 - t2 * r;
                t1 = temp;
            }
            dataGridView1.Rows.Add(null, q1, q2, t1, null);
            if (t1 > 0)
                return t1;
            else
                return x + t1;
        }

        private void txtKhoa2_TextChanged(object sender, EventArgs e)
        {
            //xóa dữ liệu kết quả trước đó
            txtBan2.Text = "";
            dataGridView1.Rows.Clear();
            //nếu khóa không có dữ liệu thì dừng
            if (txtKhoa1.Text == "" || txtKhoa2.Text == "" || gcd(Convert.ToInt32(txtKhoa1.Text), 26) != 1)
                return;
            d = euclide(26, Convert.ToInt32(txtKhoa1.Text));
            dataGridView1.Rows.Add("a^-1", "=", d, null, null);
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            txtBan2.Text = "";
            //chức năng mã hóa
            if (btnDo.Text == "Mã hóa")
            {
                //kiểm tra
                if (kiemTra())
                {
                    // lấy dữ liệu
                    string ban1 = txtBan1.Text;
                    int a = Convert.ToInt32(txtKhoa1.Text);
                    int b = Convert.ToInt32(txtKhoa2.Text);
                    //thực hiện mã hóa
                    foreach (char ch in ban1)
                    {
                        //kiểm tra nếu đó là kì tự từ a -> z
                        if (char.IsLetter(ch))
                        {
                            //thực hiện chuyển đổi ch sang hệ thập phân
                            int i = Convert.ToInt32(ch);
                            //kiểm tra nếu ch là in hoa hay in thường
                            //thực hiện chuyển i sang bảng từ 0-25, cộng với khóa rồi lấy số dư khi mod 26 rồi đưa về lại bảng ascii
                            if (i >= 97)
                                txtBan2.Text += Convert.ToChar((a * (i - 97) + b) % 26 + 97);
                            else
                                txtBan2.Text += Convert.ToChar((a * (i - 65) + b) % 26 + 65);
                        }
                        else
                        {
                            txtBan2.Text += ch;
                        }
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
                    // lấy dữ liệu
                    string ban1 = txtBan1.Text;
                    int b = Convert.ToInt32(txtKhoa2.Text);
                    //thực hiện giải mã
                    foreach (char ch in ban1)
                    {
                        //kiểm tra nếu đó là kì tự từ a -> z
                        if (char.IsLetter(ch))
                        {
                            //thực hiện chuyển đổi ch sang hệ thập phân
                            int i = Convert.ToInt32(ch);
                            //kiểm tra nếu ch là in hoa hay in thường
                            //thực hiện chuyển i sang bảng từ 0-25,áp dụng công thức rồi lấy số dư khi mod 26 rồi đưa về lại bảng ascii
                            if (i >= 97)
                                txtBan2.Text += Convert.ToChar((d * (i - 97 + 26 * 2 - b)) % 26 + 97);
                            else
                                txtBan2.Text += Convert.ToChar((d * (i - 65 + 26 * 2 - b)) % 26 + 65);
                        }
                        else
                        {
                            txtBan2.Text += ch;
                        }
                    }
                }
            }
        }

        private void giảiMãToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void mởFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Text files|*.txt";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    txtBan1.Text = sr.ReadLine();
                    txtKhoa1.Text = sr.ReadLine();
                    txtKhoa2.Text = sr.ReadLine();
                    sr.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đọc thất bại!");
            }
        }

        private void lưuFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "Text files|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = File.CreateText(saveFileDialog1.FileName);
                    sw.WriteLine(txtBan2.Text);
                    sw.WriteLine(txtKhoa1.Text);
                    sw.WriteLine(txtKhoa2.Text);
                    sw.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lưu thất bại!");
            }
        }
    }
}
