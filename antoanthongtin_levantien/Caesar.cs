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
    public partial class Caesar : Form
    {
        //biến thông báo lỗi
        string loi = "";
        public Caesar()
        {
            InitializeComponent();
            //tắt phóng to, thu nhỏ của form
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //về lại menu
            this.Close();
        }

        private void sWITCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chuyển đổi chức năng mã hóa và giải mã của form
            if (sWITCHToolStripMenuItem.Text == "Giải mã")
            {
                btnDo.Text = "Giải mã";
                label1.Text = "Bản mã";
                label3.Text = "Bản rõ";
                sWITCHToolStripMenuItem.Text = "Mã hóa";
            }
            else
            {
                btnDo.Text = "Mã hóa";
                label1.Text = "Bản rõ";
                label3.Text = "Bản mã";
                sWITCHToolStripMenuItem.Text = "Giải mã";
            }
            xoaText();
        }

        public bool kiemTra()
        {
            //kiểm tra nếu đầu vào rỗng
            if (string.IsNullOrEmpty(txtBan1.Text) || string.IsNullOrEmpty(txtKhoa.Text))
            {
                loi = "Vui lòng nhập đầy đủ thông tin";
                return false;
            }
            try
            {
                //kiểm tra nếu khóa không phải số nguyên
                int a = Convert.ToInt32(txtKhoa.Text);
                return true;
            }
            catch (Exception)
            {
                loi = "Vui lòng nhập lại khóa theo kiểu số nguyên";
                return false;
            }
        }

        public void xoaText()
        {
            //xóa dữ liệu đã nhập vào
            txtBan1.Text = "";
            txtKhoa.Text = "";
            txtBan2.Text = "";
        }
        private void btnDo_Click(object sender, EventArgs e)
        {
            //chức năng mã hóa
            if (btnDo.Text == "Mã hóa")
            {
                //kiểm tra
                if (kiemTra())
                {
                    //lấy dữ liệu
                    string ban1 = txtBan1.Text;
                    int khoa = Convert.ToInt32(txtKhoa.Text);
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
                                txtBan2.Text += Convert.ToChar((i - 97 + khoa) % 26 + 97);
                            else
                                txtBan2.Text += Convert.ToChar((i - 65 + khoa) % 26 + 65);
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
                    //lấy dữ liệu
                    string ban1 = txtBan1.Text;
                    int khoa = Convert.ToInt32(txtKhoa.Text);
                    //thực hiện giải mã
                    foreach (char ch in ban1)
                    {
                        //kiểm tra nếu đó là kì tự từ a -> z
                        if (char.IsLetter(ch))
                        {
                            //thực hiện chuyển đổi ch sang hệ thập phân
                            int i = Convert.ToInt32(ch);
                            //kiểm tra nếu ch là in hoa hay in thường
                            //thực hiện chuyển i sang bảng từ 0-25 trừ đi khóa (+26 nếu trường hợp trừ kháo ra số âm)rồi lấy số dư khi mod 26 rồi đưa về lại bảng ascii
                            if (i >= 97)
                                txtBan2.Text += Convert.ToChar((i - 97 - khoa + 26) % 26 + 97);
                            else
                                txtBan2.Text += Convert.ToChar((i - 65 - khoa + 26) % 26 + 65);
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
        }

        private void txtBan1_TextChanged(object sender, EventArgs e)
        {
            //xóa dữ liệu kết quả từ lần nhập trước, hàm này tích hợp cho cả txtBan1, txtKhoa
            txtBan2.Text = "";
        }

        private void mởFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Text Files|*.txt";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    txtBan1.Text = sr.ReadLine();
                    txtKhoa.Text = sr.ReadLine();
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
                saveFileDialog1.Filter = "Text Files|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = File.CreateText(saveFileDialog1.FileName);
                    sw.WriteLine(txtBan2.Text);
                    sw.WriteLine(txtKhoa.Text);
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
