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
namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=vinod-PC;Initial Catalog=Sample;Integrated Security=True");
            SqlDataAdapter ss = new SqlDataAdapter("select count(*) from Login",con);
            DataTable dt = new DataTable();
            ss.Fill(dt);




            this.Hide();
            Main f1 = new Main();        
            f1.Show();
        }
    }
}
