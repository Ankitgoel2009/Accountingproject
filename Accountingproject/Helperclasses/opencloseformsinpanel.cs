using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accountingproject.Helperclasses
{
    class opencloseformsinpanel
    {
        // first time use 
        public static void showwindow(Form openwin, Panel p)
        {
            openwin.TopLevel = false;
            p.Controls.Add(openwin);
            // Calculate the X and Y coordinates for centering the form
            int x = (p.Width - openwin.Width) / 2;
            int y = (p.Height - openwin.Height) / 2;
            // Set the location of the form
            openwin.Location = new Point(x, y);
            openwin.FormBorderStyle = FormBorderStyle.None;
            openwin.StartPosition = FormStartPosition.CenterParent;
            openwin.Anchor = AnchorStyles.None;
            openwin.ControlBox = false;
            openwin.BringToFront();
            openwin.Show();
        }
        // for subsequent uses when i have to close the current form, opens a new form inside the panel3   


        public static void showwindow(Form openwin, Form closewin, Panel p)
        {
            closewin.Close();
            openwin.TopLevel = false;
            p.Controls.Add(openwin);
            openwin.FormBorderStyle = FormBorderStyle.None;
            openwin.WindowState = FormWindowState.Maximized;
            openwin.ControlBox = false;
            openwin.BringToFront();
            openwin.Show();
        }
    }
}
