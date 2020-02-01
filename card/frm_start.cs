using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace card
{
    public partial class Frm_start : Form
    {
        public Frm_start()
        {
            InitializeComponent();
        }

        private void Start_frm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            this.Refresh();
            Thread.Sleep(2500);
            this.Close();
        }
       
       
    }
}
