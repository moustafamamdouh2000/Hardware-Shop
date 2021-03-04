using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace WindowsFormsApp5
{
    public partial class MainForm : Form
    {
        static string connectionstring = @"Data Source=LAPTOP-27QOD7MD;Initial Catalog=MainDataBase;Integrated Security=True";
        SqlConnection cnn = new SqlConnection(connectionstring);
        SqlCommand cmd;
        SqlDataAdapter data = new SqlDataAdapter();
        public static int i = 0;
        Component[] Comps = new Component[100];
        string name, specs, manufacture,serial_number, type,price;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {// TODO: This line of code loads data into the 'mainDataBaseDataSet.Components' table. You can move, or remove it, as needed.
            this.componentsTableAdapter.Fill(this.mainDataBaseDataSet.Components);
            this.testtTableAdapter.Fill(this.testDataSet.Testt);
            if (LoginForm.flag1 == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
        public void button1_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          /*  cnn.Open();
            string query = "SELECT * FROM Components ";
            SqlDataAdapter SDA = new SqlDataAdapter(query,cnn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            Grid.DataSource = dt;
            cnn.Close();*/
        }
 
        public const int WM_NCHITTEST = 0x84;
        public const int HT_CLIENT = 0x1;
        public const int HT_CAPTION = 0x2;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panelleft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Component1_Load(object sender, EventArgs e)
        {

        }

        private void Home_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void guna2TextBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Storage_Panel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Storage_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainText_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {
         /*   name = guna2TextBox5.Text;
            manufacture = guna2TextBox2.Text;
            serial_number = guna2TextBox1.Text;
            type = Convert.ToString(guna2ComboBox1.SelectedItem);
            specs = richTextBox1.Text;
            price = guna2TextBox3.Text;*/
            if (Convert.ToString(guna2ComboBox1.SelectedItem) == "Rams")
            {
                type = "Rams";
                Comps[i] = new Rams(name, serial_number, manufacture);
            }
            else if (Convert.ToString(guna2ComboBox1.SelectedItem) == "MotherBoard")
            {
                type = "MotherBoard";
                Comps[i] = new MotherBoard(name, serial_number, manufacture);
            }
            else if (Convert.ToString(guna2ComboBox1.SelectedItem) == "GPU")
            {
                type = "GPU";
                Comps[i] = new GPU(name, serial_number, manufacture);
            }
            cnn.Open();
             data.InsertCommand = new SqlCommand("INSERT INTO Components VALUES(@Serial_Number,@Name,@Manufacture,@Specs,@Type,@Price)");
              data.InsertCommand.Connection = cnn;
              data.InsertCommand.Parameters.Add("@Serial_Number", serial_number);
              data.InsertCommand.Parameters.Add("@Name",name);
              data.InsertCommand.Parameters.Add("@Manufacture", manufacture);
              data.InsertCommand.Parameters.Add("@Specs", specs);
              data.InsertCommand.Parameters.Add("@Type", type);
              data.InsertCommand.Parameters.Add("@Price", price);
              data.InsertCommand.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Added !");
            clearTexts();
            i++;
        }
        private void clearTexts()
        {
            /*guna2TextBox1.Clear();
          guna2TextBox3.Clear();
            richTextBox1.Clear();
            guna2TextBox2.Clear();
            guna2TextBox5.Clear();
            guna2ComboBox1.ResetText();*/
        }
    } }