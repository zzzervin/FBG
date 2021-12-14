using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBG
{
    public partial class Form1 : Form
    {
        int pipeS = 8;
        int garvity = 5;
        int score = 0;
       
        
    

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pipe_Click(object sender, EventArgs e)
        {

        }




        private void gTEvent(object sender, EventArgs e)
        {
            flappybird.Top += garvity;
            pipe.Left -= pipeS;
            pipedown.Left -= pipeS;


            
        }

        private void gkisu(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                garvity = 15;

            }

        }

        private void gkisd(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                garvity = -15;


            }
        }
    }
}
