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

namespace Learning_Courses_2
{
    public partial class Form1 : Form
    {
        public string conString = "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Initial Catalog=p1g8;User ID=p1g8;Password=Bd2022ua";
        public string DATABASE_PROJECT_PREFIX = "LearningCourses";
        public string TABLE_COURSE = "Course";
        public string TABLE_COMPANY = "Company";
        public string TABLE_COUNTRIES = "Countries";
        public string TABLE_COURSE_INSTANCE = "Course_Instance";
        public string TABLE_EMPLOYEE = "Emoployee";
        public string TABLE_INSTANCE_ATENDEE = "Instance_Atendee";
        public string TABLE_ORDERS = "Orders";
        public string TABLE_TUTOR = "Tutor";
        public int rowsSize = 0;
        public SqlConnection con;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(conString);
        }

        private void Tabs_SelectedIndexChanged(object sender, TabControlEventArgs e)
            {
              if (e.TabPage.Name == "tab_start")
            {

            }else if(e.TabPage.Name == "tab_courses")
            {
                refreshDataForCoursesTable();

            }
            else if (e.TabPage.Name == "tab_companies")
            {
                refreshDataForCompaniesTable();
            }
         
        }



        private void company_addBtn_Click(object sender, EventArgs e)
        {
            bool canRun = true;
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                if (!String.IsNullOrEmpty(companyIdTxtBox.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("Id field is populated, thats mean maybe you want to update it instead of Adding. Are you sure you want add this record ?", "Add Record", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        canRun = true;
                    }
                    else
                    {
                        canRun = false;
                    }
                }

                if (canRun)
                {
                    string query = "INSERT INTO " + DATABASE_PROJECT_PREFIX + "." + TABLE_COMPANY;
                    string tablefields = "(company_id,company_name,industry)";
                    string values = "values(";
                    values = values + addValue((rowsSize + 1).ToString()) + ",";
                    values = values + addValue(companyNameTxtBox.Text) + ",";
                    values = values + addValue(companyIndustryTxtBox.Text);
                    values = values + ")";
                    query = query + tablefields + values;
                    MessageBox.Show(query);
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Succesfully inserted");
                }
                
            }
            else
            {
                MessageBox.Show("Connections is not in open state");
            }

            con.Close();
            refreshDataForCompaniesTable();
        }

