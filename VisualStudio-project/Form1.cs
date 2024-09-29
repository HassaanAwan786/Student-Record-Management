using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace webassignment4
{
    public partial class Form1 : Form
    {
        private const string connectionString = @"Data Source=DESKTOP-23ESJGT\SQLEXPRESS;Initial Catalog=Web-Assign;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetStudentRecord();
        }

        private void GetStudentRecord()//table function
        {
             
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM StudentsTb";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);

                con.Close();

                StudentRecordDataGridView.DataSource = dt;

               

                // Enable horizontal scrolling
                StudentRecordDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                StudentRecordDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                StudentRecordDataGridView.ScrollBars = ScrollBars.Both;
            }

        }

        private void button1_Click(object sender, EventArgs e)// this function is for inserting the data 
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {   //here @nam is temporary variable
                string query = "INSERT INTO StudentsTb (RollNumber,Name ,FatherName,Mobile,Address) VALUES (@RollNum, @Nam,@FNam,@mobile,@address)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nam", txtStudentName.Text);
                cmd.Parameters.AddWithValue("@RollNum", int.TryParse(txtRollNumber.Text, out int studentID) ? studentID : (int?)null);
                cmd.Parameters.AddWithValue("@FNam", txtFatherName.Text);
                cmd.Parameters.AddWithValue("@mobile", txtMobile.Text); 
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                // Refresh the student record after adding a new student
                GetStudentRecord();

                // Clear the textboxes     it serve the same pupose as reset function do but its automatic
                txtStudentName.Text = "";
                txtRollNumber.Text = "";
                txtFatherName.Text = "";
                txtMobile.Text = "";
                txtAddress.Text = "";

                MessageBox.Show("Row inserted successfully.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//THIS IS DELETE BUTTON
        {
            if (StudentRecordDataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = StudentRecordDataGridView.SelectedRows[0].Index;
                int studentID = Convert.ToInt32(StudentRecordDataGridView.Rows[selectedRowIndex].Cells["RollNumber"].Value);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM StudentsTb WHERE RollNumber = @RollNum";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@RollNum", studentID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    // Refresh the student record after deleting
                    GetStudentRecord();

                    // Clear the textboxes
                    txtStudentName.Text = "";
                    txtRollNumber.Text = "";
                    txtFatherName.Text = "";
                    txtMobile.Text = "";
                    txtAddress.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
            MessageBox.Show("SELECTED ROW IS DELETED SUCCESSFULLY.");
        }

        private void button4_Click(object sender, EventArgs e)//this button is for resetig the text field 
        {
            // Clear the textboxes
            txtStudentName.Text = "";
            txtRollNumber.Text = "";
            txtFatherName.Text = "";
            txtMobile.Text = "";
            txtAddress.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)/// update button
        {
            if (StudentRecordDataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = StudentRecordDataGridView.SelectedRows[0].Index;
                int studentID = Convert.ToInt32(StudentRecordDataGridView.Rows[selectedRowIndex].Cells["RollNumber"].Value);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "UPDATE StudentsTb SET Name = @Nam, FatherName = @FNam, Mobile = @mobile, Address = @address WHERE RollNumber = @RollNum";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Nam", txtStudentName.Text);
                    cmd.Parameters.AddWithValue("@FNam", txtFatherName.Text);
                    cmd.Parameters.AddWithValue("@mobile", txtMobile.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@RollNum", studentID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    // Refresh the student record after updating
                    GetStudentRecord();

                     
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
            MessageBox.Show("Updated successful.");
        }
    }
}
