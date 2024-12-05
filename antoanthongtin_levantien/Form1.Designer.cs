namespace antoanthongtin_levantien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            lựaChọnToolStripMenuItem = new ToolStripMenuItem();
            mởFileToolStripMenuItem = new ToolStripMenuItem();
            lưuFileToolStripMenuItem = new ToolStripMenuItem();
            giảiMãToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1 = new GroupBox();
            txtKhoa = new TextBox();
            txtBanro = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtBanma = new TextBox();
            label3 = new Label();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { lựaChọnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // lựaChọnToolStripMenuItem
            // 
            lựaChọnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mởFileToolStripMenuItem, lưuFileToolStripMenuItem, giảiMãToolStripMenuItem, thoátToolStripMenuItem });
            lựaChọnToolStripMenuItem.Name = "lựaChọnToolStripMenuItem";
            lựaChọnToolStripMenuItem.Size = new Size(68, 20);
            lựaChọnToolStripMenuItem.Text = "Lựa chọn";
            // 
            // mởFileToolStripMenuItem
            // 
            mởFileToolStripMenuItem.Name = "mởFileToolStripMenuItem";
            mởFileToolStripMenuItem.Size = new Size(114, 22);
            mởFileToolStripMenuItem.Text = "Mở file";
            mởFileToolStripMenuItem.Click += mởFileToolStripMenuItem_Click;
            // 
            // lưuFileToolStripMenuItem
            // 
            lưuFileToolStripMenuItem.Name = "lưuFileToolStripMenuItem";
            lưuFileToolStripMenuItem.Size = new Size(114, 22);
            lưuFileToolStripMenuItem.Text = "Lưu file";
            lưuFileToolStripMenuItem.Click += lưuFileToolStripMenuItem_Click;
            // 
            // giảiMãToolStripMenuItem
            // 
            giảiMãToolStripMenuItem.Name = "giảiMãToolStripMenuItem";
            giảiMãToolStripMenuItem.Size = new Size(114, 22);
            giảiMãToolStripMenuItem.Text = "Giải mã";
            giảiMãToolStripMenuItem.Click += giảiMãToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(114, 22);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtKhoa);
            groupBox1.Controls.Add(txtBanro);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 133);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đầu vào";
            // 
            // txtKhoa
            // 
            txtKhoa.Location = new Point(470, 49);
            txtKhoa.Name = "txtKhoa";
            txtKhoa.Size = new Size(170, 23);
            txtKhoa.TabIndex = 3;
            // 
            // txtBanro
            // 
            txtBanro.Location = new Point(65, 49);
            txtBanro.Name = "txtBanro";
            txtBanro.Size = new Size(226, 23);
            txtBanro.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(470, 31);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Khóa:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 31);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Bản rõ:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtBanma);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 166);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 272);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Đầu ra";
            // 
            // txtBanma
            // 
            txtBanma.Location = new Point(65, 62);
            txtBanma.Name = "txtBanma";
            txtBanma.ReadOnly = true;
            txtBanma.Size = new Size(226, 23);
            txtBanma.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 44);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 0;
            label3.Text = "Bản mã:";
            // 
            // button1
            // 
            button1.Location = new Point(558, 228);
            button1.Name = "button1";
            button1.Size = new Size(192, 121);
            button1.TabIndex = 3;
            button1.Text = "Mã hóa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mã hóa khối hiện đại DES (Mã hóa)";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem lựaChọnToolStripMenuItem;
        private ToolStripMenuItem mởFileToolStripMenuItem;
        private ToolStripMenuItem lưuFileToolStripMenuItem;
        private ToolStripMenuItem giảiMãToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private GroupBox groupBox1;
        private TextBox txtKhoa;
        private TextBox txtBanro;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtBanma;
        private Label label3;
        private Button button1;
    }
}
