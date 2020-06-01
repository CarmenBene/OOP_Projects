using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBallGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.initGraph(pictureBox1);
            for (int i = 0; i < Engine.countR; i++)
                Engine.balls.Add(new Regular());
            for (int i = 0; i < 5; i++)
                Engine.balls.Add(new Monster());
            for (int i = 0; i < 5; i++)
                Engine.balls.Add(new Repelent());
            Engine.DrawMap();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
              Engine.TurnMap();
            Engine.DrawMap();

            label1.Text = Engine.countR.ToString();
            if (Engine.countR == 0)
                timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
