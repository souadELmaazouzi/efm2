using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace efm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-INU93R5\SQLEXPRESS01;Initial Catalog=tdiefm;Integrated Security=True");
        SqlCommand cmd = new SqlCommand("select * from personne ;");
        DataTable dt = new DataTable();
        BindingSource bd = new BindingSource();
        private void Form1_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = bd;
            cnx.Close();
            affiche();
        }
        private void affiche()
        {
            cmd.Connection = cnx;
            cnx.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            bd.DataSource = dt;
            textBox1.DataBindings.Add("Text", bd, "CIN");
            textBox2.DataBindings.Add("Text", bd, "NOM");
            textBox3.DataBindings.Add("Text", bd, "Prenom");
            textBox4.DataBindings.Add("Text", bd, "age");
            textBox5.DataBindings.Add("Text", bd, "age");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bd.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bd.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bd.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bd.MoveLast();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text=string.Empty;
            textBox2.Text=string.Empty;
            textBox3.Text=string.Empty;
            textBox4.Text=string.Empty;
            textBox5.Text=string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }   
}
