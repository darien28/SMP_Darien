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
    public partial class FRM_PUR : Form
    {
        DB_SMPEntities db = new DB_SMPEntities();
        TB_supp tb_supp = new TB_supp();
        PL.FRM_PUR frm_pur = new PL.FRM_PUR();
        Tb_pur tb_purr = new Tb_pur();

        BL.Methods methods = new BL.Methods();
        int id;
        public FRM_PUR()
        {
            InitializeComponent();
            SMP.DB_SMPEntities dbcontext = new SMP.DB_SMPEntities();
            dbcontext.TB_CAT.LoadAsync().ContinueWith(loadTask=>
            {
                dataGridView1.DataSource = dbcontext.TB_CAT.Local.ToBindingList();
            });
        }

        private void FRM_CAT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SMPDataSet3.Tb_pur' table. You can move, or remove it, as needed.
            this.tb_purTableAdapter.Fill(this.dB_SMPDataSet3.Tb_pur);
            // TODO: This line of code loads data into the 'dB_SMPDataSet1.TB_supp' table. You can move, or remove it, as needed.
            this.tB_suppTableAdapter.Fill(this.dB_SMPDataSet1.TB_supp);
            // TODO: This line of code loads data into the 'dB_SMPDataSet.TB_CAT' table. You can move, or remove it, as needed.
            this.tB_CATTableAdapter.Fill(this.dB_SMPDataSet.TB_CAT);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // added 
        private void btn_add_Click(object sender, EventArgs e)
        {
            PL.FFRM_PUR_ADD frm_add = new FFRM_PUR_ADD();
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
                    tb_purr = db.Tb_pur.Where(x => x.ID == id).FirstOrDefault();
                    if (tb_purr != null)
                    {
                        db.Tb_pur.Remove(tb_purr);
                        db.SaveChanges();
                        Update_data();
                    }
                }
            }
        }


        private void Update_data()
        {
            
            db = new DB_SMPEntities();
            dataGridView1.DataSource = db.Tb_pur.ToList();
        }

      
    }
}
