using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Simple_Login_FORM
{
    public partial class RegisterForm : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=pc.savagerpls.fr;port=3306;Initial Catalog=LoginForm;User Id=Arloniumexec;password='Arlonium628807800'");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm fm = new LoginForm();
            fm.Show();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO LoginForm (email,username, password) VALUES ('" + EmailBox.Text + "', '" + PasswordBox.Text + "','" + UsernameBox.Text + "');";
            DataTable de = new DataTable();
            MySqlDataAdapter dp = new MySqlDataAdapter(cmd);
            dp.Fill(de);
            con.Close();
            MessageBox.Show("Votre inscription est terminée, merci de contacter Alx ou Lny sur discord afin que votre compte soit activé.");
        }
    }
}
