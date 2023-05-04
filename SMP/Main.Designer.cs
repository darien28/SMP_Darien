
namespace SMP
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pn_topbar = new System.Windows.Forms.Panel();
            this.lb_titlepage = new System.Windows.Forms.Label();
            this.byn_min = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.pn_navbar = new System.Windows.Forms.Panel();
            this.pn_titlenav = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_home_click = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.pn_cont = new System.Windows.Forms.Panel();
            this.pn_topbar.SuspendLayout();
            this.pn_navbar.SuspendLayout();
            this.pn_titlenav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_topbar
            // 
            this.pn_topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pn_topbar.Controls.Add(this.lb_titlepage);
            this.pn_topbar.Controls.Add(this.byn_min);
            this.pn_topbar.Controls.Add(this.btn_max);
            this.pn_topbar.Controls.Add(this.btn_close);
            this.pn_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_topbar.Location = new System.Drawing.Point(225, 0);
            this.pn_topbar.Name = "pn_topbar";
            this.pn_topbar.Size = new System.Drawing.Size(711, 45);
            this.pn_topbar.TabIndex = 0;
            this.pn_topbar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lb_titlepage
            // 
            this.lb_titlepage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_titlepage.AutoSize = true;
            this.lb_titlepage.ForeColor = System.Drawing.Color.Silver;
            this.lb_titlepage.Location = new System.Drawing.Point(290, 6);
            this.lb_titlepage.Name = "lb_titlepage";
            this.lb_titlepage.Size = new System.Drawing.Size(66, 33);
            this.lb_titlepage.TabIndex = 9;
            this.lb_titlepage.Text = "Main";
            // 
            // byn_min
            // 
            this.byn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.byn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.byn_min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.byn_min.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.byn_min.Location = new System.Drawing.Point(560, 6);
            this.byn_min.Name = "byn_min";
            this.byn_min.Size = new System.Drawing.Size(45, 42);
            this.byn_min.TabIndex = 8;
            this.byn_min.Text = "━";
            this.byn_min.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.byn_min.UseVisualStyleBackColor = false;
            this.byn_min.Click += new System.EventHandler(this.byn_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_max.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_max.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_max.Location = new System.Drawing.Point(611, 6);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(45, 42);
            this.btn_max.TabIndex = 6;
            this.btn_max.Text = "❒";
            this.btn_max.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_max.UseVisualStyleBackColor = false;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_close.Location = new System.Drawing.Point(662, 6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(45, 42);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "X";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pn_navbar
            // 
            this.pn_navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pn_navbar.Controls.Add(this.pn_titlenav);
            this.pn_navbar.Controls.Add(this.flowLayoutPanel1);
            this.pn_navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_navbar.ForeColor = System.Drawing.Color.Gray;
            this.pn_navbar.Location = new System.Drawing.Point(0, 0);
            this.pn_navbar.Name = "pn_navbar";
            this.pn_navbar.Size = new System.Drawing.Size(225, 617);
            this.pn_navbar.TabIndex = 1;
            this.pn_navbar.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_navbar_Paint);
            // 
            // pn_titlenav
            // 
            this.pn_titlenav.Controls.Add(this.pictureBox1);
            this.pn_titlenav.Controls.Add(this.label2);
            this.pn_titlenav.Controls.Add(this.label3);
            this.pn_titlenav.Location = new System.Drawing.Point(12, 3);
            this.pn_titlenav.Name = "pn_titlenav";
            this.pn_titlenav.Size = new System.Drawing.Size(198, 229);
            this.pn_titlenav.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(27, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Darien Saad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(52, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Adman";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_home_click);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Controls.Add(this.button9);
            this.flowLayoutPanel1.Controls.Add(this.btn_user);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 267);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(225, 232);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // btn_home_click
            // 
            this.btn_home_click.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_home_click.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home_click.ForeColor = System.Drawing.Color.Silver;
            this.btn_home_click.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_home_click.Location = new System.Drawing.Point(3, 3);
            this.btn_home_click.Name = "btn_home_click";
            this.btn_home_click.Size = new System.Drawing.Size(222, 33);
            this.btn_home_click.TabIndex = 9;
            this.btn_home_click.Text = "Main";
            this.btn_home_click.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_home_click.UseVisualStyleBackColor = false;
            this.btn_home_click.Click += new System.EventHandler(this.button6_Click);
            this.btn_home_click.Leave += new System.EventHandler(this.btn_home_click_Leave);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Silver;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.Location = new System.Drawing.Point(3, 42);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(222, 33);
            this.button7.TabIndex = 10;
            this.button7.Text = "Categories";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Silver;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.Location = new System.Drawing.Point(3, 81);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(222, 33);
            this.button8.TabIndex = 11;
            this.button8.Text = "Suppliers";
            this.button8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Silver;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.Location = new System.Drawing.Point(3, 120);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(222, 33);
            this.button9.TabIndex = 12;
            this.button9.Text = "Purchases";
            this.button9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btn_user
            // 
            this.btn_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_user.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user.ForeColor = System.Drawing.Color.Silver;
            this.btn_user.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_user.Location = new System.Drawing.Point(3, 159);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(222, 33);
            this.btn_user.TabIndex = 16;
            this.btn_user.Text = "Usres";
            this.btn_user.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_user.UseVisualStyleBackColor = false;
            this.btn_user.Click += new System.EventHandler(this.button13_Click);
            // 
            // pn_cont
            // 
            this.pn_cont.BackColor = System.Drawing.Color.White;
            this.pn_cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cont.Location = new System.Drawing.Point(225, 45);
            this.pn_cont.Name = "pn_cont";
            this.pn_cont.Size = new System.Drawing.Size(711, 572);
            this.pn_cont.TabIndex = 2;
            this.pn_cont.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_cont_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 617);
            this.Controls.Add(this.pn_cont);
            this.Controls.Add(this.pn_topbar);
            this.Controls.Add(this.pn_navbar);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            this.Text = "SMP";
            this.pn_topbar.ResumeLayout(false);
            this.pn_topbar.PerformLayout();
            this.pn_navbar.ResumeLayout(false);
            this.pn_titlenav.ResumeLayout(false);
            this.pn_titlenav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_topbar;
        private System.Windows.Forms.Panel pn_navbar;
        private System.Windows.Forms.Panel pn_cont;
        private System.Windows.Forms.Label lb_titlepage;
        private System.Windows.Forms.Button byn_min;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_home_click;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Panel pn_titlenav;
        public System.Windows.Forms.Button button7;
    }
}

