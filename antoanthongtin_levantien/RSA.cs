using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace antoanthongtin_levantien
{
    public partial class RSA : Form
    {
        //biến thông báo lỗi
        string loi = "";
        //lưu khóa để lưu file
        BigInteger Ed = 0, N = 0;
        public RSA()
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
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            //thêm cột
            dataGridView1.Columns.Add("r", "R");
            dataGridView1.Columns.Add("q1", "Q1");
            dataGridView1.Columns.Add("q2", "Q2");
            dataGridView1.Columns.Add("t1", "T1");
            dataGridView1.Columns.Add("t2", "T2");
            dataGridView2.Columns.Add("somu", "Số mũ");
            dataGridView2.Columns.Add("ketqua", "Kết quả");
            dataGridView2.Columns.Add("coso", "Cơ số");

            dataGridView2.Visible = false;
            txtBan1.Select();
        }

        private void mởFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xoaText();
            try
            {
                openFileDialog1.Filter = "Text Files|*.txt";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    txtBan1.Text = sr.ReadLine();
                    txtK1.Text = sr.ReadLine();
                    txtK2.Text = sr.ReadLine();
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
            if (!kiemTraMD())
            {
                MessageBox.Show(loi);
                return;
            }

            try
            {
                saveFileDialog1.Filter = "Text Files | *.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = File.CreateText(saveFileDialog1.FileName);
                    sw.WriteLine(txtBan2.Text);
                    sw.WriteLine(Ed);
                    sw.WriteLine(N);
                    //if(sWITCHToolStripMenuItem.Text == "Giải mã")
                    //{
                    //    sw.WriteLine(txtBan2.Text);
                    //    sw.WriteLine(txtD.Text);
                    //    sw.WriteLine(txtK2.Text);
                    //}
                    //else
                    //{
                    //    sw.WriteLine(txtBan2.Text);
                    //    sw.WriteLine(txtE.Text);
                    //    sw.WriteLine(txtK2.Text);
                    //}
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
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        public bool kiemTra()
        {
            //kiểm tra nếu đầu vào rỗng
            if (string.IsNullOrEmpty(txtBan1.Text) || string.IsNullOrEmpty(txtK1.Text) || string.IsNullOrEmpty(txtK2.Text))
            {
                loi = "Vui lòng nhập đầy đủ thông tin";
                return false;
            }
            //kiểm tra nếu dữ liệu nhập vào không thuộc kiểu số nguyên
            try
            {
                int mc = int.Parse(txtBan1.Text);
                int N = int.Parse(txtK2.Text);
                if(mc >= N || mc < 0)
                {
                    loi = "Vui lòng nhập đầu vào >= 0 và < N";
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

        public bool kiemTraMD()
        {
            //kiểm tra nếu đầu vào rỗng
            if (string.IsNullOrEmpty(txtBan1.Text) || string.IsNullOrEmpty(txtP.Text) || string.IsNullOrEmpty(txtQ.Text) || string.IsNullOrEmpty(txtE.Text))
            {
                loi = "Vui lòng nhập đầy đủ thông tin";
                return false;
            }
            //kiểm tra nếu dữ liệu nhập vào không thuộc kiểu số nguyên
            try
            {
                int q = Convert.ToInt32(txtQ.Text);
                int p = Convert.ToInt32(txtP.Text);
                int e = Convert.ToInt32(txtE.Text);
                int c = Convert.ToInt32(txtBan1.Text);
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
            txtBan2.Text = "";
            txtP.Text = "";
            txtQ.Text = "";
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
        }

        public BigInteger gcd(BigInteger x, BigInteger y)
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

        public BigInteger euclide(BigInteger x, BigInteger y)
        {
            //thực hiện dùng thuật toán euclide mở rộng để tính toán và in ra datagridview

            // Xóa tất cả các dòng hiện có trong DataGridView trước khi thêm kết quả mới
            dataGridView1.Rows.Clear();
            BigInteger q1 = x, q2 = y, t1 = 0, t2 = 1, r = 0, temp;
            // Thực hiện vòng lặp cho đến khi q2 = 0
            while (q2 != 0)
            {
                r = q1 / q2;

                // Thêm kết quả của bước tính toán vào DataGridView (thương, q1, q2, t1, t2)
                dataGridView1.Rows.Add(r, q1, q2, t1, t2);

                // Cập nhật lại các giá trị q1 và q2
                temp = q2;
                q2 = q1 - q2 * r;
                q1 = temp;

                // Cập nhật lại các giá trị t1 và t2
                temp = t2;
                t2 = t1 - t2 * r;
                t1 = temp;
            }
            // Thêm kết quả cuối cùng vào DataGridView (q1, q2, t1)
            dataGridView1.Rows.Add(null, q1, q2, t1, null);
            // Nếu t1 là số âm, cộng x vào t1 để đảm bảo t1 là số dương
            if (t1 < 0)
                t1 += x;
            // Thêm kết quả cuối cùng vào DataGridView (a^-1 = t1)
            dataGridView1.Rows.Add("d", "=", t1, null, null);
            return t1;
        }

        public bool soNT(long n)
        {
            // Số nhỏ hơn 2 không phải là số nguyên tố
            if (n < 2)
            {
                return false;
            }

            // Kiểm tra từ 2 đến căn bậc hai của số đó
            for (long i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) // Nếu chia hết cho i, không phải số nguyên tố
                {
                    return false;
                }
            }

            return true; // Nếu không chia hết cho số nào, đó là số nguyên tố
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            //reset contextmenustrip
            if (contextMenuStrip1 != null)
            {
                contextMenuStrip1.Items.Clear();
            }
            contextMenuStrip1 = new ContextMenuStrip();

            //kiểm tra P & Q
            if (string.IsNullOrEmpty(txtP.Text) || string.IsNullOrEmpty(txtQ.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            //kiểm tra nếu dữ liệu nhập vào không thuộc kiểu số nguyên
            try
            {
                long a = Convert.ToInt32(txtP.Text);
                long b = Convert.ToInt32(txtQ.Text);
                if (!soNT(a))
                {
                    MessageBox.Show("Hãy nhập lại P là số nguyên tố");
                    return;
                }
                if (!soNT(b))
                {
                    MessageBox.Show("Hãy nhập lại Q là số nguyên tố");
                    return;
                }
                if(a == b)
                {
                    MessageBox.Show("Hãy nhập lại Q != P");
                    return;
                }
                if (Math.Abs(a - b) < 10)
                {
                    MessageBox.Show("p và q không nên quá gần nhau.");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập khóa thuộc kiểu số nguyên");
                return;
            }

            //lấy dữ liệu
            BigInteger p = Convert.ToInt32(txtP.Text);
            BigInteger q = Convert.ToInt32(txtQ.Text);
            BigInteger phiN = (p - 1) * (q - 1);
            int x = 0;
            //thêm dữ liệu vào contextmenustrip
            for (int i = 2; i < phiN; i++)
            {
                if (x == 15)
                    break;
                if (gcd(i, phiN) == 1)
                {
                    contextMenuStrip1.Items.Add(i.ToString());
                    x++;
                }
            }

            // Thêm sự kiện click vào menu item
            foreach (ToolStripItem item in contextMenuStrip1.Items)
            {
                item.Click += contextMenuStrip1_Click;
            }

            // Hiển thị ContextMenu tại vị trí con trỏ chuột
            contextMenuStrip1.Show(Cursor.Position);
        }

        private void contextMenuStrip1_Click(object? sender, EventArgs e)
        {
            // Khi click vào item, lấy giá trị
            ToolStripItem clickedItem = sender as ToolStripItem ?? new ToolStripMenuItem("");
            txtE.Text = clickedItem.Text;
        }

        private void txtE_TextChanged(object sender, EventArgs e)
        {
            //thay đổi giá trị của d,k1,k2 theo e
            if (txtE.Text == "")
            {
                txtD.Text = "";
                txtK1.Text = "";
                txtK2.Text = "";
            }
            else
            {
                long p = Convert.ToInt32(txtP.Text);
                long q = Convert.ToInt32(txtQ.Text);
                BigInteger n = p * q;
                BigInteger phiN = (p - 1) * (q - 1);
                long E = Convert.ToInt32(txtE.Text);

                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
                txtD.Text = euclide(phiN, E).ToString();
                if (sWITCHToolStripMenuItem.Text == "Giải mã")
                {
                    txtK1.Text = E.ToString();
                    txtK2.Text = n.ToString();
                    Ed = int.Parse(txtD.Text);
                    N = n;

                }
                else
                {
                    txtK1.Text = txtD.Text;
                    txtK2.Text = n.ToString();
                    Ed = E;
                    N = n;
                }
            }
        }

        private void txtP_TextChanged(object sender, EventArgs e)
        {
            //reset e,d,k1,k2 khi thay đổi p,q
            txtE.Text = "";
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            txtBan2.Text = "";
            dataGridView2.Rows.Clear();
            //chức năng mã hóa
            if (btnDo.Text == "Mã hóa")
            {
                //kiểm tra
                if (kiemTra())
                {
                    //hiện dgv 2
                    dataGridView1.Visible = false;
                    dataGridView2.Visible = true;
                    //lấy dữ liệu
                    long m = Convert.ToInt32(txtBan1.Text);
                    long E = Convert.ToInt32(txtK1.Text);
                    BigInteger n = Convert.ToInt32(txtK2.Text);

                    //hiển thị
                    string somu = Convert.ToString(E, 2);
                    BigInteger ketqua = 1, coso = m;
                    dataGridView2.Rows.Add(new string[3] { somu, ketqua.ToString(), coso.ToString() });
                    for (int i = somu.Length - 1; i >= 0; i--)
                    {
                        if (somu[i] == '0')
                        {
                            coso = (coso * coso) % n;
                            dataGridView2.Rows.Add(new string[3] { somu[i].ToString(), "__", coso.ToString() });
                        }
                        else
                        {
                            ketqua = (ketqua * coso) % n;
                            coso = (coso * coso) % n;
                            dataGridView2.Rows.Add(new string[3] { somu[i].ToString(), ketqua.ToString(), coso.ToString() });
                        }
                    }
                    //in kq
                    txtBan2.Text = ketqua.ToString();
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
                    //hiện dgv 2
                    dataGridView1.Visible = false;
                    dataGridView2.Visible = true;
                    //lấy dữ liệu
                    long m = Convert.ToInt32(txtBan1.Text);
                    long d = Convert.ToInt32(txtK1.Text);
                    BigInteger n = Convert.ToInt32(txtK2.Text);

                    //hiển thị
                    string somu = Convert.ToString(d, 2);
                    BigInteger ketqua = 1, coso = m;
                    dataGridView2.Rows.Add(new string[3] { somu, ketqua.ToString(), coso.ToString() });
                    for (int i = somu.Length - 1; i >= 0; i--)
                    {
                        if (somu[i] == '0')
                        {
                            coso = (coso * coso) % n;
                            dataGridView2.Rows.Add(new string[3] { somu[i].ToString(), "__", coso.ToString() });
                        }
                        else
                        {
                            ketqua = (ketqua * coso) % n;
                            coso = (coso * coso) % n;
                            dataGridView2.Rows.Add(new string[3] { somu[i].ToString(), ketqua.ToString(), coso.ToString() });
                        }
                    }
                    //in kq
                    txtBan2.Text = ketqua.ToString();
                }
                else
                {
                    //thông báo lỗi
                    MessageBox.Show(loi);
                }
            }
        }

        private void sWITCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chuyển đổi chức năng mã hóa và giải mã của form
            if (sWITCHToolStripMenuItem.Text == "Giải mã")
            {
                btnDo.Text = "Giải mã";
                label5.Text = "Bản mã";
                label3.Text = "Bản rõ";
                label7.Text = "Khóa bí mật: ";
                sWITCHToolStripMenuItem.Text = "Mã hóa";
            }
            else
            {
                btnDo.Text = "Mã hóa";
                label5.Text = "Bản rõ";
                label3.Text = "Bản mã";
                label7.Text = "Khóa công khai: ";
                sWITCHToolStripMenuItem.Text = "Giải mã";
            }
            xoaText();
        }

        private void hellpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trong chứng thực:\n + Mã hóa = giải mã trong bảo mật \n + Giải mã = mã hóa trong bảo mật", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xoaText();
        }
    }
}