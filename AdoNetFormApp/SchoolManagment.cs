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

namespace AdoNetFormApp
{
    public partial class SchoolManagment : Form
    {
        static string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\myuser\Desktop\C# lesson works\Ado.net\AdoNetFormApp\AdoNetFormApp\Data\ProductDB.mdf';Integrated Security=True";
        SqlConnection connection = new SqlConnection(_connectionString);
        public SchoolManagment()
        {
            InitializeComponent();

        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            connection.Open();
            var teacherName = txtTeacherName.Text;
            var insertQuery = "insert into teachers values('" + teacherName + "')";
            var command = new SqlCommand(insertQuery, connection);
            command.ExecuteNonQuery();
            AddTeachersToCmb();
            connection.Close();
            MessageBox.Show("Teacher data added!");
        }
        private void AddTeachersToCmb()
        {
            cmbTeacher.Items.Clear();
            var selectQuery = "Select * from Teachers";
            var da = new SqlDataAdapter(selectQuery, connection);
            var ds = new DataSet();
            da.Fill(ds);
            foreach (DataRow teacher in ds.Tables[0].Rows)
            {
                cmbTeacher.Items.Add(teacher["name"]);
            }
        }
       
        private void SchoolManagment_Load(object sender, EventArgs e)
        {
            connection.Open();
            AddTeachersToCmb();
            connection.Close();
        }

        private void btnShowTeacher_Click(object sender, EventArgs e)
        {
            connection.Open();
            var selectQuery = "Select * from Teachers";
            var da = new SqlDataAdapter(selectQuery, connection);
            var ds = new DataSet();
            da.Fill(ds);
            dgwTeachers.DataSource = ds.Tables[0];
            connection.Close();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            connection.Open();
            var className = txtClassName.Text;
            var studentCount = Convert.ToInt32(txtStudCount.Text);
            var teacherName = txtTeacherName.Text;
            var insertQuery = "insert into classes values((select id from teachers where name ='"+teacherName+"'),'" + className + "','"+studentCount+"')";
            var command = new SqlCommand(insertQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Class data added!");
        }

        private void btnShowClass_Click(object sender, EventArgs e)
        {
            connection.Open();
            var selectQuery = "Select * from classes";
            var da = new SqlDataAdapter(selectQuery, connection);
            var ds = new DataSet();
            da.Fill(ds);
            dgwClasses.DataSource = ds.Tables[0];
            connection.Close();
        }
    }
}
