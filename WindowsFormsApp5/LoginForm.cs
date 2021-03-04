using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp5
{
    public partial class LoginForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

 
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        MainForm Form2 = new MainForm();
        public static int flag1;
        Authentication form3 = new Authentication();
        private void button1_Click(object sender, EventArgs e)
        {
            flag1 = 0;
            this.Hide();
            Form2.ShowDialog();
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flag1 = 1;
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }

    }


 
    }

