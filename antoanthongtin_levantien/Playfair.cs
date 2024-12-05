using Microsoft.VisualBasic.Logging;
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
    public partial class Playfair : Form
    {
        //biến thông báo lỗi
        string loi = "";
        //biến mảng để dùng khi mã hóa và giải mã
        string[] chuoi = new string[25];
        public Playfair()
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
            dataGridView1.Columns.Add("1", "1");
            dataGridView1.Columns.Add("2", "2");
            dataGridView1.Columns.Add("3", "3");
            dataGridView1.Columns.Add("4", "4");
            dataGridView1.Columns.Add("5", "5");
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //về lại menu
            this.Close();
        }
        public bool kiemTra()
        {
            //kiểm tra nếu đầu vào rỗng
            if (string.IsNullOrEmpty(txtBan1.Text) || string.IsNullOrEmpty(txtKhoa.Text))
            {
                loi = "Vui lòng nhập đầy đủ thông tin";
                return false;
            }
            //kiểm tra nếu dữ liệu nhập vào không thuộc từ a->z
            string a = txtBan1.Text + txtKhoa.Text;
            if (!char.IsLetter(a, 0))
            {
                loi = "Vui lòng nhập vào kiểu chuỗi/kí tự";
                return false;
            }
            return true;
        }

        public void xoaText()
        {
            //xóa dữ liệu đã nhập vào
            txtBan1.Text = "";
            txtKhoa.Text = "";
            txtBan2.Text = "";
        }

        private void txtBan1_TextChanged_1(object sender, EventArgs e)
        {
            //xóa dữ liệu kết quả trước đó
            txtBan2.Text = "";
            chuoi = new string[25];
            dataGridView1.Rows.Clear();
            //nếu khóa không có dữ liệu thì dừng
            if (txtKhoa.Text == "")
                return;

            //tạo 1 tập hợp không cho phép trùng giá trị
            HashSet<string> list = new HashSet<string>();
            //lấy dữ liệu khóa
            string khoa = txtKhoa.Text.ToUpper();

            //thêm các từ trong khóa vào list
            for (int i = 0; i < khoa.Length; i++)
                if (khoa[i] != 'J')
                {
                    list.Add(khoa[i].ToString()); // thêm ký tự vào HashSet
                }

            //thêm các kí tự còn lại từ a->z (vì trong tiếng anh i-j dễ phân biệt -> I/J)
            for (int i = 65; i < 91; i++)
            {
                string c = Convert.ToChar(i).ToString();
                if (c == "J")
                    continue;
                list.Add(c);
            }

            //chuyển list thành mảng
            list.CopyTo(chuoi);
            //thêm bảng vào datagridview
            string[] row = new string[5];
            for (int i = 0; i < 25; i++)
            {
                //thêm dữ liệu vào hàng
                row[i % 5] = chuoi[i];
                //chuyển I thành I/J
                if (chuoi[i] == "I")
                    row[i % 5] += "/J";
                //khi đủ 1 hàng -> thêm hàng vào datagridview và reset mảng để thêm hàng mới
                if (i % 5 == 4 && row[4] != null)
                {
                    dataGridView1.Rows.Add(row);
                    row = new string[5];
                }
            }
        }
        public (string, string) layDuLieu(string a, string b, int i)
        {
            //lấy số hàng và cột dựa vào phép tính vd: 6 -> hàng 1 cột 1, 2 -> hàng 0 cột 2
            //  0   1   2   3   4
            //  1
            //  2
            //  3
            //  4
            int hangA = Array.IndexOf(chuoi, a) / 5;
            int cotA = Array.IndexOf(chuoi, a) % 5;
            int hangB = Array.IndexOf(chuoi, b) / 5;
            int cotB = Array.IndexOf(chuoi, b) % 5;
            //txtBan2.Text += "" + hangA + cotA + hangB + cotB;
            //biến lưu kết quả
            string c = "", d = "";
            //dạng 1 khi mã hóa
            if (i == 0)
            {
                //cùng hàng
                if (hangA == hangB)
                {
                    //lấy bên phải
                    c = chuoi[hangA * 5 + (cotA + 1) % 5];
                    d = chuoi[hangB * 5 + (cotB + 1) % 5];
                }
                else if (cotA == cotB)   //cùng cột
                {
                    //lấy bên dưới
                    c = chuoi[(hangA + 1) % 5 * 5 + cotA];
                    d = chuoi[(hangB + 1) % 5 * 5 + cotB];
                }
                else    //còn lại
                {
                    //lấy vị trí cùng hàng ở cột đối diện
                    c = chuoi[hangA * 5 + cotB];
                    d = chuoi[hangB * 5 + cotA];
                }
            }
            else    //dạng 2 khi giải mã 
            {
                //cùng hàng
                if (hangA == hangB)
                {
                    //lấy bên phải
                    c = chuoi[hangA * 5 + (cotA + 4 ) % 5];
                    d = chuoi[hangB * 5 + (cotB + 4 ) % 5];
                }
                else if (cotA == cotB)   //cùng cột
                {
                    //lấy bên dưới
                    c = chuoi[(hangA + 4) % 5 * 5 + cotA];
                    d = chuoi[(hangB + 4) % 5 * 5 + cotB];
                }
                else    //còn lại
                {
                    //lấy vị trí cùng hàng ở cột đối diện
                    c = chuoi[hangA * 5 + cotB];
                    d = chuoi[hangB * 5 + cotA];
                }
            }
            return (c, d);
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
                    //lấy dữ liệu
                    string banro = txtBan1.Text.Replace(" ", "").ToUpper();
                    string ban1 = "";
                    //thêm x vào các trường hợp đặc biệt như 2 kí tự được xét giống nhau hoặc bản rõ lẻ
                    for (int i = 0, j = 0; i < banro.Length; i += 2, j += 2)
                    {
                        if (i + 1 < banro.Length)
                        {
                            if (banro[i] != banro[i + 1])
                                ban1 += banro[i] + "" + banro[i + 1];
                            else
                            {
                                ban1 += banro[i] + "X";
                                i--;
                            }
                        }
                        else
                        {
                            ban1 += banro[i] + "X";
                        }
                    }
                    //thực hiện mã hóa
                    for (int i = 0; i < ban1.Length; i += 2)
                    {
                        (string a, string b) = layDuLieu(ban1[i].ToString(), ban1[i + 1].ToString(), 0);
                        txtBan2.Text += a + b;
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
                    //nếu là giải mã phải nhập đúng bản mã sau khi mã hóa từ bàn rõ
                    if (txtBan1.Text.Length % 2 != 0)
                    {
                        loi = "Vui lòng nhập đúng bản mã";
                        MessageBox.Show(loi);
                        return;
                    }
                    //lấy dữ liệu
                    string ban1 = txtBan1.Text.Replace(" ", "").ToUpper();
                    //thực hiện giải mã
                    string kq = "";
                    for (int i = 0; i < ban1.Length; i += 2)
                    {
                        (string a, string b) = layDuLieu(ban1[i].ToString(), ban1[i + 1].ToString(), 1);
                        kq += a + b;
                    }
                    //Xóa x ở các trường hợp đặc biệt
                    for (int i = 0; i < kq.Length - 1; i++)
                    {
                        if (kq[i] != 'X')
                            txtBan2.Text += kq[i];
                        else if ((i > 0 && i + 1 < kq.Length && kq[i - 1] != kq[i + 1]))
                        {
                            txtBan2.Text += 'X';
                        }
                    }
                    if (kq[kq.Length - 1] != 'X')
                        txtBan2.Text += kq[kq.Length - 1];
                }
                else
                {
                    //thông báo lỗi
                    MessageBox.Show(loi);
                }
            }
        }

        private void đảoNgượcToolStripMenuItem_Click(object sender, EventArgs e)
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