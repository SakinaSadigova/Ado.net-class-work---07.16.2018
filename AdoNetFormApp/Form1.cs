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
    public partial class Form1 : Form
    {
        static string _connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\myuser\Desktop\C# lesson works\Ado.net\AdoNetFormApp\AdoNetFormApp\Data\ProductDB.mdf';Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(_connection);

        public Form1()
        {
            InitializeComponent();
            var selectQuery = "Select * from category";
            var da = new SqlDataAdapter(selectQuery, sqlConnection);
            var ds = new DataSet();
            da.Fill(ds);
            foreach (DataRow category in ds.Tables[0].Rows)
            {
                cmbCategory.Items.Add(category["CategoryName"]);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ToConnect()
        {
            sqlConnection.Open();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var categoryName = txtCatName.Text;
            sqlConnection.Open();
            var addQuery = "insert into category values('"+categoryName+"')";
            SqlCommand SqlCommand = new SqlCommand(addQuery,sqlConnection);
            SqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            var selectQuery = "Select * from category";
            var da = new SqlDataAdapter(selectQuery, sqlConnection);
            var ds = new DataSet();
            da.Fill(ds);
            cmbCategory.Items.Clear();
            foreach (DataRow category in ds.Tables[0].Rows)
            {
                cmbCategory.Items.Add(category["CategoryName"]);
            }

        }

        private void btnShowCat_Click(object sender, EventArgs e)
        {
            var selectQuery = "Select * from category";
            var da = new SqlDataAdapter(selectQuery,sqlConnection);
            var ds = new DataSet();
            da.Fill(ds);
            txtCategories.Clear();

            foreach (DataRow category in ds.Tables[0].Rows)
            {
                txtCategories.Text += category["Id"] + "." + category["CategoryName"] + "\r\n";
            }
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            var _productName = txtProdName.Text;
            var _productPrice = Convert.ToDecimal(txtProdPrice.Text);
            var _categoryName = cmbCategory.SelectedItem;
            var insertQuery = "insert into product values('" + _productName + "','" + _productPrice + "',(select id from category where categoryname='" + _categoryName+"'))";
            var command = new SqlCommand(insertQuery, sqlConnection);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Test");
        }

        private void btnShowProd_Click(object sender, EventArgs e)
        {
            var selectQuery = "Select * from product";
            var da = new SqlDataAdapter(selectQuery, sqlConnection);
            var ds = new DataSet();
            da.Fill(ds);
            txtCategories.Clear();

            foreach (DataRow product in ds.Tables[0].Rows)
            {
                txtProducts.Text += product["Id"] + "." + product["ProductName"] + "\r\n";
            }
        }
    }
}
