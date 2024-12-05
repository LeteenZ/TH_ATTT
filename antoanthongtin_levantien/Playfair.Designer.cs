namespace antoanthongtin_levantien
{
    partial class Playfair
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
            sWITCHToolStripMenuItem = new ToolStripMenuItem();
            mởFileToolStripMenuItem = new ToolStripMenuItem();
            lưuFileToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            btnDo = new Button();
            groupBox2 = new GroupBox();
            txtBan2 = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            txtKhoa = new TextBox();
            label2 = new Label();
            txtBan1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sWITCHToolStripMenuItem, mởFileToolStripMenuItem, lưuFileToolStripMenuItem, thoátToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sWITCHToolStripMenuItem
            // 
            sWITCHToolStripMenuItem.Name = "sWITCHToolStripMenuItem";
            sWITCHToolStripMenuItem.Size = new Size(59, 20);
            sWITCHToolStripMenuItem.Text = "Giải mã";
            sWITCHToolStripMenuItem.Click += đảoNgượcToolStripMenuItem_Click;
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
            btnDo.Location = new Point(342, 194);
            btnDo.Name = "btnDo";
            btnDo.Size = new Size(120, 40);
            btnDo.TabIndex = 4;
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
            groupBox2.TabIndex = 2;
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
            groupBox1.Controls.Add(txtKhoa);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBan1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(244, 411);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đầu vào";
            // 
            // txtKhoa
            // 
            txtKhoa.Location = new Point(38, 235);
            txtKhoa.Name = "txtKhoa";
            txtKhoa.Size = new Size(171, 23);
            txtKhoa.TabIndex = 3;
            txtKhoa.TextChanged += txtBan1_TextChanged_1;
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
            txtBan1.TextChanged += txtBan1_TextChanged_1;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(262, 244);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(276, 194);
            dataGridView1.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Playfair
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
            Name = "Playfair";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Playfair";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sWITCHToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private Button btnDo;
        private GroupBox groupBox2;
        private TextBox txtBan2;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox txtKhoa;
        private Label label2;
        private TextBox txtBan1;
        private Label label1;
        private DataGridView dataGridView1;
        private ToolStripMenuItem mởFileToolStripMenuItem;
        private ToolStripMenuItem lưuFileToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}