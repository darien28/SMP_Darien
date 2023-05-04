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
using SMP;



namespace SMP.PL
{
    public partial class FFRM_PUR_ADD : Form
    {
        //init
        DB_SMPEntities db=new DB_SMPEntities();
        TB_supp tb_supp = new TB_supp();
        Tb_pur tb_Pur = new Tb_pur();

        BL.Methods methods = new BL.Methods();
        PL.FRM_SUPP frm_supp = new FRM_SUPP();
        double buy, sell, qt, tbuy, tsell, trev;
        public int id;
        public FFRM_PUR_ADD()
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
                dialog.lb_titlepage.Text = "Categor name required";
                dialog.Show();
            }
            else
            {
                //check if add or edit
                if (id == 0)
                {
                    //add
                    //pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_Pur.pur_name = edt_name.Text;
                    tb_Pur.pur_type = edt_type.Text;
                    tb_Pur.pur_Buy = Convert.ToDouble(edt_buy.Text);
                    tb_Pur.pur_sell = Convert.ToDouble(edt_sell.Text);
                    tb_Pur.pur_Qu= Convert.ToDouble(edt_qt.Text);
                    tb_Pur.pur_Tbuy = Convert.ToDouble(edt_tbuy.Text);
                    db.Tb_pur.Add(tb_Pur);
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

        private void edt_buy_TextChanged(object sender, EventArgs e)
        {
            pro_cat();
        }

        private void edt_sell_TextChanged(object sender, EventArgs e)
        {
            pro_cat();
        }

        private void edt_qt_TextChanged(object sender, EventArgs e)
        {
            pro_cat();
        }

        private void edt_tbuy_TextChanged(object sender, EventArgs e)
        {
            pro_cat();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FFRM_PUR_ADD_Activated(object sender, EventArgs e)
        {
         //   edt_name.dat = db.TB_CAT.Select(x => x.CAT_Name);
        }
        private void pro_cat()
        {
            sell = Convert.ToDouble(edt_sell.Text);
            buy = Convert.ToDouble(edt_buy.Text);
           qt= Convert.ToDouble(edt_qt.Text);
            tsell = sell * qt;
            tbuy = buy * qt;
            edt_tbuy.Text = tbuy.ToString();
            



        }
    }
}
