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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace antoanthongtin_levantien
{
    public partial class Hang : Form
    {
        //biến thông báo lỗi
        string loi = "";
        //biến lưu các phần tử của khóa nhằm dễ dàng thao tác
        int[] k = new int[100];
        //lưu mảng 2 chiều của bản 2
        char[,] ch = new char[100, 100];
        //lưu giới hạn hàng và cột từ bản rõ và khóa, lấy số to nhất trong khóa để so sánh xem đã nhập đúng khóa theo kiểu từ 1->n chưa
        int cot = 0, hang = 0, lonnhat = 0;
        //lưu các số trong khóa để xét các khóa có theo thứ tự và có bị trùng lặp không
        HashSet<int> ss = new HashSet<int>();
        public Hang()
        {
            InitializeComponent();
            //bắt buộc nhập khóa trước
            txtKhoa.Focus();
            txtBan1.ReadOnly = true;
            //tắt phóng to, thu nhỏ của form
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //thiết kế giao diện datagridview
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            try
            {
                //kiểm tra nếu khóa không phải số nguyên
                //tách khóa ra bởi 2 trường hợp được nối bằng " " hoặc ","
                string[] khoa = txtKhoa.Text.Trim().Split(new char[] { ' ', ',' });
                for (int i = 0; i < khoa.Length; i++)
                {
                    int a = Convert.ToInt32(khoa[i]);
                }
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

        private void txtBan1_TextChanged(object sender, EventArgs e)
        {
            txtBan2.Text = "";
            //kiểm tra nếu khóa đã nhập đúng
            if ((ss.Count != lonnhat && txtKhoa.Text != "") || txtKhoa.Text == "")
            {
                txtKhoa.Text = "";
                txtBan1.Text = "";
                txtKhoa.Focus();
                return;
            }

            try
            {
                dataGridView1.Rows.Clear();
                //lấy dữ liệu
                string banro = txtBan1.Text.Trim();
                hang = (banro.Length / lonnhat) + 1;
                cot = lonnhat;
                ch = new char[cot, hang];

                //lập 1 từ điển cho việc đảo ngược lại vị trí của bảng theo 1 nguyên lý
                //VD:
                // 3 => 2  0
                // 6 => 5  1
                // 2 => 1  2
                // 1 => 0  3
                // 5 => 4  4
                // 4 => 3  5
                Dictionary<int, int> map = new Dictionary<int, int>();
                for (int i = 0; i < lonnhat; i++)
                {
                    map.Add(k[i] - 1, i);
                }

                //dạng hiển thị
                if (btnDo.Text == "Mã hóa")
                {
                    //thêm hàng vào dgv
                    string[] row = new string[cot];
                    int so = 0;
                    for (int i = 0; i < hang; i++)
                    {
                        row = new string[cot];
                        for (int j = 0; j < cot; j++)
                        {
                            //đặt giới hạn cho hàng cuối dừng lại
                            if (so >= banro.Length)
                                break;
                            row[j] = banro[so].ToString();
                            // hàng = cột của g.trị (nhưng được chuyển theo cặp g.trị trong dictionary), cột = hàng của g.trị
                            ch[k[j] - 1, i] = Convert.ToChar(row[j]);
                            so++;
                        }
                        dataGridView1.Rows.Add(row);
                    }
                }
                else
                {
                    // hàng = cột của g.trị, cột = hàng của g.trị(nhưng được chuyển theo cặp g.trị trong dictionary)
                    ch = new char[hang,cot];
                    int so = 0;
                    for (int i = 0; i < cot; i++)
                    {
                        for (int j = 0; j < hang; j++)
                        {
                            //khi xét đến hàng cuối, nếu vị trí của nó >= số kí tự thừa ra khi trừ đi tổng kí tự các hàng trên nó => xét tiếp
                            if (j == hang - 1 && map[i] >= (banro.Length - (cot * (hang - 1))))
                            {
                                continue;
                            }
                            else
                            {
                                ch[j, map[i]] = banro[so];
                                so++;
                            }
                        }
                    }
                    //hiển thị 
                    string[] row = new string[100];
                    for (int i = 0; i < hang; i++)
                    {
                        row = new string[cot];
                        for (int j = 0; j < cot; j++)
                        {
                            row[j] = ch[i, j].ToString();
                        }
                        dataGridView1.Rows.Add(row);
                    }
                }
            }
            catch (Exception)
            {
                if (txtBan1.Text == "")
                    return;
                MessageBox.Show("Lỗi");
            }
        }

        private void txtKhoa_TextChanged(object sender, EventArgs e)
        {
            //reset dữ liệu
            lonnhat = 0;
            ss.Clear();
            ss = new HashSet<int>();
            k = new int[100];
            try
            {
                //chuyển dạng khi khóa được nhập
                if (txtKhoa.Text == "")
                    txtBan1.ReadOnly = true;
                else
                    txtBan1.ReadOnly = false;

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                //lấy dữ liệu
                string banro = txtBan1.Text;
                string[] khoa = txtKhoa.Text.Trim().Split(new char[] { ' ', ',' });

                for (int i = 0; i < khoa.Length; i++)
                {
                    //chuyển số từ chuỗi thành hệ 10 trong bảng ascii rồi lấy giá trị số bắt đầu từ 0
                    k[i] = Convert.ToInt32(khoa[i]);
                    ss.Add(k[i]);
                    if (lonnhat < k[i])
                        lonnhat = k[i];
                    //thêm cột cho dgv
                    dataGridView1.Columns.Add(k[i].ToString(), k[i].ToString());
                    //đặt cho dữ liệu trong cột được căn giữa
                    dataGridView1.Columns[k[i].ToString()].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                //đặt cho tiêu đề cột được căn giữa
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception)
            {
                if (txtKhoa.Text == "")
                    return;
                MessageBox.Show("Lỗi");
            }
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
                    //kiểm tra nếu khóa đã nhập đúng
                    if ((ss.Count != lonnhat && txtKhoa.Text != "") || txtKhoa.Text == "")
                    {
                        txtKhoa.Text = "";
                        txtBan1.Text = "";
                        txtKhoa.Focus();
                        MessageBox.Show("Nhập lại khóa!");
                        return;
                    }
                    //thực hiện mã hóa
                    string result = "";
                    for (int i = 0; i < cot; i++)
                    {
                        for (int j = 0; j < hang; j++)
                        {
                            if (ch[i, j] == '\0')
                                continue;
                            result += ch[i, j];
                        }
                    }
                    txtBan2.Text = result;
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
                    //kiểm tra nếu khóa đã nhập đúng
                    if ((ss.Count != lonnhat && txtKhoa.Text != "") || txtKhoa.Text == "")
                    {
                        txtKhoa.Text = "";
                        txtBan1.Text = "";
                        txtKhoa.Focus();
                        MessageBox.Show("Nhập lại khóa!");
                        return;
                    }
                    //thực hiện giải mã
                    string result = "";
                    for (int i = 0; i < hang; i++)
                    {
                        for (int j = 0; j < cot; j++)
                        {
                            result += ch[i, j];
                        }
                    }
                    txtBan2.Text = result;
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
    }
}
