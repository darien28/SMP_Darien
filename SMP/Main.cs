using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMP
{
    public partial class Main : Form
    {
        // init form

        PL.FAM_HOME frm_home = new PL.FAM_HOME();
        PL.FRM_CAT frm_cat = new PL.FRM_CAT();
        PL.FRM_SUPP frm_supp = new PL.FRM_SUPP();
        PL.FRM_PUR frm_pur = new PL.FRM_PUR();
        PL.FRM_Users frm_users= new PL.FRM_Users();
        DB_SMPEntities db = new DB_SMPEntities();
        public Main()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_navbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_home.panel1_home);//هاي صفحه رئسيه غير اسم الي بيها مورين ومشترينووو

        }

        private void button9_Click(object sender, EventArgs e)
        {

            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_pur.pn_cat);
            db = new DB_SMPEntities();
            frm_pur.dataGridView1.DataSource = db.TB_CAT.ToList();
            lb_titlepage.Text = "PURCHESS";
        }
        //close app
        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }
        // min app
        private void byn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState==FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;

            }
        }
        // collaps
        private void btn_collapse_Click(object sender, EventArgs e)
        {
            if (pn_navbar.Width==250)
            {
                pn_navbar.Width = 50;
                pn_titlenav.Visible = false;
                pn_titlenav.Height = 200;

            }
            else
            {
                pn_navbar.Width = 250;
                pn_titlenav.Visible = true;
                pn_titlenav.Height = 200;

            }
        }

        private void pn_cont_Paint(object sender, PaintEventArgs e)
        {

        }
        //load home page
        private void btn_home_click_Leave(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_home.panel1_home);
        }
        // load cat
        private void button7_Click(object sender, EventArgs e)
        {

            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_cat.pn_cat);
            db = new DB_SMPEntities();
           frm_cat.dataGridView1.DataSource = db.TB_CAT.ToList();
            lb_titlepage.Text = "CATEGRIES";
        }
        //loag suppler
        private void button8_Click(object sender, EventArgs e)
        {

            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_supp.pn_cat);
            db = new DB_SMPEntities();
            frm_supp.dataGridView1.DataSource = db.TB_CAT.ToList();
            lb_titlepage.Text = "SUPPLIERS";
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
        //PAGR USERS
        private void button13_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_users.pn_cat);
            lb_titlepage.Text = " USERS ";
        }
    }
}
