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

//Ethan Elliott
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
            //get rid of happy hannukah
            happyHannukah.Visible = false;

            //create sound players
            SoundPlayer boop = new SoundPlayer(Properties.Resources.Boop);
            SoundPlayer shimmer = new SoundPlayer(Properties.Resources.Star);

            //create graphics objects
            Graphics g = this.CreateGraphics();
            Font bigFont = new Font("Helvetica", 24, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Pen constellationPen = new Pen(Color.White, 8);
            Pen redPen = new Pen(Color.Red, 8);
            Pen greenPen = new Pen(Color.Green, 8);
          
            //create constellation
            BackColor = (Color.Black);
            Refresh();
            shimmer.Play();
            Thread.Sleep(1000);
            g.DrawLine(redPen, 197, 168, 105, 289);
            boop.Play();

            Thread.Sleep(500);
            g.DrawLine(constellationPen, 106, 300, 203, 327);
            boop.Play();
            Thread.Sleep(500);
            g.DrawLine(redPen, 220, 330, 236, 341);
            boop.Play();
            Thread.Sleep(500);
            g.DrawLine(greenPen, 250, 339, 352, 323);
            boop.Play();
            Thread.Sleep(500);
            g.DrawLine(constellationPen, 366, 315, 445, 198);
            boop.Play();
            Thread.Sleep(500);
            g.DrawLine(redPen, 453, 199, 667, 264);
            boop.Play();
            Thread.Sleep(500);
            g.DrawLine(greenPen, 19, 431, 44, 440);
            boop.Play();
            Thread.Sleep(500);
            g.DrawLine(constellationPen, 57, 439, 194, 539);
            boop.Play();
            Thread.Sleep(500);
            g.DrawLine(redPen, 207, 545, 276, 460);
            boop.Play();
            Thread.Sleep(500);
            g.DrawLine(greenPen, 276, 446, 346, 453);
            boop.Play();
            Thread.Sleep(500);
            g.DrawLine(constellationPen, 273, 446, 246, 350);
            boop.Play();
            Thread.Sleep(500);
            g.DrawLine(redPen, 352, 441, 361, 328);
            boop.Play();
            Thread.Sleep(500);
            g.DrawLine(greenPen, 359, 445, 369, 568);
            boop.Play();

            //draw paragraph and text

            g.DrawString("Hercules", bigFont, drawBrush, 475, 30);




        }


    }
}
