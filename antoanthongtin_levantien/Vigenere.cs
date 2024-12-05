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
    public partial class Vigenere : Form
    {
        //biến thông báo lỗi
        string loi = "";
        //biến lưu giá trị số của bản 1
        int[] p = new int[100];
        //biến lưu giá trị số của khóa
        int[] kh = new int[100];
        //biến để lưu giá trị của bản rõ ban đầu là in hoa hay in thường
        char[] ss = new char[100];
        public Vigenere()
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

        private void txtBan1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                //lấy dữ liệu để thực hiện phép toán và thêm hàng vào dgv
                string[] rows = new string[txtBan1.Text.Length];
                int i = 0;
                foreach (char c in txtBan1.Text)
                {
                    //thêm cột
                    dataGridView1.Columns.Add(c.ToString(), c.ToString());
                    //thêm hàng và lưu dữ liệu
                    int j = Convert.ToInt32(c);
                    if (char.IsUpper(c))
                        j -= 65;
                    else
                        j -= 97;
                    rows[i] = j.ToString();
                    p[i] = j;
                    ss[i] = c;
                    i++;
                }
                //thêm hàng
                dataGridView1.Rows.Add(rows);
            }
            catch (Exception)
            {
                if (txtBan1.Text == "")
                    return;
                MessageBox.Show("Mời nhập lại");
            }
        }

        private void txtKhoa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //xóa kết quả trước và ghi lại dgv
                txtBan2.Text = "";
                txtBan1_TextChanged(sender, e);
                if (txtBan1.Text == "")
                {
                    return;
                }

                string banro = txtBan1.Text;
                string khoa = txtKhoa.Text;

                //khởi tạo và thêm các giá trị của khóa vào dgv
                string[] row = new string[banro.Length];
                //j là vị trí giá trị hiện thời của khóa, k là giá trị kiểu số trên miền 26 của từng giá trị
                int j = 0, k = 0;
                for (int i = 0; i < banro.Length; i++)
                {
                    k = (int)khoa[j];
                    if (char.IsUpper(khoa[j]))
                        k -= 65;
                    else
                        k -= 97;

                    row[i] = k.ToString();
                    kh[i] = k;
                    j++;
                    //nếu hết giá trị của khóa mà bản rõ > khóa, thực hiện lặp lại khóa
                    if (j >= khoa.Length)
                        j = 0;
                }
                dataGridView1.Rows.Add(row);
            }
            catch (Exception)
            {
                if (txtKhoa.Text == "")
                    return;
                MessageBox.Show("Mời nhập lại");
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
                    // lấy dữ liệu
                    string ban1 = txtBan1.Text;
                    //thực hiện mã hóa

                    //thực hiện tính toán kiểu số bản mã và in ra dgv
                    string[] row = new string[ban1.Length];
                    for (int i = 0; i < ban1.Length; i++)
                    {
                        row[i] = ((p[i] + kh[i]) % 26).ToString();
                    }
                    dataGridView1.Rows.Add(row);

                    //thực hiện tính toán để in ra kiểu chữ của bản mã
                    row = new string[ban1.Length];
                    int k = 0;
                    for (int i = 0; i < ban1.Length; i++)
                    {
                        if (char.IsUpper(ss[i]))
                            k = 65;
                        else
                            k = 97;

                        row[i] = Convert.ToChar((p[i] + kh[i]) % 26 + k).ToString();
                        txtBan2.Text += row[i].ToString();
                    }
                    dataGridView1.Rows.Add(row);
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
                    //thực hiện giải mã
                    //thực hiện tính toán kiểu số bản mã và in ra dgv
                    string[] row = new string[ban1.Length];
                    for (int i = 0; i < ban1.Length; i++)
                    {
                        row[i] = ((p[i] - kh[i] + 26*2) % 26).ToString();
                    }
                    dataGridView1.Rows.Add(row);

                    //thực hiện tính toán để in ra kiểu chữ của bản mã
                    row = new string[ban1.Length];
                    int k = 0;
                    for (int i = 0; i < ban1.Length; i++)
                    {
                        if (char.IsUpper(ss[i]))
                            k = 65;
                        else
                            k = 97;

                        row[i] = Convert.ToChar((p[i] - kh[i] + 26) % 26 + k).ToString();
                        txtBan2.Text += row[i].ToString();
                    }
                    dataGridView1.Rows.Add(row);
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
