using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Code_Flat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Pop up file location dialog and get info
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "Text Files|*.txt";

            DialogResult result = dialog.ShowDialog();

            MessageBox.Show(string.Format("{0}", result));
            // Take info in file and save it
        }
    }
}
