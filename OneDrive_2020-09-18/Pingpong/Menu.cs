using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pingpong
{
    public partial class Menu : Form
    {
        public Form RefTopingPong { get; set; }
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pingPong f = new pingPong();
            f.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            pingPongFr f3 = new pingPongFr();
            f3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            racingMotoEN rm = new racingMotoEN();
            rm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.ShowDialog();
            
            
        }
    }
}
