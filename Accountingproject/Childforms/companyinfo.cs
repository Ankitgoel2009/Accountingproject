using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accountingproject.Helperclasses;
using Accountingproject.Childforms;

namespace Accountingproject.Childforms
{
    public partial class companyinfo : Form
    {
        public companyinfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel P = this.Parent as Panel;
            if (P != null)
            {
                
                login n = new login();
                opencloseformsinpanel.showfadedwindow(n, P);
            }
    }
    }
}
