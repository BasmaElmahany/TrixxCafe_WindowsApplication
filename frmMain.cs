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
        private Control logoControl; 
        private Control welcomeLabelControl; 



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
            
            //Profile profileForm = new Profile(_loggedInUserName);
          //  profileForm.ShowDialog();

            lblTitle.Text = " بيانات الملف الشخصي";

            Profile profileForm = new Profile(_loggedInUserName);
            LoadFormIntoPanel(profileForm);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "لوحة التحكم";
            lblUsername.Text = "اسم المستخدم الحالي : " + _loggedInUserName;
            lblUsername.Font = new Font(lblUsername.Font.FontFamily, 10, FontStyle.Bold);

            logoControl = pictureBox9; 
            welcomeLabelControl = labelHome;  


        }
        private void LoadFormIntoPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            controlPanel.Controls.Clear();
            controlPanel.Controls.Add(form);
            form.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "لوحة التحكم"; // Update the label text to "Dashboard"
            controlPanel.Controls.Clear(); // Clear any current content in panel3
            controlPanel.Controls.Add(logoControl); // Re-add the logo control (PictureBox) to panel3
            controlPanel.Controls.Add(welcomeLabelControl);  // Re-add the welcome label to panel3
            logoControl.Show(); // Ensure the logo is visible
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "التصنيفات";
            SampleAdd categorysForm = new SampleAdd();
            LoadFormIntoPanel(categorysForm);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "طاقم العمل";
            Staff_Details staffForm = new Staff_Details();
            LoadFormIntoPanel(staffForm);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            lblTitle.Text = " التقارير";
            frmReports reportForm = new frmReports();
            LoadFormIntoPanel(reportForm);
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            lblTitle.Text = " الطلبات";
            frmPOS posForm = new frmPOS();
            LoadFormIntoPanel(posForm);
        }
    }
}
