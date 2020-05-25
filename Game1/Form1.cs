using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game1
{
    public partial class Form1 : Form
    {
        public bool Start = false;
        double x;
        public Form1()
        {
            InitializeComponent();
        }

        private void quitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
        public void Button(KeyEventArgs key)
        {
            switch (key.KeyCode)
            {
                case Keys.Space:
                    {
                     Start = true;
                        break;
                    }
                    
            }
        }
    }
}
