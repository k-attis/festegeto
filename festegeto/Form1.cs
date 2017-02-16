using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace festegeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap buffer;
        Graphics bufferg;

        private void panel2_Resize(object sender, EventArgs e)
        {
            buffer = new Bitmap(panel2.Width, panel2.Height);
            bufferg = Graphics.FromImage(buffer);
        }

        Thread t;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            t = new Thread(new ThreadStart(szal));
            t.Start();
        }

        void szal()
        {
            bufferg.Clear(Color.White);

            for (int y = 0; y < buffer.Height; y++)
                for (int x = 0; x < buffer.Width; x++)
                    if ((y * buffer.Width + x) % 8 == 1)
                        buffer.SetPixel(x, y, Color.Black);

            button1.Enabled = true;
        }
    }
}
