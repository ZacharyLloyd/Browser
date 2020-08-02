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
        
        string m_homePage = "https://starwars.fandom.com/wiki/Timeline_of_galactic_history";
        public FormMain()
        {
            InitializeComponent();
            //Set the background image
            this.BackgroundImage = Properties.Resources.JediLibrary;
            //Automatically take the user to home page when Form is Initialized
            Browser.Navigate(m_homePage);
            //Used to disable any JavaScript or HTML errors a webpage so the user does not see them
            Browser.ScriptErrorsSuppressed = true;
        }

        private void LoadWebsite_Click(object sender, EventArgs e)
        {
            //Have the browser window navigate to the text in the url text box
            Browser.Navigate(URL.Text);
            //Used to disable any JavaScript or HTML errors a webpage so the user does not see them
            Browser.ScriptErrorsSuppressed = true;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            //Set the URL text box text equal to the home page string
            URL.Text = m_homePage;
            //Have the browser window navigate to the text in the url text box
            Browser.Navigate(URL.Text);
            //Used to disable any JavaScript or HTML errors a webpage so the user does not see them
            Browser.ScriptErrorsSuppressed = true;
        }
    }
}
