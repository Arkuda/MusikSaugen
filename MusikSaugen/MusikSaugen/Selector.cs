using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MusikSaugen.Classes;

namespace MusikSaugen
{
    public partial class Selector : Form
    {
        public Selector()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    toolStripTextBox1.Text = dialog.SelectedPath;
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Downloader.checkedList = checkedListBox1;
            Downloader.FolderToDownload = toolStripTextBox1.Text;
            Thread thread = new Thread(Downloader.StartDownload);
            thread.Start();
        }
    }
}
