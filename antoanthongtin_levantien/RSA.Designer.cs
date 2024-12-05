namespace antoanthongtin_levantien
{
    partial class RSA
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSA));
            menuStrip1 = new MenuStrip();
            sWITCHToolStripMenuItem = new ToolStripMenuItem();
            mởFileToolStripMenuItem = new ToolStripMenuItem();
            lưuFileToolStripMenuItem = new ToolStripMenuItem();
            hellpToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            btnDo = new Button();
            groupBox2 = new GroupBox();
            txtBan2 = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            txtK2 = new TextBox();
            txtK1 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtQ = new TextBox();
            label1 = new Label();
            btnChoose = new Button();
            txtP = new TextBox();
            txtD = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label2 = new Label();
            txtE = new TextBox();
            txtBan1 = new TextBox();
            label5 = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dataGridView2 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sWITCHToolStripMenuItem, mởFileToolStripMenuItem, lưuFileToolStripMenuItem, hellpToolStripMenuItem, resetToolStripMenuItem, thoátToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // sWITCHToolStripMenuItem
            // 
            sWITCHToolStripMenuItem.Name = "sWITCHToolStripMenuItem";
            sWITCHToolStripMenuItem.Size = new Size(59, 20);
            sWITCHToolStripMenuItem.Text = "Giải mã";
            sWITCHToolStripMenuItem.Click += sWITCHToolStripMenuItem_Click;
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
            // hellpToolStripMenuItem
            // 
            hellpToolStripMenuItem.Name = "hellpToolStripMenuItem";
            hellpToolStripMenuItem.Size = new Size(44, 20);
            hellpToolStripMenuItem.Text = "Help";
            hellpToolStripMenuItem.Click += hellpToolStripMenuItem_Click;
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(47, 20);
            resetToolStripMenuItem.Text = "Reset";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
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
            dataGridView1.Location = new Point(265, 244);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(276, 194);
            dataGridView1.TabIndex = 9;
            // 
            // btnDo
            // 
            btnDo.BackColor = SystemColors.ActiveCaption;
            btnDo.FlatStyle = FlatStyle.Flat;
            btnDo.Location = new Point(345, 194);
            btnDo.Name = "btnDo";
            btnDo.Size = new Size(120, 40);
            btnDo.TabIndex = 8;
            btnDo.Text = "Mã hóa";
            btnDo.UseVisualStyleBackColor = false;
            btnDo.Click += btnDo_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtK2);
            groupBox2.Controls.Add(txtBan2);
            groupBox2.Controls.Add(txtK1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(547, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(244, 411);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Đầu ra";
            // 
            // txtBan2
            // 
            txtBan2.Location = new Point(42, 105);
            txtBan2.Name = "txtBan2";
            txtBan2.ReadOnly = true;
            txtBan2.Size = new Size(171, 23);
            txtBan2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 87);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 0;
            label3.Text = "Bản mã:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(txtBan1);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(15, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(244, 411);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đầu vào";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtQ);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnChoose);
            panel1.Controls.Add(txtP);
            panel1.Controls.Add(txtD);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtE);
            panel1.Location = new Point(6, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 255);
            panel1.TabIndex = 7;
            // 
            // txtK2
            // 
            txtK2.Location = new Point(122, 275);
            txtK2.Name = "txtK2";
            txtK2.ReadOnly = true;
            txtK2.Size = new Size(47, 23);
            txtK2.TabIndex = 2;
            // 
            // txtK1
            // 
            txtK1.Location = new Point(69, 275);
            txtK1.Name = "txtK1";
            txtK1.ReadOnly = true;
            txtK1.Size = new Size(47, 23);
            txtK1.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(175, 261);
            label9.Name = "label9";
            label9.Size = new Size(26, 40);
            label9.TabIndex = 1;
            label9.Text = "]";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(40, 261);
            label8.Name = "label8";
            label8.Size = new Size(26, 40);
            label8.TabIndex = 1;
            label8.Text = "[";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 244);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 0;
            label7.Text = "Khóa công khai:";
            // 
            // txtQ
            // 
            txtQ.Location = new Point(49, 94);
            txtQ.Name = "txtQ";
            txtQ.Size = new Size(151, 23);
            txtQ.TabIndex = 5;
            txtQ.TextChanged += txtP_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UTM A&S Graceland", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 37);
            label1.Name = "label1";
            label1.Size = new Size(24, 21);
            label1.TabIndex = 4;
            label1.Text = "P:";
            // 
            // btnChoose
            // 
            btnChoose.Location = new Point(128, 152);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(72, 23);
            btnChoose.TabIndex = 6;
            btnChoose.Text = "Choose";
            btnChoose.UseVisualStyleBackColor = true;
            btnChoose.Click += btnChoose_Click;
            // 
            // txtP
            // 
            txtP.Location = new Point(49, 37);
            txtP.Name = "txtP";
            txtP.Size = new Size(151, 23);
            txtP.TabIndex = 5;
            txtP.TextChanged += txtP_TextChanged;
            // 
            // txtD
            // 
            txtD.Location = new Point(49, 203);
            txtD.Name = "txtD";
            txtD.ReadOnly = true;
            txtD.Size = new Size(73, 23);
            txtD.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("UTM A&S Graceland", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 94);
            label4.Name = "label4";
            label4.Size = new Size(23, 21);
            label4.TabIndex = 4;
            label4.Text = "Q:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("UTM A&S Graceland", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 203);
            label6.Name = "label6";
            label6.Size = new Size(24, 21);
            label6.TabIndex = 4;
            label6.Text = "D:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UTM A&S Graceland", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 152);
            label2.Name = "label2";
            label2.Size = new Size(21, 21);
            label2.TabIndex = 4;
            label2.Text = "E:";
            // 
            // txtE
            // 
            txtE.Location = new Point(49, 152);
            txtE.Name = "txtE";
            txtE.ReadOnly = true;
            txtE.Size = new Size(73, 23);
            txtE.TabIndex = 5;
            txtE.TextChanged += txtE_TextChanged;
            // 
            // txtBan1
            // 
            txtBan1.Location = new Point(27, 105);
            txtBan1.Name = "txtBan1";
            txtBan1.Size = new Size(181, 23);
            txtBan1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 87);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 0;
            label5.Text = "Bản rõ:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            contextMenuStrip1.Click += contextMenuStrip1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(265, 244);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(276, 194);
            dataGridView2.TabIndex = 10;
            // 
            // RSA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(btnDo);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RSA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RSA";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sWITCHToolStripMenuItem;
        private ToolStripMenuItem mởFileToolStripMenuItem;
        private ToolStripMenuItem lưuFileToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private DataGridView dataGridView1;
        private Button btnDo;
        private GroupBox groupBox2;
        private TextBox txtBan2;
        private Label label3;
        private GroupBox groupBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btnChoose;
        private TextBox txtE;
        private Label label2;
        private TextBox txtQ;
        private Label label4;
        private TextBox txtP;
        private Label label1;
        private TextBox txtBan1;
        private Label label5;
        private TextBox txtD;
        private Label label6;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel1;
        private TextBox txtK2;
        private TextBox txtK1;
        private Label label9;
        private Label label8;
        private Label label7;
        private DataGridView dataGridView2;
        private ToolStripMenuItem hellpToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
    }
}