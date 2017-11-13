using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_rhalf
{
    public partial class Form1 : Form
    {
        //Variaveis para movimentação da Form...
        int x, y;
        Point Point = new Point();


        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        #region Movimentar a Form...

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point = Control.MousePosition;
                Point.X -= x;
                Point.Y -= y;
                this.Location = Point;
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }
        #endregion

        #region Design dos botões, e funções minimizar, fechar, e maximizar...

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.IndianRed;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Crimson;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.IndianRed;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Crimson;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            string URL = string.Empty;
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    URL = "http://cdn.upx.net.br/listen/00189.wmx";
                    break;

                case 1:
                    URL = "http://mixaac.crossradio.com.br:1100/live";
                    break;

                default:
                    MessageBox.Show("Selecione uma rádio!!");
                    break;

            }

            if (!URL.Equals(""))
                axWindowsMediaPlayer1.URL = URL ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Jovem Pan");
            listBox1.Items.Add("Mix");
        }
    }
}
