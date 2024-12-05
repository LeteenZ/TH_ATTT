namespace antoanthongtin_levantien
{
    partial class Form2
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
            lựaChọnToolStripMenuItem = new ToolStripMenuItem();
            mởFileToolStripMenuItem = new ToolStripMenuItem();
            lưuFileToolStripMenuItem = new ToolStripMenuItem();
            mãHóaToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            groupBox3 = new GroupBox();
            txtKhoa1 = new TextBox();
            txtBanma1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            groupBox4 = new GroupBox();
            txtBanro1 = new TextBox();
            label6 = new Label();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
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
            lựaChọnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mởFileToolStripMenuItem, lưuFileToolStripMenuItem, mãHóaToolStripMenuItem, thoátToolStripMenuItem });
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
            // mãHóaToolStripMenuItem
            // 
            mãHóaToolStripMenuItem.Name = "mãHóaToolStripMenuItem";
            mãHóaToolStripMenuItem.Size = new Size(114, 22);
            mãHóaToolStripMenuItem.Text = "Mã hóa";
            mãHóaToolStripMenuItem.Click += mãHóaToolStripMenuItem_Click;
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
            // groupBox3
            // 
            groupBox3.Controls.Add(txtKhoa1);
            groupBox3.Controls.Add(txtBanma1);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(12, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 133);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Đầu vào";
            // 
            // txtKhoa1
            // 
            txtKhoa1.Location = new Point(470, 49);
            txtKhoa1.Name = "txtKhoa1";
            txtKhoa1.Size = new Size(170, 23);
            txtKhoa1.TabIndex = 3;
            // 
            // txtBanma1
            // 
            txtBanma1.Location = new Point(65, 49);
            txtBanma1.Name = "txtBanma1";
            txtBanma1.Size = new Size(226, 23);
            txtBanma1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(470, 31);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 1;
            label5.Text = "Khóa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 31);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 0;
            label4.Text = "Bản mã:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtBanro1);
            groupBox4.Controls.Add(label6);
            groupBox4.Location = new Point(12, 166);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(470, 272);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Đầu ra";
            // 
            // txtBanro1
            // 
            txtBanro1.Location = new Point(65, 62);
            txtBanro1.Name = "txtBanro1";
            txtBanro1.ReadOnly = true;
            txtBanro1.Size = new Size(226, 23);
            txtBanro1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 44);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 0;
            label6.Text = "Bản rõ:";
            // 
            // button2
            // 
            button2.Location = new Point(558, 210);
            button2.Name = "button2";
            button2.Size = new Size(192, 121);
            button2.TabIndex = 5;
            button2.Text = "Giải mã";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mã hóa khối hiện đại DES (Giải mã)";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem lựaChọnToolStripMenuItem;
        private ToolStripMenuItem mởFileToolStripMenuItem;
        private ToolStripMenuItem lưuFileToolStripMenuItem;
        private ToolStripMenuItem mãHóaToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private GroupBox groupBox3;
        private TextBox txtKhoa1;
        private TextBox txtBanma1;
        private Label label5;
        private Label label4;
        private GroupBox groupBox4;
        private TextBox txtBanro1;
        private Label label6;
        private Button button2;
    }
}