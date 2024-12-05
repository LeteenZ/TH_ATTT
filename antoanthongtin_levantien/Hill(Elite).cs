using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace antoanthongtin_levantien
{
    public partial class Hill_Elite_ : Form
    {
        //lưu bậc
        private int bac = 1;
        //lưu lỗi
        private string loi = "";
        //lưu số kí tự x cần bỏ qua
        private int boqua = 0;
        //
        public Hill_Elite_()
        {
            InitializeComponent();
            //tắt phóng to, thu nhỏ của form
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //thiết kế giao diện datagridview: tự động co dãn và ẩn các header của hàng và cột
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

            this.Load += new EventHandler(btnThem_Click);
            btnXoa.Enabled = false;
            txtBan1.Select();

            label4.Visible = false;
            dataGridView1.Visible = false;
            tableLayoutPanel2.Visible = false;
        }
        //
        private void thoátToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
        //
        private void mởFileToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            try
            {
                // Cài đặt bộ lọc cho hộp thoại mở file, chỉ cho phép chọn các file có đuôi .txt
                openFileDialog1.Filter = "Text Files|*.txt";
                // Mở hộp thoại cho phép người dùng chọn file. Nếu người dùng chọn OK, tiến hành xử lý file
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Khởi tạo đối tượng StreamReader để đọc file được chọn
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    // Đọc dòng đầu tiên của file và gán vào TextBox 'txtBan1'
                    txtBan1.Text = sr.ReadLine();
                    // Khởi tạo một mảng để lưu trữ các dòng ma trận
                    string[] lines = new string[bac];

                    // Đọc từng dòng ma trận từ file và lưu vào mảng 'lines'
                    for (int i = 0; i < bac; i++)
                    {
                        // Đọc một dòng từ file, nếu dòng null thì gán chuỗi rỗng
                        lines[i] = sr.ReadLine() ?? "";
                        // Kiểm tra xem dòng có bị thiếu hay không, nếu thiếu thì thông báo lỗi và đóng file
                        if ( string.IsNullOrWhiteSpace(lines[i]))
                        {
                            MessageBox.Show("Bậc của ma trận hiện tại lớn bậc của ma trận trong bản ghi!");
                            sr.Close();
                            return;
                        }
                    }

                    // Đọc dòng cuối cùng từ file để lấy giá trị của biến boqua
                    string boquaLine = sr.ReadToEnd() ?? "";
                    // Kiểm tra xem giá trị đọc được có phải là một số nguyên hợp lệ không
                    if (int.TryParse(boquaLine, out int boqua))
                    {
                        this.boqua = boqua;
                    }
                    else
                    {
                        boqua = 0;
                        if (!string.IsNullOrWhiteSpace(boquaLine))
                        {
                            MessageBox.Show("Bậc của ma trận hiện tại nhỏ bậc của ma trận trong bản ghi!");
                            sr.Close();
                            return;
                        }
                    }

                    // Kiểm tra độ dài mỗi dòng ma trận và gán các giá trị vào các TextBox tương ứng
                    for (int i = 0; i < bac; i++)
                    {
                        // Tách các giá trị trong dòng thành mảng con 'values' bằng cách phân cách bởi dấu cách
                        string[] dong = lines[i].Split(' ');
                        // Kiểm tra xem số lượng phần tử trong dòng có khớp với bậc ma trận không
                        if (dong.Length != bac)
                        {
                            MessageBox.Show("Ma trận không đúng bậc " + bac + "!");
                            sr.Close();
                            boqua = 0;
                            return;
                        }

                        // Gán giá trị vào các TextBox trong form, theo thứ tự của dòng và cột
                        for (int j = 0; j < bac; j++)
                        {
                            // Tạo tên của TextBox theo định dạng 'txtKxy', trong đó x là chỉ số dòng, y là chỉ số cột
                            string ten = $"txtK{i + 1}{j + 1}";
                            // Tìm kiếm điều khiển (TextBox) có tên tương ứng trong bảng điều khiển (tableLayoutPanel1)
                            Control[] controls = tableLayoutPanel1.Controls.Find(ten, true);     //true: tìm kiếm cả trong các điều khiển con của các điều khiển con (nếu có)

                            // Nếu tìm thấy điều khiển và điều khiển đó là TextBox, gán giá trị vào TextBox
                            if (controls.Length > 0 && controls[0] is TextBox)
                            {
                                controls[0].Text = dong[j];
                            }
                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đọc thất bại!");
            }
        }
        //
        private void lưuFileToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (!kiemTra())
            {
                MessageBox.Show(loi);
                return;
            }
            try
            {
                // Mở hộp thoại lưu file Thiết lập bộ lọc để chỉ cho phép lưu các file có đuôi .txt
                saveFileDialog1.Filter = "Text Files|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Tạo đối tượng StreamWriter để ghi vào file với tên do người dùng chọn
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        // Lưu giá trị txtBan1 vào file
                        sw.WriteLine(txtBan2.Text);
                        // Duyệt qua các dòng trong ma trận (bac là kích thước ma trận)
                        for (int i = 0; i < bac; i++)
                        {
                            // Khởi tạo chuỗi line để lưu các giá trị trong một dòng ma trận
                            string line = "";
                            // Duyệt qua các cột trong ma trận
                            for (int j = 0; j < bac; j++)
                            {
                                // Tạo tên điều khiển (TextBox) theo mẫu txtK{row}{column}
                                string ten = $"txtK{i + 1}{j + 1}";
                                // Tìm điều khiển có tên tương ứng trong tableLayoutPanel1
                                Control[] controls = tableLayoutPanel1.Controls.Find(ten, true);    //true: tìm kiếm cả trong các điều khiển con của các điều khiển con (nếu có)

                                // Nếu tìm thấy điều khiển và điều khiển đó là một TextBox. Thêm nội dung của TextBox vào chuỗi line, cách nhau bởi dấu cách
                                if (controls.Length > 0 && controls[0] is TextBox)
                                {
                                    line += controls[0].Text + " ";
                                }
                            }
                            // Ghi dòng ma trận (sau khi đã loại bỏ khoảng trắng thừa) vào file
                            sw.WriteLine(line.Trim());
                        }
                        if (giảiMãToolStripMenuItem.Text == "Giải mã")
                        {
                            // Biến đếm số lượng ký tự 'x' ở cuối chuỗi trong txtBan1
                            int dem = 0;
                            // Lấy chiều dài của chuỗi trong txtBan1
                            int n = txtBan1.Text.Length;

                            // Bắt đầu từ cuối chuỗi và đếm số lượng 'x'
                            for (int i = n - 1; i >= 0; i--)
                            {
                                // Nếu gặp ký tự 'x' tăng biến đếm
                                if (txtBan1.Text[i] == 'x')
                                {
                                    dem++;
                                }
                                else
                                {
                                    break; // Dừng nếu không phải là 'x'
                                }
                            }
                            // Ghi số lượng 'x' vào file
                            sw.WriteLine(dem);

                            // Hiển thị thông báo lưu thành công
                            MessageBox.Show("Dữ liệu đã được lưu thành công!");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lưu thất bại!");
            }
        }
        //
        private void giảiMãToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            //chuyển đổi chức năng mã hóa và giải mã của form
            if (giảiMãToolStripMenuItem.Text == "Giải mã")
            {
                //thay đổi lại label của bản rõ, bản mã, chế độ mh/gm và nút thực hiện tính toán
                btnDo.Text = "Giải mã";
                label1.Text = "Bản mã";
                label3.Text = "Bản rõ";
                giảiMãToolStripMenuItem.Text = "Mã hóa";
                label4.Visible = true;
                dataGridView1.Visible = true;
                tableLayoutPanel2.Visible = true;
            }
            else
            {
                //thay đổi lại label của bản rõ, bản mã, chế độ mh/gm và nút thực hiện tính toán
                btnDo.Text = "Mã hóa";
                label1.Text = "Bản rõ";
                label3.Text = "Bản mã";
                giảiMãToolStripMenuItem.Text = "Giải mã";
                label4.Visible = false;
                dataGridView1.Visible = false;
                tableLayoutPanel2.Visible = false;
            }
            //xóa các dữ liệu trước đó khi thực hiện chuyển đổi chức năng
            xoaText();
        }
        //
        public bool kiemTra()
        {
            // Kiểm tra nếu nội dung là rỗng
            if (string.IsNullOrEmpty(txtBan1.Text))
            {
                loi = "Vui lòng nhập đầy đủ thông tin";
                return false;
            }
            // Kiểm tra nếu nội dung không phải là chuỗi chỉ chứa ký tự chữ cái
            if (!txtBan1.Text.All(char.IsLetter))
            {
                loi = "Vui lòng chỉ nhập các ký tự chữ cái";
                return false;
            }
            //kiểm tra textbox
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                //kiểm tra nếu thành phần trong tablepanel là textbox
                if (control is TextBox textBox)
                {
                    //kiểm tra nếu nội dung nhập vào là rỗng
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        loi = "Vui lòng nhập đầy đủ thông tin";
                        return false;
                    }

                    // Kiểm tra nếu nội dung không phải là số nguyên
                    if (!int.TryParse(textBox.Text, out int x)) 
                    {
                        loi = "Vui lòng nhập lại khóa theo kiểu số nguyên";
                        return false;
                    }

                    if (x < 0 || x > 25) // Kiểm tra nếu giá trị ngoài khoảng [0,25]
                    {
                        loi = "Vui lòng nhập các phần tử khóa trong [0,25]";
                        return false;
                    }
                }
            }
            // Lấy khóa mã hóa từ các ô TextBox trong TableLayoutPanel
            int[,] khoa = new int[bac, bac];
            for (int row = 0; row < bac; row++)
            {
                for (int col = 0; col < bac; col++)
                {
                    // Tạo tên TextBox theo định dạng txtKxy
                    string txtBoxName = "txtK" + (row + 1) + (col + 1);
                    // Lấy TextBox từ TableLayoutPanel
                    TextBox txtBox = tableLayoutPanel1.Controls
                        .OfType<TextBox>()                                                  //tạo một danh sách chỉ chứa các đối tượng kiểu TextBox trong Controls.
                        .FirstOrDefault(tb => tb.Name == txtBoxName) ?? new TextBox();      //tìm phần tử đầu tiên trong danh sách các TextBox mà có thuộc tính Name khớp với giá trị của biến txtBoxName

                    // Nếu tìm thấy TextBox, lấy dữ liệu từ nó
                    khoa[row, col] = int.Parse(txtBox.Text);
                }
            }

            // Tính định thức của ma trận khóa và nghịch đảo của ma trận khóa mod 26
            int det = new MaTranNghich().TinhDinhThuc(khoa, bac);
            // Xét trường hợp nếu det = 0
            if (det == 0)
            {
                loi = "Vui lòng nhập lại ma trận sao cho det(K) của ma trận != 0";
                return false;
            }
            if (gcd(det, 26) != 1)
            {
                loi = "Vui lòng nhập lại ma trận sao cho ưcln det(K) và 26 là 1";
                return false;
            }
            //nếu đáp ứng tất cả các điều kiện trả về true
            return true;
        }
        //
        public void xoaText()
        {
            //xóa dữ liệu đầu vào, ra
            txtBan1.Text = "";
            txtBan2.Text = "";
            //xóa nội dung đã hiển thị trên datagridview
            dataGridView1.Rows.Clear();
            boqua = 0;
        }
        //
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
        //
        public int euclide(int x, int y)
        {
            //thực hiện dùng thuật toán euclide mở rộng để tính toán và in ra datagridview

            // Xóa tất cả các dòng hiện có trong DataGridView trước khi thêm kết quả mới
            dataGridView1.Rows.Clear();
            int q1 = x, q2 = y, t1 = 0, t2 = 1, r = 0, temp;
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
            dataGridView1.Rows.Add("a^-1", "=", t1, null, null);
            return t1;
        }
        //
        private void toolStripMenuItem3_TextChanged(object? sender, EventArgs e)
        {
            // Kiểm tra nếu văn bản của toolStripMenuItem3 là "2" thì vô hiệu hóa nút xóa vì không có ma trận bậc 1
            if (toolStripMenuItem3.Text == "2")
            {
                btnXoa.Enabled = false;
            }
            // Kiểm tra nếu văn bản của toolStripMenuItem3 là "8" thì vô hiệu hóa nút thêm vì từ bậc 8 trở đi ô quá nhỏ không thể nhìn rõ số
            else if (toolStripMenuItem3.Text == "8")
            {
                btnThem.Enabled = false;
            }
            // Kích hoạt lại nút thêm và xóa
            else
            {
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
            }

            //xóa các dữ liệu đầu vào, ra, và khóa khi thực hiện đổi chế độ
            xoaText();
            //Cập nhật bậc của ma trận 
            bac = Convert.ToInt32(toolStripMenuItem3.Text);

            // Lấy số lượng hàng và cột hiện tại của TableLayoutPanel
            int hangs = tableLayoutPanel1.RowCount;
            int cots = tableLayoutPanel1.ColumnCount;

            // Xóa các kiểu dáng hàng và cột cũ trong TableLayoutPanel
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();

            // Cấu hình hàng, cột: Chia đều các hàng, cột theo tỷ lệ phần trăm (100f = float 100%: nằm tính theo % chính xác)
            for (int i = 0; i < hangs; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / hangs));
            }
            for (int i = 0; i < cots; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / cots));
            }

            //tương tự panel2

            // Xóa các kiểu dáng hàng và cột cũ trong TableLayoutPanel
            tableLayoutPanel2.RowStyles.Clear();
            tableLayoutPanel2.ColumnStyles.Clear();

            // Cấu hình hàng, cột: Chia đều các hàng, cột theo tỷ lệ phần trăm (100f = float 100%: nằm tính theo % chính xác)
            for (int i = 0; i < hangs; i++)
            {
                tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / hangs));
            }
            for (int i = 0; i < cots; i++)
            {
                tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / cots));
            }
        }
        //
        private void btnThem_Click(object? sender, EventArgs e)
        {
            // Tăng số lượng hàng và cột lên 1
            tableLayoutPanel1.ColumnCount++;
            tableLayoutPanel1.RowCount++;

            // Duyệt qua từng hàng và cột của TableLayoutPanel để thêm TextBox mới
            for (int hang = 0; hang < tableLayoutPanel1.RowCount; hang++)
            {
                for (int cot = 0; cot < tableLayoutPanel1.ColumnCount; cot++)
                {
                    // Kiểm tra nếu ô này chưa có TextBox, nếu không có thì tạo mới một TextBox
                    if (tableLayoutPanel1.GetControlFromPosition(cot, hang) == null)
                    {
                        // Tạo một TextBox mới
                        TextBox txtBox = new TextBox();
                        txtBox.Name = "txtK" + (hang + 1) + (cot + 1);   //Đặt Name cho txt để gọi
                        txtBox.Multiline = true;                        //Đặt cho nhiều dòng
                        txtBox.Dock = DockStyle.Fill;                   // Để TextBox lấp đầy ô control
                        txtBox.KeyDown += txtK11_KeyDown;               //thêm sự kiện khi ấn enter

                        // Thêm TextBox vào TableLayoutPanel tại vị trí cột và hàng tương ứng
                        tableLayoutPanel1.Controls.Add(txtBox, cot, hang);
                    }
                }
            }

            //tương tự ở panel2
            // Tăng số lượng hàng và cột lên 1
            tableLayoutPanel2.ColumnCount++;
            tableLayoutPanel2.RowCount++;

            // Duyệt qua từng hàng và cột của TableLayoutPanel để thêm TextBox mới
            for (int hang = 0; hang < tableLayoutPanel2.RowCount; hang++)
            {
                for (int cot = 0; cot < tableLayoutPanel2.ColumnCount; cot++)
                {
                    // Kiểm tra nếu ô này chưa có TextBox, nếu không có thì tạo mới một TextBox
                    if (tableLayoutPanel2.GetControlFromPosition(cot, hang) == null)
                    {
                        // Tạo một TextBox mới
                        TextBox txtBox = new TextBox();
                        txtBox.Name = "txtK" + (hang + 1) + (cot + 1) + 1;   //Đặt Name cho txt để gọi
                        txtBox.Multiline = true;                        //Đặt cho nhiều dòng
                        txtBox.Dock = DockStyle.Fill;                   // Để TextBox lấp đầy ô control
                        txtBox.KeyDown += txtK11_KeyDown;               //thêm sự kiện khi ấn enter
                        txtBox.ReadOnly = true;                         //Không cho chỉnh sửa
                        // Thêm TextBox vào TableLayoutPanel tại vị trí cột và hàng tương ứng
                        tableLayoutPanel2.Controls.Add(txtBox, cot, hang);
                    }
                }
            }

            // Cập nhật văn bản của toolStripMenuItem3 để hiển thị giá trị của bac + 1
            toolStripMenuItem3.Text = "" + (bac + 1);
        }
        //
        private void btnXoa_Click(object? sender, EventArgs e)
        {
            // Lấy chỉ số hàng và cột cuối cùng trong TableLayoutPanel
            int hangCuoi = tableLayoutPanel1.RowCount - 1;
            int cotCuoi = tableLayoutPanel1.ColumnCount - 1;

            // Kiểm tra số hàng và số cột có hợp lệ để xóa hay không (phải lớn hơn 0)
            if (hangCuoi < 0 || cotCuoi < 0)
            {
                MessageBox.Show("Không có hàng hoặc cột nào để xóa.");
                return;
            }

            // Xóa các TextBox trong hàng, cột cuối cùng
            for (int cot = 0; cot <= cotCuoi; cot++)
            {
                // Lấy điều khiển tại vị trí của các cột ở hàng cuối
                var control = tableLayoutPanel1.GetControlFromPosition(cot, hangCuoi);
                // Nếu điều khiển không null (tồn tại)
                if (control != null)
                {
                    // Loại bỏ điều khiển khỏi TableLayoutPanel
                    tableLayoutPanel1.Controls.Remove(control);
                    // Giải phóng tài nguyên của điều khiển
                    control.Dispose();
                }
            }
            for (int hang = 0; hang <= hangCuoi; hang++)
            {
                // Lấy điều khiển tại vị trí các hàng ở cột cuối
                var control = tableLayoutPanel1.GetControlFromPosition(cotCuoi, hang);
                // Nếu điều khiển không null (tồn tại)
                if (control != null)
                {
                    // Loại bỏ điều khiển khỏi TableLayoutPanel
                    tableLayoutPanel1.Controls.Remove(control);
                    // Giải phóng tài nguyên của điều khiển
                    control.Dispose();
                }
            }

            // Giảm số hàng và cột nếu còn lớn hơn 0
            if (tableLayoutPanel1.RowCount > 1)
            {
                tableLayoutPanel1.RowCount--;
            }
            if (tableLayoutPanel1.ColumnCount > 1)
            {
                tableLayoutPanel1.ColumnCount--;
            }

            //tương tự panel2
            // Xóa các TextBox trong hàng, cột cuối cùng
            for (int cot = 0; cot <= cotCuoi; cot++)
            {
                // Lấy điều khiển tại vị trí của các cột ở hàng cuối
                var control = tableLayoutPanel2.GetControlFromPosition(cot, hangCuoi);
                // Nếu điều khiển không null (tồn tại)
                if (control != null)
                {
                    // Loại bỏ điều khiển khỏi TableLayoutPanel
                    tableLayoutPanel2.Controls.Remove(control);
                    // Giải phóng tài nguyên của điều khiển
                    control.Dispose();
                }
            }
            for (int hang = 0; hang <= hangCuoi; hang++)
            {
                // Lấy điều khiển tại vị trí các hàng ở cột cuối
                var control = tableLayoutPanel2.GetControlFromPosition(cotCuoi, hang);
                // Nếu điều khiển không null (tồn tại)
                if (control != null)
                {
                    // Loại bỏ điều khiển khỏi TableLayoutPanel
                    tableLayoutPanel2.Controls.Remove(control);
                    // Giải phóng tài nguyên của điều khiển
                    control.Dispose();
                }
            }

            // Giảm số hàng và cột nếu còn lớn hơn 0
            if (tableLayoutPanel2.RowCount > 1)
            {
                tableLayoutPanel2.RowCount--;
            }
            if (tableLayoutPanel2.ColumnCount > 1)
            {
                tableLayoutPanel2.ColumnCount--;
            }

            //cập nhật lại bậc của chương trình
            toolStripMenuItem3.Text = "" + (bac - 1);
        }
        //
        private void btnDo_Click(object? sender, EventArgs e)
        {
            // Xóa nội dung TextBox txtBan2 trước khi thực hiện mã hóa hoặc giải mã
            txtBan2.Text = "";
            // Chế độ mã hóa
            if (btnDo.Text == "Mã hóa")
            {
                // Kiểm tra điều kiện đầu vào hợp lệ
                if (kiemTra())
                {
                    // Lấy khóa mã hóa từ các ô TextBox trong TableLayoutPanel
                    int[,] khoa = new int[bac, bac];
                    for (int row = 0; row < bac; row++)
                    {
                        for (int col = 0; col < bac; col++)
                        {
                            // Tạo tên TextBox theo định dạng txtKxy
                            string txtBoxName = "txtK" + (row + 1) + (col + 1);
                            // Lấy TextBox từ TableLayoutPanel
                            TextBox txtBox = tableLayoutPanel1.Controls
                                .OfType<TextBox>()                                                  //tạo một danh sách chỉ chứa các đối tượng kiểu TextBox trong Controls.
                                .FirstOrDefault(tb => tb.Name == txtBoxName) ?? new TextBox();      //tìm phần tử đầu tiên trong danh sách các TextBox mà có thuộc tính Name khớp với giá trị của biến txtBoxName

                            // Nếu tìm thấy TextBox, lấy dữ liệu từ nó
                            khoa[row, col] = int.Parse(txtBox.Text);
                        }
                    }

                    //lấy bản 1
                    string ban = txtBan1.Text;
                    // Đảm bảo độ dài của bản mã chia hết cho kích thước của ma trận. Nếu không đủ, thêm 'X' vào cuối để đủ kích thước
                    while (ban.Length % bac != 0)
                    {
                        ban += "X";
                    }

                    // Chuyển các ký tự thành mã ASCII và lưu lại để chuyển sang chữ hoa hoặc thường khi in kết quả
                    int[] hoa_thuong = ban.Select(c => char.IsUpper(c) ? 65 : 97).ToArray();
                    // Chuyển bản 1 ban đầu thành các kí tự in hoa và lưu thành mảng 1 chiều
                    char[] chuoi = ban.Select(c => char.ToUpper(c)).ToArray();

                    // Tạo ma trận bản mã (ban1) với số hàng = chiều dài chuỗi / kích thước ma trận
                    int[,] ban1 = new int[chuoi.Length / bac, bac];
                    // Duyệt từng phần tử trong mảng chuoi để chuyển thành số nhằm thực hiện cho việc tính toán
                    for (int i = 0; i < (chuoi.Length / bac); i++)
                    {
                        for (int j = 0; j < bac; j++)
                        {
                            ban1[i, j] = chuoi[i * bac + j] - 'A'; // Chuyển đổi ký tự thành số (a=0, b=1, ..., z=25)
                        }
                    }

                    int kq = 0;     //biến lưu kết quả tạm thời của lần tính toán khi thực hiện nhân ma trận [1 * bac] vói ma trận khóa [bac * bac]
                    int x = 0;      //biến duyệt từng số thứ tự trong mảng hoa_thuong nhằm hiện thị kí tự hoa/thường so với bản 1

                    //tính toán
                    for (int i = 0; i < (chuoi.Length / bac); i++)
                    {
                        for (int j = 0; j < bac; j++)
                        {
                            //reset biến kq để thực hiện phép tính tiếp theo
                            kq = 0;

                            //nhân ma trận
                            for (int k = 0; k < bac; k++)
                            {
                                kq += ban1[i, k] * khoa[j, k];
                            }

                            // Đảm bảo kết quả không âm, lấy modulo 26 để đảm bảo kết quả trong phạm vi (0-25)
                            while (kq < 0)
                                kq += 26;

                            // Chuyển kết quả về ký tự và hiển thị
                            txtBan2.Text += Convert.ToChar(kq % 26 + hoa_thuong[x]);
                            //duyệt phần tử tiếp theo của mảng hoa_thuong
                            x++;
                        }
                    }
                }
                else
                {
                    MessageBox.Show(loi);
                }
            }
            // Chế độ giải mã
            else
            {
                // Kiểm tra điều kiện đầu vào hợp lệ
                if (kiemTra())
                {
                    //lấy bản 1
                    string ban = txtBan1.Text;
                    // Đảm bảo độ dài của bản mã chia hết cho kích thước của ma trận. Nếu không đủ, yêu cầu nhập lại
                    if (ban.Length % bac != 0)
                    {
                        MessageBox.Show("Vui lòng nhập lại bản mã. Bạn đã nhập thiếu bản mã(chiều dài của bản mã không chia hết cho bậc của ma trận)");
                        txtBan1.Select();
                        return;
                    }
                    // Chuyển các ký tự thành mã ASCII và lưu lại để chuyển sang chữ hoa hoặc thường khi in kết quả
                    int[] hoa_thuong = ban.Select(c => char.IsUpper(c) ? 65 : 97).ToArray();
                    // Chuyển bản 1 ban đầu thành các kí tự in hoa và lưu thành mảng 1 chiều
                    char[] chuoi = ban.Select(c => char.ToUpper(c)).ToArray();

                    // Tạo ma trận bản mã (ban1) với số hàng = chiều dài chuỗi / kích thước ma trận
                    int[,] ban1 = new int[chuoi.Length / bac, bac];
                    // Duyệt từng phần tử trong mảng chuoi để chuyển thành số nhằm thực hiện cho việc tính toán
                    for (int i = 0; i < (chuoi.Length / bac); i++)
                    {
                        for (int j = 0; j < bac; j++)
                        {
                            ban1[i, j] = chuoi[i * bac + j] - 'A'; // Chuyển đổi ký tự thành số (a=0, b=1, ..., z=25)
                        }
                    }

                    // Lấy khóa mã hóa từ các ô TextBox trong TableLayoutPanel
                    int[,] khoa = new int[bac, bac];
                    for (int row = 0; row < bac; row++)
                    {
                        for (int col = 0; col < bac; col++)
                        {
                            // Tạo tên TextBox theo định dạng txtKxy
                            string txtBoxName = "txtK" + (row + 1) + (col + 1);
                            // Lấy TextBox từ TableLayoutPanel
                            TextBox txtBox = tableLayoutPanel1.Controls
                                .OfType<TextBox>()                                                  //tạo một danh sách chỉ chứa các đối tượng kiểu TextBox trong Controls.
                                .FirstOrDefault(tb => tb.Name == txtBoxName) ?? new TextBox();      //tìm phần tử đầu tiên trong danh sách các TextBox mà có thuộc tính Name khớp với giá trị của biến txtBoxName

                            // Nếu tìm thấy TextBox, lấy dữ liệu từ nó
                            khoa[row, col] = int.Parse(txtBox.Text);
                        }
                    }

                    // Tính định thức của ma trận khóa và nghịch đảo của ma trận khóa mod 26
                    int det = new MaTranNghich().TinhDinhThuc(khoa, bac);
                    // Áp dụng thuật toán Euclid để tìm nghịch đảo của định thức mod 26
                    int det_1 = euclide(26, det);
                    // Tính ma trận nghịch đảo
                    int[,] khoa_dao = new MaTranNghich().MaTranNghichDao(khoa, det_1, bac);
                    //hiển thị
                    for (int row = 0; row < bac; row++)
                    {
                        for (int col = 0; col < bac; col++)
                        {
                            // Tạo tên TextBox theo định dạng txtKxy
                            string txtBoxName = "txtK" + (row + 1) + (col + 1) + 1;
                            // Lấy TextBox từ TableLayoutPanel
                            TextBox txtBox = tableLayoutPanel2.Controls
                                .OfType<TextBox>()                                                  //tạo một danh sách chỉ chứa các đối tượng kiểu TextBox trong Controls.
                                .FirstOrDefault(tb => tb.Name == txtBoxName) ?? new TextBox();      //tìm phần tử đầu tiên trong danh sách các TextBox mà có thuộc tính Name khớp với giá trị của biến txtBoxName

                            // Nếu tìm thấy TextBox, lấy dữ liệu từ nó
                            txtBox.Text = khoa_dao[row, col] + "";
                        }
                    }

                    string hienthi = "";    //biến hiển thị
                    int kq = 0;             //biến lưu kết quả tạm thời của lần tính toán khi thực hiện nhân ma trận [1 * bac] vói ma trận khóa [bac * bac]
                    int x = 0;              //biến duyệt từng số thứ tự trong mảng hoa_thuong nhằm hiện thị kí tự hoa/thường so với bản 1

                    //tính toán
                    for (int i = 0; i < (chuoi.Length / bac); i++)
                    {
                        for (int j = 0; j < bac; j++)
                        {
                            //reset biến kq để thực hiện phép tính tiếp theo
                            kq = 0;

                            //nhân ma trận
                            for (int k = 0; k < bac; k++)
                            {
                                kq += ban1[i, k] * khoa_dao[j, k];
                            }

                            // Đảm bảo kết quả không âm, lấy modulo 26 để đảm bảo kết quả trong phạm vi (0-25)
                            while (kq < 0)
                                kq += 26;

                            // Chuyển kết quả về ký tự
                            hienthi += Convert.ToChar(kq % 26 + hoa_thuong[x]);
                            //duyệt phần tử tiếp theo của mảng hoa_thuong
                            x++;
                        }
                    }

                    // Xử lý loại bỏ ký tự 'x' được thêm vào trong quá trình mã hóa
                    int countX = 0;                 // Biến để đếm số lượng 'x' ở cuối
                    int a = hienthi.Length - 1;     // Biến lưu độ dài chuỗi hiển thị

                    // Đếm các 'x' ở cuối chuỗi
                    while (a >= 0 && char.ToUpper(hienthi[a]) == 'X')
                    {
                        countX++;
                        a--;
                    }

                    // Chỉ xóa các ký tự 'x' ở cuối, nhưng giữ lại k ký tự "x" cuối cùng từ bản 1
                    txtBan2.Text = hienthi.Substring(0, hienthi.Length - countX + boqua);
                }
                else
                {
                    MessageBox.Show(loi);
                }
            }
        }
        //
        private void txtK11_KeyDown(object? sender, KeyEventArgs e)
        {
            // Kiểm tra xem phím được nhấn có phải là Enter không
            if (e.KeyCode == Keys.Enter)
            {
                // Ngừng xử lý sự kiện Enter mặc định (không tạo thêm dòng mới trong TextBox)
                e.SuppressKeyPress = true;

                // Ép kiểu sender thành TextBox và lấy tên của TextBox (?.Name để trả về null nếu ko ép kiểu thành công)
                string textBoxName = (sender as TextBox)?.Name.Trim() ?? "";

                // Lấy số hàng (a) và số cột (b) từ tên TextBox (ví dụ: txtK11 -> a = 1, b = 1)
                int a = Convert.ToInt32(textBoxName[textBoxName.Length - 2].ToString());
                int b = Convert.ToInt32(textBoxName[textBoxName.Length - 1].ToString());

                // Nếu tên TextBox rỗng hoặc nếu đã đến cuối ma trận, không làm gì
                if (textBoxName == "" || (a == bac && b == bac))
                    return;

                // Nếu cột đã đến bac, chuyển sang hàng tiếp theo và reset cột về 1 và chuyển sang hàng tiếp theo
                if (b == bac)
                {
                    b = 1;
                    a++;
                }
                else
                {
                    // Nếu chưa đến cột cuối, tăng số cột lên 1
                    b++;
                }

                // Tìm TextBox tiếp theo trong bảng với tên "txtK{a}{b}" và đặt focus vào nó
                Control textBoxControl = tableLayoutPanel1.Controls["txtK" + a + b] ?? new Control();
                textBoxControl.Focus();
            }
        }
        //
        private void resetToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            xoaText();
            //tìm các control của tablepanel xem cái nào là textbox
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is TextBox textBox)
                {
                    // Xóa nội dung của TextBox
                    textBox.Text = "";
                }
            }
            foreach (Control control in tableLayoutPanel2.Controls)
            {
                if (control is TextBox textBox)
                {
                    // Xóa nội dung của TextBox
                    textBox.Text = "";
                }
            }
        }
    }
}