
namespace Employees_Salary
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblHrsWorked = new System.Windows.Forms.Label();
            this.lblEmpRank = new System.Windows.Forms.Label();
            this.lblDeductions = new System.Windows.Forms.Label();
            this.cbGSIS = new System.Windows.Forms.CheckBox();
            this.cbWithholdingTax = new System.Windows.Forms.CheckBox();
            this.cbPhilHealth = new System.Windows.Forms.CheckBox();
            this.cbPagibig = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalDeduction = new System.Windows.Forms.Label();
            this.lblLoanDetails = new System.Windows.Forms.Label();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.rbWithoutLoan = new System.Windows.Forms.RadioButton();
            this.rbWithLoan = new System.Windows.Forms.RadioButton();
            this.cbEmpRank = new System.Windows.Forms.ComboBox();
            this.tbEmpName = new System.Windows.Forms.TextBox();
            this.tbHrsWorked = new System.Windows.Forms.TextBox();
            this.tbGrossSalary = new System.Windows.Forms.TextBox();
            this.tbTtlDeductions = new System.Windows.Forms.TextBox();
            this.tbNetPay = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGrossSal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(12, 30);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(97, 15);
            this.lblEmpName.TabIndex = 0;
            this.lblEmpName.Text = "Employee Name:";
            // 
            // lblHrsWorked
            // 
            this.lblHrsWorked.AutoSize = true;
            this.lblHrsWorked.Location = new System.Drawing.Point(12, 57);
            this.lblHrsWorked.Name = "lblHrsWorked";
            this.lblHrsWorked.Size = new System.Drawing.Size(119, 15);
            this.lblHrsWorked.TabIndex = 1;
            this.lblHrsWorked.Text = "No of Hours Worked:";
            // 
            // lblEmpRank
            // 
            this.lblEmpRank.AutoSize = true;
            this.lblEmpRank.Location = new System.Drawing.Point(12, 92);
            this.lblEmpRank.Name = "lblEmpRank";
            this.lblEmpRank.Size = new System.Drawing.Size(91, 15);
            this.lblEmpRank.TabIndex = 2;
            this.lblEmpRank.Text = "Employee Rank:";
            // 
            // lblDeductions
            // 
            this.lblDeductions.AutoSize = true;
            this.lblDeductions.Location = new System.Drawing.Point(12, 155);
            this.lblDeductions.Name = "lblDeductions";
            this.lblDeductions.Size = new System.Drawing.Size(70, 15);
            this.lblDeductions.TabIndex = 4;
            this.lblDeductions.Text = "Deductions:";
            // 
            // cbGSIS
            // 
            this.cbGSIS.AutoSize = true;
            this.cbGSIS.Location = new System.Drawing.Point(20, 183);
            this.cbGSIS.Name = "cbGSIS";
            this.cbGSIS.Size = new System.Drawing.Size(120, 19);
            this.cbGSIS.TabIndex = 5;
            this.cbGSIS.Text = "GSIS Contribution";
            this.cbGSIS.UseVisualStyleBackColor = true;
            // 
            // cbWithholdingTax
            // 
            this.cbWithholdingTax.AutoSize = true;
            this.cbWithholdingTax.Location = new System.Drawing.Point(20, 219);
            this.cbWithholdingTax.Name = "cbWithholdingTax";
            this.cbWithholdingTax.Size = new System.Drawing.Size(123, 19);
            this.cbWithholdingTax.TabIndex = 6;
            this.cbWithholdingTax.Text = "Witholding Tax      ";
            this.cbWithholdingTax.UseVisualStyleBackColor = true;
            // 
            // cbPhilHealth
            // 
            this.cbPhilHealth.AutoSize = true;
            this.cbPhilHealth.Location = new System.Drawing.Point(220, 183);
            this.cbPhilHealth.Name = "cbPhilHealth";
            this.cbPhilHealth.Size = new System.Drawing.Size(94, 19);
            this.cbPhilHealth.TabIndex = 7;
            this.cbPhilHealth.Text = "PHILHEALTH";
            this.cbPhilHealth.UseVisualStyleBackColor = true;
            // 
            // cbPagibig
            // 
            this.cbPagibig.AutoSize = true;
            this.cbPagibig.Location = new System.Drawing.Point(220, 219);
            this.cbPagibig.Name = "cbPagibig";
            this.cbPagibig.Size = new System.Drawing.Size(74, 19);
            this.cbPagibig.TabIndex = 8;
            this.cbPagibig.Text = "PAG-IBIG";
            this.cbPagibig.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "P1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "10%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "P200";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "P300";
            // 
            // lblTotalDeduction
            // 
            this.lblTotalDeduction.AutoSize = true;
            this.lblTotalDeduction.Location = new System.Drawing.Point(12, 255);
            this.lblTotalDeduction.Name = "lblTotalDeduction";
            this.lblTotalDeduction.Size = new System.Drawing.Size(98, 15);
            this.lblTotalDeduction.TabIndex = 13;
            this.lblTotalDeduction.Text = "Total Deductions:";
            // 
            // lblLoanDetails
            // 
            this.lblLoanDetails.AutoSize = true;
            this.lblLoanDetails.Location = new System.Drawing.Point(12, 285);
            this.lblLoanDetails.Name = "lblLoanDetails";
            this.lblLoanDetails.Size = new System.Drawing.Size(74, 15);
            this.lblLoanDetails.TabIndex = 14;
            this.lblLoanDetails.Text = "Loan Details:";
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.Location = new System.Drawing.Point(12, 316);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(51, 15);
            this.lblNetPay.TabIndex = 15;
            this.lblNetPay.Text = "Net Pay:";
            // 
            // rbWithoutLoan
            // 
            this.rbWithoutLoan.AutoSize = true;
            this.rbWithoutLoan.Checked = true;
            this.rbWithoutLoan.Location = new System.Drawing.Point(3, 4);
            this.rbWithoutLoan.Name = "rbWithoutLoan";
            this.rbWithoutLoan.Size = new System.Drawing.Size(97, 19);
            this.rbWithoutLoan.TabIndex = 16;
            this.rbWithoutLoan.TabStop = true;
            this.rbWithoutLoan.Text = "Without Loan";
            this.rbWithoutLoan.UseVisualStyleBackColor = true;
            // 
            // rbWithLoan
            // 
            this.rbWithLoan.AutoSize = true;
            this.rbWithLoan.Location = new System.Drawing.Point(116, 4);
            this.rbWithLoan.Name = "rbWithLoan";
            this.rbWithLoan.Size = new System.Drawing.Size(79, 19);
            this.rbWithLoan.TabIndex = 17;
            this.rbWithLoan.TabStop = true;
            this.rbWithLoan.Text = "With Loan";
            this.rbWithLoan.UseVisualStyleBackColor = true;
            // 
            // cbEmpRank
            // 
            this.cbEmpRank.FormattingEnabled = true;
            this.cbEmpRank.Items.AddRange(new object[] {
            "Rank 1",
            "Rank 2",
            "Rank 3"});
            this.cbEmpRank.Location = new System.Drawing.Point(141, 89);
            this.cbEmpRank.Name = "cbEmpRank";
            this.cbEmpRank.Size = new System.Drawing.Size(173, 23);
            this.cbEmpRank.TabIndex = 18;
            // 
            // tbEmpName
            // 
            this.tbEmpName.Location = new System.Drawing.Point(141, 22);
            this.tbEmpName.Name = "tbEmpName";
            this.tbEmpName.Size = new System.Drawing.Size(173, 23);
            this.tbEmpName.TabIndex = 19;
            // 
            // tbHrsWorked
            // 
            this.tbHrsWorked.Location = new System.Drawing.Point(141, 54);
            this.tbHrsWorked.Name = "tbHrsWorked";
            this.tbHrsWorked.Size = new System.Drawing.Size(173, 23);
            this.tbHrsWorked.TabIndex = 20;
            // 
            // tbGrossSalary
            // 
            this.tbGrossSalary.Location = new System.Drawing.Point(141, 120);
            this.tbGrossSalary.Name = "tbGrossSalary";
            this.tbGrossSalary.ReadOnly = true;
            this.tbGrossSalary.Size = new System.Drawing.Size(173, 23);
            this.tbGrossSalary.TabIndex = 21;
            // 
            // tbTtlDeductions
            // 
            this.tbTtlDeductions.Location = new System.Drawing.Point(141, 252);
            this.tbTtlDeductions.Name = "tbTtlDeductions";
            this.tbTtlDeductions.ReadOnly = true;
            this.tbTtlDeductions.Size = new System.Drawing.Size(173, 23);
            this.tbTtlDeductions.TabIndex = 22;
            // 
            // tbNetPay
            // 
            this.tbNetPay.Location = new System.Drawing.Point(141, 313);
            this.tbNetPay.Name = "tbNetPay";
            this.tbNetPay.ReadOnly = true;
            this.tbNetPay.Size = new System.Drawing.Size(173, 23);
            this.tbNetPay.TabIndex = 23;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(20, 356);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Padding = new System.Windows.Forms.Padding(3);
            this.btnCompute.Size = new System.Drawing.Size(107, 33);
            this.btnCompute.TabIndex = 24;
            this.btnCompute.Text = "btn-&COMPUTE";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(133, 356);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(3);
            this.btnClear.Size = new System.Drawing.Size(116, 33);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "btn-CLEA&R";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(255, 356);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 33);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "btn-CLO&SE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbWithoutLoan);
            this.panel1.Controls.Add(this.rbWithLoan);
            this.panel1.Location = new System.Drawing.Point(119, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 26);
            this.panel1.TabIndex = 27;
            // 
            // lblGrossSal
            // 
            this.lblGrossSal.AutoSize = true;
            this.lblGrossSal.Location = new System.Drawing.Point(12, 123);
            this.lblGrossSal.Name = "lblGrossSal";
            this.lblGrossSal.Size = new System.Drawing.Size(73, 15);
            this.lblGrossSal.TabIndex = 28;
            this.lblGrossSal.Text = "Gross Salary:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 399);
            this.Controls.Add(this.lblGrossSal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.tbNetPay);
            this.Controls.Add(this.tbTtlDeductions);
            this.Controls.Add(this.tbGrossSalary);
            this.Controls.Add(this.tbHrsWorked);
            this.Controls.Add(this.tbEmpName);
            this.Controls.Add(this.cbEmpRank);
            this.Controls.Add(this.lblNetPay);
            this.Controls.Add(this.lblLoanDetails);
            this.Controls.Add(this.lblTotalDeduction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPagibig);
            this.Controls.Add(this.cbPhilHealth);
            this.Controls.Add(this.cbWithholdingTax);
            this.Controls.Add(this.cbGSIS);
            this.Controls.Add(this.lblDeductions);
            this.Controls.Add(this.lblEmpRank);
            this.Controls.Add(this.lblHrsWorked);
            this.Controls.Add(this.lblEmpName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblHrsWorked;
        private System.Windows.Forms.Label lblEmpRank;
        private System.Windows.Forms.Label lblGrossSalary;
        private System.Windows.Forms.Label lblDeductions;
        private System.Windows.Forms.CheckBox cbGSIS;
        private System.Windows.Forms.CheckBox cbWithholdingTax;
        private System.Windows.Forms.CheckBox cbPhilHealth;
        private System.Windows.Forms.CheckBox cbPagibig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalDeduction;
        private System.Windows.Forms.Label lblLoanDetails;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.RadioButton rbWithoutLoan;
        private System.Windows.Forms.RadioButton rbWithLoan;
        private System.Windows.Forms.ComboBox cbEmpRank;
        private System.Windows.Forms.TextBox tbEmpName;
        private System.Windows.Forms.TextBox tbHrsWorked;
        private System.Windows.Forms.TextBox tbGrossSalary;
        private System.Windows.Forms.TextBox tbTtlDeductions;
        private System.Windows.Forms.TextBox tbNetPay;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGrossSal;
    }
}

