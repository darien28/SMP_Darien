﻿using System;
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
    public partial class FFRM_USERS_ADD : Form
    {
        //init
        DB_SMPEntities db=new DB_SMPEntities();
        TB_Users tb_users = new TB_Users();
        BL.Methods methods = new BL.Methods();
     //   PL.FRM_SUPP frm_supp = new FRM_SUPP();
       
        public int id;
        public FFRM_USERS_ADD()
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
                dialog.lb_titlepage.Text = "usersname required";
                dialog.Show();
            }
            else
            {
                //check if add or edit
                if (id == 0)
                {
                    //add
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);

                    tb_users.User_Name = edt_name.Text;
                    tb_users.User_pass = edt_pass.Text;
                    tb_users.User_Roll = edt_roll.Text;
                   db.TB_Users.Add(tb_users);
                    db.SaveChanges();
                    toast.txt_caption.Text = "ADDED USERS ";
                    toast.Show();
                  //  db = new DB_SMPEntities();
                   // frm_supp.dataGridView1.DataSource = db.TB_CAT.ToList();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
