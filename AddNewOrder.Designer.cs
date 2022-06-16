namespace orderapp2
{
    partial class AddNewOrder
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnSubmitOrderData = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 66);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(92, 15);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(133, 66);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 23);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(12, 97);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(104, 15);
            this.lblDistance.TabIndex = 2;
            this.lblDistance.Text = "Distance to deliver";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(133, 97);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 23);
            this.txtDistance.TabIndex = 3;
            this.txtDistance.TextChanged += new System.EventHandler(this.txtDistance_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 163);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 15);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Among us";
            // 
            // btnSubmitOrderData
            // 
            this.btnSubmitOrderData.Location = new System.Drawing.Point(12, 195);
            this.btnSubmitOrderData.Name = "btnSubmitOrderData";
            this.btnSubmitOrderData.Size = new System.Drawing.Size(308, 39);
            this.btnSubmitOrderData.TabIndex = 5;
            this.btnSubmitOrderData.Text = "Submit Data";
            this.btnSubmitOrderData.UseVisualStyleBackColor = true;
            this.btnSubmitOrderData.Click += new System.EventHandler(this.btnSubmitOrderData_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblError.Location = new System.Drawing.Point(12, 137);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(38, 15);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "label1";
            this.lblError.Visible = false;
            // 
            // AddNewOrder
            // 
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIsClosing);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 265);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSubmitOrderData);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.MaximizeBox = false;
            this.Name = "AddNewOrder";
            this.Text = "AddNewOrder";
            this.Load += new System.EventHandler(this.AddNewOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private Label lblDistance;
        private TextBox txtDistance;
        private Label lblTotal;
        private Button btnSubmitOrderData;
        private Label lblError;
    }
}