namespace card
{
    partial class frm_setting
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_setting));
            this.txt_org = new System.Windows.Forms.TextBox();
            this.txt_exname = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contm_frm_main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ثبتنامکارتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_register = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.cmbo_logo = new System.Windows.Forms.ComboBox();
            this.picb_image = new System.Windows.Forms.PictureBox();
            this.picb_logo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.contm_frm_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_org
            // 
            this.txt_org.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_org.Location = new System.Drawing.Point(192, 74);
            this.txt_org.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_org.Name = "txt_org";
            this.txt_org.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_org.Size = new System.Drawing.Size(260, 30);
            this.txt_org.TabIndex = 4;
            this.txt_org.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_exname
            // 
            this.txt_exname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_exname.Location = new System.Drawing.Point(192, 101);
            this.txt_exname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_exname.Name = "txt_exname";
            this.txt_exname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_exname.Size = new System.Drawing.Size(260, 30);
            this.txt_exname.TabIndex = 5;
            this.txt_exname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_year
            // 
            this.txt_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_year.Location = new System.Drawing.Point(192, 130);
            this.txt_year.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_year.Name = "txt_year";
            this.txt_year.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_year.Size = new System.Drawing.Size(260, 30);
            this.txt_year.TabIndex = 6;
            this.txt_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 18);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "جمهوری اسلامی ایران";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 50);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(191, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "وزارت علوم ، تحقیقات و فناوری";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.ContextMenuStrip = this.contm_frm_main;
            this.groupBox1.Controls.Add(this.btn_register);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_date);
            this.groupBox1.Controls.Add(this.cmbo_logo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.picb_image);
            this.groupBox1.Controls.Add(this.picb_logo);
            this.groupBox1.Controls.Add(this.txt_year);
            this.groupBox1.Controls.Add(this.txt_org);
            this.groupBox1.Controls.Add(this.txt_exname);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(653, 423);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // contm_frm_main
            // 
            this.contm_frm_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contm_frm_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ثبتنامکارتToolStripMenuItem});
            this.contm_frm_main.Name = "contm_frm_main";
            this.contm_frm_main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contm_frm_main.Size = new System.Drawing.Size(179, 34);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(175, 6);
            // 
            // ثبتنامکارتToolStripMenuItem
            // 
            this.ثبتنامکارتToolStripMenuItem.Name = "ثبتنامکارتToolStripMenuItem";
            this.ثبتنامکارتToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.ثبتنامکارتToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.ثبتنامکارتToolStripMenuItem.Text = "بازگشت";
            this.ثبتنامکارتToolStripMenuItem.Click += new System.EventHandler(this.ثبتنامکارتToolStripMenuItem_Click);
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(252, 201);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(104, 32);
            this.btn_register.TabIndex = 12;
            this.btn_register.Text = "ثبت";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(566, 207);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "تاریخ امتحان";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_date
            // 
            this.txt_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date.Location = new System.Drawing.Point(419, 201);
            this.txt_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_date.Name = "txt_date";
            this.txt_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_date.Size = new System.Drawing.Size(141, 30);
            this.txt_date.TabIndex = 10;
            this.txt_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbo_logo
            // 
            this.cmbo_logo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_logo.FormattingEnabled = true;
            this.cmbo_logo.Items.AddRange(new object[] {
            "سازمان سنجش آموزش کشور ",
            "شرکت تعاونی سازمان سنجش"});
            this.cmbo_logo.Location = new System.Drawing.Point(464, 169);
            this.cmbo_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbo_logo.Name = "cmbo_logo";
            this.cmbo_logo.Size = new System.Drawing.Size(183, 24);
            this.cmbo_logo.TabIndex = 9;
            this.cmbo_logo.SelectedIndexChanged += new System.EventHandler(this.cmbo_logo_SelectedIndexChanged);
            // 
            // picb_image
            // 
            this.picb_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picb_image.Location = new System.Drawing.Point(5, 21);
            this.picb_image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picb_image.Name = "picb_image";
            this.picb_image.Size = new System.Drawing.Size(114, 144);
            this.picb_image.TabIndex = 0;
            this.picb_image.TabStop = false;
            // 
            // picb_logo
            // 
            this.picb_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picb_logo.Location = new System.Drawing.Point(533, 21);
            this.picb_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picb_logo.Name = "picb_logo";
            this.picb_logo.Size = new System.Drawing.Size(114, 144);
            this.picb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_logo.TabIndex = 1;
            this.picb_logo.TabStop = false;
            // 
            // frm_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(677, 448);
            this.ContextMenuStrip = this.contm_frm_main;
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_setting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات";
            this.Load += new System.EventHandler(this.frm_setting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contm_frm_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picb_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picb_image;
        private System.Windows.Forms.PictureBox picb_logo;
        private System.Windows.Forms.TextBox txt_org;
        private System.Windows.Forms.TextBox txt_exname;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contm_frm_main;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ComboBox cmbo_logo;
        private System.Windows.Forms.ToolStripMenuItem ثبتنامکارتToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Button btn_register;
    }
}