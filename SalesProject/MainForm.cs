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
    public partial class MainForm : Form
    {
        List<Store> storeList;
        List<Product> productList;

        string queryDGV1 = "exec Proc_InfoSalesAVG @storeCodeList, @productCodeList, @date1, @date2";
        string queryDGV2 = "exec Proc_InfoProductSalesAVG @storeCodeList, @productCodeList, @date1, @date2";

        public MainForm()
        {
            InitializeComponent();
            DataBaseCmd.Connect();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBaseCmd.CloseConnection();
        }

        private void StoreLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using(var storeForm = new StoresForm())
            {
                if(storeForm.ShowDialog() == DialogResult.OK)
                {
                    storeList = StoresForm.storesResultList;

                    storeRichTextBox.Visible = true;
                    storeRichTextBox.Text = "";
                    foreach (var store in storeList)
                    {
                        storeRichTextBox.Text += store.StoreName + "\n";
                    }
                }
                else
                {
                    if(StoresForm.storesResultList.Count==0)
                    {
                        storeRichTextBox.Visible = false;
                        storeRichTextBox.Text = "";
                    }
                }
            }
        }

        private void ProductLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var productForm = new ProductsForm())
            {
                if (productForm.ShowDialog() == DialogResult.OK)
                {
                    productList = ProductsForm.productResultList;

                    productRichTextBox.Visible = true;
                    productRichTextBox.Text = "";
                    foreach (var store in ProductsForm.productResultList)
                    {
                        productRichTextBox.Text += store.ProductCode + "\n";
                    }
                }
                else
                {
                    if (ProductsForm.productResultList.Count == 0)
                    {
                        productRichTextBox.Visible = false;
                        productRichTextBox.Text = "";
                    }
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (storeList is null || productList is null || storeList.Count == 0 || productList.Count == 0)
            {
                MessageBox.Show("Выберите магазины и продукты для формирования отчета","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime dateTime1 = monthCalendar1.SelectionStart;
            DateTime dateTime2 = monthCalendar1.SelectionEnd;

            List<int> storeCodeList = new List<int>();
            foreach(var x in storeList)
            {
                storeCodeList.Add(x.StoreCode);
            }

            List<string> productCodeList = new List<string>();
            foreach (var x in productList)
            {
                productCodeList.Add(x.ProductCode);
            }

            var dtStoreCode = Operation.ConvertToDataTable(storeCodeList, typeof(int));
            var dtProductCode = Operation.ConvertToDataTable(productCodeList, typeof(string));

            DataTable dt1 = await DataBaseCmd.ExecuteQuery(queryDGV1, dtStoreCode, dtProductCode, dateTime1, dateTime2);
            infoDataGridView.DataSource = dt1;

            DataTable dt2 = await DataBaseCmd.ExecuteQuery(queryDGV2, dtStoreCode, dtProductCode, dateTime1, dateTime2);
            infoDataGridView2.DataSource = dt2;
        }

        
    }
}
