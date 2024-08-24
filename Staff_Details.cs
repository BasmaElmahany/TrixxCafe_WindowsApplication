using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trixx_CafeSystem
{
    public partial class Staff_Details : SampleAdd
    {
        private string _loggedInUserName;
        public event EventHandler StaffSaved;

        public Staff_Details(string loggedInUserName)
        {
            InitializeComponent();
            _loggedInUserName = loggedInUserName;
        }

        // Public properties to access the text boxes from outside if needed
        public TextBox TxtName => txtName;
        public TextBox TxtPhoneNumber => txtPhoneNumber;
        public TextBox TxtAddress => txtAddress;
        public TextBox TxtNID => txtNID;

        public int? StaffId { get; set; }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            string staffName = TxtName.Text.Trim();

            if (string.IsNullOrEmpty(staffName))
            {
                MessageBox.Show("من فضلك ادخل اسم صحيح", "خطأ");
                return;
            }

            using (var context = new Context())
            {
                // Assume _loggedInUserName is the username of the logged-in user.
                var user = context.Login_Users.FirstOrDefault(u => u.User_Name == _loggedInUserName);
                if (user == null)
                {
                    MessageBox.Show("المستخدم الحالي غير موجود.", "خطأ");
                    return;
                }

                if (StaffId.HasValue && StaffId.Value > 0)
                {
                    // Update existing staff
                    var existingStaff = context.Staffs.Find(StaffId.Value);
                    if (existingStaff != null)
                    {
                        // Update the staff fields
                        existingStaff.Staff_Name = TxtName.Text;
                        existingStaff.Staff_Phone = TxtPhoneNumber.Text;
                        existingStaff.NID = TxtNID.Text;
                        existingStaff.Address = TxtAddress.Text;
                        existingStaff.User_ID = user.User_ID; // Ensure the foreign key is set correctly
                        context.SaveChanges();

                        MessageBox.Show("تم تحديث بيانات الموظف بنجاح", "تم");
                    }
                    else
                    {
                        MessageBox.Show("لم يتم العثور على الموظف", "خطأ");
                    }
                }
                else
                {
                    // Add new staff
                    var newStaff = new Staff
                    {
                        Staff_Name = TxtName.Text,
                        Staff_Phone = TxtPhoneNumber.Text,
                        NID = TxtNID.Text,
                        Address = TxtAddress.Text,
                        User_ID = user.User_ID,
                        Assign_Date = DateTime.Now.Date// Ensure the foreign key is set correctly
                    };
                    context.Staffs.Add(newStaff);
                    context.SaveChanges();

                    MessageBox.Show("تم إضافة الموظف بنجاح", "تم");
                }
            }

            // Raise the StaffSaved event to notify that a staff record was added or updated
            StaffSaved?.Invoke(this, EventArgs.Empty);

            this.Close();
        }


        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
        }
    }
}