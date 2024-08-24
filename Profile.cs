using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trixx_CafeSystem
{
    public partial class Profile : Form
    {
        private  string _loggedInUserName;
        private readonly Context _context;
        public Profile(string loggedInUserName)
        {
            InitializeComponent();
            _context = new Context();
            _loggedInUserName = loggedInUserName;
            LoadUserData();
        }
        private void LoadUserData()
        {
            var user = _context.Login_Users.SingleOrDefault(u => u.User_Name == _loggedInUserName);
            if (user != null)
            {
                txtUserName.Text = user.User_Name;
                txtPassword.Text = user.Password;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string newUserName = txtUserName.Text;
            string newPassword = txtPassword.Text;

            // Perform validation
            if (newUserName.Length < 3)
            {
                MessageBox.Show("يجب أن يتكون اسم المستخدم من 3 أحرف على الأقل.", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidPassword(newPassword))
            {
                MessageBox.Show("يجب أن تحتوي كلمة المرور على حرف كبير واحد وحرف صغير واحد ورقم واحد وحرف خاص واحد على الأقل.", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var user = _context.Login_Users.SingleOrDefault(u => u.User_Name == _loggedInUserName);
            if (user != null)
            {
                user.User_Name = newUserName;
                user.Password = newPassword;
                _context.SaveChanges();
                _loggedInUserName = newUserName; // Update the logged-in username
                                                 // Ensure the MainForm is set as the Owner
                if (this.Owner is frmMain mainForm)
                {
                    mainForm.UpdateUsernameLabel(newUserName);
                }

                MessageBox.Show("تم تحديث الملف الشخصي بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
    
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog
            var result = MessageBox.Show("هل أنت متأكد أنك تريد حذف حسابك؟ لا يمكن التراجع عن هذا الإجراء.", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            // Check the user's response
            if (result == DialogResult.Yes)
            {
                var user = _context.Login_Users.SingleOrDefault(u => u.User_Name == _loggedInUserName);
                if (user != null)
                {
                    _context.Login_Users.Remove(user);
                    _context.SaveChanges();

                    MessageBox.Show("تم حذف المستخدم بنجاح. سيتم إغلاق التطبيق الآن.", "تم حذف المستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit(); // Exit the application
                }
            }
            else
            {
                // Show a message indicating that the delete operation was canceled
                MessageBox.Show("تم إلغاء حذف الحساب.", "تم إلغاء العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newUserName = txtUserName.Text;
            string newPassword = txtPassword.Text;

            // Validate input
            if (newUserName.Length < 3)
            {
                MessageBox.Show("يجب أن يتكون اسم المستخدم من 3 أحرف على الأقل.", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidPassword(newPassword))
            {
                MessageBox.Show("يجب أن تتكون كلمة المرور من 5 اجزاء على الأقل، وتحتوي على أرقام فقط بالإضافة إلى حرف واحد على الأقل.", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the username already exists
            var existingUser = _context.Login_Users.Any(u => u.User_Name == newUserName);
            if (existingUser)
            {
                MessageBox.Show("اسم المستخدم موجود بالفعل. الرجاء اختيار اسم مستخدم مختلف.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add new user
            var newUser = new Login_User
            {
                User_Name = newUserName,
                Password = newPassword
            };

            _context.Login_Users.Add(newUser);
            _context.SaveChanges();
            MessageBox.Show("تمت إضافة مستخدم جديد بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the input fields
            txtUserName.Clear();
            txtPassword.Clear();

        }
        private bool IsValidPassword(string password)
        {
            if (password.Length < 5) return false;

            bool hasLetter = false;
            bool hasOnlyDigitsAndLetters = true;

            foreach (char c in password)
            {
                if (char.IsLetter(c)) hasLetter = true;
                if (!char.IsLetterOrDigit(c)) hasOnlyDigitsAndLetters = false;
            }

            // The password should contain at least one letter and consist of only letters and digits
            return hasLetter && hasOnlyDigitsAndLetters;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the Profile form
            try
            {
                DialogResult result = RTLMessageBoxForm.Show("هل تريد الخروج ؟", "الخروج");
                if (result == DialogResult.Yes)
                {
                    this.Close(); // Close the current form
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception: {ex.Message}");
            }
        }


    }
}
