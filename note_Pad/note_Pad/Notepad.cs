using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace note_Pad
{
    public partial class Notepad : Form
    {
        private string filename = null;

        public Notepad()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Text = string.Empty;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( openFileDialog.ShowDialog()==System.Windows.Forms.DialogResult.OK )
            {
               textBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            filename = openFileDialog.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filename))
            {
                return;

                File.WriteAllText(filename, textBox.Text);
            }
        }//asdasd
    }
}
