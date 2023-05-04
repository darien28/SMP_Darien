using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using SMP.EBL;

namespace SMP.PL
{
    public partial class FRM_CAT : Form
    {
        DB_SMPEntities db = new DB_SMPEntities();
        TB_CAT tb_cat = new TB_CAT();
        BL.Methods methods = new BL.Methods();
        int id;
        public FRM_CAT()
        {
            InitializeComponent();
            SMP.DB_SMPEntities dbcontext = new SMP.DB_SMPEntities();
            dbcontext.TB_CAT.LoadAsync().ContinueWith(loadTask =>
            {
                dataGridView1.DataSource = dbcontext.TB_CAT.Local.ToBindingList();
            });
        }

        private void FRM_CAT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SMPDataSet.TB_CAT' table. You can move, or remove it, as needed.
            this.tB_CATTableAdapter.Fill(this.dB_SMPDataSet.TB_CAT);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // added 
        private void btn_add_Click(object sender, EventArgs e)
        {
            PL.FFRM_CAT_ADD frm_add = new FFRM_CAT_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "Add";
            frm_add.Show();
            
        }
        // update 
        private void button4_Click(object sender, EventArgs e)
        {
            Update_data();
        }
        //delet
        private void button2_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();

            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            object cellValue = dataGridView1.Rows[rowIndex].Cells["iDDataGridViewTextBoxColumn"].Value;
            var result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (int.TryParse(cellValue.ToString(), out id))
                {
                    tb_cat = db.TB_CAT.FirstOrDefault(x => x.ID == id);
                    if (tb_cat != null)
                    {
                        db.TB_CAT.Remove(tb_cat);
                        db.SaveChanges();
                        Update_data();
                    }
                }
            }
        }


        private void Update_data()
        {
            throw new NotImplementedException();
            db = new DB_SMPEntities();
            dataGridView1.DataSource = db.TB_CAT.ToList();
        }

      
    }
}
