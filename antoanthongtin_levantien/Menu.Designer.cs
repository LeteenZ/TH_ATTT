namespace antoanthongtin_levantien
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            menuStrip1 = new MenuStrip();
            mãHóaToolStripMenuItem = new ToolStripMenuItem();
            caesarToolStripMenuItem = new ToolStripMenuItem();
            playfairToolStripMenuItem = new ToolStripMenuItem();
            affineToolStripMenuItem = new ToolStripMenuItem();
            vigenèreToolStripMenuItem = new ToolStripMenuItem();
            hillToolStripMenuItem = new ToolStripMenuItem();
            hàngToolStripMenuItem = new ToolStripMenuItem();
            mãHóaCôngKhaiToolStripMenuItem = new ToolStripMenuItem();
            rSAToolStripMenuItem = new ToolStripMenuItem();
            deffineHellmanToolStripMenuItem = new ToolStripMenuItem();
            mãHóaHiệnĐạiToolStripMenuItem = new ToolStripMenuItem();
            dESToolStripMenuItem = new ToolStripMenuItem();
            aESToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            btnCaesar = new Button();
            btnPlayfair = new Button();
            btnAffine = new Button();
            btnVigenere = new Button();
            btnHill = new Button();
            btnHang = new Button();
            btnChon = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mãHóaToolStripMenuItem, mãHóaCôngKhaiToolStripMenuItem, mãHóaHiệnĐạiToolStripMenuItem, thoátToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mãHóaToolStripMenuItem
            // 
            mãHóaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { caesarToolStripMenuItem, playfairToolStripMenuItem, affineToolStripMenuItem, vigenèreToolStripMenuItem, hillToolStripMenuItem, hàngToolStripMenuItem });
            mãHóaToolStripMenuItem.Name = "mãHóaToolStripMenuItem";
            mãHóaToolStripMenuItem.Size = new Size(102, 20);
            mãHóaToolStripMenuItem.Text = "Mã hóa cổ điển";
            // 
            // caesarToolStripMenuItem
            // 
            caesarToolStripMenuItem.Name = "caesarToolStripMenuItem";
            caesarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D1;
            caesarToolStripMenuItem.Size = new Size(159, 22);
            caesarToolStripMenuItem.Text = "Caesar";
            caesarToolStripMenuItem.Click += caesarToolStripMenuItem_Click;
            // 
            // playfairToolStripMenuItem
            // 
            playfairToolStripMenuItem.Name = "playfairToolStripMenuItem";
            playfairToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D2;
            playfairToolStripMenuItem.Size = new Size(159, 22);
            playfairToolStripMenuItem.Text = "Playfair";
            playfairToolStripMenuItem.Click += playfairToolStripMenuItem_Click;
            // 
            // affineToolStripMenuItem
            // 
            affineToolStripMenuItem.Name = "affineToolStripMenuItem";
            affineToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D3;
            affineToolStripMenuItem.Size = new Size(159, 22);
            affineToolStripMenuItem.Text = "Affine";
            affineToolStripMenuItem.Click += affineToolStripMenuItem_Click;
            // 
            // vigenèreToolStripMenuItem
            // 
            vigenèreToolStripMenuItem.Name = "vigenèreToolStripMenuItem";
            vigenèreToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D4;
            vigenèreToolStripMenuItem.Size = new Size(159, 22);
            vigenèreToolStripMenuItem.Text = "Vigenère";
            vigenèreToolStripMenuItem.Click += vigenèreToolStripMenuItem_Click;
            // 
            // hillToolStripMenuItem
            // 
            hillToolStripMenuItem.Name = "hillToolStripMenuItem";
            hillToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D5;
            hillToolStripMenuItem.Size = new Size(159, 22);
            hillToolStripMenuItem.Text = "Hill";
            hillToolStripMenuItem.Click += hillToolStripMenuItem_Click;
            // 
            // hàngToolStripMenuItem
            // 
            hàngToolStripMenuItem.Name = "hàngToolStripMenuItem";
            hàngToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D6;
            hàngToolStripMenuItem.Size = new Size(159, 22);
            hàngToolStripMenuItem.Text = "Hàng";
            hàngToolStripMenuItem.Click += hàngToolStripMenuItem_Click;
            // 
            // mãHóaCôngKhaiToolStripMenuItem
            // 
            mãHóaCôngKhaiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rSAToolStripMenuItem, deffineHellmanToolStripMenuItem });
            mãHóaCôngKhaiToolStripMenuItem.Name = "mãHóaCôngKhaiToolStripMenuItem";
            mãHóaCôngKhaiToolStripMenuItem.Size = new Size(115, 20);
            mãHóaCôngKhaiToolStripMenuItem.Text = "Mã hóa công khai";
            // 
            // rSAToolStripMenuItem
            // 
            rSAToolStripMenuItem.Name = "rSAToolStripMenuItem";
            rSAToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D7;
            rSAToolStripMenuItem.Size = new Size(199, 22);
            rSAToolStripMenuItem.Text = "RSA";
            rSAToolStripMenuItem.Click += rSAToolStripMenuItem_Click;
            // 
            // deffineHellmanToolStripMenuItem
            // 
            deffineHellmanToolStripMenuItem.Name = "deffineHellmanToolStripMenuItem";
            deffineHellmanToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D8;
            deffineHellmanToolStripMenuItem.Size = new Size(199, 22);
            deffineHellmanToolStripMenuItem.Text = "Deffine-Hellman";
            deffineHellmanToolStripMenuItem.Click += deffineHellmanToolStripMenuItem_Click;
            // 
            // mãHóaHiệnĐạiToolStripMenuItem
            // 
            mãHóaHiệnĐạiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dESToolStripMenuItem, aESToolStripMenuItem });
            mãHóaHiệnĐạiToolStripMenuItem.Name = "mãHóaHiệnĐạiToolStripMenuItem";
            mãHóaHiệnĐạiToolStripMenuItem.Size = new Size(105, 20);
            mãHóaHiệnĐạiToolStripMenuItem.Text = "Mã hóa hiện đại";
            // 
            // dESToolStripMenuItem
            // 
            dESToolStripMenuItem.Name = "dESToolStripMenuItem";
            dESToolStripMenuItem.Size = new Size(98, 22);
            dESToolStripMenuItem.Text = "DES";
            dESToolStripMenuItem.Click += dESToolStripMenuItem_Click;
            // 
            // aESToolStripMenuItem
            // 
            aESToolStripMenuItem.Name = "aESToolStripMenuItem";
            aESToolStripMenuItem.Size = new Size(98, 22);
            aESToolStripMenuItem.Text = "AES";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(51, 20);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // btnCaesar
            // 
            btnCaesar.Anchor = AnchorStyles.None;
            btnCaesar.BackColor = SystemColors.Control;
            btnCaesar.FlatStyle = FlatStyle.Flat;
            btnCaesar.ForeColor = SystemColors.ButtonHighlight;
            btnCaesar.Location = new Point(363, 214);
            btnCaesar.Name = "btnCaesar";
            btnCaesar.Size = new Size(120, 40);
            btnCaesar.TabIndex = 1;
            btnCaesar.Text = "Caesar";
            btnCaesar.UseVisualStyleBackColor = false;
            btnCaesar.Click += btnCaesar_Click;
            btnCaesar.MouseEnter += btnCaesar_MouseEnter;
            btnCaesar.MouseLeave += btnCaesar_MouseEnter;
            btnCaesar.Resize += btnChon_Resize;
            // 
            // btnPlayfair
            // 
            btnPlayfair.Anchor = AnchorStyles.None;
            btnPlayfair.FlatStyle = FlatStyle.Flat;
            btnPlayfair.ForeColor = SystemColors.ButtonHighlight;
            btnPlayfair.Location = new Point(363, 214);
            btnPlayfair.Name = "btnPlayfair";
            btnPlayfair.Size = new Size(120, 40);
            btnPlayfair.TabIndex = 2;
            btnPlayfair.Text = "Playfair";
            btnPlayfair.UseVisualStyleBackColor = true;
            btnPlayfair.Click += btnPlayfair_Click;
            btnPlayfair.MouseEnter += btnPlayfair_MouseEnter;
            btnPlayfair.MouseLeave += btnPlayfair_MouseEnter;
            btnPlayfair.Resize += btnChon_Resize;
            // 
            // btnAffine
            // 
            btnAffine.Anchor = AnchorStyles.None;
            btnAffine.FlatStyle = FlatStyle.Flat;
            btnAffine.ForeColor = SystemColors.ButtonHighlight;
            btnAffine.Location = new Point(363, 214);
            btnAffine.Name = "btnAffine";
            btnAffine.Size = new Size(120, 40);
            btnAffine.TabIndex = 3;
            btnAffine.Text = "Affine";
            btnAffine.UseVisualStyleBackColor = true;
            btnAffine.Click += btnAffine_Click;
            btnAffine.MouseEnter += btnAffine_MouseEnter;
            btnAffine.MouseLeave += btnAffine_MouseEnter;
            btnAffine.Resize += btnChon_Resize;
            // 
            // btnVigenere
            // 
            btnVigenere.Anchor = AnchorStyles.None;
            btnVigenere.FlatStyle = FlatStyle.Flat;
            btnVigenere.ForeColor = SystemColors.ButtonHighlight;
            btnVigenere.Location = new Point(363, 214);
            btnVigenere.Name = "btnVigenere";
            btnVigenere.Size = new Size(120, 40);
            btnVigenere.TabIndex = 4;
            btnVigenere.Text = "Vigenère";
            btnVigenere.UseVisualStyleBackColor = true;
            btnVigenere.Click += btnVigenere_Click;
            btnVigenere.MouseEnter += btnVigenere_MouseEnter;
            btnVigenere.MouseLeave += btnVigenere_MouseEnter;
            btnVigenere.Resize += btnChon_Resize;
            // 
            // btnHill
            // 
            btnHill.Anchor = AnchorStyles.None;
            btnHill.FlatStyle = FlatStyle.Flat;
            btnHill.ForeColor = SystemColors.ButtonHighlight;
            btnHill.Location = new Point(363, 214);
            btnHill.Name = "btnHill";
            btnHill.Size = new Size(120, 40);
            btnHill.TabIndex = 5;
            btnHill.Text = "Hill";
            btnHill.UseVisualStyleBackColor = true;
            btnHill.Click += btnHill_Click;
            btnHill.MouseEnter += btnHill_MouseEnter;
            btnHill.MouseLeave += btnHill_MouseEnter;
            btnHill.Resize += btnChon_Resize;
            // 
            // btnHang
            // 
            btnHang.Anchor = AnchorStyles.None;
            btnHang.FlatStyle = FlatStyle.Flat;
            btnHang.ForeColor = SystemColors.ButtonHighlight;
            btnHang.Location = new Point(363, 214);
            btnHang.Name = "btnHang";
            btnHang.Size = new Size(120, 40);
            btnHang.TabIndex = 6;
            btnHang.Text = "Hàng";
            btnHang.UseVisualStyleBackColor = true;
            btnHang.Click += btnHang_Click;
            btnHang.MouseEnter += btnHang_MouseEnter;
            btnHang.MouseLeave += btnHang_MouseEnter;
            btnHang.Resize += btnChon_Resize;
            // 
            // btnChon
            // 
            btnChon.Anchor = AnchorStyles.None;
            btnChon.Location = new Point(363, 214);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(120, 40);
            btnChon.TabIndex = 7;
            btnChon.Text = "Chọn";
            btnChon.UseVisualStyleBackColor = true;
            btnChon.Click += btnChon_Click;
            btnChon.Resize += btnChon_Resize;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChon);
            Controls.Add(btnHang);
            Controls.Add(btnHill);
            Controls.Add(btnVigenere);
            Controls.Add(btnAffine);
            Controls.Add(btnPlayfair);
            Controls.Add(btnCaesar);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mãHóaToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem caesarToolStripMenuItem;
        private ToolStripMenuItem playfairToolStripMenuItem;
        private ToolStripMenuItem affineToolStripMenuItem;
        private ToolStripMenuItem vigenèreToolStripMenuItem;
        private ToolStripMenuItem hillToolStripMenuItem;
        private ToolStripMenuItem hàngToolStripMenuItem;
        private ToolStripMenuItem mãHóaCôngKhaiToolStripMenuItem;
        private Button btnCaesar;
        private Button btnPlayfair;
        private Button btnAffine;
        private Button btnVigenere;
        private Button btnHill;
        private Button btnHang;
        private Button btnChon;
        private ToolStripMenuItem rSAToolStripMenuItem;
        private ToolStripMenuItem deffineHellmanToolStripMenuItem;
        private ToolStripMenuItem mãHóaHiệnĐạiToolStripMenuItem;
        private ToolStripMenuItem dESToolStripMenuItem;
        private ToolStripMenuItem aESToolStripMenuItem;
    }
}
