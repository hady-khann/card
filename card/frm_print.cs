using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace card
{
    public partial class frm_print : Form
    {
        public frm_print()
        {
            InitializeComponent();
        }
        db_cardEntities dbmanager = new db_cardEntities();
        
        int min=0;
        int max=0;
        
        private void frm_print_Load(object sender, EventArgs e)
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







            if (Properties.Settings.Default.multiprint == true)
            {
                min = dbmanager.tbl_current.Min(x => x.id);
                max = dbmanager.tbl_current.Max(x => x.id);

                for (int i = min; i <= max; i++)
                {
                    if (cancel == false)
                    {
                        try
                        {
                            tbl_current tblc = dbmanager.tbl_current.FirstOrDefault(x => x.id == i);
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
                Properties.Settings.Default.multiprint = false;
                new frm_currentexam().Visible = true;
                new frm_currentexam().Enabled = true;
                this.Close();
            }



            if (Properties.Settings.Default.multiprint == false)
            {
                    if (cancel == false)
                    {

                        tbl_current tblc = dbmanager.tbl_current.FirstOrDefault(x => x.id == Properties.Settings.Default.id);
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

                        print();
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




            Properties.Settings.Default.multiprint = false;
            new frm_currentexam().Visible = true;
            new frm_currentexam().Enabled = true;
            this.Close();
        }





        public void print()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintImage);
            pd.Print();
        }

        private void PrintImage(object o, PrintPageEventArgs e)
        {
            
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int width = this.Width;
            int height = this.Height;

            Rectangle bounds = new Rectangle(x, y, width, height);

            Bitmap img = new Bitmap(width, height);

            //this.DrawToBitmap(bitmap, this.ClientRectangle);

            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
            img.Save(@"C:\latestimage.jpg");
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
    }
}
