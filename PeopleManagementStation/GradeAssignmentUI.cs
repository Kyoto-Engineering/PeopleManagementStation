using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppUserManagementSystem.DbGateway;


namespace PeopleManagementStation
{

    public partial class GradeAssignmentUI : Form
    {
        public bool statusidselected;
        public int statusId;
        private int userid;
        private SqlConnection con;
        private SqlCommand cmd;
        ConnectionString cs = new ConnectionString();
        private SqlDataReader rdr;
        public GradeAssignmentUI()
        {
            InitializeComponent();
        }


        

        private void employeegrdload()
        {

            con = new SqlConnection(cs.DBConn);
            con.Open();
            string q1 ="SELECT Users.UserName, Users.FullName, Designations.Designation FROM Users LEFT OUTER JOIN Designations ON Users.DesignationId = Designations.DesignationId";
            cmd = new SqlCommand(q1, con);
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            Employee.Rows.Clear();
            while (rdr.Read() == true)
            {
                Employee.Rows.Add(rdr[0], rdr[1], rdr[2]);
            }

            con.Close();



        }

       


        private void UserStatusUI_Load(object sender, EventArgs e)
        {
            gradegrdload();

            groupBox3.Enabled = false;
            button1.Enabled = false;
        }

        private void gradegrdload()
        {

            con = new SqlConnection(cs.DBConn);
            con.Open();
            string q1 = "SELECT Grade.GradeId, Grade.Basics, Grade.TransportAllowance, Grade.MedicalAllowance, Grade.HouseRent, grade.OtherAllowance, grade.GrossSalary FROM Grade";
            cmd = new SqlCommand(q1, con);
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            Gradegrid.Rows.Clear();
            while (rdr.Read() == true)
            {
                Gradegrid.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6]);
            }

            con.Close();



        }

      


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void MainUI(object sender, EventArgs e)
        {
            employeegrdload();
            gradegrdload();
            groupBox3.Enabled = false;
            button1.Enabled = false;
        }

        private void Employee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Employee.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow dr = Employee.CurrentRow;


                    fullnamebox.Text = dr.Cells[0].Value.ToString();
                    nicknametxtbox.Text = dr.Cells[1].Value.ToString();
                    designationtxtbox.Text = dr.Cells[2].Value.ToString();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                groupBox3.Enabled = true;
            }
        }

        private void Gradegrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Employee.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow dr = Employee.CurrentRow;


                    newgradetextbox.Text = dr.Cells[0].Value.ToString();
                   

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                groupBox3.Enabled = true;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
