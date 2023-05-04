
namespace SMP.PL
{
    partial class FFRM_PUR_ADD
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
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edt_tbuy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edt_sell = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edt_qt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edt_buy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_type = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.lb_titlepage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_add.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(554, 488);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(231, 49);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add \r\n";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.edt_tbuy);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.edt_sell);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.edt_qt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.edt_buy);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.edt_type);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.edt_name);
            this.groupBox1.Controls.Add(this.lb_titlepage);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 404);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "informatiom";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // edt_tbuy
            // 
            this.edt_tbuy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_tbuy.Location = new System.Drawing.Point(213, 272);
            this.edt_tbuy.Name = "edt_tbuy";
            this.edt_tbuy.Size = new System.Drawing.Size(232, 32);
            this.edt_tbuy.TabIndex = 22;
            this.edt_tbuy.Text = "0";
            this.edt_tbuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_tbuy.TextChanged += new System.EventHandler(this.edt_tbuy_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(21, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "total purchase price";
            // 
            // edt_sell
            // 
            this.edt_sell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_sell.Location = new System.Drawing.Point(213, 187);
            this.edt_sell.Name = "edt_sell";
            this.edt_sell.Size = new System.Drawing.Size(232, 32);
            this.edt_sell.TabIndex = 20;
            this.edt_sell.Text = "0";
            this.edt_sell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_sell.TextChanged += new System.EventHandler(this.edt_sell_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(28, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "sale price";
            // 
            // edt_qt
            // 
            this.edt_qt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_qt.Location = new System.Drawing.Point(213, 225);
            this.edt_qt.Name = "edt_qt";
            this.edt_qt.Size = new System.Drawing.Size(232, 32);
            this.edt_qt.TabIndex = 18;
            this.edt_qt.Text = "0";
            this.edt_qt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_qt.TextChanged += new System.EventHandler(this.edt_qt_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(28, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Quantity";
            // 
            // edt_buy
            // 
            this.edt_buy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_buy.Location = new System.Drawing.Point(213, 146);
            this.edt_buy.Name = "edt_buy";
            this.edt_buy.Size = new System.Drawing.Size(232, 32);
            this.edt_buy.TabIndex = 16;
            this.edt_buy.Text = "0";
            this.edt_buy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_buy.TextChanged += new System.EventHandler(this.edt_buy_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(28, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "fierce price";
            // 
            // edt_type
            // 
            this.edt_type.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_type.Location = new System.Drawing.Point(213, 103);
            this.edt_type.Name = "edt_type";
            this.edt_type.Size = new System.Drawing.Size(232, 32);
            this.edt_type.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(28, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Type";
            // 
            // edt_name
            // 
            this.edt_name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_name.Location = new System.Drawing.Point(213, 59);
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(232, 32);
            this.edt_name.TabIndex = 12;
            // 
            // lb_titlepage
            // 
            this.lb_titlepage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_titlepage.AutoSize = true;
            this.lb_titlepage.BackColor = System.Drawing.Color.Transparent;
            this.lb_titlepage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titlepage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb_titlepage.Location = new System.Drawing.Point(28, 59);
            this.lb_titlepage.Name = "lb_titlepage";
            this.lb_titlepage.Size = new System.Drawing.Size(74, 24);
            this.lb_titlepage.TabIndex = 10;
            this.lb_titlepage.Text = " Name ";
            // 
            // FFRM_PUR_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(817, 575);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FFRM_PUR_ADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFRM_CAT_ADD";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FFRM_CAT_ADD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_titlepage;
        private System.Windows.Forms.TextBox edt_tbuy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edt_sell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edt_qt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edt_buy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edt_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edt_name;
    }
}