using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class MainControllClasses
    {
        public static void ShowControlss(System.Windows.Forms.Control control, System.Windows.Forms.Control cont)
        {
            cont.Controls.Clear();
            control.Dock = System.Windows.Forms.DockStyle.Fill;
            control.Focus();
            cont.Controls.Add(control);
        }
    }
}
