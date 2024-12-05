namespace antoanthongtin_levantien
{
    partial class Hill
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
            bậc3ToolStripMenuItem = new ToolStripMenuItem();
            mởFileToolStripMenuItem = new ToolStripMenuItem();
            lưuFileToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            btnDo = new Button();
            groupBox2 = new GroupBox();
            txtBan2 = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtK33 = new TextBox();
            txtK32 = new TextBox();
            txtK31 = new TextBox();
            txtK23 = new TextBox();
            txtK22 = new TextBox();
            txtK21 = new TextBox();
            txtK13 = new TextBox();
            txtK12 = new TextBox();
            txtK11 = new TextBox();
            label2 = new Label();
            txtBan1 = new TextBox();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { giảiMãToolStripMenuItem, bậc3ToolStripMenuItem, mởFileToolStripMenuItem, lưuFileToolStripMenuItem, thoátToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // giảiMãToolStripMenuItem
            // 
            giảiMãToolStripMenuItem.Name = "giảiMãToolStripMenuItem";
            giảiMãToolStripMenuItem.Size = new Size(59, 20);
            giảiMãToolStripMenuItem.Text = "Giải mã";
            giảiMãToolStripMenuItem.Click += sWITCHToolStripMenuItem_Click;
            // 
            // bậc3ToolStripMenuItem
            // 
            bậc3ToolStripMenuItem.Name = "bậc3ToolStripMenuItem";
            bậc3ToolStripMenuItem.Size = new Size(47, 20);
            bậc3ToolStripMenuItem.Text = "Bậc 3";
            bậc3ToolStripMenuItem.Click += bậc3ToolStripMenuItem_Click;
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
            // btnDo
            // 
            btnDo.BackColor = SystemColors.ActiveCaption;
            btnDo.FlatStyle = FlatStyle.Flat;
            btnDo.Location = new Point(346, 199);
            btnDo.Name = "btnDo";
            btnDo.Size = new Size(120, 40);
            btnDo.TabIndex = 6;
            btnDo.Text = "Mã hóa";
            btnDo.UseVisualStyleBackColor = false;
            btnDo.Click += btnDo_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtBan2);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(543, 32);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(244, 411);
            groupBox2.TabIndex = 4;
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
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBan1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(244, 411);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đầu vào";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(txtK33, 2, 2);
            tableLayoutPanel1.Controls.Add(txtK32, 1, 2);
            tableLayoutPanel1.Controls.Add(txtK31, 0, 2);
            tableLayoutPanel1.Controls.Add(txtK23, 2, 1);
            tableLayoutPanel1.Controls.Add(txtK22, 1, 1);
            tableLayoutPanel1.Controls.Add(txtK21, 0, 1);
            tableLayoutPanel1.Controls.Add(txtK13, 2, 0);
            tableLayoutPanel1.Controls.Add(txtK12, 1, 0);
            tableLayoutPanel1.Controls.Add(txtK11, 0, 0);
            tableLayoutPanel1.Location = new Point(38, 235);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(122, 98);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // txtK33
            // 
            txtK33.Dock = DockStyle.Fill;
            txtK33.Location = new Point(83, 67);
            txtK33.Multiline = true;
            txtK33.Name = "txtK33";
            txtK33.Size = new Size(36, 28);
            txtK33.TabIndex = 8;
            // 
            // txtK32
            // 
            txtK32.Dock = DockStyle.Fill;
            txtK32.Location = new Point(43, 67);
            txtK32.Multiline = true;
            txtK32.Name = "txtK32";
            txtK32.Size = new Size(34, 28);
            txtK32.TabIndex = 7;
            txtK32.KeyDown += txtK32_KeyDown;
            // 
            // txtK31
            // 
            txtK31.Dock = DockStyle.Fill;
            txtK31.Location = new Point(3, 67);
            txtK31.Multiline = true;
            txtK31.Name = "txtK31";
            txtK31.Size = new Size(34, 28);
            txtK31.TabIndex = 6;
            txtK31.KeyDown += txtK31_KeyDown;
            // 
            // txtK23
            // 
            txtK23.Dock = DockStyle.Fill;
            txtK23.Location = new Point(83, 35);
            txtK23.Multiline = true;
            txtK23.Name = "txtK23";
            txtK23.Size = new Size(36, 26);
            txtK23.TabIndex = 5;
            txtK23.KeyDown += txtK23_KeyDown;
            // 
            // txtK22
            // 
            txtK22.Dock = DockStyle.Fill;
            txtK22.Location = new Point(43, 35);
            txtK22.Multiline = true;
            txtK22.Name = "txtK22";
            txtK22.Size = new Size(34, 26);
            txtK22.TabIndex = 4;
            txtK22.KeyDown += txtK22_KeyDown;
            // 
            // txtK21
            // 
            txtK21.Dock = DockStyle.Fill;
            txtK21.Location = new Point(3, 35);
            txtK21.Multiline = true;
            txtK21.Name = "txtK21";
            txtK21.Size = new Size(34, 26);
            txtK21.TabIndex = 3;
            txtK21.KeyDown += txtK21_KeyDown;
            // 
            // txtK13
            // 
            txtK13.Dock = DockStyle.Fill;
            txtK13.Location = new Point(83, 3);
            txtK13.Multiline = true;
            txtK13.Name = "txtK13";
            txtK13.Size = new Size(36, 26);
            txtK13.TabIndex = 2;
            txtK13.KeyDown += txtK13_KeyDown;
            // 
            // txtK12
            // 
            txtK12.Dock = DockStyle.Fill;
            txtK12.Location = new Point(43, 3);
            txtK12.Multiline = true;
            txtK12.Name = "txtK12";
            txtK12.Size = new Size(34, 26);
            txtK12.TabIndex = 1;
            txtK12.KeyDown += txtK12_KeyDown;
            // 
            // txtK11
            // 
            txtK11.Dock = DockStyle.Fill;
            txtK11.Location = new Point(3, 3);
            txtK11.Multiline = true;
            txtK11.Name = "txtK11";
            txtK11.Size = new Size(34, 26);
            txtK11.TabIndex = 0;
            txtK11.KeyDown += txtK11_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 217);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Khóa:";
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
            // Hill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDo);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Name = "Hill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hill";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem giảiMãToolStripMenuItem;
        private ToolStripMenuItem mởFileToolStripMenuItem;
        private ToolStripMenuItem lưuFileToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private Button btnDo;
        private GroupBox groupBox2;
        private TextBox txtBan2;
        private Label label3;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtBan1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtK33;
        private TextBox txtK32;
        private TextBox txtK31;
        private TextBox txtK23;
        private TextBox txtK22;
        private TextBox txtK21;
        private TextBox txtK13;
        private TextBox txtK12;
        private TextBox txtK11;
        private ToolStripMenuItem bậc3ToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}