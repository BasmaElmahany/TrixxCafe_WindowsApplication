using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Trixx_CafeSystem
{
    public partial class frmMain : Form
    {
        private string _loggedInUserName;

        public frmMain(string loggedInUserName)
        {
            InitializeComponent();
            _loggedInUserName = loggedInUserName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog
            DialogResult result = MessageBox.Show("هل تريد تاكيد الخروج ؟؟", "تاكيد الخروج", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Exit the application
            }
            // If the user selects "No", do nothing and return to the application
        }
        
        private Size originalSize = new Size(922, 550);
        private Point originalLocation = new Point(0, 0);
        private Point originalExitButtonLocation;
        private Point originalMaximizeButtonLocation;
        private Point originalMinimizeButtonLocation;
        private bool isMaximized = false;
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                // Undo the maximization
                this.WindowState = FormWindowState.Normal; // Change the state to Normal
                this.Size = originalSize;
                this.Location = originalLocation;

                // Restore the original button positions
                btnExit.Location = originalExitButtonLocation;
                btnMax.Location = originalMaximizeButtonLocation;
                btnMin.Location = originalMinimizeButtonLocation;

                btnMax.Text = "تكبير";
                isMaximized = false;
            }
            else
            {
                // Store the original size, location, and button positions before maximizing
                originalSize = this.Size;
                originalLocation = this.Location;
                originalExitButtonLocation = btnExit.Location;
                originalMaximizeButtonLocation = btnMax.Location;
                originalMinimizeButtonLocation = btnMin.Location;

                // Maximize the form
                this.WindowState = FormWindowState.Maximized;

                // Move the buttons to a specific location when the form is maximized
                btnExit.Location = new Point(1100, 5);  // Example: move to (X, Y)
                btnMax.Location = new Point(1030, 5);   // Example: move to (X, Y)
                btnMin.Location = new Point(960, 5);    // Example: move to (X, Y)

                btnMax.Text = "عودة";
                isMaximized = true;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnModifyProfile_Click(object sender, EventArgs e)
        {
            // Open the Profile form and pass the logged -in username
            Profile profileForm = new Profile(_loggedInUserName);
            profileForm.ShowDialog(); // Show profile form as a dialog
        }
    }
}
