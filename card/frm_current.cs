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
using System.Xml;

namespace card
{
    public partial class frm_currentexam : Form
    {
        public frm_currentexam()
        {
            InitializeComponent();
        }

        frm_print frmp = new frm_print();
        db_card dbmanagerr = new db_card();
        
        //db_cardEntities dbmanager = new db_cardEntities();
        private void Frm_currentexam_Load(object sender, EventArgs e)
        {
            dbmanagerr.ReadXml("db_card.xml");

            dgv.DataSource = dbmanagerr.tbl_current;
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
            
            
            try
            {
                int row = int.Parse(dgv.SelectedCells[0].Value.ToString());
                db_card.tbl_currentRow tblc = dbmanagerr.tbl_current.FirstOrDefault(x => x.id == row);

                string mtemp =(tblc.name + " : آیا مایل به حذف رکورد با نام " +Environment.NewLine+ " و سمت : " + tblc.side + " هستید ؟؟ "  );
                DialogResult dres = MessageBox.Show(mtemp, "هشدار حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dres == DialogResult.Yes)
                {
                    dbmanagerr.tbl_current.Removetbl_currentRow(tblc);
                    dbmanagerr.WriteXml("db_card.xml");

                    dgv.DataSource = dbmanagerr.tbl_current;
                    dgv.Sort(dgv.Columns[1], ListSortDirection.Ascending);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("لطفا ابتدا یکی از رکوردها را برای حذف انتخاب کنید");
            }
        }

        private void Dgv_Click(object sender, EventArgs e)
        {
            try
            {

                Properties.Settings.Default.multiprint = false;
                Properties.Settings.Default.singleprint = Convert.ToInt32(dgv.SelectedCells[0].Value);
                Properties.Settings.Default.Save();
                int row = int.Parse(dgv.SelectedCells[0].Value.ToString());
                Properties.Settings.Default.id = row;
                Properties.Settings.Default.Save();
            }
            catch (Exception)
            {
            }
            

        }


        private void Btn_print_Click(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(dgv.SelectedCells[0].Value);
                Properties.Settings.Default.multiprint = false;
                Properties.Settings.Default.singleprint = id ;
                Properties.Settings.Default.Save();


                new frm_print().Show();
                this.Visible = false;
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("لطفا ابتدا یکی از رکوردها را برای پرینت تکی انتخاب کنید");
            }
        }

        private void ComboBox1_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                
                dgv.DataSource = dbmanagerr.tbl_current.Where(x => x.side == comboBox1.SelectedItem.ToString()).ToList();
                dgv.Sort(dgv.Columns[1], ListSortDirection.Ascending);
                foundedrecords.Text = "تعداد عناصر یافت شده :" + dgv.Rows.Count;
            }
            catch (Exception)
            {
                MessageBox.Show("سمت مورد نظر یافت نشد");
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
            dgv.DataSource = dbmanagerr.tbl_current.Where(x => x.name.Contains(textBox1.Text)).ToList();
            dgv.Sort(dgv.Columns[1], ListSortDirection.Ascending);
            if (textBox1.Text == "" || textBox1.Text == " ")
            {
                dgv.DataSource = dbmanagerr.tbl_current;
                dgv.Sort(dgv.Columns[1], ListSortDirection.Ascending);
            }
            foundedrecords.Text = "تعداد عناصر یافت شده :" + dgv.Rows.Count;
        }

        private void Btn_printallcard_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.multiprint = true;
            Properties.Settings.Default.Save();

            this.Enabled = false;
            this.Visible = false;
            new frm_print().Show();

        }



        private void Button1_Click(object sender, EventArgs e)
        {
            
        }
        


        private void Btn_baygani_Click(object sender, EventArgs e)
        {


        }


        private void Btn_memberlist_Click(object sender, EventArgs e)
        {

            try
            {
                dgv.DataSource = dbmanagerr.tbl_current;
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


            for (int i = 1; i <= 4; i++)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new frm_view().Show();
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
    }

}
