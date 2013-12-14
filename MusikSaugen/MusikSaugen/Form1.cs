using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MusikSaugen.Classes;

namespace MusikSaugen
{
    public partial class Form1 : Form
    {

        public Scaner scaner;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            scaner = new Scaner(this.webBrowser1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }
    }
}
