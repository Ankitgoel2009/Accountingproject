using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accountingproject.Childforms;
using Accountingproject.Helperclasses;

namespace Accountingproject
{
    public partial class mainmaster : Form
    {
        public mainmaster()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void mainmaster_Load(object sender, EventArgs e)
        {
            companyinfo hm = new companyinfo();
            opencloseformsinpanel.showwindow(hm, panel1); // centre the companyinfo form
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
