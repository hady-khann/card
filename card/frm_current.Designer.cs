namespace card
{
    partial class frm_currentexam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_currentexam));
            this.conm_frm_reg = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.لیستکلاعضاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_memberlist = new System.Windows.Forms.Button();
            this.btn_printallcard = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_baygani = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bayganifilename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listfilename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.foundedrecords = new System.Windows.Forms.Label();
            this.conm_frm_reg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // conm_frm_reg
            // 
            this.conm_frm_reg.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.conm_frm_reg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.لیستکلاعضاToolStripMenuItem,
            this.toolStripSeparator4,
            this.خروجToolStripMenuItem});
            this.conm_frm_reg.Name = "conm_frm_reg";
            this.conm_frm_reg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.conm_frm_reg.Size = new System.Drawing.Size(174, 58);
            // 
            // لیستکلاعضاToolStripMenuItem
            // 
            this.لیستکلاعضاToolStripMenuItem.Name = "لیستکلاعضاToolStripMenuItem";
            this.لیستکلاعضاToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.لیستکلاعضاToolStripMenuItem.Text = "لیست کل اعضا";
            this.لیستکلاعضاToolStripMenuItem.Click += new System.EventHandler(this.لیستکلاعضاToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(170, 6);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(204, 386);
            this.btn_print.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(141, 45);
            this.btn_print.TabIndex = 37;
            this.btn_print.Text = "پرینت تکی";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_memberlist
            // 
            this.btn_memberlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_memberlist.Location = new System.Drawing.Point(1078, 440);
            this.btn_memberlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_memberlist.Name = "btn_memberlist";
            this.btn_memberlist.Size = new System.Drawing.Size(141, 46);
            this.btn_memberlist.TabIndex = 36;
            this.btn_memberlist.Text = "لیست اعضا";
            this.btn_memberlist.UseVisualStyleBackColor = true;
            this.btn_memberlist.Click += new System.EventHandler(this.btn_memberlist_Click);
            // 
            // btn_printallcard
            // 
            this.btn_printallcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printallcard.Location = new System.Drawing.Point(204, 440);
            this.btn_printallcard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_printallcard.Name = "btn_printallcard";
            this.btn_printallcard.Size = new System.Drawing.Size(141, 46);
            this.btn_printallcard.TabIndex = 35;
            this.btn_printallcard.Text = "پرینت همه کارت ها";
            this.btn_printallcard.UseVisualStyleBackColor = true;
            this.btn_printallcard.Click += new System.EventHandler(this.btn_printallcard_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Location = new System.Drawing.Point(6, 385);
            this.btn_del.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(141, 46);
            this.btn_del.TabIndex = 34;
            this.btn_del.Text = "حذف ";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_baygani
            // 
            this.btn_baygani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baygani.Location = new System.Drawing.Point(872, 440);
            this.btn_baygani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_baygani.Name = "btn_baygani";
            this.btn_baygani.Size = new System.Drawing.Size(141, 46);
            this.btn_baygani.TabIndex = 42;
            this.btn_baygani.Text = "بایگانی";
            this.btn_baygani.UseVisualStyleBackColor = true;
            this.btn_baygani.Click += new System.EventHandler(this.btn_baygani_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(635, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "جستوجو براساس نام";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(646, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 44;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(474, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "جستوجو بر اساس سمت";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "مراقب ",
            "رابط",
            "امانات",
            "خدمات عمومی",
            "حفاظت فیزیکی",
            "راهنما",
            "سرپرست سالن",
            "مسئول مخزن",
            "تطبیق عکس",
            "سالن اجتماعات",
            "تاسیسات",
            "سمعی بصری",
            "نماینده تمام الاختیار",
            "دستیار نماینده تام الاختیار",
            "مدیر حوزه ",
            "حراست"});
            this.comboBox1.Location = new System.Drawing.Point(464, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(162, 24);
            this.comboBox1.TabIndex = 46;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 58);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1232, 323);
            this.dgv.TabIndex = 29;
            this.dgv.Click += new System.EventHandler(this.dgv_Click);
            // 
            // bayganifilename
            // 
            this.bayganifilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bayganifilename.Location = new System.Drawing.Point(872, 523);
            this.bayganifilename.Name = "bayganifilename";
            this.bayganifilename.Size = new System.Drawing.Size(141, 27);
            this.bayganifilename.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(894, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "نام فایل بایگانی";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(872, 385);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 46);
            this.button1.TabIndex = 64;
            this.button1.Text = "مسیر فایل بایگانی";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listfilename
            // 
            this.listfilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listfilename.Location = new System.Drawing.Point(1078, 523);
            this.listfilename.Name = "listfilename";
            this.listfilename.Size = new System.Drawing.Size(141, 27);
            this.listfilename.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1094, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "نام فایل لیست";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1078, 385);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 46);
            this.button2.TabIndex = 67;
            this.button2.Text = "مسیر فایل لیست";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(6, 440);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 45);
            this.button3.TabIndex = 68;
            this.button3.Text = "مرتب سازی ردیف ها";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // foundedrecords
            // 
            this.foundedrecords.AutoSize = true;
            this.foundedrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foundedrecords.Location = new System.Drawing.Point(280, 26);
            this.foundedrecords.Name = "foundedrecords";
            this.foundedrecords.Size = new System.Drawing.Size(145, 20);
            this.foundedrecords.TabIndex = 69;
            this.foundedrecords.Text = "تعداد عناصر یافت شده :";
            // 
            // frm_currentexam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1244, 603);
            this.ContextMenuStrip = this.conm_frm_reg;
            this.Controls.Add(this.foundedrecords);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listfilename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bayganifilename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_baygani);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_memberlist);
            this.Controls.Add(this.btn_printallcard);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_currentexam";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم ثبت نام";
            this.Load += new System.EventHandler(this.frm_currentexam_Load);
            this.conm_frm_reg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip conm_frm_reg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_memberlist;
        private System.Windows.Forms.Button btn_printallcard;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_baygani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem لیستکلاعضاToolStripMenuItem;
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox bayganifilename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox listfilename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label foundedrecords;
    }
}