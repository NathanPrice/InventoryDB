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

namespace InventoryDB
{
    public partial class frmMain : Form
    {
        SqlConnection con = new SqlConnection("Data Source=PC15\\SQLEXPRESS;Initial Catalog=Inventory;Persist Security Info=True;User ID=Nate;Password=password2");

        public frmMain()
        {
            InitializeComponent();
        }

        private void inventoryTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventoryTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryDataSet);

        }

        private void inventoryTableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.inventoryTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryDataSet);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet.InventoryTable' table. You can move, or remove it, as needed.
            this.inventoryTableTableAdapter.Fill(this.inventoryDataSet.InventoryTable);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
