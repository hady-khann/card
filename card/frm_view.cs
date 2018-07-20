using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace card
{
    public partial class frm_view : Form
    {
        public frm_view()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        db_cardEntities dbmanager = new db_cardEntities();
        List<int> lselect = new List<int>();

        bool pic = false;
        private void frm_view_Load(object sender, EventArgs e)
        {
            //this comment is just a temprory test fir git

            //dbmanager.tbl_main.SqlQuery("SELECT id as [ID] , name as [نام ], side as [ سمت ] , date as[ تاریخ] ,filed_main as [حوزه اصلی] ,field_other as [حوزه فرعی], floor as [طبقه], classnumber as [شماره کلاس], v_start as [از شماره],v_end as [تا شماره], v_number as [تعداد داوطلبان], year as  [سال], picture as [عکس], exam as [امتحان] from tbl_main order by side, v_start, name ;").ToList();
            //load form properties
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            lbl_date.Text = Properties.Settings.Default.date;
            lblt3.Text = Properties.Settings.Default.str_orgname;
            lblt4.Text = Properties.Settings.Default.str_exname;
            lblt5.Text = Properties.Settings.Default.str_year;

            if (Properties.Settings.Default.logo == "تعاونی سازمان سنجش")
            {
                picb_logo.Image = Properties.Resources.تعاونی_سازمان_سنجش;
                picb_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (Properties.Settings.Default.logo == "سازمان سنجش")
            {
                picb_logo.Image = Properties.Resources.سازمان_سنجش;
                picb_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            this.ControlBox = false;

            //load database into dgv


            dgv.DataSource = dbmanager.tbl_main.SqlQuery("select * from tbl_main order by side , name ").ToList();

            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "ردیف";
            dgv.Columns[2].HeaderText = "نام";
            dgv.Columns[3].HeaderText = "سمت";
            dgv.Columns[4].HeaderText = "حوزه اصلی";
            dgv.Columns[5].HeaderText = "حوزه فرعی";
            dgv.Columns[6].HeaderText = "طبقه";
            dgv.Columns[7].HeaderText = "شماره کلاس";
            dgv.Columns[8].HeaderText = "از شماره";
            dgv.Columns[9].HeaderText = "تا شماره";
            dgv.Columns[10].HeaderText = "تعداد داوطلبان";
            dgv.Columns[11].HeaderText = "آدرس تصویر";

        }

        private void picb_image_Click(object sender, EventArgs e)
        {

            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                pic = true;
                picb_image.Image = Image.FromFile(ofd.FileName);
                Properties.Settings.Default.current_pic = ofd.FileName;
                picb_image.SizeMode = PictureBoxSizeMode.StretchImage;
            }


        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void بازگشتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_currentexam frmreg = new frm_currentexam();
            frmreg.Enabled = true;
            frmreg.Visible = true;
            this.Close();
        }

        private void btn_ed_Click(object sender, EventArgs e)
        {
            int row = int.Parse(dgv.SelectedCells[0].Value.ToString());
            tbl_main tblm = dbmanager.tbl_main.FirstOrDefault(x => x.id == row);

            string strside = cmbo_side.SelectedItem.ToString();
            tblm.name = txt_name.Text;
            tblm.side = strside;
            tblm.picture = ofd.FileName;
            tblm.floor = txt_floor.Text;
            tblm.classnumber = txt_class.Text;
            tblm.v_number = txt_volunteer.Text;
            tblm.v_start = txt_startnum.Text;
            tblm.v_end = txt_endnum.Text;
            tblm.filed_main = txt_fieldmain.Text;
            tblm.field_other = txt_fieldother.Text;
            dbmanager.SaveChanges();

            dgv.DataSource = dbmanager.tbl_main.SqlQuery("select * from tbl_main order by side , name ").ToList();

        }

        private void btn_printall_Click(object sender, EventArgs e)
        {
            frm_print frmp = new frm_print();
            frmp.Show();
            this.Visible = false;
            this.Enabled = false;





        }

        private void conm_frm_reg_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            tbl_main tblm = new tbl_main();

            tbl_main tblm2 = dbmanager.tbl_main.FirstOrDefault(x => x.name == txt_name.Text);

            if (tblm2 != null)
            {
                DialogResult dr = MessageBox.Show("  نام مورد نظر در جدول وجود دارد . " + "  نام  : " + tblm2.name + "    سمت  : " + tblm2.side + Environment.NewLine + " آیا مایل به وارد کردن دوباره نام هستید ؟؟", "هشدار نام تکراری", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);



                if (dr == DialogResult.Yes)
                {
                    //if (pic == false || txt_fieldmain.Text == "" || txt_fieldother.Text == "" || txt_name.Text == "" || txt_startnum.Text == "" || txt_volunteer.Text == "")
                    //{
                    //    MessageBox.Show("لطفا تمام فیلد ها را پر کنید");
                    //    return;
                    //}
                    string strside = cmbo_side.SelectedItem.ToString();
                    tblm.name = txt_name.Text;
                    tblm.side = strside;

                    if (pic == false)
                    {
                        tblm.picture = "null";
                    }
                    else if (pic == true)
                    {
                        tblm.picture = ofd.FileName;
                    }
                    tblm.floor = txt_floor.Text;
                    tblm.classnumber = txt_class.Text;
                    tblm.v_number = txt_volunteer.Text;
                    tblm.v_start = txt_startnum.Text;
                    tblm.v_end = txt_endnum.Text;
                    tblm.filed_main = txt_fieldmain.Text;
                    tblm.field_other = txt_fieldother.Text;
                    dbmanager.tbl_main.Add(tblm);
                    dbmanager.SaveChanges();
                    dgv.DataSource = dbmanager.tbl_main.SqlQuery("select * from tbl_main order by side , name ").ToList();
                    pic = false;
                }
            }
            else
            {
                //if (pic == false || txt_fieldmain.Text == "" || txt_fieldother.Text == "" || txt_name.Text == "" || txt_startnum.Text == "" || txt_volunteer.Text == "")
                //{
                //    MessageBox.Show("لطفا تمام فیلد ها را پر کنید");
                //    return;
                //}
                string strside = cmbo_side.SelectedItem.ToString();
                tblm.name = txt_name.Text;
                tblm.side = strside;

                if (pic == false)
                {
                    tblm.picture = "null";
                }
                else if (pic == true)
                {
                    tblm.picture = ofd.FileName;
                }
                tblm.floor = txt_floor.Text;
                tblm.classnumber = txt_class.Text;
                tblm.v_number = txt_volunteer.Text;
                tblm.v_start = txt_startnum.Text;
                tblm.v_end = txt_endnum.Text;
                tblm.filed_main = txt_fieldmain.Text;
                tblm.field_other = txt_fieldother.Text;
                dbmanager.tbl_main.Add(tblm);
                dbmanager.SaveChanges();
                dgv.DataSource = dbmanager.tbl_main.SqlQuery("select * from tbl_main order by side , name ").ToList();
                pic = false;
            }
            
        }


        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                int row = int.Parse(dgv.SelectedCells[0].Value.ToString());
                tbl_main tblm = dbmanager.tbl_main.FirstOrDefault(x => x.id == row);
                dbmanager.tbl_main.Remove(tblm);
                dbmanager.SaveChanges();
                dgv.DataSource = dbmanager.tbl_main.SqlQuery("select * from tbl_main order by side , name ").ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_setting frms = new frm_setting();
            frms.Show();
        }

        private void dgv_Click(object sender, EventArgs e)
        {
            int row = int.Parse(dgv.SelectedCells[0].Value.ToString());
            tbl_main tblm = dbmanager.tbl_main.FirstOrDefault(x => x.id == row);
            if (multiselect == true)
            {
                
                listBox1.Items.Add(dgv.SelectedCells[0].Value);
                listBox2.Items.Add(tblm.name + " | " + tblm.side);
                lselect.Add(Convert.ToInt32(dgv.SelectedCells[0].Value));
            }


            if (tblm.picture == "null")
            {
                picb_image.Image = Properties.Resources.person_unknown;
            }
            else if (tblm.picture != "null")
            {
                picb_image.ImageLocation = tblm.picture;
            }

            txt_name.Text = tblm.name;
            cmbo_side.SelectedItem = tblm.side;
            ofd.FileName = tblm.picture;
            txt_floor.Text = tblm.floor;
            txt_class.Text = tblm.classnumber;
            txt_volunteer.Text = tblm.v_number;
            txt_startnum.Text = tblm.v_start;
            txt_endnum.Text = tblm.v_end;
            txt_fieldmain.Text = tblm.filed_main;
            txt_fieldother.Text = tblm.field_other;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            cmbo_side.SelectedIndex = -1;
            txt_floor.Text = "";
            txt_class.Text = "";
            txt_fieldmain.Text = "";
            txt_fieldother.Text = "";
            txt_volunteer.Text = "";
            txt_startnum.Text = "";
            txt_endnum.Text = "";
            picb_image.Image = Properties.Resources.person_unknown;
        }
        bool multiselect = false;
        private void btn_print_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            multiselect = true;
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            multiselect = false;

        }

        private void btn_dellist_Click(object sender, EventArgs e)
        {
            try
            {
                lselect.Remove(Convert.ToInt32(listBox1.SelectedItem));
                listBox2.Items.Remove(listBox2.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            catch (Exception)
            {
                MessageBox.Show("لطفا یک ردیف را انتخاب کنید و یا مجدد سعی کنید");
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (var item in lselect)
                {
                    {
                        tbl_main tblm = dbmanager.tbl_main.FirstOrDefault(x => x.id == item);
                        tbl_current tblc = new tbl_current();
                        tbl_current tblc2 = dbmanager.tbl_current.FirstOrDefault(x => x.name == tblm.name);

                        if (tblc2 != null)
                        {
                            DialogResult dr = MessageBox.Show("  نام مورد نظر در جدول وجود دارد . " + "  نام  : " + tblc2.name + "    سمت  : " + tblc2.side + Environment.NewLine + " آیا مایل به وارد کردن دوباره نام هستید ؟؟", "هشدار نام تکراری", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);



                            if (dr == DialogResult.Yes)
                            {
                                tblc.name = tblm.name;
                                tblc.side = tblm.side;
                                tblc.field_main = tblm.filed_main;
                                tblc.field_other = tblm.field_other;
                                tblc.floor = tblm.floor;
                                tblc.classnumber = tblm.classnumber;
                                tblc.v_start = tblc.v_start;
                                tblc.v_end = tblm.v_end;
                                tblc.v_number = tblm.v_number;
                                tblc.picture = tblm.picture;
                                dbmanager.tbl_current.Add(tblc);
                                dbmanager.SaveChanges();
                            }
                        }
                        else
                        {
                            tblc.name = tblm.name;
                            tblc.side = tblm.side;
                            tblc.field_main = tblm.filed_main;
                            tblc.field_other = tblm.field_other;
                            tblc.floor = tblm.floor;
                            tblc.classnumber = tblm.classnumber;
                            tblc.v_start = tblc.v_start;
                            tblc.v_end = tblm.v_end;
                            tblc.v_number = tblm.v_number;
                            tblc.picture = tblm.picture;
                            dbmanager.tbl_current.Add(tblc);
                            dbmanager.SaveChanges();
                        }

                    }

                    new frm_currentexam().Show();
                    this.Enabled = false;
                    this.Visible = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("لطفا رکورد های مورد نظر را انتخاب کنید");
            }
        }

        private void btn_current_Click(object sender, EventArgs e)
        {
            new frm_currentexam().Show();
            this.Enabled = false;
            this.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgv.DataSource = dbmanager.tbl_main.Where(x => x.name.Contains(textBox1.Text)).ToList();
            if (textBox1.Text == "" || textBox1.Text == " ")
            {
                dgv.DataSource = dbmanager.tbl_main.SqlQuery("select * from tbl_main order by side , name ").ToList();
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgv.DataSource = dbmanager.tbl_main.Where(x => x.side == comboBox1.SelectedItem.ToString()).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("سمت مورد نظر یافت نشد");
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                listBox2.SelectedIndex = listBox1.SelectedIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
