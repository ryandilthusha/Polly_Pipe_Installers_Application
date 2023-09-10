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
    public partial class Installation_Form : Form
    {
        public Installation_Form()
        {
            InitializeComponent();

            display_data_grid_view_Installation();      //Data Grid for Installations

            display_data_grid_view_Facilities();        //Data Grid for Facilities

            display_data_grid_view_Customers();         //Data Grid for Customers



            fillcombo_FacilityID();    //Filling Facility ID ComboBox with Facility table's Facility ID

            fillcombo_CustomerID();    //Filling Customer ID ComboBox with Customer table's Customer ID

        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-44KSVRU;Initial Catalog=Polly_Pipe;Integrated Security=True");
        SqlCommand cmd;


        //For data grid view
        SqlDataAdapter adpt;
        DataTable dt;

        //********************************* Quick Menu BUTTONS **********************************************************************************************************************

        private void btn_customers_Click(object sender, EventArgs e)
        {
            Customers_Form2 obj = new Customers_Form2();
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
            txt_installationID.Text = "";
            cmb_facilityID.Text = "";
            cmb_customerID.Text = "";
            txt_installation_location.Text = "";
            dtp_start_date.Value = DateTime.Now;
            dtp_ending_date.Value = DateTime.Now;
        }

        public void display_data_grid_view_Installation()    //For the data grid view of Facilities
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM Installation_Table", con);
                adpt.Fill(dt);
                dgv_installation.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void dgv_installation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            int ID;

            ID = int.Parse(dgv_installation.Rows[e.RowIndex].Cells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Installation_Table WHERE Installation_ID = '" + ID + "' ";

            SqlDataReader DR1 = cmd.ExecuteReader();

            if (DR1.Read())
            {
                txt_installationID.Text = DR1.GetValue(0).ToString();
                cmb_facilityID.Text = DR1.GetValue(1).ToString();
                cmb_customerID.Text = DR1.GetValue(2).ToString();
                txt_installationID.Text = DR1.GetValue(3).ToString();
                dtp_start_date.Value = DateTime.Parse(DR1.GetValue(4).ToString());
                dtp_ending_date.Value = DateTime.Parse(DR1.GetValue(5).ToString());
            }
            DR1.Close();
            con.Close();
        }

        public void display_data_grid_view_Facilities()    //For the data grid view of Facilities List
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM Facility_Table", con);
                adpt.Fill(dt);
                dgv_facility_List.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void dgv_facility_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            int ID;

            ID = int.Parse(dgv_facility_List.Rows[e.RowIndex].Cells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Facility_Table WHERE Facility_ID = '" + ID + "' ";

            SqlDataReader DR1 = cmd.ExecuteReader();

            if (DR1.Read())
            {
                cmb_facilityID.Text = DR1.GetValue(0).ToString();
            }
            DR1.Close();
            con.Close();
        }

        public void display_data_grid_view_Customers()    //For the data grid view of Customers
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
                cmb_customerID.Text = DR1.GetValue(0).ToString();
            }
            DR1.Close();
            con.Close();
        }





        // Facility ID ComboBox Fill ******* Facility ID ComboBox Fill ******* Facility ID ComboBox Fill ******* Facility ID ComboBox Fill ******* Facility ID ComboBox Fill ******* Facility ID ComboBox Fill *******

        private void fillcombo_FacilityID()    //ComboBox fill with Facility IDs
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Facility_ID FROM Facility_Table", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("cmb_facilityID", typeof(int));
            dt.Load(dr);
            cmb_facilityID.ValueMember = "Facility_ID";
            cmb_facilityID.DataSource = dt;
            con.Close();
        }

        // Customer ID ComboBox Fill ******* Customer ID ComboBox Fill ******* Customer ID ComboBox Fill ******* Customer ID ComboBox Fill ******* Customer ID ComboBox Fill ******* Customer ID ComboBox Fill *******

        private void fillcombo_CustomerID()    //ComboBox fill with Facility IDs
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Customer_ID FROM Customers_Table", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("cmb_customerID", typeof(int));
            dt.Load(dr);
            cmb_customerID.ValueMember = "Customer_ID";
            cmb_customerID.DataSource = dt;
            con.Close();
        }





        //***********************************SAVE*************Edit***************Delete*****************************************************************************************

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (cmb_facilityID.Text == "" || cmb_customerID.Text == "" || txt_installation_location.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Installation_Table(Facility_ID,Customer_ID,Installation_Location,Start_date,End_date) VALUES('" + cmb_facilityID.Text + "' , '" + cmb_customerID.Text + "' , '" + txt_installation_location.Text + "' , '" + dtp_start_date.Value.ToString("yyyy-MM-dd") + "' , '" + dtp_ending_date.Value.ToString("yyyy-MM-dd") + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Installation added successfully!!!");

                    display_data_grid_view_Installation();   //data grid view method
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
            if (cmb_facilityID.Text == "" || cmb_customerID.Text == "" || txt_installation_location.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    con.Open();
                    cmd = new SqlCommand("UPDATE Installation_Table SET Facility_ID = '" + cmb_facilityID.Text + "' , Customer_ID = '" + cmb_customerID.Text + "' ,  Installation_Location = '" + txt_installation_location.Text + "', Start_date = '" + dtp_start_date.Value.ToString("yyyy-MM-dd") + "' ,  End_date = '" + dtp_ending_date.Value.ToString("yyyy-MM-dd") + "'  WHERE Installation_ID = '" + txt_installationID.Text + "'  ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Installation edit successfully!!!");

                    display_data_grid_view_Installation();   //data grid view method
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
            if (txt_installationID.Text == "")
            {
                MessageBox.Show("Select Installation to Delete");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Installation_Table WHERE Installation_ID = '" + txt_installationID.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Installation delete successfully!!!");

                    display_data_grid_view_Installation();   //data grid view method
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
            txt_installationID.Text = "";
            cmb_facilityID.Text = "";
            cmb_customerID.Text = "";
            txt_installation_location.Text = "";
            dtp_start_date.Value = DateTime.Now;
            dtp_ending_date.Value = DateTime.Now;
        }
    }
}
