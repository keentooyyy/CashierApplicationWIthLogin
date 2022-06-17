namespace CashierApplication
{
    partial class frmPurchaseDiscountedItem
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
            this.ItemTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DiscountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.PaymentTexbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item:";
            // 
            // ItemTextbox
            // 
            this.ItemTextbox.Location = new System.Drawing.Point(23, 53);
            this.ItemTextbox.Name = "ItemTextbox";
            this.ItemTextbox.Size = new System.Drawing.Size(266, 26);
            this.ItemTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 22);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Discount (%)";
            // 
            // DiscountTextBox
            // 
            this.DiscountTextBox.Location = new System.Drawing.Point(302, 53);
            this.DiscountTextBox.Name = "DiscountTextBox";
            this.DiscountTextBox.Size = new System.Drawing.Size(136, 26);
            this.DiscountTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price:";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(75, 85);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(214, 26);
            this.PriceTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity:";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(370, 85);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(68, 26);
            this.QuantityTextBox.TabIndex = 7;
            // 
            // ComputeButton
            // 
            this.ComputeButton.Location = new System.Drawing.Point(171, 148);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(121, 37);
            this.ComputeButton.TabIndex = 8;
            this.ComputeButton.Text = "Compute";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Amount:";
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.AutoSize = true;
            this.TotalAmountLabel.Location = new System.Drawing.Point(217, 218);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(50, 18);
            this.TotalAmountLabel.TabIndex = 10;
            this.TotalAmountLabel.Text = "xxxxxx";
            // 
            // PaymentTexbox
            // 
            this.PaymentTexbox.Location = new System.Drawing.Point(169, 278);
            this.PaymentTexbox.Name = "PaymentTexbox";
            this.PaymentTexbox.Size = new System.Drawing.Size(168, 26);
            this.PaymentTexbox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Payment Received:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(343, 272);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(92, 36);
            this.SubmitButton.TabIndex = 13;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Change:";
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Location = new System.Drawing.Point(220, 341);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(57, 18);
            this.ChangeLabel.TabIndex = 15;
            this.ChangeLabel.Text = "xxxxxxx";
            // 
            // frmPurchaseDiscountedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 404);
            this.Controls.Add(this.ChangeLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PaymentTexbox);
            this.Controls.Add(this.TotalAmountLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DiscountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemTextbox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPurchaseDiscountedItem";
            this.Text = "Purchase Discounted Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ItemTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DiscountTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TotalAmountLabel;
        private System.Windows.Forms.TextBox PaymentTexbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ChangeLabel;
    }
}

