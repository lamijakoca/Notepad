using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            ProductName.Text = string.Format("Product name: {0}", Application.ProductName);
            ProductVersion.Text = string.Format("Product version: {0}", Application.ProductVersion);
            Copyright.Text = string.Format("Copyright ©  2020");
        }
    }
}
