using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace card
{
    public partial class frm_setting : Form
    {
        public frm_setting()
        {
            InitializeComponent();
        }

        private void frm_setting_Load(object sender, EventArgs e)
        {
            txt_date.Text = Properties.Settings.Default.date;
            //this.FormBorderStyle = FormBorderStyle.None;
            
            txt_exname.Text = Properties.Settings.Default.str_exname;
            txt_org.Text = Properties.Settings.Default.str_orgname;
            txt_year.Text = Properties.Settings.Default.str_year;
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
            Properties.Settings.Default.Save();
        }

        private void cmbo_logo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbo_logo.SelectedIndex == 0)
            {
                Properties.Settings.Default.logo = "سازمان سنجش";
                picb_logo.Image = Properties.Resources.سازمان_سنجش;
                picb_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (cmbo_logo.SelectedIndex == 1)
            {
                picb_logo.Image = Properties.Resources.تعاونی_سازمان_سنجش;
                picb_logo.SizeMode = PictureBoxSizeMode.StretchImage;
                Properties.Settings.Default.logo = "تعاونی سازمان سنجش";
            }
            Properties.Settings.Default.Save();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (cmbo_logo.SelectedIndex == 0)
            {
                Properties.Settings.Default.logo = "سازمان سنجش";
            }
            if (cmbo_logo.SelectedIndex == 1)
            {
                Properties.Settings.Default.logo = "تعاونی سازمان سنجش";
            }
            Properties.Settings.Default.date = txt_date.Text;
            Properties.Settings.Default.str_exname = txt_exname.Text;
            Properties.Settings.Default.str_orgname = txt_org.Text;
            Properties.Settings.Default.str_year = txt_year.Text;
            Properties.Settings.Default.Save();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new frm_view().Show();
            this.Visible = false;
            this.Enabled = false;
        }
    }
}
