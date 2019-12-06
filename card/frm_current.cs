using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace card
{
    public partial class frm_currentexam : Form
    {
        public frm_currentexam()
        {
            InitializeComponent();
        }
        frm_print frmp = new frm_print();
        db_cardEntities dbmanager = new db_cardEntities();
        private void Frm_currentexam_Load(object sender, EventArgs e)
        {
            //Frm_start frms = new Frm_start();
            //frms.Show();

            dgv.DataSource = dbmanager.tbl_current.SqlQuery("select * from tbl_current order by side , name ").ToList();
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
            Giverownum();
        }

        private void بازگشتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_view frmv1 = new frm_view()
            {
                Visible = true,
                Enabled = true
            };
            this.Close();
        }

        private void Btn_del_Click(object sender, EventArgs e)
        {
            int row = int.Parse(dgv.SelectedCells[0].Value.ToString());
            tbl_current tblc = dbmanager.tbl_current.FirstOrDefault(x => x.id == row);

            try
            {
                string mtemp = string.Format("  آیا مایل به حذف ردیف : {0} با نام : {1} و سمت : {2} هستید ؟؟", tblc.row, tblc.name, tblc.side);
                DialogResult dres = MessageBox.Show(mtemp, "هشدار حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dres == DialogResult.Yes)
                {
                    dbmanager.tbl_current.Remove(tblc);
                    dbmanager.SaveChanges();
                    dgv.DataSource = dbmanager.tbl_current.SqlQuery("select * from tbl_current order by side , name ").ToList();
                }
                Giverownum();
            }
            catch (Exception)
            {
                MessageBox.Show("لطفا ابتدا یکی از رکوردها را انتخاب کنید");
            }
        }

        private void Dgv_Click(object sender, EventArgs e)
        {
            int row = int.Parse(dgv.SelectedCells[0].Value.ToString());
            Properties.Settings.Default.id = row;
            Properties.Settings.Default.Save();
        }


        private void Btn_print_Click(object sender, EventArgs e)
        {

            try
            {
                Properties.Settings.Default.multiprint = false;
                Properties.Settings.Default.Save();

                this.Visible = false;
                this.Enabled = false;
                new frm_print().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgv.DataSource = dbmanager.tbl_current.Where(x => x.side == comboBox1.SelectedItem.ToString()).ToList();
                foundedrecords.Text = "تعداد عناصر یافت شده :" + dgv.Rows.Count;
            }
            catch (Exception)
            {
                MessageBox.Show("سمت مورد نظر یافت نشد");
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            dgv.DataSource = dbmanager.tbl_current.Where(x => x.name.Contains(textBox1.Text)).ToList();
            if (textBox1.Text == "" || textBox1.Text == " ")
            {
                dgv.DataSource = dbmanager.tbl_current.SqlQuery("select * from tbl_current order by side , name ").ToList();
            }
            foundedrecords.Text = "تعداد عناصر یافت شده :" + dgv.Rows.Count;
        }

        private void Btn_printallcard_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.multiprint = false;
            Properties.Settings.Default.Save();
            this.Enabled = false;
            this.Visible = false;
            new frm_print().Show();

        }



        private void Button1_Click(object sender, EventArgs e)
        {
            
        }
        private void Giverownum()
        {
            dgv.SelectAll();
            int rownum = dgv.RowCount;

            for (int i = 0; i < dgv.RowCount; i++)
            {
                int t = Convert.ToInt32(dgv.SelectedRows[i].Cells[0].Value);
                tbl_current tblc = dbmanager.tbl_current.FirstOrDefault(x => x.id == t);
                tblc.row = rownum;
                rownum--;

                dbmanager.SaveChanges();
            }
            dgv.DataSource = dbmanager.tbl_current.SqlQuery("select * from tbl_current order by side , name ").ToList();
        }


        private void Btn_baygani_Click(object sender, EventArgs e)
        {


        }


        private void Btn_memberlist_Click(object sender, EventArgs e)
        {

            try
            {
                dgv.DataSource = dbmanager.tbl_current.SqlQuery("select * from tbl_current order by side , name ").ToList();
                Exporttoexcel2(dgv, listfilename.Text, Properties.Settings.Default.listfilepath);
                MessageBox.Show("فایل اکسل شما با موفقیت در مسیر " + Properties.Settings.Default.listfilepath + "" + listfilename.Text + " ذخیره شد ");
            }
            catch (Exception)
            {
                MessageBox.Show(" لطفا در انتخاب نام از علائم / \\ : * < > | استفاده نکنید");
            }

        }

       
        public void Exporttoexcel2(DataGridView datagridviewid, string excelfilename, string filepath)
        {
            Microsoft.Office.Interop.Excel.Application obex = new Microsoft.Office.Interop.Excel.Application();
            obex.Application.Workbooks.Add(Type.Missing);
            obex.Columns.ColumnWidth = 18;


            for (int i = 1; i < 4; i++)
            {
                obex.Cells[1, i] = datagridviewid.Columns[i].HeaderText;
            }

            for (int i = 0; i < datagridviewid.Rows.Count; i++)
            {
                for (int j = 1; j < 4; j++)
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


        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult dres = folderBrowserDialog1.ShowDialog();
            if (dres == DialogResult.OK)
            {
                Properties.Settings.Default.listfilepath = folderBrowserDialog1.SelectedPath + "\\";
                Properties.Settings.Default.Save();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Giverownum();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new frm_view().Show();
            this.Visible = false;
            this.Enabled = false;
        }
    }

}
