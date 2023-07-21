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
        // open new form first time 
        public static void showwindow(Form openwin, Panel p)
        {
            openwin.TopLevel = false;
            p.Controls.Add(openwin);
            openwin.FormBorderStyle = FormBorderStyle.None;
            openwin.StartPosition = FormStartPosition.CenterParent;
            openwin.WindowState = FormWindowState.Maximized;
            openwin.Anchor = AnchorStyles.None;
            openwin.ControlBox = false;
            openwin.BringToFront();
            openwin.Show();
        }
       

        public static void showfadedwindow(Form openwin, Panel p  )
        {
            Form fadedform = new Form();
            fadedform.TopLevel = false;
            p.Controls.Add(fadedform);
            fadedform.FormBorderStyle = FormBorderStyle.None;
            fadedform.Opacity = 0.1;
            fadedform.TransparencyKey = Control.DefaultBackColor;
            // fadedform.BackColor = Color.LightPink;
            // fadedform.Size = p.Size;
            fadedform.WindowState = FormWindowState.Maximized;
            fadedform.ControlBox = false;
            // fadedform.Location = p.Location;
            fadedform.ShowInTaskbar = false;
            fadedform.BringToFront();           
            fadedform.Show();

            // form is added but no faded effect can be seen on companyinfo form 



            // now open login form over an above companyinfo form  but how ???
            // Calculate the X and Y coordinates for centering the form
            int x = (p.Width - openwin.Width) / 2;
            int y = (p.Height - openwin.Height) / 2;
            // Set the location of the form
             openwin.Location = new Point(x, y);
             openwin.FormBorderStyle = FormBorderStyle.None;
             openwin.WindowState = FormWindowState.Maximized;
             openwin.ControlBox = false;

        }

        // for subsequent uses when i have to close the current form, opens a new form inside the panel3   
        public static void showwindow(Form openwin, Form closewin, Panel p)
        {
            p.Controls.Remove(closewin);
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
