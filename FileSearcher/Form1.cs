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

namespace FileSearcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nameSearchBut_Click(object sender, EventArgs e)
        {
            FIlenameLabel.Visible = true;
            FilenameTB.Visible = true;
            FilenameBT.Visible = true;
        }

        private void FilenameBT_Click(object sender, EventArgs e)
        {

        }
    }
}
