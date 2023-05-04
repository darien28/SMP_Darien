using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMP.EBL;

namespace SMP.PL
{
    public partial class FFRM_CAT_ADD : Form
    {
        //init
        DB_SMPEntities db=new DB_SMPEntities();
        TB_CAT tb_cat = new TB_CAT();
        BL.Methods methods = new BL.Methods();
        PL.FRM_CAT frm_cat = new FRM_CAT();
       
        public int id;
        public FFRM_CAT_ADD()
        {
            InitializeComponent();
        }

        private void FFRM_CAT_ADD_Load(object sender, EventArgs e)
        {

        }

        private void lb_titlepage_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        // add or edit
        private void button2_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            //check if add or edit
            if (edt_name.Text == "")
            {
                dialog.Width = this.Width;
                dialog.lb_titlepage.Text = "Category name required";
                dialog.Show();
            }
            else
            {
                //check if add or edit
                if (id == 0)
                {
                    //add
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_cat.CAT_Name = edt_name.Text;
                    tb_cat.CAT_Cover = methods.convert_byte();
                    db.TB_CAT.Add(tb_cat);
                    db.SaveChanges();
                    toast.txt_caption.Text = "Added";
                    this.Close();
                    toast.Show();
                    db = new DB_SMPEntities();
                    frm_cat.dataGridView1.DataSource = db.TB_CAT.ToList();
                    this.Close();
                    

                }
                else
                {
                    //edit
                   

                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edt_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
