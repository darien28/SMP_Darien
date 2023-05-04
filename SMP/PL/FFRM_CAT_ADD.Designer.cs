
namespace SMP.PL
{
    partial class FFRM_CAT_ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFRM_CAT_ADD));
            this.btn_close = new System.Windows.Forms.Button();
            this.lb_titlepage = new System.Windows.Forms.Label();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.pic_cover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_close.Location = new System.Drawing.Point(729, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(56, 27);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "X";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lb_titlepage
            // 
            this.lb_titlepage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_titlepage.AutoSize = true;
            this.lb_titlepage.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titlepage.ForeColor = System.Drawing.Color.DimGray;
            this.lb_titlepage.Location = new System.Drawing.Point(247, 49);
            this.lb_titlepage.Name = "lb_titlepage";
            this.lb_titlepage.Size = new System.Drawing.Size(240, 40);
            this.lb_titlepage.TabIndex = 10;
            this.lb_titlepage.Text = "Category Name";
            this.lb_titlepage.Click += new System.EventHandler(this.lb_titlepage_Click);
            // 
            // edt_name
            // 
            this.edt_name.Font = new System.Drawing.Font("Tahoma", 20F);
            this.edt_name.Location = new System.Drawing.Point(163, 104);
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(443, 48);
            this.edt_name.TabIndex = 11;
            this.edt_name.TextChanged += new System.EventHandler(this.edt_name_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_add.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(12, 482);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(121, 49);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add \r\n";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.button2_Click);
            // 
            // pic_cover
            // 
            this.pic_cover.Image = ((System.Drawing.Image)(resources.GetObject("pic_cover.Image")));
            this.pic_cover.Location = new System.Drawing.Point(163, 179);
            this.pic_cover.Name = "pic_cover";
            this.pic_cover.Size = new System.Drawing.Size(443, 253);
            this.pic_cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_cover.TabIndex = 14;
            this.pic_cover.TabStop = false;
            // 
            // FFRM_CAT_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 543);
            this.Controls.Add(this.pic_cover);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.edt_name);
            this.Controls.Add(this.lb_titlepage);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FFRM_CAT_ADD";
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

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lb_titlepage;
        private System.Windows.Forms.TextBox edt_name;
        private System.Windows.Forms.PictureBox pic_cover;
        public System.Windows.Forms.Button btn_add;
    }
}