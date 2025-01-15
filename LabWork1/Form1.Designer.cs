namespace LabWork1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEnterSubtotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.Label();
            this.txtDiscountPercent = new System.Windows.Forms.Label();
            this.txtDiscountAmount = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.txtNumberOfInvoices = new System.Windows.Forms.Label();
            this.txtTotalOfInvoices = new System.Windows.Forms.Label();
            this.txtInvoiceAverage = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClearTotals = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Subtotal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subtotal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Discount Prcent";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Discount Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total";
            // 
            // txtEnterSubtotal
            // 
            this.txtEnterSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnterSubtotal.Location = new System.Drawing.Point(246, 82);
            this.txtEnterSubtotal.Name = "txtEnterSubtotal";
            this.txtEnterSubtotal.Size = new System.Drawing.Size(182, 34);
            this.txtEnterSubtotal.TabIndex = 5;
            this.txtEnterSubtotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Munber Of Invoices";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total of Invoices ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(487, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "Invoices Average";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.AutoSize = true;
            this.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubtotal.Location = new System.Drawing.Point(247, 126);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(3);
            this.txtSubtotal.MaximumSize = new System.Drawing.Size(182, 34);
            this.txtSubtotal.MinimumSize = new System.Drawing.Size(182, 34);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(182, 34);
            this.txtSubtotal.TabIndex = 15;
            this.txtSubtotal.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.AutoSize = true;
            this.txtDiscountPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscountPercent.Location = new System.Drawing.Point(247, 172);
            this.txtDiscountPercent.MaximumSize = new System.Drawing.Size(182, 34);
            this.txtDiscountPercent.MinimumSize = new System.Drawing.Size(182, 34);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.Size = new System.Drawing.Size(182, 34);
            this.txtDiscountPercent.TabIndex = 16;
            this.txtDiscountPercent.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.AutoSize = true;
            this.txtDiscountAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscountAmount.Location = new System.Drawing.Point(247, 214);
            this.txtDiscountAmount.MaximumSize = new System.Drawing.Size(182, 34);
            this.txtDiscountAmount.MinimumSize = new System.Drawing.Size(182, 34);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.Size = new System.Drawing.Size(182, 34);
            this.txtDiscountAmount.TabIndex = 17;
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Location = new System.Drawing.Point(247, 255);
            this.txtTotal.MaximumSize = new System.Drawing.Size(182, 34);
            this.txtTotal.MinimumSize = new System.Drawing.Size(182, 34);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(182, 34);
            this.txtTotal.TabIndex = 18;
            // 
            // txtNumberOfInvoices
            // 
            this.txtNumberOfInvoices.AutoSize = true;
            this.txtNumberOfInvoices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumberOfInvoices.Location = new System.Drawing.Point(695, 86);
            this.txtNumberOfInvoices.MaximumSize = new System.Drawing.Size(182, 34);
            this.txtNumberOfInvoices.MinimumSize = new System.Drawing.Size(182, 34);
            this.txtNumberOfInvoices.Name = "txtNumberOfInvoices";
            this.txtNumberOfInvoices.Size = new System.Drawing.Size(182, 34);
            this.txtNumberOfInvoices.TabIndex = 19;
            // 
            // txtTotalOfInvoices
            // 
            this.txtTotalOfInvoices.AutoSize = true;
            this.txtTotalOfInvoices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalOfInvoices.Location = new System.Drawing.Point(695, 137);
            this.txtTotalOfInvoices.MaximumSize = new System.Drawing.Size(182, 34);
            this.txtTotalOfInvoices.MinimumSize = new System.Drawing.Size(182, 34);
            this.txtTotalOfInvoices.Name = "txtTotalOfInvoices";
            this.txtTotalOfInvoices.Size = new System.Drawing.Size(182, 34);
            this.txtTotalOfInvoices.TabIndex = 20;
            this.txtTotalOfInvoices.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtInvoiceAverage
            // 
            this.txtInvoiceAverage.AutoSize = true;
            this.txtInvoiceAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceAverage.Location = new System.Drawing.Point(695, 188);
            this.txtInvoiceAverage.MaximumSize = new System.Drawing.Size(182, 34);
            this.txtInvoiceAverage.MinimumSize = new System.Drawing.Size(182, 34);
            this.txtInvoiceAverage.Name = "txtInvoiceAverage";
            this.txtInvoiceAverage.Size = new System.Drawing.Size(182, 34);
            this.txtInvoiceAverage.TabIndex = 21;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(470, 331);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(108, 33);
            this.btnCalculate.TabIndex = 22;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClearTotals
            // 
            this.btnClearTotals.Location = new System.Drawing.Point(609, 330);
            this.btnClearTotals.Name = "btnClearTotals";
            this.btnClearTotals.Size = new System.Drawing.Size(141, 33);
            this.btnClearTotals.TabIndex = 23;
            this.btnClearTotals.Text = "Clear Totals";
            this.btnClearTotals.UseVisualStyleBackColor = true;
            this.btnClearTotals.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(769, 331);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 33);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 416);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearTotals);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtInvoiceAverage);
            this.Controls.Add(this.txtTotalOfInvoices);
            this.Controls.Add(this.txtNumberOfInvoices);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEnterSubtotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEnterSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtSubtotal;
        private System.Windows.Forms.Label txtDiscountPercent;
        private System.Windows.Forms.Label txtDiscountAmount;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label txtNumberOfInvoices;
        private System.Windows.Forms.Label txtTotalOfInvoices;
        private System.Windows.Forms.Label txtInvoiceAverage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClearTotals;
        private System.Windows.Forms.Button btnExit;
    }
}

