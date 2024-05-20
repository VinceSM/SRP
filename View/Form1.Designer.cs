namespace SRP
{
    partial class Form1
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
            this.lblhoursWorked = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtHsWoked = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtNameEmp = new System.Windows.Forms.TextBox();
            this.lblNameEmployee = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.txtDetailsEmployee = new System.Windows.Forms.TextBox();
            this.lblHoursSalary = new System.Windows.Forms.Label();
            this.txtHsSalary = new System.Windows.Forms.TextBox();
            this.btnCalcSalary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblhoursWorked
            // 
            this.lblhoursWorked.AutoSize = true;
            this.lblhoursWorked.Location = new System.Drawing.Point(12, 84);
            this.lblhoursWorked.Name = "lblhoursWorked";
            this.lblhoursWorked.Size = new System.Drawing.Size(119, 16);
            this.lblhoursWorked.TabIndex = 0;
            this.lblhoursWorked.Text = "HOURS WORKED";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(353, 77);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(60, 16);
            this.lblSalary.TabIndex = 1;
            this.lblSalary.Text = "SALARY";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(12, 176);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(70, 16);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "POSITION";
            // 
            // txtHsWoked
            // 
            this.txtHsWoked.Location = new System.Drawing.Point(138, 78);
            this.txtHsWoked.Name = "txtHsWoked";
            this.txtHsWoked.Size = new System.Drawing.Size(149, 22);
            this.txtHsWoked.TabIndex = 3;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(138, 170);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(149, 22);
            this.txtPosition.TabIndex = 4;
            // 
            // txtNameEmp
            // 
            this.txtNameEmp.Location = new System.Drawing.Point(138, 31);
            this.txtNameEmp.Name = "txtNameEmp";
            this.txtNameEmp.Size = new System.Drawing.Size(149, 22);
            this.txtNameEmp.TabIndex = 5;
            // 
            // lblNameEmployee
            // 
            this.lblNameEmployee.AutoSize = true;
            this.lblNameEmployee.Location = new System.Drawing.Point(12, 37);
            this.lblNameEmployee.Name = "lblNameEmployee";
            this.lblNameEmployee.Size = new System.Drawing.Size(122, 16);
            this.lblNameEmployee.TabIndex = 6;
            this.lblNameEmployee.Text = "NAME EMPLOYEE";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(441, 71);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(100, 22);
            this.txtSalary.TabIndex = 7;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(402, 173);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(205, 23);
            this.btnSendEmail.TabIndex = 8;
            this.btnSendEmail.Text = "SEND EMAIL";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            // 
            // txtDetailsEmployee
            // 
            this.txtDetailsEmployee.Location = new System.Drawing.Point(248, 217);
            this.txtDetailsEmployee.Multiline = true;
            this.txtDetailsEmployee.Name = "txtDetailsEmployee";
            this.txtDetailsEmployee.ReadOnly = true;
            this.txtDetailsEmployee.Size = new System.Drawing.Size(474, 191);
            this.txtDetailsEmployee.TabIndex = 9;
            // 
            // lblHoursSalary
            // 
            this.lblHoursSalary.AutoSize = true;
            this.lblHoursSalary.Location = new System.Drawing.Point(12, 130);
            this.lblHoursSalary.Name = "lblHoursSalary";
            this.lblHoursSalary.Size = new System.Drawing.Size(112, 16);
            this.lblHoursSalary.TabIndex = 10;
            this.lblHoursSalary.Text = "HOURS SALARY";
            // 
            // txtHsSalary
            // 
            this.txtHsSalary.Location = new System.Drawing.Point(138, 124);
            this.txtHsSalary.Name = "txtHsSalary";
            this.txtHsSalary.Size = new System.Drawing.Size(149, 22);
            this.txtHsSalary.TabIndex = 11;
            // 
            // btnCalcSalary
            // 
            this.btnCalcSalary.Location = new System.Drawing.Point(402, 130);
            this.btnCalcSalary.Name = "btnCalcSalary";
            this.btnCalcSalary.Size = new System.Drawing.Size(205, 23);
            this.btnCalcSalary.TabIndex = 12;
            this.btnCalcSalary.Text = "CALCULATE SALARY";
            this.btnCalcSalary.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcSalary);
            this.Controls.Add(this.txtHsSalary);
            this.Controls.Add(this.lblHoursSalary);
            this.Controls.Add(this.txtDetailsEmployee);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblNameEmployee);
            this.Controls.Add(this.txtNameEmp);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtHsWoked);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblhoursWorked);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhoursWorked;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtHsWoked;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtNameEmp;
        private System.Windows.Forms.Label lblNameEmployee;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.TextBox txtDetailsEmployee;
        private System.Windows.Forms.Label lblHoursSalary;
        private System.Windows.Forms.TextBox txtHsSalary;
        private System.Windows.Forms.Button btnCalcSalary;
    }
}

