
namespace Trixx_CafeSystem
{
    partial class FormCheckOut
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.txtRecieved = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Size = new System.Drawing.Size(374, 98);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.button1, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(117, 26);
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.Text = "  تفاصيل الدفع";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Trixx_CafeSystem.Properties.Resources.checkout;
            this.pictureBox1.Location = new System.Drawing.Point(262, 12);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 289);
            this.panel2.Size = new System.Drawing.Size(374, 71);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(33, 17);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Location = new System.Drawing.Point(182, 17);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "مبلغ الدفع ";
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Enabled = false;
            this.txtBillAmount.Location = new System.Drawing.Point(206, 146);
            this.txtBillAmount.MaxLength = 100;
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(100, 26);
            this.txtBillAmount.TabIndex = 3;
            // 
            // txtRecieved
            // 
            this.txtRecieved.Location = new System.Drawing.Point(33, 146);
            this.txtRecieved.MaxLength = 100;
            this.txtRecieved.Name = "txtRecieved";
            this.txtRecieved.Size = new System.Drawing.Size(100, 26);
            this.txtRecieved.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "القيمة المدفوعة";
            // 
            // btnChange
            // 
            this.btnChange.Enabled = false;
            this.btnChange.Location = new System.Drawing.Point(206, 213);
            this.btnChange.MaxLength = 100;
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(100, 26);
            this.btnChange.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "الباقي";
            // 
            // FormCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 360);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRecieved);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBillAmount);
            this.Controls.Add(this.label2);
            this.Name = "FormCheckOut";
            this.Text = "FormCheckOut";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtBillAmount, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtRecieved, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnChange, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.TextBox txtRecieved;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox btnChange;
        private System.Windows.Forms.Label label4;
    }
}