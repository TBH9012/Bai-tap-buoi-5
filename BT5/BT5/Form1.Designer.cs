namespace BT5
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoVănBảnMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởTậpTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lưuNộiDungVănBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.địnhDạngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNewVanBan = new System.Windows.Forms.ToolStripButton();
            this.tsbLuu = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.tsbWordInDam = new System.Windows.Forms.ToolStripButton();
            this.tsbWordInNghieng = new System.Windows.Forms.ToolStripButton();
            this.tsbWordGachChan = new System.Windows.Forms.ToolStripButton();
            this.rtbVanBan = new System.Windows.Forms.RichTextBox();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.địnhDạngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoVănBảnMớiToolStripMenuItem,
            this.mởTậpTinToolStripMenuItem,
            this.toolStripSeparator1,
            this.lưuNộiDungVănBảnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // tạoVănBảnMớiToolStripMenuItem
            // 
            this.tạoVănBảnMớiToolStripMenuItem.Image = global::BT5.Properties.Resources.VanBan;
            this.tạoVănBảnMớiToolStripMenuItem.Name = "tạoVănBảnMớiToolStripMenuItem";
            this.tạoVănBảnMớiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tạoVănBảnMớiToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.tạoVănBảnMớiToolStripMenuItem.Text = "Tạo văn bản mới";
            this.tạoVănBảnMớiToolStripMenuItem.Click += new System.EventHandler(this.tạoVănBảnMớiToolStripMenuItem_Click);
            // 
            // mởTậpTinToolStripMenuItem
            // 
            this.mởTậpTinToolStripMenuItem.Image = global::BT5.Properties.Resources.OpenVanBan;
            this.mởTậpTinToolStripMenuItem.Name = "mởTậpTinToolStripMenuItem";
            this.mởTậpTinToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.mởTậpTinToolStripMenuItem.Text = "Mở tập tin";
            this.mởTậpTinToolStripMenuItem.Click += new System.EventHandler(this.mởTậpTinToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(227, 6);
            // 
            // lưuNộiDungVănBảnToolStripMenuItem
            // 
            this.lưuNộiDungVănBảnToolStripMenuItem.Image = global::BT5.Properties.Resources.SaveVanBan;
            this.lưuNộiDungVănBảnToolStripMenuItem.Name = "lưuNộiDungVănBảnToolStripMenuItem";
            this.lưuNộiDungVănBảnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.lưuNộiDungVănBảnToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.lưuNộiDungVănBảnToolStripMenuItem.Text = "Lưu nội dung văn bản";
            this.lưuNộiDungVănBảnToolStripMenuItem.Click += new System.EventHandler(this.lưuNộiDungVănBảnToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // địnhDạngToolStripMenuItem
            // 
            this.địnhDạngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem});
            this.địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            this.địnhDạngToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.địnhDạngToolStripMenuItem.Text = "Định dạng";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewVanBan,
            this.tsbLuu,
            this.toolStripComboBox1,
            this.toolStripComboBox2,
            this.tsbWordInDam,
            this.tsbWordInNghieng,
            this.tsbWordGachChan});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNewVanBan
            // 
            this.tsbNewVanBan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewVanBan.Image = global::BT5.Properties.Resources.VanBan;
            this.tsbNewVanBan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewVanBan.Name = "tsbNewVanBan";
            this.tsbNewVanBan.Size = new System.Drawing.Size(23, 22);
            this.tsbNewVanBan.Text = "toolStripButton1";
            this.tsbNewVanBan.Click += new System.EventHandler(this.tsbNewVanBan_Click);
            // 
            // tsbLuu
            // 
            this.tsbLuu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLuu.Image = global::BT5.Properties.Resources.SaveVanBan;
            this.tsbLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLuu.Name = "tsbLuu";
            this.tsbLuu.Size = new System.Drawing.Size(23, 22);
            this.tsbLuu.Text = "toolStripButton2";
            this.tsbLuu.Click += new System.EventHandler(this.tsbLuu_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox2.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox2_SelectedIndexChanged);
            // 
            // tsbWordInDam
            // 
            this.tsbWordInDam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbWordInDam.Image = global::BT5.Properties.Resources.B_VanBan;
            this.tsbWordInDam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWordInDam.Name = "tsbWordInDam";
            this.tsbWordInDam.Size = new System.Drawing.Size(23, 22);
            this.tsbWordInDam.Text = "toolStripButton3";
            this.tsbWordInDam.Click += new System.EventHandler(this.tsbWordInDam_Click);
            // 
            // tsbWordInNghieng
            // 
            this.tsbWordInNghieng.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbWordInNghieng.Image = global::BT5.Properties.Resources.I_VanBan;
            this.tsbWordInNghieng.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWordInNghieng.Name = "tsbWordInNghieng";
            this.tsbWordInNghieng.Size = new System.Drawing.Size(23, 22);
            this.tsbWordInNghieng.Text = "toolStripButton4";
            this.tsbWordInNghieng.Click += new System.EventHandler(this.tsbWordInNghieng_Click);
            // 
            // tsbWordGachChan
            // 
            this.tsbWordGachChan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbWordGachChan.Image = global::BT5.Properties.Resources.U_VanBan;
            this.tsbWordGachChan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWordGachChan.Name = "tsbWordGachChan";
            this.tsbWordGachChan.Size = new System.Drawing.Size(23, 22);
            this.tsbWordGachChan.Text = "toolStripButton5";
            this.tsbWordGachChan.Click += new System.EventHandler(this.tsbWordGachChan_Click);
            // 
            // rtbVanBan
            // 
            this.rtbVanBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbVanBan.Location = new System.Drawing.Point(0, 49);
            this.rtbVanBan.Name = "rtbVanBan";
            this.rtbVanBan.Size = new System.Drawing.Size(800, 401);
            this.rtbVanBan.TabIndex = 2;
            this.rtbVanBan.Text = "";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbVanBan);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Soạn thảo văn bản";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoVănBảnMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mởTậpTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem lưuNộiDungVănBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem địnhDạngToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RichTextBox rtbVanBan;
        private System.Windows.Forms.ToolStripButton tsbNewVanBan;
        private System.Windows.Forms.ToolStripButton tsbLuu;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripButton tsbWordInDam;
        private System.Windows.Forms.ToolStripButton tsbWordInNghieng;
        private System.Windows.Forms.ToolStripButton tsbWordGachChan;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
    }
}

