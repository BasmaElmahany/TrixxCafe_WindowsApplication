using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trixx_CafeSystem
{
    public partial class FormSalariesAdd : SampleAdd
    {
        private Context _context;
        private FormSalaries _formSalaries;

        public FormSalariesAdd(FormSalaries formSalaries)
        {
            InitializeComponent();
            _context = new Context();
            _formSalaries = formSalaries;
            LoadComboBoxData();
        }
        public int id = 0;
        public override void btnSave_Click(object sender, EventArgs e)
        {                                                           
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LoadComboBoxData()
        {
            var staffNames = _context.Staffs.OrderBy(c=>c.Staff_Name).ToList();
            comboBox1.DataSource = staffNames;
            comboBox1.DisplayMember = "Staff_Name";
            comboBox1.ValueMember = "Staff_ID";
            
        }
                  
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _context.Dispose();
            base.OnFormClosed(e);
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string selectedStaff_Name = (string)comboBox1.ValueMember;
            int selectedStaffId = (int)comboBox1.SelectedValue;
            _formSalaries.LoadData(selectedStaffId, selectedStaff_Name);
            MessageBox.Show("تم الحفظ بنجاح");
            this.Close();
        }
    }
}
