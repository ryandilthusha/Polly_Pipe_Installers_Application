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
    public partial class Customers_Form : Form
    {
        public Customers_Form()
        {
            InitializeComponent();

            display_data_grid_view();   //Data Grid for Customers Table
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-44KSVRU;Initial Catalog=Polly_Pipe;Integrated Security=True");
        SqlCommand cmd;


        //For data grid view
        SqlDataAdapter adpt;
        DataTable dt;


        //********************************* Quick Menu BUTTONS **********************************************************************************************************************

        private void btn_employees_Click(object sender, EventArgs e)
        {
            Employees_Form obj = new Employees_Form();
            obj.Show();
            this.Hide();
        }

        private void btn_equipments_Click(object sender, EventArgs e)
        {
            Equipments_Form obj = new Equipments_Form();
            obj.Show();
            this.Hide();
        }

        private void btn_facilities_Click(object sender, EventArgs e)
        {
            Facility_Form obj = new Facility_Form();
            obj.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login_Form obj = new Login_Form();
            obj.Show();
            this.Hide();
        }

        //********************************* OTHER METHODS **********************************************************************************************************************

        public void clear()
        {
            txt_customerID.Text = "";
            txt_name.Text = "";
            txt_phone.Text = "";
            txt_address.Text = "";            
        }

        public void display_data_grid_view()    //For the data grid view
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM Customers_Table", con);
                adpt.Fill(dt);
                dgv_customers.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void dgv_customers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            int ID;

            ID = int.Parse(dgv_customers.Rows[e.RowIndex].Cells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Customers_Table WHERE Customer_ID = '" + ID + "' ";

            SqlDataReader DR1 = cmd.ExecuteReader();

            if (DR1.Read())
            {
                txt_customerID.Text = DR1.GetValue(0).ToString();
                txt_name.Text = DR1.GetValue(1).ToString();
                txt_phone.Text = DR1.GetValue(2).ToString();
                txt_address.Text = DR1.GetValue(3).ToString();
            }
            DR1.Close();
            con.Close();
        }


        //***********************************SAVE*************Edit***************Delete*****************************************************************************************

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_phone.Text == "" || txt_address.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {                    
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Customers_Table(Name,Phone,Address) VALUES('" + txt_name.Text + "' , '" + txt_phone.Text + "' , '" + txt_address.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer added successfully!!!");

                    display_data_grid_view();   //data grid view method
                    clear();    //data clear method

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_phone.Text == "" || txt_address.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    con.Open();
                    cmd = new SqlCommand("UPDATE Customers_Table SET Name = '" + txt_name.Text + "' ,  Phone = '" + txt_phone.Text + "', Address = '" + txt_address.Text + "' WHERE Customer_ID = '" + txt_customerID.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer edit successfully!!!");

                    display_data_grid_view();   //data grid view method
                    clear();    //data clear method                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_customerID.Text == "")
            {
                MessageBox.Show("Select Customer to Delete");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Customers_Table WHERE Customer_ID = '" + txt_customerID.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer delete successfully!!!");

                    display_data_grid_view();   //data grid view method
                    clear();    //data clear method
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_customerID.Text = "";
            txt_name.Text = "";
            txt_phone.Text = "";
            txt_address.Text = "";
        }
    }
}
