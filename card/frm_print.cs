using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace card
{
    
    public partial class frm_print : Form
    {
        int x = 0;
        int y = 0;
        public frm_print()
        {
            InitializeComponent();
        }
        db_card dbmanagerr = new db_card();
        //db_cardEntities dbmanager = new db_cardEntities();

        int min = 0;
        int max = 0;

        private void frm_print_Load(object sender, EventArgs e)
        {
            try
            {

                this.FormBorderStyle = FormBorderStyle.None;
                this.ControlBox = false;
                lblt3.Text = Properties.Settings.Default.str_orgname;
                lblt4.Text = Properties.Settings.Default.str_exname;
                lblt5.Text = Properties.Settings.Default.str_year;
                lbl_date.Text = Properties.Settings.Default.date;
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

                dbmanagerr.ReadXml("db_card.xml");




                if (Properties.Settings.Default.multiprint == false)
                {
                    if (cancel == false)
                    {
                        int row = Convert.ToInt32(Properties.Settings.Default.singleprint);
                        db_card.tbl_currentRow tblc = dbmanagerr.tbl_current.FirstOrDefault(x => x.id == row);
                        if (tblc.picture != "null")
                        {
                            string t = tblc.picture.ToString();
                            picb_image.Image = Image.FromFile(@"" + t);
                        }


                        lbl_name.Text = tblc.name;
                        lbl_side.Text = tblc.side;
                        lbl_field_main.Text = tblc.field_main;
                        lbl_field_other.Text = tblc.field_other;
                        lbl_floor.Text = tblc.floor;
                        lbl_class.Text = tblc.classnumber;
                        lbl_v_number.Text = tblc.v_number;
                        lbl_v_start.Text = tblc.v_start;
                        lbl_v_end.Text = tblc.v_end;

                        this.Refresh();
                        print();
                    }
                }


                if (Properties.Settings.Default.multiprint == true)
                {
                    min = dbmanagerr.tbl_current.Min(x => Convert.ToInt32(x.id));
                    max = dbmanagerr.tbl_current.Max(x => Convert.ToInt32(x.id));

                    for (int i = min; i <= max; i++)
                    {
                        if (cancel == false)
                        {
                            try
                            {
                                db_card.tbl_currentRow tblc = dbmanagerr.tbl_current.FirstOrDefault(x => x.id == i);
                                if (tblc.picture != "null")
                                {
                                    string t = tblc.picture.ToString();
                                    picb_image.Image = Image.FromFile(@"" + t);
                                }

                                lbl_name.Text = tblc.name;
                                lbl_side.Text = tblc.side;
                                lbl_field_main.Text = tblc.field_main;
                                lbl_field_other.Text = tblc.field_other;
                                lbl_floor.Text = tblc.floor;
                                lbl_class.Text = tblc.classnumber;
                                lbl_v_number.Text = tblc.v_number;
                                lbl_v_start.Text = tblc.v_start;
                                lbl_v_end.Text = tblc.v_end;
                                if (tblc.picture != "null")
                                {
                                    picb_image.ImageLocation = @"" + tblc.picture;
                                }
                                else
                                {
                                    picb_image.Image = Properties.Resources.person_unknown;
                                }

                                this.Refresh();
                                print();
                            }
                            catch (Exception)
                            {
                                continue;
                            }
                        }
                        else
                        {
                            Properties.Settings.Default.multiprint = false;
                            new frm_currentexam().Visible = true;
                            new frm_currentexam().Enabled = true;
                            this.Close();
                            return;
                        }
                    }
                    Thread.Sleep(4000);
                }



                Properties.Settings.Default.multiprint = false;
                new frm_currentexam().Visible = true;
                new frm_currentexam().Enabled = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        public void print()
        {

            //PrintDocument recordDoc = new PrintDocument();
            //recordDoc.DefaultPageSettings.PaperSize = new PaperSize("210 x 297 mm", 800, 800);
            //PrintPreviewDialog ppvw = new PrintPreviewDialog();
            //ppvw.Document = recordDoc;
            //ppvw.ShowDialog();

            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.PaperSize = new PaperSize("210 x 297 mm", 118, 81);
            pd.PrintPage += new PrintPageEventHandler(PrintImage);

            //PrintPreviewDialog ppvw = new PrintPreviewDialog();
            //ppvw.Document = pd;
            //ppvw.ShowDialog();

            pd.Print();
        }

        private void PrintImage(object o, PrintPageEventArgs e)
        {
            int width = (this.Width * 5);
            int height = (this.Height * 5);

            Rectangle bounds = new Rectangle(x, y, width, height + 200);

            Bitmap img = new Bitmap(width, height);

            //this.DrawToBitmap(bitmap, this.ClientRectangle);

            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
            img.Save(@"D:\latestimage.jpg");
        }


        private void بازگشتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_currentexam frmreg = new frm_currentexam();
            frmreg.Enabled = true;
            frmreg.Visible = true;
            this.Close();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool cancel = false;

        private void لغوToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cancel = true;
        }

        private void lbl_side_Click(object sender, EventArgs e)
        {

        }

        private void frm_print_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                cancel = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
