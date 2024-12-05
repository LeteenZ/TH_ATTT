namespace antoanthongtin_levantien
{
    partial class Affine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            giảiMãToolStripMenuItem = new ToolStripMenuItem();
            mởFileToolStripMenuItem = new ToolStripMenuItem();
            lưuFileToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            btnDo = new Button();
            groupBox2 = new GroupBox();
            txtBan2 = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            txtKhoa2 = new TextBox();
            txtKhoa1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtBan1 = new TextBox();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { giảiMãToolStripMenuItem, mởFileToolStripMenuItem, lưuFileToolStripMenuItem, thoátToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // giảiMãToolStripMenuItem
            // 
            giảiMãToolStripMenuItem.Name = "giảiMãToolStripMenuItem";
            giảiMãToolStripMenuItem.Size = new Size(59, 20);
            giảiMãToolStripMenuItem.Text = "Giải mã";
            giảiMãToolStripMenuItem.Click += giảiMãToolStripMenuItem_Click;
            // 
            // mởFileToolStripMenuItem
            // 
            mởFileToolStripMenuItem.Name = "mởFileToolStripMenuItem";
            mởFileToolStripMenuItem.Size = new Size(56, 20);
            mởFileToolStripMenuItem.Text = "Mở file";
            mởFileToolStripMenuItem.Click += mởFileToolStripMenuItem_Click;
            // 
            // lưuFileToolStripMenuItem
            // 
            lưuFileToolStripMenuItem.Name = "lưuFileToolStripMenuItem";
            lưuFileToolStripMenuItem.Size = new Size(58, 20);
            lưuFileToolStripMenuItem.Text = "Lưu file";
            lưuFileToolStripMenuItem.Click += lưuFileToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(49, 20);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(262, 244);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(276, 194);
            dataGridView1.TabIndex = 9;
            // 
            // btnDo
            // 
            btnDo.BackColor = SystemColors.ActiveCaption;
            btnDo.FlatStyle = FlatStyle.Flat;
            btnDo.Location = new Point(342, 194);
            btnDo.Name = "btnDo";
            btnDo.Size = new Size(120, 40);
            btnDo.TabIndex = 8;
            btnDo.Text = "Mã hóa";
            btnDo.UseVisualStyleBackColor = false;
            btnDo.Click += btnDo_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtBan2);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(544, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(244, 411);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Đầu ra";
            // 
            // txtBan2
            // 
            txtBan2.Location = new Point(54, 177);
            txtBan2.Name = "txtBan2";
            txtBan2.ReadOnly = true;
            txtBan2.Size = new Size(171, 23);
            txtBan2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 159);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 0;
            label3.Text = "Bản mã:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtKhoa2);
            groupBox1.Controls.Add(txtKhoa1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBan1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(244, 411);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đầu vào";
            // 
            // txtKhoa2
            // 
            txtKhoa2.Location = new Point(122, 249);
            txtKhoa2.Name = "txtKhoa2";
            txtKhoa2.Size = new Size(38, 23);
            txtKhoa2.TabIndex = 4;
            txtKhoa2.TextChanged += txtKhoa2_TextChanged;
            // 
            // txtKhoa1
            // 
            txtKhoa1.Location = new Point(61, 249);
            txtKhoa1.Name = "txtKhoa1";
            txtKhoa1.Size = new Size(38, 23);
            txtKhoa1.TabIndex = 4;
            txtKhoa1.TextChanged += txtKhoa2_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(105, 251);
            label6.Name = "label6";
            label6.Size = new Size(13, 21);
            label6.TabIndex = 3;
            label6.Text = ",";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(166, 242);
            label5.Name = "label5";
            label5.Size = new Size(19, 30);
            label5.TabIndex = 3;
            label5.Text = ")";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(36, 242);
            label4.Name = "label4";
            label4.Size = new Size(19, 30);
            label4.TabIndex = 3;
            label4.Text = "(";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 217);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Khóa(a,b):";
            // 
            // txtBan1
            // 
            txtBan1.Location = new Point(38, 83);
            txtBan1.Name = "txtBan1";
            txtBan1.Size = new Size(171, 23);
            txtBan1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 65);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Bản rõ:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Affine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnDo);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Affine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Affine";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem giảiMãToolStripMenuItem;
        private ToolStripMenuItem mởFileToolStripMenuItem;
        private ToolStripMenuItem lưuFileToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private DataGridView dataGridView1;
        private Button btnDo;
        private GroupBox groupBox2;
        private TextBox txtBan2;
        private Label label3;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtBan1;
        private Label label1;
        private Label label4;
        private TextBox txtKhoa2;
        private TextBox txtKhoa1;
        private Label label6;
        private Label label5;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}