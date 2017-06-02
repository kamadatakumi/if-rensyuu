using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_rensyuu
{
    public partial class Form1 : Form
    {
        int vx = 50;
        int vy = 20;
    public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //vx = -30;
            if (vx == 50)
            {
                vx = -50;
            }
            else
            {
                vx = 50;
            }
            if (vy == 20)
            {
                vy = -20;
            }
            else
            {
                vy = 20;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button1.Left == 0)
            {
                vx = 50;
            }
            else if(button1.Left == 700)
            {
                vx = -50;
            }
            if (button1.Top == 0)
            {
                vy = 20;
            }
            else if(button1.Top == 400)
            {
                vy = -20;
            }
            button1.Left += vx;
            button1.Top += vy;
        }

private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (button1.Visible == true)
            {
                button1.Visible = false;
            }
            else if(button1.Visible == false)
                button1.Visible = true;
        }
    }
}
