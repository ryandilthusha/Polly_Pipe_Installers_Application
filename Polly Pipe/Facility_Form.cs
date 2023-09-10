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
    public partial class Facility_Form : Form
    {
        public Facility_Form()
        {
            InitializeComponent();

            display_data_grid_view_Facilities();   //Data Grid for Facilities

            display_data_grid_view_Employee_Types();    //Data Grid for Employee Types

            display_data_grid_view_Equipment_Types();   //Data Grid for Equipment Types


            fillcombo_EmployeeType_ID();        //Filling Employee Type ID ComboBox with Employee Type table's Facility ID

            fillcombo_EquipmentType_ID();       //Filling Equipment ID ID ComboBox with Equipment table's Facility ID
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

        private void btn_equipments_Click(object sender, EventArgs e)
        {
            Equipments_Form obj = new Equipments_Form();
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
            txt_facilityID.Text = "";
            txt_facility_type.Text = "";
            txt_installation_period.Text = "";
            cmb_employee_type.Text = "";
            txt_additional_employees.Text = "";
            cmb_equipment_type.Text = "";
            txt_additional_equipments.Text = "";
        }

        public void display_data_grid_view_Facilities()    //For the data grid view of Facilities
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM Facility_Table", con);
                adpt.Fill(dt);
                dgv_facilities.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void dgv_facilities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            int ID;

            ID = int.Parse(dgv_facilities.Rows[e.RowIndex].Cells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Facility_Table WHERE Facility_ID = '" + ID + "' ";

            SqlDataReader DR1 = cmd.ExecuteReader();

            if (DR1.Read())
            {
                txt_facilityID.Text = DR1.GetValue(0).ToString();
                txt_facility_type.Text = DR1.GetValue(1).ToString();
                txt_installation_period.Text = DR1.GetValue(2).ToString();
                cmb_employee_type.Text = DR1.GetValue(3).ToString();
                txt_additional_employees.Text = DR1.GetValue(4).ToString();
                cmb_equipment_type.Text = DR1.GetValue(5).ToString();
                txt_additional_equipments.Text = DR1.GetValue(6).ToString();
            }
            DR1.Close();
            con.Close();
        }


        public void display_data_grid_view_Employee_Types()    //For the data grid view of Employee Types
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM Employee_Type_Table", con);
                adpt.Fill(dt);
                dgv_employee_types.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void dgv_employee_types_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            int ID;

            ID = int.Parse(dgv_employee_types.Rows[e.RowIndex].Cells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Employee_Type_Table WHERE Employee_Type_ID = '" + ID + "' ";

            SqlDataReader DR1 = cmd.ExecuteReader();

            if (DR1.Read())
            {
                cmb_employee_type.Text = DR1.GetValue(0).ToString();
            }
            DR1.Close();
            con.Close();
        }

        public void display_data_grid_view_Equipment_Types()    //For the data grid view of Equipment Types
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM Equipments_Table", con);
                adpt.Fill(dt);
                dgv_equipment_types.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void dgv_equipment_types_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            int ID;

            ID = int.Parse(dgv_equipment_types.Rows[e.RowIndex].Cells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Equipments_Table WHERE Equipment_ID = '" + ID + "' ";

            SqlDataReader DR1 = cmd.ExecuteReader();

            if (DR1.Read())
            {
                cmb_equipment_type.Text = DR1.GetValue(0).ToString();
            }
            DR1.Close();
            con.Close();
        }

        // Employee Type ID ComboBox Fill ******* Employee Type ID ComboBox Fill ******* Employee Type ID ComboBox Fill ******* Employee Type ID ComboBox Fill ******* Employee Type ID ComboBox Fill ******* Employee Type ID ComboBox Fill *******

        private void fillcombo_EmployeeType_ID()    //ComboBox fill with Facility IDs
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Employee_Type_ID FROM Employee_Type_Table", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("cmb_employee_type", typeof(int));
            dt.Load(dr);
            cmb_employee_type.ValueMember = "Employee_Type_ID";
            cmb_employee_type.DataSource = dt;
            con.Close();
        }



        // Equipment Type ID ComboBox Fill ******* Equipment Type ID ComboBox Fill ******* Equipment Type ID ComboBox Fill ******* Equipment Type ID ComboBox Fill ******* Equipment Type ID ComboBox Fill ******* Equipment Type ID ComboBox Fill *******

        private void fillcombo_EquipmentType_ID()    //ComboBox fill with Facility IDs
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Equipment_ID FROM Equipments_Table", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("cmb_equipment_type", typeof(int));
            dt.Load(dr);
            cmb_equipment_type.ValueMember = "Equipment_ID";
            cmb_equipment_type.DataSource = dt;
            con.Close();
        }


        //***********************************SAVE*************Edit***************Delete*****************************************************************************************

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_facility_type.Text == "" || txt_installation_period.Text == "" || cmb_employee_type.Text == "" || txt_additional_employees.Text == "" || cmb_equipment_type.Text == "" || txt_additional_equipments.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Facility_Table(Facility_Type,Installation_Period,Employee_Type,Additional_Employees,Equipment_Type,Additional_Equipments) VALUES('" + txt_facility_type.Text + "' , '" + txt_installation_period.Text + "' , '" + cmb_employee_type.Text + "' , '" + txt_additional_employees.Text + "' , '" + cmb_equipment_type.Text + "' , '" + txt_additional_equipments.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Facility added successfully!!!");

                    display_data_grid_view_Facilities();   //data grid view method
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
            if (txt_facility_type.Text == "" || txt_installation_period.Text == "" || cmb_employee_type.Text == "" || txt_additional_employees.Text == "" || cmb_equipment_type.Text == "" || txt_additional_equipments.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    con.Open();
                    cmd = new SqlCommand("UPDATE Facility_Table SET Facility_Type = '" + txt_facility_type.Text + "' , Installation_Period = '" + txt_installation_period.Text + "' ,  Employee_Type = '" + cmb_employee_type.Text + "', Additional_Employees = '" + txt_additional_employees.Text + "' ,  Equipment_Type = '" + cmb_equipment_type.Text + "', Additional_Equipments = '" + txt_additional_equipments.Text + "'  WHERE Facility_ID = '" + txt_facilityID.Text + "'  ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Facility edit successfully!!!");

                    display_data_grid_view_Facilities();   //data grid view method
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
            if (txt_facilityID.Text == "")
            {
                MessageBox.Show("Select Facility to Delete");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Facility_Table WHERE Facility_ID = '" + txt_facilityID.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Facility delete successfully!!!");

                    display_data_grid_view_Facilities();   //data grid view method
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
            txt_facilityID.Text = "";
            txt_facility_type.Text = "";
            txt_installation_period.Text = "";
            cmb_employee_type.Text = "";
            txt_additional_employees.Text = "";
            cmb_equipment_type.Text = "";
            txt_additional_equipments.Text = "";
        }
    }
}
