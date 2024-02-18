using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesProject.Classes;

namespace SalesProject
{
    public partial class StoresForm : Form
    {
        List<Store> storesList;
        string query = "exec StoreSummary";

        public static List<Store> storesResultList = new List<Store>();
        public StoresForm()
        {
            InitializeComponent();
            GetStores();
            SetCheckedListBox();

            storesResultList.Clear();
        }

        private void GetStores()
        {
            var dataTable = DataBaseCmd.ExecuteQuery(query);
            storesList = new List<Store>();
            foreach(DataRow row in dataTable.Rows)
            {
                storesList.Add(new Store(int.Parse(row[0].ToString()), row[1].ToString()));
            }
        }

        private void SetCheckedListBox()
        {
            checkedListBox1.DataSource = storesList;
            checkedListBox1.DisplayMember = "storeName";
            checkedListBox1.ValueMember = "storeCode";
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            foreach (Store store in  checkedListBox1.CheckedItems)
            {
                storesResultList.Add(store);
            }

            this.Close();
        }

        private void StoresForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (storesResultList.Count > 0)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Cancel;
        }
    }
}
