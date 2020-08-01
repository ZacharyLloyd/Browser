using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star_Wars_Browser
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void LoadWebsite_Click(object sender, EventArgs e)
        {
            Browser.Navigate(URL.Text);
            Browser.ScriptErrorsSuppressed = true;
        }
    }
}
