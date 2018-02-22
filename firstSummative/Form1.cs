using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

//Ethan Elliott Februrary 21st 2018
namespace firstSummative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void Form1_Click(object sender, EventArgs e)
        {
            //get rid of first label
            happyHannukah.Visible = false;

            //create sound players
            SoundPlayer boop = new SoundPlayer(Properties.Resources.Boop);
            SoundPlayer shimmer = new SoundPlayer(Properties.Resources.Star);

            //create graphics objects
            Graphics g = this.CreateGraphics();
            Font bigFont = new Font("Helvetica", 24, FontStyle.Bold);
            Font lilFont = new Font("Arial", 15, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Pen constellationPen = new Pen(Color.White, 8);
            Pen redPen = new Pen(Color.Red, 8);
            Pen greenPen = new Pen(Color.Green, 8);
          
            //create constellation
            BackColor = (Color.Black);
            Refresh();
            shimmer.Play();
            Thread.Sleep(1000);

            //drawing lines - each block of code is one line
            g.DrawLine(redPen, 205, 160, 100, 289);
            boop.Play();
           
            Thread.Sleep(500);
            g.DrawLine(constellationPen, 100, 290, 205, 330);
            boop.Play();
           
            Thread.Sleep(500);
            g.DrawLine(redPen, 220, 330, 245, 330);
            boop.Play();
            
            Thread.Sleep(500);
            g.DrawLine(greenPen, 250, 328, 352, 323);
            boop.Play();           

            Thread.Sleep(500);
            g.DrawLine(constellationPen, 366, 315, 445, 198);
            boop.Play();
           
            Thread.Sleep(500);
            g.DrawLine(redPen, 453, 190, 675, 260);
            boop.Play();

            Thread.Sleep(500);
            g.DrawLine(greenPen, 19, 431, 44, 440);
            boop.Play();

            Thread.Sleep(500);
            g.DrawLine(constellationPen, 57, 439, 194, 539);
            boop.Play();
     
            Thread.Sleep(500);
            g.DrawLine(redPen, 207, 545, 270, 460);
            boop.Play();

            Thread.Sleep(500);
            g.DrawLine(greenPen, 265, 460, 350, 440);
            boop.Play();

            Thread.Sleep(500);
            g.DrawLine(constellationPen, 273, 460, 255, 340);
            boop.Play();

            Thread.Sleep(500);
            g.DrawLine(redPen, 355, 441, 357, 328);
            boop.Play();

            Thread.Sleep(500);
            g.DrawLine(greenPen, 360, 445, 375, 568);
            boop.Play();

            //draw stars
            g.FillEllipse(drawBrush, 360, 568, 25, 25);
            g.FillEllipse(drawBrush, 346, 425, 25, 25);
            g.FillEllipse(drawBrush, 10, 420, 25, 25);
            g.FillEllipse(drawBrush, 44, 430, 25, 25);
            g.FillEllipse(drawBrush, 194, 530, 25, 25);
            g.FillEllipse(drawBrush, 255, 450, 25, 25);
            g.FillEllipse(drawBrush, 197, 142, 25, 25);
            g.FillEllipse(drawBrush, 670, 250, 25, 25);
            g.FillEllipse(drawBrush, 440, 180, 25, 25);
            g.FillEllipse(drawBrush, 352, 310, 25, 25);
            g.FillEllipse(drawBrush, 236, 320, 25, 25);
            g.FillEllipse(drawBrush, 352, 310, 25, 25);
            g.FillEllipse(drawBrush, 203, 320, 25, 25);
            g.FillEllipse(drawBrush, 80, 280, 25, 25);


            //draw paragraph and text
            shimmer.Play();
            g.DrawString("Hercules", bigFont, drawBrush, 310, 30);
            g.DrawString("Hercules is one of the largest constellations in the", lilFont, drawBrush, 150, 70);
            g.DrawString("night sky but doesn't contain any very bright stars.", lilFont, drawBrush, 150, 90);


        }


    }
}
