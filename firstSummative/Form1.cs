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

            //making lines - each block of code is one line
            g.DrawLine(redPen, 197, 168, 105, 289);
            boop.Play();
            g.FillEllipse(drawBrush, 197, 142, 25, 25);
            g.FillEllipse(drawBrush, 100, 289, 25, 25);

            Thread.Sleep(500);
            g.DrawLine(constellationPen, 106, 300, 203, 327);
            boop.Play();
            g.FillEllipse(drawBrush, 203, 320, 25, 25);

            Thread.Sleep(500);
            g.DrawLine(redPen, 220, 330, 236, 341);
            boop.Play();
            g.FillEllipse(drawBrush, 236, 320, 25, 25);

            Thread.Sleep(500);
            g.DrawLine(greenPen, 250, 339, 352, 323);
            boop.Play();
            g.FillEllipse(drawBrush, 352, 310, 25, 25);

            Thread.Sleep(500);
            g.DrawLine(constellationPen, 366, 315, 445, 198);
            boop.Play();
            g.FillEllipse(drawBrush, 440, 180, 25, 25);

            Thread.Sleep(500);
            g.DrawLine(redPen, 453, 199, 667, 264);
            boop.Play();
            g.FillEllipse(drawBrush, 670, 250, 25, 25);

            Thread.Sleep(500);
            g.DrawLine(greenPen, 19, 431, 44, 440);
            boop.Play();
            g.FillEllipse(drawBrush, 10, 420, 25, 25);
            g.FillEllipse(drawBrush, 44, 430, 25, 25);

            Thread.Sleep(500);
            g.DrawLine(constellationPen, 57, 439, 194, 539);
            boop.Play();
            g.FillEllipse(drawBrush, 194, 530, 25, 25);

            Thread.Sleep(500);
            g.DrawLine(redPen, 207, 545, 276, 460);
            boop.Play();
            g.FillEllipse(drawBrush, 255, 448, 25, 25);

            Thread.Sleep(500);
            g.DrawLine(greenPen, 276, 446, 346, 453);
            boop.Play();
            g.FillEllipse(drawBrush, 346, 430, 25, 25);

            Thread.Sleep(500);
            g.DrawLine(constellationPen, 273, 446, 246, 350);
            boop.Play();

            Thread.Sleep(500);
            g.DrawLine(redPen, 352, 441, 361, 328);
            boop.Play();

            Thread.Sleep(500);
            g.DrawLine(greenPen, 359, 445, 369, 568);
            boop.Play();
            g.FillEllipse(drawBrush, 369, 568, 25, 25);

            //draw paragraph and text
            shimmer.Play();
            g.DrawString("Hercules", bigFont, drawBrush, 310, 30);
            g.DrawString("Hercules is one of the largest constellations in the", lilFont, drawBrush, 150, 70);
            g.DrawString("night sky but doesn't contain any very bright stars.", lilFont, drawBrush, 150, 90);


        }


    }
}
