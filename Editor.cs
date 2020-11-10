using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PandoraEditorApp
{
    public partial class Editor : Form
    {

        protected override void WndProc(ref Message m)
        {
            //Allows the window to be moveable.
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;


       

        public Editor()
        {
            InitializeComponent();
        }



        private void Editor_Load(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*txt)|*.txt|All Files (*.*)|*.*";
            openFile.InitialDirectory = "C:";
            openFile.Title = "Open a File";

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SettingGui u1 = new SettingGui();
            u1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            
        }
    }
}
