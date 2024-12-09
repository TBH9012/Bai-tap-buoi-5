using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.Text = "Tahoma";
            toolStripComboBox2.Text = "14";

            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                toolStripComboBox1.Items.Add(font.Name);
            }

            List<int> listSize = new List<int> { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var s in listSize)
            {
                toolStripComboBox2.Items.Add(s);
            }
        }

        private void tsbNewVanBan_Click(object sender, EventArgs e)
        {
            rtbVanBan.Clear();
            toolStripComboBox1.SelectedIndex = toolStripComboBox1.Items.IndexOf("Tahoma");
            toolStripComboBox2.SelectedIndex = toolStripComboBox2.Items.IndexOf("14");
            rtbVanBan.Font = new Font("Tahoma", 14);
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbVanBan.Clear();
            toolStripComboBox1.SelectedIndex = toolStripComboBox1.Items.IndexOf("Tahoma");
            toolStripComboBox2.SelectedIndex = toolStripComboBox2.Items.IndexOf("14");
            rtbVanBan.Font = new Font("Tahoma", 14);
        }

        private void tsbLuu_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Format (*.txt)|*.txt|RichText Format (*.rtf)|*.rtf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                rtbVanBan.SaveFile(saveFileDialog.FileName);
            }
        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Format (*.txt)|*.txt|RichText Format (*.rtf)|*.rtf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                rtbVanBan.SaveFile(saveFileDialog.FileName);
            }
        }

        private void tsbWordInDam_Click(object sender, EventArgs e)
        {
            if (rtbVanBan.SelectionFont != null)
            {
                Font currentFont = rtbVanBan.SelectionFont;
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Bold;
                rtbVanBan.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }

        private void tsbWordInNghieng_Click(object sender, EventArgs e)
        {
            if (rtbVanBan.SelectionFont != null)
            {
                Font currentFont = rtbVanBan.SelectionFont;
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Italic;
                rtbVanBan.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }

        private void tsbWordGachChan_Click(object sender, EventArgs e)
        {
            if (rtbVanBan.SelectionFont != null)
            {
                Font currentFont = rtbVanBan.SelectionFont;
                FontStyle newFontStyle = currentFont.Style ^ FontStyle.Underline;
                rtbVanBan.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbVanBan.Font = new Font(toolStripComboBox1.SelectedItem.ToString(), rtbVanBan.Font.Size);
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox2.SelectedItem != null)
            {
                int fontSize = int.Parse(toolStripComboBox2.SelectedItem.ToString());
                rtbVanBan.Font = new Font(rtbVanBan.Font.FontFamily, fontSize);
            }
            else
            {
                rtbVanBan.Font = new Font(rtbVanBan.Font.FontFamily, 14);
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                this.rtbVanBan.Font = fd.Font;
            }

        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|RichText Files (*.rtf)|*.rtf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rtbVanBan.LoadFile(openFileDialog.FileName);
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
