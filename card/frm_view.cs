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
        db_card dbmanagerr = new db_card();
        //db_cardEntities dbmanager = new db_cardEntities();
        List<int> lselect = new List<int>();
        int row = 0;
        bool pic = false;
        private void frm_view_Load(object sender, EventArgs e)
        {
            //this comment is just a temprory test fir git

            //dbmanager.tbl_main.SqlQuery("SELECT id as [ID] , name as [نام ], side as [ سمت ] , date as[ تاریخ] ,filed_main as [حوزه اصلی] ,field_other as [حوزه فرعی], floor as [طبقه], classnumber as [شماره کلاس], v_start as [از شماره],v_end as [تا شماره], v_number as [تعداد داوطلبان], year as  [سال], picture as [عکس], exam as [امتحان] from tbl_main order by side, v_start, name ;").ToList();
            //load form properties
            //this.FormBorderStyle = FormBorderStyle.None;
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

            //load database into dgv


            dbmanagerr.ReadXml("db_card.xml");
            dgv.DataSource = dbmanagerr.tbl_main;
            dgv.Sort(dgv.Columns[1], ListSortDirection.Ascending);

            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "نام";
            dgv.Columns[2].HeaderText = "سمت";
            dgv.Columns[3].HeaderText = "حوزه اصلی";
            dgv.Columns[4].HeaderText = "حوزه فرعی";
            dgv.Columns[5].HeaderText = "طبقه";
            dgv.Columns[6].HeaderText = "شماره کلاس";
            dgv.Columns[7].HeaderText = "از شماره";
            dgv.Columns[8].HeaderText = "تا شماره";
            dgv.Columns[9].HeaderText = "تعداد داوطلبان";
            dgv.Columns[10].HeaderText = "آدرس تصویر";

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


        private void btn_ed_Click(object sender, EventArgs e)
        {
            try
            {
                int row = int.Parse(dgv.SelectedCells[0].Value.ToString());

                //Delete row
                db_card.tbl_mainRow tblm = dbmanagerr.tbl_main.FirstOrDefault(x => x.id == row);

                dbmanagerr.tbl_main.Removetbl_mainRow(tblm);

                dbmanagerr.WriteXml("db_card.xml");

                //insert row
                string strside = cmbo_side.SelectedItem.ToString();

                if (pic == false)
                {
                    dbmanagerr.tbl_main.Addtbl_mainRow(txt_name.Text, strside, txt_fieldmain.Text, txt_fieldother.Text, txt_floor.Text,
                    txt_class.Text, txt_startnum.Text, txt_endnum.Text, txt_volunteer.Text, "null");
                    dbmanagerr.WriteXml("db_card.xml");
                }
                else if (pic == true)
                {
                    dbmanagerr.tbl_main.Addtbl_mainRow(txt_name.Text, strside, txt_fieldmain.Text, txt_fieldother.Text, txt_floor.Text,
                    txt_class.Text, txt_startnum.Text, txt_endnum.Text, txt_volunteer.Text, ofd.FileName.ToString());
                    dbmanagerr.WriteXml("db_card.xml");
                }

                dgv.DataSource = dbmanagerr.tbl_main;
                dgv.Sort(dgv.Columns[1], ListSortDirection.Ascending);
            }
            catch (Exception)
            {

                MessageBox.Show("لطفا ابتدا یکی از رکوردها را برای ویرایش انتخاب کنید");
            }
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
            
            try
            {

                db_card.tbl_mainRow tblm2 = dbmanagerr.tbl_main.FirstOrDefault(x => x.name == txt_name.Text);

                if (tblm2 != null)
                {
                    DialogResult dr = MessageBox.Show("  نام مورد نظر در جدول وجود دارد . " + Environment.NewLine + "  نام  : " + tblm2.name + "    سمت  : " + tblm2.side + Environment.NewLine + " آیا مایل به وارد کردن دوباره نام هستید ؟؟", "هشدار نام تکراری", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);



                    if (dr == DialogResult.Yes)
                    {
                        string strside = cmbo_side.SelectedItem.ToString();
                        if (pic==false)
                        {

                            dbmanagerr.tbl_main.Addtbl_mainRow(txt_name.Text, strside, txt_fieldmain.Text, txt_fieldother.Text, txt_floor.Text,
                           txt_class.Text, txt_startnum.Text, txt_endnum.Text, txt_volunteer.Text, "null");

                            dbmanagerr.WriteXml("db_card.xml");
                        }
                        else if(pic==true)
                        {
                            dbmanagerr.tbl_main.Addtbl_mainRow(txt_name.Text, strside, txt_fieldmain.Text, txt_fieldother.Text, txt_floor.Text,
                            txt_class.Text, txt_startnum.Text, txt_endnum.Text, txt_volunteer.Text,ofd.FileName);
                            dbmanagerr.WriteXml("db_card.xml");
                        }
                    }
                }

                else
                {
                    string strside = cmbo_side.SelectedItem.ToString();
                    if (pic == false)
                    {

                        dbmanagerr.tbl_main.Addtbl_mainRow(txt_name.Text, strside, txt_fieldmain.Text, txt_fieldother.Text, txt_floor.Text,
                       txt_class.Text, txt_startnum.Text, txt_endnum.Text, txt_volunteer.Text, "null");

                        dbmanagerr.WriteXml("db_card.xml");
                    }
                    else if(pic == true)
                    {
                        dbmanagerr.tbl_main.Addtbl_mainRow(txt_name.Text, strside, txt_fieldmain.Text, txt_fieldother.Text, txt_floor.Text,
                        txt_class.Text, txt_startnum.Text, txt_endnum.Text, txt_volunteer.Text,ofd.FileName);
                        dbmanagerr.WriteXml("db_card.xml");
                    }
                }
                dgv.DataSource = dbmanagerr.tbl_main;
                dgv.Sort(dgv.Columns[1], ListSortDirection.Ascending);
            }
            catch (Exception)
            {
                MessageBox.Show("باید حداقل دو مقدار نام و سمت را وارد کنید ");
            }

        }


        private void btn_del_Click(object sender, EventArgs e)
        {



            try
            {
                int row = int.Parse(dgv.SelectedCells[0].Value.ToString());
                db_card.tbl_mainRow tblm = dbmanagerr.tbl_main.FirstOrDefault(x => x.id == row);

                string mtemp = string.Format( tblm.name + " : آیا مایل به حذف رکورد با نام  " + Environment.NewLine + " : و سمت  " + tblm.side + " هستید ؟؟ ");
                DialogResult dres = MessageBox.Show(mtemp, "هشدار حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dres == DialogResult.Yes)
                {
                    dbmanagerr.tbl_main.Removetbl_mainRow(tblm);
                    dbmanagerr.WriteXml("db_card.xml");

                    dgv.DataSource = dbmanagerr.tbl_main;
                    dgv.Sort(dgv.Columns[1], ListSortDirection.Ascending);
                    try
                    {
                        dgv_Click(sender, e);
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("لطفا ابتدا یکی از رکوردها را برای حذف انتخاب کنید");
            }

            dgv.DataSource = dbmanagerr.tbl_main;
        }

        private void dgv_Click(object sender, EventArgs e)
        {
            try
            {
                picb_image.ImageLocation = string.Empty;
                row = int.Parse(dgv.SelectedCells[0].Value.ToString());
                db_card.tbl_mainRow tblm = dbmanagerr.tbl_main.FirstOrDefault(x => x.id == row);
                if (multiselect == true)
                {

                    listBox1.Items.Add(dgv.SelectedCells[0].Value);
                    listBox2.Items.Add(tblm.id + "     " + tblm.name + "     " + tblm.side);
                    lselect.Add(Convert.ToInt32(dgv.SelectedCells[0].Value));
                }


                if (tblm.picture == "null")
                {
                    picb_image.Image = Properties.Resources.person_unknown;
                    pic = false;
                }
                else if (tblm.picture != "null")
                {
                    picb_image.ImageLocation = tblm.picture.ToString();
                    pic = true;
                }

                txt_name.Text = tblm.name;
                cmbo_side.SelectedItem = tblm.side;
                ofd.FileName = tblm.picture;
                txt_floor.Text = tblm.floor;
                txt_class.Text = tblm.classnumber;
                txt_volunteer.Text = tblm.v_number;
                txt_startnum.Text = tblm.v_start;
                txt_endnum.Text = tblm.v_end;
                txt_fieldmain.Text = tblm.field_main;
                txt_fieldother.Text = tblm.field_other;
            }
            catch (Exception)
            {
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            pic = false;
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
            //multiselect btn
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
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
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

                db_card.tbl_mainRow tblm2 = dbmanagerr.tbl_main.FirstOrDefault(x => x.name == txt_name.Text);

                foreach (var item in lselect)
                {

                    db_card.tbl_mainRow tblm = dbmanagerr.tbl_main.FirstOrDefault(x => x.id == item);
                    db_card.tbl_currentRow tblc2 = dbmanagerr.tbl_current.FirstOrDefault(x => x.name == tblm.name);

                    if (tblc2 != null)
                    {
                        DialogResult dr = MessageBox.Show("  نام مورد نظر در جدول وجود دارد . " + Environment.NewLine + "  نام  : " + tblc2.name + "    سمت  : " + tblc2.side + Environment.NewLine + " آیا مایل به وارد کردن دوباره نام هستید ؟؟", "هشدار نام تکراری", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);



                        if (dr == DialogResult.Yes)
                        {
                            db_card.tbl_mainRow tblm3 = dbmanagerr.tbl_main.FirstOrDefault(x => x.id == item);

                            dbmanagerr.tbl_current.Addtbl_currentRow(tblm3.name, tblm3.side, tblm3.field_main, tblm3.field_other, tblm3.floor,
                                tblm3.classnumber, tblm3.v_start, tblm3.v_end, tblm3.v_number, tblm3.picture);
                            dbmanagerr.WriteXml("db_card.xml");
                        }
                    }
                    else
                    {
                        db_card.tbl_mainRow tblm3 = dbmanagerr.tbl_main.FirstOrDefault(x => x.id == item);

                        dbmanagerr.tbl_current.Addtbl_currentRow(tblm3.name, tblm3.side, tblm3.field_main, tblm3.field_other, tblm3.floor,
                            tblm3.classnumber, tblm3.v_start, tblm3.v_end, tblm3.v_number, tblm3.picture);
                        dbmanagerr.WriteXml("db_card.xml");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("لطفا رکورد های مورد نظر را انتخاب کنید");
            }

            new frm_currentexam().Show();
            this.Enabled = false;
            this.Visible = false;

        }

        private void btn_current_Click(object sender, EventArgs e)
        {
            new frm_currentexam().Show();
            this.Enabled = false;
            this.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                dgv.DataSource = dbmanagerr.tbl_main.Where(x => x.name.Contains(textBox1.Text)).ToList();
                if (textBox1.Text == "" || textBox1.Text == " ")
                {

                    dgv.DataSource = dbmanagerr.tbl_main;
                }
                foundedrecords.Text = "تعداد عناصر یافت شده :" + dgv.Rows.Count;
                dgv.Sort(dgv.Columns[1], ListSortDirection.Ascending);
            }
            catch (Exception)
            {
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                dgv.DataSource = dbmanagerr.tbl_main.Where(x => x.side == comboBox1.SelectedItem.ToString()).ToList();
                dgv.Sort(dgv.Columns[1], ListSortDirection.Ascending);
                foundedrecords.Text = "تعداد عناصر یافت شده :" + dgv.Rows.Count;
            }
            catch (Exception)
            {
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dres = folderBrowserDialog1.ShowDialog();
            if (dres == DialogResult.OK)
            {
                Properties.Settings.Default.bayganifilepath = folderBrowserDialog1.SelectedPath + "\\";
                Properties.Settings.Default.Save();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                dgv.DataSource = dbmanagerr.tbl_main;
                Exporttoexcel(dgv, bayganifilename.Text, Properties.Settings.Default.bayganifilepath);
                MessageBox.Show("فایل اکسل شما با موفقیت در مسیر " + Properties.Settings.Default.bayganifilepath + "" + bayganifilename.Text + " ذخیره شد ");
            }
            catch (Exception)
            {
                MessageBox.Show(" لطفا در انتخاب نام از علائم / \\ : * < > | استفاده نکنید");
            }
        }
        public void Exporttoexcel(DataGridView datagridviewid, string excelfilename, string filepath)
        {
            Microsoft.Office.Interop.Excel.Application obex = new Microsoft.Office.Interop.Excel.Application();
            obex.Application.Workbooks.Add(Type.Missing);
            obex.Columns.ColumnWidth = 18;


            for (int i = 1; i < 11; i++)
            {
                obex.Cells[1, i] = datagridviewid.Columns[i].HeaderText;
            }

            for (int i = 0; i < datagridviewid.Rows.Count; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    if (datagridviewid.Rows[i].Cells[j].Value != null)
                    {
                        obex.Cells[i + 2, j] = datagridviewid.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }

            obex.ActiveWorkbook.SaveCopyAs(@"" + filepath + "" + excelfilename + ".xlsx");
            obex.ActiveWorkbook.Saved = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm_currentexam frmreg = new frm_currentexam();
            frmreg.Enabled = true;
            frmreg.Visible = true;
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new frm_setting().Show();
            this.Visible = false;
            this.Enabled = false;
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    btn_del.PerformClick();
                }
            }
            catch (Exception)
            {
            }
        }

        private void listBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                listBox1.SelectedIndex = listBox2.SelectedIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}