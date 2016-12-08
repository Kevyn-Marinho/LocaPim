using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmtelalogin
{
    public partial class frmCD_Carro : Form
    {
        public frmCD_Carro()
        {
            InitializeComponent();
        }

        private void btnSalvarCarro_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("Deseja Salvar Carro?", "erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSairCadCarros_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tblCarroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblCarroBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.bANCODEDADOSDataSet);

        }

        private void tblCarroBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tblCarroBindingSource.EndEdit();
           // this.tableAdapterManager.UpdateAll(this.bANCODEDADOSDataSet);

        }

        private void frmCD_Carro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bANCODEDADOSDataSet.tblCarro' table. You can move, or remove it, as needed.
            //this.tblCarroTableAdapter.Fill(this.bANCODEDADOSDataSet.tblCarro);

        }

        private void iDCarroTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
