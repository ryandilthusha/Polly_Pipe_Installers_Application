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
    public partial class EmployeeTypes_Form : Form
    {
        public EmployeeTypes_Form()
        {
            InitializeComponent();

            display_data_grid_view();   //Data Grid for Employee Types Table
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-44KSVRU;Initial Catalog=Polly_Pipe;Integrated Security=True");
        SqlCommand cmd;


        //For data grid view
        SqlDataAdapter adpt;
        DataTable dt;


        //********************************* Quick Menu BUTTONS **********************************************************************************************************************

        private void btn_back_Click(object sender, EventArgs e)
        {
            Employees_Form obj = new Employees_Form();
            obj.Show();
            this.Hide();
        }


        //********************************* OTHER METHODS **********************************************************************************************************************

        public void clear()
        {
            txt_employee_typeID.Text = "";
            txt_employee_type.Text = "";
        }

        public void display_data_grid_view()    //For the data grid view of Employees
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
                txt_employee_typeID.Text = DR1.GetValue(0).ToString();
                txt_employee_type.Text = DR1.GetValue(1).ToString();
            }
            DR1.Close();
            con.Close();
        }


        //***********************************SAVE*************Edit***************Delete*****************************************************************************************

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_employee_type.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Employee_Type_Table(Employee_Type) VALUES('" + txt_employee_type.Text + "' )", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Employee Type added successfully!!!");

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
            if (txt_employee_type.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    con.Open();
                    cmd = new SqlCommand("UPDATE Employee_Type_Table SET Employee_Type = '" + txt_employee_type.Text + "'  WHERE Employee_Type_ID = '" + txt_employee_typeID.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Employee Type edit successfully!!!");

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
            if (txt_employee_typeID.Text == "")
            {
                MessageBox.Show("Select Employee Type to Delete");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Employee_Type_Table WHERE Employee_Type_ID = '" + txt_employee_typeID.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Employee Type delete successfully!!!");

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
            txt_employee_typeID.Text = "";
            txt_employee_type.Text = "";
        }
    }
}
