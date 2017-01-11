using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void originalImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OriginalImageForm originalImageForm = new OriginalImageForm();
            originalImageForm.Show();
        }

        private void filteredImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilteredImageForm filteredImageForm = new FilteredImageForm();
            filteredImageForm.Show();
        }
    }
}
