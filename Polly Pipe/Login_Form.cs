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

namespace Polly_Pipe
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-44KSVRU;Initial Catalog=Rent_Car_Project;Integrated Security=True");

        private void Login_Form_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (cmb_role.Text == "Select a Role" && txt_username.Text == "" && txt_password.Text == "")
            {
                MessageBox.Show("Select a Role then enter username and password");
            }
            else if (cmb_role.Text == "Select a Role" && txt_username.Text == "" && txt_password.Text != "")
            {
                MessageBox.Show("Select a Role then enter username");
            }
            else if (cmb_role.Text == "Select a Role" && txt_username.Text != "" && txt_password.Text == "")
            {
                MessageBox.Show("Select a Role then enter password");
            }
            else if (cmb_role.Text == "Select a Role" && txt_username.Text != "" && txt_password.Text != "")
            {
                MessageBox.Show("Select a Role");
            }

            else
            {
                // ADMIN LOGIN CODE with defined Username and Password

                if (cmb_role.SelectedIndex > -1)
                {
                    if (cmb_role.SelectedItem.ToString() == "ADMIN")
                    {
                        if (txt_username.Text == "Admin" && txt_password.Text == "Admin")
                        {
                            Customers_Form obj = new Customers_Form();
                            this.Hide();
                            obj.Show();
                        }
                        else
                        {
                            MessageBox.Show("If you are ADMIN, please enter correct Username and Password");
                        }
                    }
                    else
                    {
                        // REPRESENTATIVE LOGIN CODE with defined Username and Password in the DATABASE

                        
                        if (cmb_role.SelectedItem.ToString() == "REPRESENTATIVE")
                        {
                            if (txt_username.Text == "Rep" && txt_password.Text == "Rep")
                            {
                                Installation_Form obj = new Installation_Form();
                                this.Hide();
                                obj.Show();
                            }
                            else
                            {
                                MessageBox.Show("If you are REPRESENTATIVE, please enter correct Username and Password");
                            }
                        }
                    }
                }
            }
        }

        private void lbl_clear_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
            txt_password.Text = "";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
