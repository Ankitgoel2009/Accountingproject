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
    public partial class selectcompany : Form
    {
        public selectcompany()
        {
            InitializeComponent();
        }

        private void selectcompany_Load(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int selectedValue = (int)comboBox1.SelectedIndex;

            //if (selectedValue == 0)
            //{
            //    Panel P = this.Parent as Panel;
            //    if (P != null)
            //    {
            //        // Open a new page for Company 1
            //        login company1Form = new login();
            //       opencloseformsinpanel.showwindow(company1Form, P);
            //    }
               
            //}
            //else if (selectedValue == 1)
            //{
            //    // Open a new page for Company 2 which has no loginpage 
            // //  Company2Form company2Form = new Company2Form();
            //  //  company2Form.Show();
            //}
        }
    }
}
