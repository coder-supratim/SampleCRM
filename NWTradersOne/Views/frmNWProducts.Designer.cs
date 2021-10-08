
namespace NWTraders.Views
{
    partial class frmNWProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.txtTotalSales = new System.Windows.Forms.TextBox();
            this.lblSellerEmployee = new System.Windows.Forms.Label();
            this.txtSellerEmployee = new System.Windows.Forms.TextBox();
            this.lblSalesRegion = new System.Windows.Forms.Label();
            this.cmbSalesRegion = new System.Windows.Forms.ComboBox();
            this.lblDiscontinued = new System.Windows.Forms.Label();
            this.chkDiscontinued = new System.Windows.Forms.CheckBox();
            this.grpSearchProducts = new System.Windows.Forms.GroupBox();
            this.productDetail = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.rtfProductDetail = new System.Windows.Forms.RichTextBox();
            this.rtfSupplierDetail = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSearchProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1047, 738);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(939, 738);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 30);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.AliceBlue;
            this.lblProductName.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(24, 43);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(121, 23);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.White;
            this.txtProductName.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(166, 43);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(150, 27);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.TextChanged += new System.EventHandler(this.TxtProductName_TextChanged);
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.BackColor = System.Drawing.Color.AliceBlue;
            this.lblTotalSales.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.Location = new System.Drawing.Point(60, 87);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(85, 23);
            this.lblTotalSales.TabIndex = 1;
            this.lblTotalSales.Text = "Total Sales";
            this.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.BackColor = System.Drawing.Color.White;
            this.txtTotalSales.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSales.Location = new System.Drawing.Point(166, 86);
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.Size = new System.Drawing.Size(150, 27);
            this.txtTotalSales.TabIndex = 2;
            this.txtTotalSales.TextChanged += new System.EventHandler(this.TxtTotalSales_TextChanged);
            // 
            // lblSellerEmployee
            // 
            this.lblSellerEmployee.BackColor = System.Drawing.Color.AliceBlue;
            this.lblSellerEmployee.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerEmployee.Location = new System.Drawing.Point(24, 127);
            this.lblSellerEmployee.Name = "lblSellerEmployee";
            this.lblSellerEmployee.Size = new System.Drawing.Size(121, 27);
            this.lblSellerEmployee.TabIndex = 1;
            this.lblSellerEmployee.Text = "Seller Employee";
            this.lblSellerEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSellerEmployee
            // 
            this.txtSellerEmployee.BackColor = System.Drawing.Color.White;
            this.txtSellerEmployee.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellerEmployee.Location = new System.Drawing.Point(166, 127);
            this.txtSellerEmployee.Name = "txtSellerEmployee";
            this.txtSellerEmployee.Size = new System.Drawing.Size(150, 27);
            this.txtSellerEmployee.TabIndex = 2;
            // 
            // lblSalesRegion
            // 
            this.lblSalesRegion.BackColor = System.Drawing.Color.AliceBlue;
            this.lblSalesRegion.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesRegion.Location = new System.Drawing.Point(20, 178);
            this.lblSalesRegion.Name = "lblSalesRegion";
            this.lblSalesRegion.Size = new System.Drawing.Size(125, 23);
            this.lblSalesRegion.TabIndex = 1;
            this.lblSalesRegion.Text = "Region of Sales";
            this.lblSalesRegion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbSalesRegion
            // 
            this.cmbSalesRegion.BackColor = System.Drawing.Color.White;
            this.cmbSalesRegion.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSalesRegion.FormattingEnabled = true;
            this.cmbSalesRegion.Location = new System.Drawing.Point(166, 174);
            this.cmbSalesRegion.Name = "cmbSalesRegion";
            this.cmbSalesRegion.Size = new System.Drawing.Size(150, 27);
            this.cmbSalesRegion.TabIndex = 3;
            this.cmbSalesRegion.SelectedIndexChanged += new System.EventHandler(this.CmbSalesRegion_SelectedIndexChanged);
            // 
            // lblDiscontinued
            // 
            this.lblDiscontinued.BackColor = System.Drawing.Color.AliceBlue;
            this.lblDiscontinued.Location = new System.Drawing.Point(24, 218);
            this.lblDiscontinued.Name = "lblDiscontinued";
            this.lblDiscontinued.Size = new System.Drawing.Size(124, 23);
            this.lblDiscontinued.TabIndex = 5;
            this.lblDiscontinued.Text = "Active Product";
            // 
            // chkDiscontinued
            // 
            this.chkDiscontinued.Location = new System.Drawing.Point(166, 217);
            this.chkDiscontinued.Name = "chkDiscontinued";
            this.chkDiscontinued.Size = new System.Drawing.Size(29, 24);
            this.chkDiscontinued.TabIndex = 4;
            this.chkDiscontinued.CheckedChanged += new System.EventHandler(this.chkDiscontinued_CheckedChanged);
            // 
            // grpSearchProducts
            // 
            this.grpSearchProducts.BackColor = System.Drawing.Color.White;
            this.grpSearchProducts.Controls.Add(this.txtProductName);
            this.grpSearchProducts.Controls.Add(this.lblProductName);
            this.grpSearchProducts.Controls.Add(this.txtSellerEmployee);
            this.grpSearchProducts.Controls.Add(this.lblSellerEmployee);
            this.grpSearchProducts.Controls.Add(this.txtTotalSales);
            this.grpSearchProducts.Controls.Add(this.lblTotalSales);
            this.grpSearchProducts.Controls.Add(this.cmbSalesRegion);
            this.grpSearchProducts.Controls.Add(this.lblSalesRegion);
            this.grpSearchProducts.Controls.Add(this.chkDiscontinued);
            this.grpSearchProducts.Controls.Add(this.lblDiscontinued);
            this.grpSearchProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpSearchProducts.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.grpSearchProducts.Location = new System.Drawing.Point(12, 28);
            this.grpSearchProducts.Name = "grpSearchProducts";
            this.grpSearchProducts.Size = new System.Drawing.Size(341, 250);
            this.grpSearchProducts.TabIndex = 4;
            this.grpSearchProducts.TabStop = false;
            this.grpSearchProducts.Text = "Search your favourite products:";
            // 
            // productDetail
            // 
            this.productDetail.Location = new System.Drawing.Point(0, 0);
            this.productDetail.Name = "productDetail";
            this.productDetail.Size = new System.Drawing.Size(100, 23);
            this.productDetail.TabIndex = 0;
            // 
            // dgvProducts
            // 
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProducts.Location = new System.Drawing.Point(380, 28);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 82;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(752, 250);
            this.dgvProducts.TabIndex = 5;
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.DgvProduct_SelectionChanged);
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSuppliers.Location = new System.Drawing.Point(371, 313);
            this.dgvSuppliers.MultiSelect = false;
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.RowHeadersWidth = 82;
            this.dgvSuppliers.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.Size = new System.Drawing.Size(416, 250);
            this.dgvSuppliers.TabIndex = 5;
            // 
            // rtfProductDetail
            // 
            this.rtfProductDetail.Font = new System.Drawing.Font("Corbel", 11F);
            this.rtfProductDetail.Location = new System.Drawing.Point(12, 313);
            this.rtfProductDetail.Name = "rtfProductDetail";
            this.rtfProductDetail.Size = new System.Drawing.Size(273, 250);
            this.rtfProductDetail.TabIndex = 6;
            this.rtfProductDetail.Text = "";
            // 
            // rtfSupplierDetail
            // 
            this.rtfSupplierDetail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtfSupplierDetail.Font = new System.Drawing.Font("Corbel", 11F);
            this.rtfSupplierDetail.Location = new System.Drawing.Point(380, 313);
            this.rtfSupplierDetail.Name = "rtfSupplierDetail";
            this.rtfSupplierDetail.Size = new System.Drawing.Size(451, 250);
            this.rtfSupplierDetail.TabIndex = 6;
            this.rtfSupplierDetail.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Supplier Info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmNWProducts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1183, 800);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtfSupplierDetail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtfProductDetail);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.grpSearchProducts);
            this.Controls.Add(this.dgvSuppliers);

            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNWProducts";
            this.Text = "Northwind Traders Inc. Product Page";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grpSearchProducts.ResumeLayout(false);
            this.grpSearchProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblSellerEmployee;
        private System.Windows.Forms.TextBox txtSellerEmployee;
        private System.Windows.Forms.Label lblSalesRegion;
        private System.Windows.Forms.ComboBox cmbSalesRegion;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.TextBox txtTotalSales;
        private System.Windows.Forms.Label lblDiscontinued;
        private System.Windows.Forms.CheckBox chkDiscontinued;

        private System.Windows.Forms.GroupBox grpSearchProducts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridView dgvSuppliers;

        private System.Windows.Forms.Label productDetail;
        private System.Windows.Forms.RichTextBox rtfProductDetail;
        private System.Windows.Forms.RichTextBox rtfSupplierDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}