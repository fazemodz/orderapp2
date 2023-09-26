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
            DGWAllOrders = new DataGridView();
            BtnAddNewOrder = new Button();
            btnRefreshData = new Button();
            btnDeleteOrder = new Button();
            cbIDTodelete = new ComboBox();
            btn_CloseAPP = new Button();
            ((System.ComponentModel.ISupportInitialize)DGWAllOrders).BeginInit();
            SuspendLayout();
            // 
            // DGWAllOrders
            // 
            DGWAllOrders.AllowUserToAddRows = false;
            DGWAllOrders.AllowUserToDeleteRows = false;
            DGWAllOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGWAllOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGWAllOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGWAllOrders.Location = new Point(220, 15);
            DGWAllOrders.Name = "DGWAllOrders";
            DGWAllOrders.ReadOnly = true;
            DGWAllOrders.RowTemplate.Height = 25;
            DGWAllOrders.ShowCellErrors = false;
            DGWAllOrders.ShowCellToolTips = false;
            DGWAllOrders.ShowEditingIcon = false;
            DGWAllOrders.ShowRowErrors = false;
            DGWAllOrders.Size = new Size(767, 423);
            DGWAllOrders.TabIndex = 3;
            // 
            // BtnAddNewOrder
            // 
            BtnAddNewOrder.Location = new Point(12, 39);
            BtnAddNewOrder.Name = "BtnAddNewOrder";
            BtnAddNewOrder.Size = new Size(190, 46);
            BtnAddNewOrder.TabIndex = 4;
            BtnAddNewOrder.Text = "Add new order";
            BtnAddNewOrder.UseVisualStyleBackColor = true;
            BtnAddNewOrder.Click += BtnAddNewOrder_Click;
            // 
            // btnRefreshData
            // 
            btnRefreshData.Location = new Point(12, 104);
            btnRefreshData.Name = "btnRefreshData";
            btnRefreshData.Size = new Size(190, 56);
            btnRefreshData.TabIndex = 5;
            btnRefreshData.Text = "Refresh data";
            btnRefreshData.UseVisualStyleBackColor = true;
            btnRefreshData.Click += btnRefreshData_Click;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Location = new Point(12, 179);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(188, 48);
            btnDeleteOrder.TabIndex = 6;
            btnDeleteOrder.Text = "Delete selected data";
            btnDeleteOrder.UseVisualStyleBackColor = true;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // cbIDTodelete
            // 
            cbIDTodelete.FormattingEnabled = true;
            cbIDTodelete.Location = new Point(12, 243);
            cbIDTodelete.Name = "cbIDTodelete";
            cbIDTodelete.Size = new Size(188, 23);
            cbIDTodelete.TabIndex = 7;
            cbIDTodelete.SelectedIndexChanged += cbIDTodelete_SelectedIndexChanged;
            // 
            // btn_CloseAPP
            // 
            btn_CloseAPP.Location = new Point(12, 375);
            btn_CloseAPP.Name = "btn_CloseAPP";
            btn_CloseAPP.Size = new Size(188, 46);
            btn_CloseAPP.TabIndex = 8;
            btn_CloseAPP.Text = "Exit";
            btn_CloseAPP.UseVisualStyleBackColor = true;
            btn_CloseAPP.Click += btn_CloseAPP_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 450);
            Controls.Add(btn_CloseAPP);
            Controls.Add(cbIDTodelete);
            Controls.Add(btnDeleteOrder);
            Controls.Add(btnRefreshData);
            Controls.Add(BtnAddNewOrder);
            Controls.Add(DGWAllOrders);
            MaximizeBox = false;
            MaximumSize = new Size(1027, 489);
            MinimumSize = new Size(1027, 489);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Delivery App";
            FormClosing += FormIsClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGWAllOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView DGWAllOrders;
        private Button BtnAddNewOrder;
        private Button btnRefreshData;
        private Button btnDeleteOrder;
        private ComboBox cbIDTodelete;
        private Button btn_CloseAPP;
    }
}