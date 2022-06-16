using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace orderapp2
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
            this.DGWAllOrders = new System.Windows.Forms.DataGridView();
            this.BtnAddNewOrder = new System.Windows.Forms.Button();
            this.btnRefreshData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGWAllOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // DGWAllOrders
            // 
            this.DGWAllOrders.AllowUserToAddRows = false;
            this.DGWAllOrders.AllowUserToDeleteRows = false;
            this.DGWAllOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGWAllOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGWAllOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWAllOrders.Location = new System.Drawing.Point(220, 15);
            this.DGWAllOrders.Name = "DGWAllOrders";
            this.DGWAllOrders.ReadOnly = true;
            this.DGWAllOrders.RowTemplate.Height = 25;
            this.DGWAllOrders.ShowCellErrors = false;
            this.DGWAllOrders.ShowCellToolTips = false;
            this.DGWAllOrders.ShowEditingIcon = false;
            this.DGWAllOrders.ShowRowErrors = false;
            this.DGWAllOrders.Size = new System.Drawing.Size(767, 353);
            this.DGWAllOrders.TabIndex = 3;
            // 
            // BtnAddNewOrder
            // 
            this.BtnAddNewOrder.Location = new System.Drawing.Point(12, 39);
            this.BtnAddNewOrder.Name = "BtnAddNewOrder";
            this.BtnAddNewOrder.Size = new System.Drawing.Size(190, 46);
            this.BtnAddNewOrder.TabIndex = 4;
            this.BtnAddNewOrder.Text = "Add new order";
            this.BtnAddNewOrder.UseVisualStyleBackColor = true;
            this.BtnAddNewOrder.Click += new System.EventHandler(this.BtnAddNewOrder_Click);
            // 
            // btnRefreshData
            // 
            this.btnRefreshData.Location = new System.Drawing.Point(12, 371);
            this.btnRefreshData.Name = "btnRefreshData";
            this.btnRefreshData.Size = new System.Drawing.Size(190, 23);
            this.btnRefreshData.TabIndex = 5;
            this.btnRefreshData.Text = "Refresh data";
            this.btnRefreshData.UseVisualStyleBackColor = true;
            this.btnRefreshData.Click += new System.EventHandler(this.btnRefreshData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 450);
            this.Controls.Add(this.btnRefreshData);
            this.Controls.Add(this.BtnAddNewOrder);
            this.Controls.Add(this.DGWAllOrders);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1027, 489);
            this.MinimumSize = new System.Drawing.Size(1027, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGWAllOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView DGWAllOrders;
        private Button BtnAddNewOrder;
        private Button btnRefreshData;
    }
}