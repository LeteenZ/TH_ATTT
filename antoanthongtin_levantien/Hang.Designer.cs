namespace antoanthongtin_levantien
{
    partial class Hang
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
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
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
            label2 = new Label();
            txtKhoa = new TextBox();
            txtBan1 = new TextBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { giảiMãToolStripMenuItem, mởFileToolStripMenuItem, lưuFileToolStripMenuItem, thoátToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
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
            dataGridView1.Location = new Point(12, 244);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 194);
            dataGridView1.TabIndex = 17;
            // 
            // btnDo
            // 
            btnDo.BackColor = SystemColors.ActiveCaption;
            btnDo.FlatStyle = FlatStyle.Flat;
            btnDo.Location = new Point(342, 194);
            btnDo.Name = "btnDo";
            btnDo.Size = new Size(120, 40);
            btnDo.TabIndex = 16;
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
            groupBox2.Size = new Size(244, 214);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Đầu ra";
            // 
            // txtBan2
            // 
            txtBan2.Location = new Point(45, 122);
            txtBan2.Name = "txtBan2";
            txtBan2.ReadOnly = true;
            txtBan2.Size = new Size(171, 23);
            txtBan2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 104);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 0;
            label3.Text = "Bản mã:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtKhoa);
            groupBox1.Controls.Add(txtBan1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(244, 214);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đầu vào";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 159);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Khóa:";
            // 
            // txtKhoa
            // 
            txtKhoa.Location = new Point(38, 177);
            txtKhoa.Name = "txtKhoa";
            txtKhoa.Size = new Size(171, 23);
            txtKhoa.TabIndex = 1;
            txtKhoa.TextChanged += txtKhoa_TextChanged;
            // 
            // txtBan1
            // 
            txtBan1.Location = new Point(38, 83);
            txtBan1.Name = "txtBan1";
            txtBan1.Size = new Size(171, 23);
            txtBan1.TabIndex = 1;
            txtBan1.TextChanged += txtBan1_TextChanged;
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
            // Hang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnDo);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Name = "Hang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hang";
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
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
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
        private TextBox txtKhoa;
        private TextBox txtBan1;
        private Label label1;
    }
}