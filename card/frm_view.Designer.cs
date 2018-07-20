namespace card
{
    partial class frm_view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_view));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_multiselect = new System.Windows.Forms.Button();
            this.conm_frm_reg = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ed = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbo_side = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_floor = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_startnum = new System.Windows.Forms.TextBox();
            this.txt_endnum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_volunteer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fieldother = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_fieldmain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblt3 = new System.Windows.Forms.Label();
            this.lblt5 = new System.Windows.Forms.Label();
            this.lblt4 = new System.Windows.Forms.Label();
            this.picb_logo = new System.Windows.Forms.PictureBox();
            this.lblt1 = new System.Windows.Forms.Label();
            this.lblt2 = new System.Windows.Forms.Label();
            this.picb_image = new System.Windows.Forms.PictureBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_finish = new System.Windows.Forms.Button();
            this.btn_dellist = new System.Windows.Forms.Button();
            this.btn_current = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.foundedrecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.conm_frm_reg.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 64);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1227, 256);
            this.dgv.TabIndex = 0;
            this.dgv.Click += new System.EventHandler(this.dgv_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Location = new System.Drawing.Point(9, 408);
            this.btn_del.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(113, 34);
            this.btn_del.TabIndex = 11;
            this.btn_del.Text = "حذف";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_multiselect
            // 
            this.btn_multiselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiselect.Location = new System.Drawing.Point(1045, 650);
            this.btn_multiselect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_multiselect.Name = "btn_multiselect";
            this.btn_multiselect.Size = new System.Drawing.Size(141, 34);
            this.btn_multiselect.TabIndex = 16;
            this.btn_multiselect.Text = "انتخاب چندگانه";
            this.btn_multiselect.UseVisualStyleBackColor = true;
            this.btn_multiselect.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // conm_frm_reg
            // 
            this.conm_frm_reg.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.conm_frm_reg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator3,
            this.toolStripMenuItem2,
            this.toolStripSeparator4,
            this.toolStripMenuItem3});
            this.conm_frm_reg.Name = "conm_frm_reg";
            this.conm_frm_reg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.conm_frm_reg.Size = new System.Drawing.Size(179, 88);
            this.conm_frm_reg.Opening += new System.ComponentModel.CancelEventHandler(this.conm_frm_reg_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 24);
            this.toolStripMenuItem1.Text = "تنظیمات";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(175, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(178, 24);
            this.toolStripMenuItem2.Text = "بازگشت";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.بازگشتToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(175, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(178, 24);
            this.toolStripMenuItem3.Text = "خروج";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // btn_ed
            // 
            this.btn_ed.Location = new System.Drawing.Point(9, 470);
            this.btn_ed.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ed.Name = "btn_ed";
            this.btn_ed.Size = new System.Drawing.Size(113, 34);
            this.btn_ed.TabIndex = 12;
            this.btn_ed.Text = "ویرایش";
            this.btn_ed.UseVisualStyleBackColor = true;
            this.btn_ed.Click += new System.EventHandler(this.btn_ed_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(9, 346);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(4);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(113, 34);
            this.btn_insert.TabIndex = 10;
            this.btn_insert.Text = "ثبت";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.lblt3);
            this.groupBox2.Controls.Add(this.lblt5);
            this.groupBox2.Controls.Add(this.lblt4);
            this.groupBox2.Controls.Add(this.picb_logo);
            this.groupBox2.Controls.Add(this.lblt1);
            this.groupBox2.Controls.Add(this.lblt2);
            this.groupBox2.Controls.Add(this.picb_image);
            this.groupBox2.Location = new System.Drawing.Point(129, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 452);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.ContextMenuStrip = this.conm_frm_reg;
            this.groupBox1.Controls.Add(this.cmbo_side);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_floor);
            this.groupBox1.Controls.Add(this.lbl_date);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_startnum);
            this.groupBox1.Controls.Add(this.txt_endnum);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_volunteer);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_class);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_fieldother);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_fieldmain);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 169);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(669, 273);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // cmbo_side
            // 
            this.cmbo_side.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_side.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbo_side.FormattingEnabled = true;
            this.cmbo_side.Items.AddRange(new object[] {
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
            this.cmbo_side.Location = new System.Drawing.Point(9, 50);
            this.cmbo_side.Name = "cmbo_side";
            this.cmbo_side.Size = new System.Drawing.Size(376, 33);
            this.cmbo_side.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(175, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "سمت";
            // 
            // txt_floor
            // 
            this.txt_floor.Location = new System.Drawing.Point(587, 231);
            this.txt_floor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_floor.Multiline = true;
            this.txt_floor.Name = "txt_floor";
            this.txt_floor.Size = new System.Drawing.Size(75, 30);
            this.txt_floor.TabIndex = 5;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(541, 135);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_date.Size = new System.Drawing.Size(0, 29);
            this.lbl_date.TabIndex = 21;
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(285, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "از شماره ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(193, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "تا شماره";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(531, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "تاریخ برگزاری";
            // 
            // txt_startnum
            // 
            this.txt_startnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_startnum.Location = new System.Drawing.Point(285, 230);
            this.txt_startnum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_startnum.Name = "txt_startnum";
            this.txt_startnum.Size = new System.Drawing.Size(89, 30);
            this.txt_startnum.TabIndex = 7;
            // 
            // txt_endnum
            // 
            this.txt_endnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_endnum.Location = new System.Drawing.Point(175, 230);
            this.txt_endnum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_endnum.Name = "txt_endnum";
            this.txt_endnum.Size = new System.Drawing.Size(89, 30);
            this.txt_endnum.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(219, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "شماره داوطلبی";
            // 
            // txt_volunteer
            // 
            this.txt_volunteer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_volunteer.Location = new System.Drawing.Point(5, 230);
            this.txt_volunteer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_volunteer.Name = "txt_volunteer";
            this.txt_volunteer.Size = new System.Drawing.Size(139, 30);
            this.txt_volunteer.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "تعداد داوطلب";
            // 
            // txt_class
            // 
            this.txt_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_class.Location = new System.Drawing.Point(419, 230);
            this.txt_class.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(139, 30);
            this.txt_class.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "شماره کلاس یا سالن";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(603, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "طبقه";
            // 
            // txt_fieldother
            // 
            this.txt_fieldother.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fieldother.Location = new System.Drawing.Point(9, 134);
            this.txt_fieldother.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_fieldother.Name = "txt_fieldother";
            this.txt_fieldother.Size = new System.Drawing.Size(247, 30);
            this.txt_fieldother.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "حوزه فرعی";
            // 
            // txt_fieldmain
            // 
            this.txt_fieldmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fieldmain.Location = new System.Drawing.Point(261, 134);
            this.txt_fieldmain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_fieldmain.Name = "txt_fieldmain";
            this.txt_fieldmain.Size = new System.Drawing.Size(245, 30);
            this.txt_fieldmain.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "حوزه اصلی ";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(395, 50);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(269, 34);
            this.txt_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام و نام خانوادگی";
            // 
            // lblt3
            // 
            this.lblt3.AutoSize = true;
            this.lblt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblt3.Location = new System.Drawing.Point(235, 86);
            this.lblt3.Name = "lblt3";
            this.lblt3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblt3.Size = new System.Drawing.Size(204, 25);
            this.lblt3.TabIndex = 31;
            this.lblt3.Text = "سازمان سنجش آموزش کشور";
            this.lblt3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblt5
            // 
            this.lblt5.AutoSize = true;
            this.lblt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblt5.Location = new System.Drawing.Point(283, 140);
            this.lblt5.Name = "lblt5";
            this.lblt5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblt5.Size = new System.Drawing.Size(102, 29);
            this.lblt5.TabIndex = 30;
            this.lblt5.Text = "سال ۱۳۹۷";
            this.lblt5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblt4
            // 
            this.lblt4.AutoSize = true;
            this.lblt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblt4.Location = new System.Drawing.Point(210, 111);
            this.lblt4.Name = "lblt4";
            this.lblt4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblt4.Size = new System.Drawing.Size(260, 29);
            this.lblt4.TabIndex = 29;
            this.lblt4.Text = "آزمون کارشناسی ارشد ناپیوسته";
            this.lblt4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picb_logo
            // 
            this.picb_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picb_logo.Location = new System.Drawing.Point(564, 20);
            this.picb_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picb_logo.Name = "picb_logo";
            this.picb_logo.Size = new System.Drawing.Size(114, 144);
            this.picb_logo.TabIndex = 28;
            this.picb_logo.TabStop = false;
            // 
            // lblt1
            // 
            this.lblt1.AutoSize = true;
            this.lblt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblt1.Location = new System.Drawing.Point(256, 18);
            this.lblt1.Name = "lblt1";
            this.lblt1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblt1.Size = new System.Drawing.Size(161, 25);
            this.lblt1.TabIndex = 26;
            this.lblt1.Text = "جمهوری اسلامی ایران";
            this.lblt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblt2
            // 
            this.lblt2.AutoSize = true;
            this.lblt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblt2.Location = new System.Drawing.Point(225, 53);
            this.lblt2.Name = "lblt2";
            this.lblt2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblt2.Size = new System.Drawing.Size(223, 25);
            this.lblt2.TabIndex = 27;
            this.lblt2.Text = "وزارت علوم ، تحقیقات و فناوری";
            this.lblt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picb_image
            // 
            this.picb_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picb_image.Image = global::card.Properties.Resources.person_unknown;
            this.picb_image.Location = new System.Drawing.Point(6, 20);
            this.picb_image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picb_image.Name = "picb_image";
            this.picb_image.Size = new System.Drawing.Size(129, 144);
            this.picb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_image.TabIndex = 25;
            this.picb_image.TabStop = false;
            this.picb_image.Click += new System.EventHandler(this.picb_image_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(9, 530);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(113, 34);
            this.btn_reset.TabIndex = 13;
            this.btn_reset.Text = "پاک کردن فرم";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(1045, 688);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(141, 34);
            this.btn_add.TabIndex = 27;
            this.btn_add.Text = "اضافه کردن";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_finish
            // 
            this.btn_finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finish.Location = new System.Drawing.Point(967, 728);
            this.btn_finish.Margin = new System.Windows.Forms.Padding(4);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(141, 34);
            this.btn_finish.TabIndex = 29;
            this.btn_finish.Text = "پایان";
            this.btn_finish.UseVisualStyleBackColor = true;
            this.btn_finish.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // btn_dellist
            // 
            this.btn_dellist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dellist.Location = new System.Drawing.Point(897, 688);
            this.btn_dellist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dellist.Name = "btn_dellist";
            this.btn_dellist.Size = new System.Drawing.Size(141, 34);
            this.btn_dellist.TabIndex = 30;
            this.btn_dellist.Text = "حذف";
            this.btn_dellist.UseVisualStyleBackColor = true;
            this.btn_dellist.Click += new System.EventHandler(this.btn_dellist_Click);
            // 
            // btn_current
            // 
            this.btn_current.Location = new System.Drawing.Point(897, 650);
            this.btn_current.Margin = new System.Windows.Forms.Padding(4);
            this.btn_current.Name = "btn_current";
            this.btn_current.Size = new System.Drawing.Size(141, 34);
            this.btn_current.TabIndex = 31;
            this.btn_current.Text = "امتحان جاری";
            this.btn_current.UseVisualStyleBackColor = true;
            this.btn_current.Click += new System.EventHandler(this.btn_current_Click);
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
            this.comboBox1.Location = new System.Drawing.Point(490, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(162, 24);
            this.comboBox1.TabIndex = 50;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(500, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 20);
            this.label12.TabIndex = 49;
            this.label12.Text = "جستوجو بر اساس سمت";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(666, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 48;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(658, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 20);
            this.label13.TabIndex = 47;
            this.label13.Text = "جستوجو براساس نام";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1185, 343);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 20);
            this.label14.TabIndex = 57;
            this.label14.Text = "شماره";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1021, 343);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 20);
            this.label15.TabIndex = 56;
            this.label15.Text = "نام و سمت";
            // 
            // listBox2
            // 
            this.listBox2.Enabled = false;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 22;
            this.listBox2.Location = new System.Drawing.Point(823, 378);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(342, 268);
            this.listBox2.TabIndex = 53;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(1171, 378);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(68, 268);
            this.listBox1.TabIndex = 52;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // foundedrecords
            // 
            this.foundedrecords.AutoSize = true;
            this.foundedrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foundedrecords.Location = new System.Drawing.Point(328, 32);
            this.foundedrecords.Name = "foundedrecords";
            this.foundedrecords.Size = new System.Drawing.Size(150, 20);
            this.foundedrecords.TabIndex = 58;
            this.foundedrecords.Text = "تعداد عناصر یافت شده : ";
            // 
            // frm_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1251, 784);
            this.ContextMenuStrip = this.conm_frm_reg;
            this.Controls.Add(this.foundedrecords);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_current);
            this.Controls.Add(this.btn_dellist);
            this.Controls.Add(this.btn_finish);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_ed);
            this.Controls.Add(this.btn_multiselect);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_view";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم مشاهده اعضای ثبت شده";
            this.Load += new System.EventHandler(this.frm_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.conm_frm_reg.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_multiselect;
        private System.Windows.Forms.ContextMenuStrip conm_frm_reg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Button btn_ed;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txt_floor;
        public System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_startnum;
        public System.Windows.Forms.TextBox txt_endnum;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_volunteer;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_class;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_fieldother;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_fieldmain;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblt3;
        private System.Windows.Forms.Label lblt5;
        private System.Windows.Forms.Label lblt4;
        private System.Windows.Forms.PictureBox picb_logo;
        private System.Windows.Forms.Label lblt1;
        private System.Windows.Forms.Label lblt2;
        public System.Windows.Forms.PictureBox picb_image;
        private System.Windows.Forms.ComboBox cmbo_side;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_finish;
        private System.Windows.Forms.Button btn_dellist;
        private System.Windows.Forms.Button btn_current;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label foundedrecords;
    }
}