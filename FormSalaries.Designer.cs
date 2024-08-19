
namespace Trixx_CafeSystem
{
    partial class FormSalaries
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dvgSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgstrtBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dvgTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgEndBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dvgFinishTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgWage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgCalcWage = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dvgtotalWage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.Text = "الاجور";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgSno,
            this.dvgid,
            this.dvgName,
            this.dvgstrtBtn,
            this.dvgTime,
            this.dvgEndBtn,
            this.dvgFinishTime,
            this.dvgWage,
            this.dvgCalcWage,
            this.dvgtotalWage});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridView1.Location = new System.Drawing.Point(39, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(688, 333);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 5;
            // 
            // dvgSno
            // 
            this.dvgSno.HeaderText = "Sr#";
            this.dvgSno.Name = "dvgSno";
            this.dvgSno.ReadOnly = true;
            this.dvgSno.Width = 40;
            // 
            // dvgid
            // 
            this.dvgid.HeaderText = "الترتيب";
            this.dvgid.Name = "dvgid";
            this.dvgid.ReadOnly = true;
            this.dvgid.Visible = false;
            this.dvgid.Width = 20;
            // 
            // dvgName
            // 
            this.dvgName.HeaderText = "الاسم";
            this.dvgName.Name = "dvgName";
            this.dvgName.ReadOnly = true;
            // 
            // dvgstrtBtn
            // 
            this.dvgstrtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dvgstrtBtn.HeaderText = "أبدأ";
            this.dvgstrtBtn.Name = "dvgstrtBtn";
            this.dvgstrtBtn.ReadOnly = true;
            this.dvgstrtBtn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgstrtBtn.Width = 50;
            // 
            // dvgTime
            // 
            this.dvgTime.HeaderText = "بداية الشيفت";
            this.dvgTime.Name = "dvgTime";
            this.dvgTime.ReadOnly = true;
            // 
            // dvgEndBtn
            // 
            this.dvgEndBtn.HeaderText = "انتهاء";
            this.dvgEndBtn.Name = "dvgEndBtn";
            this.dvgEndBtn.ReadOnly = true;
            this.dvgEndBtn.Width = 50;
            // 
            // dvgFinishTime
            // 
            this.dvgFinishTime.HeaderText = "انتهاء الشيفت";
            this.dvgFinishTime.Name = "dvgFinishTime";
            this.dvgFinishTime.ReadOnly = true;
            // 
            // dvgWage
            // 
            this.dvgWage.HeaderText = "الاجرة في الساعة";
            this.dvgWage.Name = "dvgWage";
            this.dvgWage.ReadOnly = true;
            this.dvgWage.Width = 90;
            // 
            // dvgCalcWage
            // 
            this.dvgCalcWage.HeaderText = "احسب ";
            this.dvgCalcWage.Name = "dvgCalcWage";
            this.dvgCalcWage.ReadOnly = true;
            this.dvgCalcWage.Width = 50;
            // 
            // dvgtotalWage
            // 
            this.dvgtotalWage.HeaderText = "الاجرة اليومية";
            this.dvgtotalWage.Name = "dvgtotalWage";
            this.dvgtotalWage.ReadOnly = true;
            this.dvgtotalWage.Width = 60;
            // 
            // FormSalaries
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(777, 505);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormSalaries";
            this.Text = "FormSalaries";
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgName;
        private System.Windows.Forms.DataGridViewButtonColumn dvgstrtBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgTime;
        private System.Windows.Forms.DataGridViewButtonColumn dvgEndBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgFinishTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgWage;
        private System.Windows.Forms.DataGridViewButtonColumn dvgCalcWage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgtotalWage;
    }
}