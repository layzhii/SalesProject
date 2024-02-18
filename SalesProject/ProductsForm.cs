using SalesProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesProject
{
    public partial class ProductsForm : Form
    {
        List<Product> productList;
        string query = "exec ProductSummary";

        public static List<Product> productResultList = new List<Product>();
        public ProductsForm()
        {
            InitializeComponent();
            GetProduct();
            SetCheckedListBox();

            productResultList.Clear();
        }

        private void GetProduct()
        {
            var dataTable = DataBaseCmd.ExecuteQuery(query);
            productList = new List<Product>();
            foreach (DataRow row in dataTable.Rows)
            {
                productList.Add(new Product(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString()));
            }
        }

        private void SetCheckedListBox()
        {
            checkedListBox1.DataSource = productList;
            checkedListBox1.DisplayMember = "productName";
            checkedListBox1.ValueMember = "productCode";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            foreach (Product product in checkedListBox1.CheckedItems)
            {
                productResultList.Add(product);
            }

            this.Close();
        }

        private void ProductsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (productResultList.Count > 0)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Cancel;
        }
    }
}
