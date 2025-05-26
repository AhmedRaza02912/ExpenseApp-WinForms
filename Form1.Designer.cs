namespace ExpenseApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Amountlabel = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.Datelabel = new System.Windows.Forms.Label();
            this.Categorylabel = new System.Windows.Forms.Label();
            this.Monthlabel = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.Yearlabel = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.Paymentlabel = new System.Windows.Forms.Label();
            this.cmbPaymentVia = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Amountlabel
            // 
            this.Amountlabel.AutoSize = true;
            this.Amountlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Amountlabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amountlabel.Location = new System.Drawing.Point(38, 86);
            this.Amountlabel.Name = "Amountlabel";
            this.Amountlabel.Size = new System.Drawing.Size(103, 37);
            this.Amountlabel.TabIndex = 0;
            this.Amountlabel.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(241, 86);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(183, 37);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.TextChanged += new System.EventHandler(this.AmountTbox_TextChanged);
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(743, 86);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(183, 37);
            this.txtDate.TabIndex = 2;
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Datelabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel.Location = new System.Drawing.Point(618, 86);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(71, 37);
            this.Datelabel.TabIndex = 2;
            this.Datelabel.Text = "Date";
            // 
            // Categorylabel
            // 
            this.Categorylabel.AutoSize = true;
            this.Categorylabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Categorylabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categorylabel.Location = new System.Drawing.Point(38, 324);
            this.Categorylabel.Name = "Categorylabel";
            this.Categorylabel.Size = new System.Drawing.Size(120, 37);
            this.Categorylabel.TabIndex = 5;
            this.Categorylabel.Text = "Category";
            // 
            // Monthlabel
            // 
            this.Monthlabel.AutoSize = true;
            this.Monthlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Monthlabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monthlabel.Location = new System.Drawing.Point(618, 324);
            this.Monthlabel.Name = "Monthlabel";
            this.Monthlabel.Size = new System.Drawing.Size(89, 37);
            this.Monthlabel.TabIndex = 7;
            this.Monthlabel.Text = "Month";
            // 
            // cmbMonth
            // 
            this.cmbMonth.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(743, 324);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(183, 37);
            this.cmbMonth.TabIndex = 6;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Food",
            "Transport",
            "Cheez",
            "CUI ",
            "Other"});
            this.cmbCategory.Location = new System.Drawing.Point(241, 324);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(183, 37);
            this.cmbCategory.TabIndex = 5;
            // 
            // Yearlabel
            // 
            this.Yearlabel.AutoSize = true;
            this.Yearlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Yearlabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yearlabel.Location = new System.Drawing.Point(618, 191);
            this.Yearlabel.Name = "Yearlabel";
            this.Yearlabel.Size = new System.Drawing.Size(70, 37);
            this.Yearlabel.TabIndex = 10;
            this.Yearlabel.Text = "Year";
            // 
            // cmbYear
            // 
            this.cmbYear.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2025",
            "2026",
            "2027"});
            this.cmbYear.Location = new System.Drawing.Point(743, 191);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(183, 37);
            this.cmbYear.TabIndex = 4;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // Paymentlabel
            // 
            this.Paymentlabel.AutoSize = true;
            this.Paymentlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Paymentlabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paymentlabel.Location = new System.Drawing.Point(38, 192);
            this.Paymentlabel.Name = "Paymentlabel";
            this.Paymentlabel.Size = new System.Drawing.Size(158, 37);
            this.Paymentlabel.TabIndex = 12;
            this.Paymentlabel.Text = "Payment Via";
            // 
            // cmbPaymentVia
            // 
            this.cmbPaymentVia.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentVia.FormattingEnabled = true;
            this.cmbPaymentVia.Items.AddRange(new object[] {
            "Cash",
            "Easy Paisa"});
            this.cmbPaymentVia.Location = new System.Drawing.Point(241, 192);
            this.cmbPaymentVia.Name = "cmbPaymentVia";
            this.cmbPaymentVia.Size = new System.Drawing.Size(183, 37);
            this.cmbPaymentVia.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.Location = new System.Drawing.Point(433, 648);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(228, 47);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 812);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbPaymentVia);
            this.Controls.Add(this.Paymentlabel);
            this.Controls.Add(this.Yearlabel);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.Monthlabel);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.Categorylabel);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.Amountlabel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Amountlabel;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.Label Categorylabel;
        private System.Windows.Forms.Label Monthlabel;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label Yearlabel;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label Paymentlabel;
        private System.Windows.Forms.ComboBox cmbPaymentVia;
        private System.Windows.Forms.Button btnSubmit;
    }
}

