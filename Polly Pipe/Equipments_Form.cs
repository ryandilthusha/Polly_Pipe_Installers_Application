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
    public partial class Equipments_Form : Form
    {
        public Equipments_Form()
        {
            InitializeComponent();

            display_data_grid_view();   //Data Grid for Equipments Table
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-44KSVRU;Initial Catalog=Polly_Pipe;Integrated Security=True");
        SqlCommand cmd;


        //For data grid view
        SqlDataAdapter adpt;
        DataTable dt;


        //********************************* Quick Menu BUTTONS **********************************************************************************************************************

        private void btn_customers_Click(object sender, EventArgs e)
        {
            Customers_Form obj = new Customers_Form();
            obj.Show();
            this.Hide();
        }

        private void btn_employees_Click(object sender, EventArgs e)
        {
            Employees_Form obj = new Employees_Form();
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
            txt_equipmentID.Text = "";
            txt_equipment_type.Text = "";
            txt_equipments_list.Text = "";
        }

        public void display_data_grid_view()    //For the data grid view
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM Equipments_Table", con);
                adpt.Fill(dt);
                dgv_equipments.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void dgv_equipments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            int ID;

            ID = int.Parse(dgv_equipments.Rows[e.RowIndex].Cells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Equipments_Table WHERE Equipment_ID = '" + ID + "' ";

            SqlDataReader DR1 = cmd.ExecuteReader();

            if (DR1.Read())
            {
                txt_equipmentID.Text = DR1.GetValue(0).ToString();
                txt_equipment_type.Text = DR1.GetValue(1).ToString();
                txt_equipments_list.Text = DR1.GetValue(2).ToString();
            }
            DR1.Close();
            con.Close();
        }


        //***********************************SAVE*************Edit***************Delete*****************************************************************************************

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_equipment_type.Text == "" || txt_equipments_list.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Equipments_Table(Equipment_Type,Equipments_List) VALUES('" + txt_equipment_type.Text + "' , '" + txt_equipments_list.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Equipment added successfully!!!");

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
            if (txt_equipment_type.Text == "" || txt_equipments_list.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    con.Open();
                    cmd = new SqlCommand("UPDATE Equipments_Table SET Equipment_Type = '" + txt_equipment_type.Text + "' ,  Equipments_List = '" + txt_equipments_list.Text + "' WHERE Equipment_ID = '" + txt_equipmentID.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Equipment edit successfully!!!");

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
            if (txt_equipmentID.Text == "")
            {
                MessageBox.Show("Select Equipment to Delete");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Equipments_Table WHERE Equipment_ID = '" + txt_equipmentID.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Equipment delete successfully!!!");

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
            txt_equipmentID.Text = "";
            txt_equipment_type.Text = "";
            txt_equipments_list.Text = "";
        }
    }
}
