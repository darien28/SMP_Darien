
namespace SMP.PL
{
    partial class FFRM_USERS_ADD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFRM_USERS_ADD));
            this.lb_titlepage = new System.Windows.Forms.Label();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.pic_cover = new System.Windows.Forms.PictureBox();
            this.edt_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_roll = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_titlepage
            // 
            this.lb_titlepage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_titlepage.AutoSize = true;
            this.lb_titlepage.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titlepage.ForeColor = System.Drawing.Color.DimGray;
            this.lb_titlepage.Location = new System.Drawing.Point(156, 200);
            this.lb_titlepage.Name = "lb_titlepage";
            this.lb_titlepage.Size = new System.Drawing.Size(177, 40);
            this.lb_titlepage.TabIndex = 10;
            this.lb_titlepage.Text = "User Name";
            this.lb_titlepage.Click += new System.EventHandler(this.lb_titlepage_Click);
            // 
            // edt_name
            // 
            this.edt_name.Font = new System.Drawing.Font("Tahoma", 20F);
            this.edt_name.Location = new System.Drawing.Point(339, 197);
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(221, 48);
            this.edt_name.TabIndex = 11;
            this.edt_name.TextChanged += new System.EventHandler(this.edt_name_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_add.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(12, 474);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(707, 44);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add \r\n";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.button2_Click);
            // 
            // pic_cover
            // 
            this.pic_cover.BackColor = System.Drawing.Color.White;
            this.pic_cover.Image = ((System.Drawing.Image)(resources.GetObject("pic_cover.Image")));
            this.pic_cover.Location = new System.Drawing.Point(213, 32);
            this.pic_cover.Name = "pic_cover";
            this.pic_cover.Size = new System.Drawing.Size(301, 147);
            this.pic_cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_cover.TabIndex = 14;
            this.pic_cover.TabStop = false;
            // 
            // edt_pass
            // 
            this.edt_pass.Font = new System.Drawing.Font("Tahoma", 20F);
            this.edt_pass.Location = new System.Drawing.Point(339, 254);
            this.edt_pass.Name = "edt_pass";
            this.edt_pass.Size = new System.Drawing.Size(221, 48);
            this.edt_pass.TabIndex = 16;
            this.edt_pass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(156, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "Passowrd";
            // 
            // edt_roll
            // 
            this.edt_roll.Font = new System.Drawing.Font("Tahoma", 16F);
            this.edt_roll.FormattingEnabled = true;
            this.edt_roll.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.edt_roll.Location = new System.Drawing.Point(339, 308);
            this.edt_roll.Name = "edt_roll";
            this.edt_roll.Size = new System.Drawing.Size(221, 41);
            this.edt_roll.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(156, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 40);
            this.label2.TabIndex = 18;
            this.label2.Text = "validity";
            // 
            // FFRM_USERS_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(762, 544);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edt_roll);
            this.Controls.Add(this.edt_pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_cover);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.edt_name);
            this.Controls.Add(this.lb_titlepage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FFRM_USERS_ADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFRM_CAT_ADD";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FFRM_CAT_ADD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_titlepage;
        private System.Windows.Forms.PictureBox pic_cover;
        public System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox edt_name;
        public System.Windows.Forms.TextBox edt_pass;
        public System.Windows.Forms.ComboBox edt_roll;
    }
}