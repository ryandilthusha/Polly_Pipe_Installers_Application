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
    public partial class Employees_Form : Form
    {
        public Employees_Form()
        {
            InitializeComponent();

            display_data_grid_view_Employees();   //Data Grid for Employees

            display_data_grid_view_Employee_Types();    //Data Grid for Employee Types



            fillcombo_EmployeeType_ID();        //Filling Employee Type ID ComboBox with Employee Type table's Facility ID
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

        private void btn_employee_Types_Click(object sender, EventArgs e)
        {
            EmployeeTypes_Form obj = new EmployeeTypes_Form();
            obj.Show();
            this.Hide();
        }


        //********************************* OTHER METHODS **********************************************************************************************************************

        public void clear()
        {
            txt_employeeID.Text = "";
            cmb_employee_type.Text = "";
            txt_name.Text = "";
            txt_phone.Text = "";
            txt_address.Text = "";
        }

        public void display_data_grid_view_Employees()    //For the data grid view of Employees
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM Employees_Table", con);
                adpt.Fill(dt);
                dgv_employees.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void dgv_employees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            int ID;

            ID = int.Parse(dgv_employees.Rows[e.RowIndex].Cells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Employees_Table WHERE Employee_ID = '" + ID + "' ";

            SqlDataReader DR1 = cmd.ExecuteReader();

            if (DR1.Read())
            {
                txt_employeeID.Text = DR1.GetValue(0).ToString();
                cmb_employee_type.Text = DR1.GetValue(1).ToString();
                txt_name.Text = DR1.GetValue(2).ToString();
                txt_phone.Text = DR1.GetValue(3).ToString();
                txt_address.Text = DR1.GetValue(4).ToString();
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

        //***********************************SAVE*************Edit***************Delete*****************************************************************************************

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (cmb_employee_type.Text == "" || txt_name.Text == "" || txt_phone.Text == "" || txt_address.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Employees_Table(Employee_Type,Name,Phone,Address) VALUES('" + cmb_employee_type.Text + "' , '" + txt_name.Text + "' , '" + txt_phone.Text + "' , '" + txt_address.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Employee added successfully!!!");

                    display_data_grid_view_Employees();   //data grid view method
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
            if (cmb_employee_type.Text == "" || txt_name.Text == "" || txt_phone.Text == "" || txt_address.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    con.Open();
                    cmd = new SqlCommand("UPDATE Employees_Table SET Employee_Type = '" + cmb_employee_type.Text + "' , Name = '" + txt_name.Text + "' ,  Phone = '" + txt_phone.Text + "', Address = '" + txt_address.Text + "' WHERE Employee_ID = '" + txt_employeeID.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Employee edit successfully!!!");

                    display_data_grid_view_Employees();   //data grid view method
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
            if (txt_employeeID.Text == "")
            {
                MessageBox.Show("Select Employee to Delete");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Employees_Table WHERE Employee_ID = '" + txt_employeeID.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Employee delete successfully!!!");

                    display_data_grid_view_Employees();   //data grid view method
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
            txt_employeeID.Text = "";
            cmb_employee_type.Text = "";
            txt_name.Text = "";
            txt_phone.Text = "";
            txt_address.Text = "";
        }

        
    }
}