        private void company_EditBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(companyIdTxtBox.Text))
            {
                MessageBox.Show("Field Id cannot be empty. Please select record you want update");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to Edit this record ?", "Edit Record  with Id: " + companyIdTxtBox.Text, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
                    {

                        // course_id,course_name,course_description,course_catagorie,course_type

                        string query = "UPDATE " + DATABASE_PROJECT_PREFIX + "." + TABLE_COMPANY + " SET ";

                        query += "company_name= '" + companyNameTxtBox.Text + "' , ";
                        query += "industry= '" + companyIndustryTxtBox.Text + "' , ";
                        query += " WHERE company_id= '" + companyIdTxtBox.Text + "'";

                        SqlCommand cmd = new SqlCommand(query, con);
                        MessageBox.Show("QUERY: " + query);
                        cmd.ExecuteNonQuery();
                        coursesTab_courseDataGrid.Refresh();
                        MessageBox.Show("Record Succesfully inserted");
                        refreshDataForCoursesTable();

                    }
                    con.Close();
                }
            }
        }

        private void company_DeleteBtn_Click(object sender, EventArgs e)
        {



            clearCompanyForm();
        }

        private void company_ClearBtn_Click(object sender, EventArgs e)
        {
            clearCompanyForm();
        }

        private void companiesTab_companyDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = coursesTab_courseDataGrid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = coursesTab_courseDataGrid.Rows[selectedrowindex];
            string selectedRecord_Id = Convert.ToString(selectedRow.Cells["companyidDataGridViewTextBoxColumn"].Value);
            string selectedRecord_Name = Convert.ToString(selectedRow.Cells["companynameDataGridViewTextBoxColumn"].Value);
            string selectedRecord_Industry = Convert.ToString(selectedRow.Cells["industryDataGridViewTextBoxColumn"].Value);

            companyIndustryTxtBox.Text = selectedRecord_Industry;
            companyNameTxtBox.Text = selectedRecord_Name;
            companyIdTxtBox.Text = selectedRecord_Id;
        }



        // COURSES TAB
        private void tab_coures_FormLoad(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'p1g8DataSet.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.p1g8DataSet.Company);
            // TODO: This line of code loads data into the 'p1g8DataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.p1g8DataSet.Course);
            // TODO: This line of code loads data into the 'p1g8DataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.p1g8DataSet.Course);

        }

        private void onAddCourseBtn(object sender, EventArgs e)
        {
            bool canRun = true;
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                if (!String.IsNullOrEmpty(courseIdTxtBox.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("Id field is populated, thats mean maybe you want to update it instead of Adding. Are you sure you want add this record ?", "Add Record", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        canRun = true;
                    }
                    else
                    {
                        canRun = false;
                    }
                }

                if (canRun)
                {
                    string query = "INSERT INTO " + DATABASE_PROJECT_PREFIX + "." + TABLE_COURSE;
                    string tablefields = "(course_id,course_name,course_description,course_catagorie,course_type)";
                    string values = "values(";
                    values = values + addValue((rowsSize + 1).ToString()) + ",";
                    values = values + addValue(courseNameTxtBox.Text) + ",";
                    values = values + addValue(courseDescriptionTxtBox.Text) + ",";
                    values = values + addValue(CourseCategorieTxtBox.Text) + ",";
                    values = values + addValue(courseTypeTxtBox.Text);
                    values = values + ")";
                    query = query + tablefields + values;
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    coursesTab_courseDataGrid.Refresh();

                    MessageBox.Show("Record Succesfully inserted");

                }
            }
            else
            {
                MessageBox.Show("Connections is not in open state");
            }

            con.Close();
            refreshDataForCoursesTable();
        }

        private void onEditCourseBtn(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(courseIdTxtBox.Text))
            {
                MessageBox.Show("Field Id cannot be empty. Please select record you want update");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to Edit this record ?", "Edit Record  with Id: " + courseIdTxtBox.Text, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
                    {

                        // course_id,course_name,course_description,course_catagorie,course_type

                        string query = "UPDATE " + DATABASE_PROJECT_PREFIX + "." + TABLE_COURSE + " SET ";

                        query += "course_name= '" + courseNameTxtBox.Text + "' , ";
                        query += "course_description= '" + courseDescriptionTxtBox.Text + "' , ";
                        query += "course_catagorie= '" + CourseCategorieTxtBox.Text + "' , ";
                        query += "course_type= '" + courseTypeTxtBox.Text + "' ";
                        query += " WHERE course_id= '" + courseIdTxtBox.Text + "'";

                        SqlCommand cmd = new SqlCommand(query, con);
                        MessageBox.Show("QUERY: " + query);
                        cmd.ExecuteNonQuery();
                        coursesTab_courseDataGrid.Refresh();
                        MessageBox.Show("Record Succesfully inserted");
                        refreshDataForCoursesTable();

                    }
                    con.Close();
                }
            }

        }
        private void onDeleteCourseBtn(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(courseIdTxtBox.Text))
            {
                MessageBox.Show("Field Id cannot be empty. Please select record you want delete");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want delete record with Id: ", "Delete Record with id: " + courseIdTxtBox.Text, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string query = "DELETE FROM " + DATABASE_PROJECT_PREFIX + "." + TABLE_COURSE;
                        query += " WHERE course_id= '" + courseIdTxtBox.Text + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        coursesTab_courseDataGrid.Refresh();
                        MessageBox.Show("Record Succesfully deleted");
                        refreshDataForCoursesTable();
                        clearCourseForm();
                    }
                    con.Close();
                }
            }
        }

        private void onClearCourseBtn(object sender, EventArgs e)
        {
            clearCourseForm();
        }

        private void coursesTab_courseDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = coursesTab_courseDataGrid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = coursesTab_courseDataGrid.Rows[selectedrowindex];
            string selectedRecord_Id = Convert.ToString(selectedRow.Cells["courseidDataGridViewTextBoxColumn"].Value);
            string selectedRecord_Name = Convert.ToString(selectedRow.Cells["coursenameDataGridViewTextBoxColumn"].Value);
            string selectedRecord_Description = Convert.ToString(selectedRow.Cells["coursedescriptionDataGridViewTextBoxColumn"].Value);
            string selectedRecord_Category = Convert.ToString(selectedRow.Cells["coursecatagorieDataGridViewTextBoxColumn"].Value);
            string selectedRecord_Type = Convert.ToString(selectedRow.Cells["coursetypeDataGridViewTextBoxColumn"].Value);

            courseDescriptionTxtBox.Text = selectedRecord_Description;
            courseTypeTxtBox.Text = selectedRecord_Type;
            courseNameTxtBox.Text = selectedRecord_Name;
            CourseCategorieTxtBox.Text = selectedRecord_Category;
            courseIdTxtBox.Text = selectedRecord_Id;
        }

        private string addValue(string value)
        {
            return "'" + value + "'";
        }

        private void clearCourseForm()
        {
            courseDescriptionTxtBox.Text = "";
            courseTypeTxtBox.Text = "";
            courseNameTxtBox.Text = "";
            CourseCategorieTxtBox.Text = "";
            courseIdTxtBox.Text = "";
        }

        private void clearCompanyForm()
        {
            companyIdTxtBox.Text = "";
            companyNameTxtBox.Text = "";
            companyIndustryTxtBox.Text = "";
        }

        private void refreshDataForCoursesTable()
        {
            DataTable dataTable = new DataTable();
            string sqlSelectAll = "SELECT * FROM " + DATABASE_PROJECT_PREFIX + "." + TABLE_COURSE;

            SqlCommand cmd = new SqlCommand(sqlSelectAll, con);
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();

            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);
            con.Close();
            da.Dispose();
            coursesTab_courseDataGrid.DataSource = dataTable;

            this.rowsSize = dataTable.Rows.Count;
        }


        private void refreshDataForCompaniesTable()
        {
            DataTable dataTable = new DataTable();
            string sqlSelectAll = "SELECT * FROM " + DATABASE_PROJECT_PREFIX + "." + TABLE_COMPANY;

            SqlCommand cmd = new SqlCommand(sqlSelectAll, con);
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();

            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);
            con.Close();
            da.Dispose();
            companiesTab_companyDataGrid.DataSource = dataTable;
            this.rowsSize = dataTable.Rows.Count;
        }

    }
}