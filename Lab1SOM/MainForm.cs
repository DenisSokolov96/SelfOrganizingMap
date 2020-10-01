using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab1SOM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();          
        }

        public double[,,] VectorW;
        private int sizeX = 4;
        private int sizeY = 4;
        //parameters
        private double R = 0;
        private double speed = 0;
        private int iterat = 0;

        private void Draw() {                     

            Graphics g = pictureBox1.CreateGraphics();
            int y = pictureBox1.Width / sizeY;
            int x = pictureBox1.Height / sizeX;
            for (int i = 0; i < sizeX; i++)
                for (int j = 0; j < sizeY; j++)
                {
                    long a1 = (long)VectorW[j, i, 0];
                    long a2 = (long)VectorW[j, i, 1];
                    long a3 = (long)VectorW[j, i, 2];

                    /* double b = 0.5 / VectorW[j, i, 0];
                     long a1 = (long)(255.0 / b);

                     b = 0.5 / VectorW[j, i, 1];
                     long a2 = (long)(255.0 / b);

                     b = 0.5 / VectorW[j, i, 2];
                     long a3 = (long)(255.0 / b);*/

                    

                    if (a1 > 255) a1 = 255;
                    if (a2 > 255) a2 = 255;
                    if (a3 > 255) a3 = 255;
                    if (a1 < 0) a1 = 0;
                    if (a2 < 0) a2 = 0;
                    if (a3 < 0) a3 = 0;
                    
                    if ((i != 0) && (j != 0))
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb((int)a1, (int)a2, (int)a3)),
                                                              j * pictureBox1.Width / sizeY - 1, i * pictureBox1.Height / sizeX - 1,
                                                    y+1, x+1 );
                    }
                    if ((i == 0) && (j == 0))
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb((int)a1, (int)a2, (int)a3)),
                                                             j * pictureBox1.Width / sizeY, i * pictureBox1.Height / sizeX,
                                                     y+1, x+1);
                    }
                    if ((i == 0) && (j != 0))
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb((int)a1, (int)a2, (int)a3)),
                                                             j * pictureBox1.Width / sizeY - 1, i * pictureBox1.Height / sizeX,
                                                  y+1, x+1);
                    }
                    if ((i != 0) && (j == 0))
                    {                        
                        g.FillRectangle(new SolidBrush(Color.FromArgb((int)a1, (int)a2, (int)a3)),
                                                             j * pictureBox1.Width / sizeY, i * pictureBox1.Height / sizeX -1,
                                                     y+1, x+1);
                    }
                }

            g.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private void перерисоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private void обучитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                sizeY = Convert.ToInt32(textY.Text);
                sizeX = Convert.ToInt32(textX.Text);

                R = Convert.ToDouble(textBox3.Text); ;
                speed = (double)trackBar1.Value / 10;
                iterat = Convert.ToInt32(textBox2.Text);
    }
            catch
            {
                textY.Text = "30";
                textX.Text = "30";
                sizeY = 30;
                sizeX = 30;
                R = Math.Max(sizeX, sizeY) / 2;
                speed = 0.1;
                iterat = 7000;
            }

            List<string> listData = new List<string>();
            for (int i = 0; i < richTextBox1.Lines.Length; i++)
                listData.Add(richTextBox1.Lines[i]);

            Learning learning = new Learning(sizeX, sizeY, listData, R, speed, iterat);
            VectorW = learning.VectorW;

            Draw();

            //вывод весов
           /* for (int j = 0; j < sizeY; j++)
            {
                for (int i = 0; i < sizeX; i++)
                {
                    richTextBox2.Text += "( ";
                    for (int k = 0; k < 3; k++)
                    {
                        richTextBox2.Text += learning.VectorW[j, i, k] + " ";
                    }
                    richTextBox2.Text += " )";
                }
                richTextBox2.Text += "\n"; 
            }*/
        }

        private void распознатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recognition learning = new Recognition(sizeX, sizeY, VectorW, textBox1.Text.ToString());
            Graphics g = pictureBox2.CreateGraphics();

            long a1 = (long)VectorW[learning.znJ, learning.znI, 0];
            long a2 = (long)VectorW[learning.znJ, learning.znI, 1];
            long a3 = (long)VectorW[learning.znJ, learning.znI, 2];
            
            if (a1 > 255) a1 = 255;
            if (a2 > 255) a2 = 255;
            if (a3 > 255) a3 = 255;
            if (a1 < 0) a1 = 0;
            if (a2 < 0) a2 = 0;
            if (a3 < 0) a3 = 0;            

            g.FillRectangle(new SolidBrush(Color.FromArgb((int)a1, (int)a2, (int)a3)),
                                                          0, 0, pictureBox2.Width, pictureBox2.Height);
            /*********************************************************************************************/
            g.Dispose();

            Graphics g2 = pictureBox1.CreateGraphics();

            int y = pictureBox1.Width / sizeY;
            int x = pictureBox1.Height / sizeX;
            g2.DrawRectangle(new Pen(Color.White),
                                        learning.znJ * y, learning.znI *  x ,
                                        y , x);

             g2.Dispose();
            
        }

       
    }
}
