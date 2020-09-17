using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Notepad : Form
    {
        string path;
        public Notepad()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            path = string.Empty;
            textBox.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*using(OpenFileDialog ofd = new OpenFileDialog() {Filter = "txt files (*.txt)|*.txt",FilterIndex = 2, RestoreDirectory = true,ReadOnlyChecked = true,ShowReadOnly = true})
            { 

                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    string fileName;
                    fileName = ofd.FileName;
                    MessageBox.Show(fileName);
                }
            }*/
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string filename = ofd.FileName;
            string readfile = File.ReadAllText(filename);
            textBox.Text = readfile;
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    Stream s = sfd.OpenFile();
                    StreamWriter sw = new StreamWriter(s);
                    sw.Write(textBox.Text);
                    sw.Close();
                    
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FormAbout frm = new FormAbout())
            {
                frm.ShowDialog();
            }
        }
    }
}
