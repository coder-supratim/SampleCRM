
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
            this.SuspendLayout();
            // 
            // frmNWProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmNWProducts";
            this.Text = "frmNWProducts";
            this.Load += new System.EventHandler(this.frmNWProducts_Load);
            this.ResumeLayout(false);

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            //this.lblProductName = new System.Windows.Forms.Label();
            //this.txtProductName = new System.Windows.Forms.TextBox();
            //this.lblSupplier = new System.Windows.Forms.Label();
            //this.txtSupplier = new System.Windows.Forms.TextBox();
            //this.lblUnitPrice = new System.Windows.Forms.Label();
            //this.txtUnitPrice = new System.Windows.Forms.TextBox();
            //this.lblSupplierContact = new System.Windows.Forms.Label();
            //this.txtSupplierContact = new System.Windows.Forms.TextBox();
        
            this.grpSearchProducts = new System.Windows.Forms.GroupBox();
          
            this.productDetail = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.rtfProductDetail = new System.Windows.Forms.RichTextBox();
            this.rtfSupplierDetail = new System.Windows.Forms.RichTextBox();
            this.grpSearchProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();

  

        //----------------------------------------
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1125, 738);
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
            this.btnReset.Location = new System.Drawing.Point(1025, 738);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 30);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            //this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // lblCompany
            // 
            //this.lblProductName.BackColor = System.Drawing.Color.AliceBlue;
            //this.lblProductName.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.lblProductName.Location = new System.Drawing.Point(20, 43);
            //this.lblProductName.Name = "lblProductName";
            //this.lblProductName.Size = new System.Drawing.Size(85, 23);
            //this.lblProductName.TabIndex = 1;
            //this.lblProductName.Text = "Product Name";
            //this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //// 
            //// txtCompany
            //// 
            //this.txtProductName.BackColor = System.Drawing.Color.White;
            //this.txtProductName.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.txtProductName.Location = new System.Drawing.Point(116, 43);
            //this.txtProductName.Name = "txtCompany";
            //this.txtProductName.Size = new System.Drawing.Size(150, 39);
            //this.txtProductName.TabIndex = 2;
            //this.txtProductName.TextChanged += new System.EventHandler(this.TxtCompany_TextChanged);
            //// 
            //// lblContact
            //// 
            //this.lblContact.BackColor = System.Drawing.Color.White;
            //this.lblContact.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.lblContact.Location = new System.Drawing.Point(20, 76);
            //this.lblContact.Name = "lblContact";
            //this.lblContact.Size = new System.Drawing.Size(85, 23);
            //this.lblContact.TabIndex = 1;
            //this.lblContact.Text = "Contact";
            //this.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //// 
            //// txtContact
            //// 
            //this.txtContact.BackColor = System.Drawing.Color.White;
            //this.txtContact.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.txtContact.Location = new System.Drawing.Point(116, 73);
            //this.txtContact.Name = "txtContact";
            //this.txtContact.Size = new System.Drawing.Size(150, 39);
            //this.txtContact.TabIndex = 2;
            //this.txtContact.TextChanged += new System.EventHandler(this.TxtContact_TextChanged);
            //// 
            //// lblCity
            ////// 
            //this.lblCity.BackColor = System.Drawing.Color.White;
            //this.lblCity.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.lblCity.Location = new System.Drawing.Point(20, 141);
            //this.lblCity.Name = "lblCity";
            //this.lblCity.Size = new System.Drawing.Size(85, 23);
            //this.lblCity.TabIndex = 1;
            //this.lblCity.Text = "City";
            //this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //// 
            //// txtCity
            //// 
            //this.txtCity.BackColor = System.Drawing.Color.White;
            //this.txtCity.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.txtCity.Location = new System.Drawing.Point(116, 141);
            //this.txtCity.Name = "txtCity";
            //this.txtCity.Size = new System.Drawing.Size(150, 39);
            //this.txtCity.TabIndex = 2;
            //this.txtCity.TextChanged += new System.EventHandler(this.TxtCity_TextChanged);
            //// 
            //// lblRegion
            //// 
            //this.lblRegion.BackColor = System.Drawing.Color.White;
            //this.lblRegion.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.lblRegion.Location = new System.Drawing.Point(20, 178);
            //this.lblRegion.Name = "lblRegion";
            //this.lblRegion.Size = new System.Drawing.Size(85, 23);
            //this.lblRegion.TabIndex = 1;
            //this.lblRegion.Text = "Region";
            //this.lblRegion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //// 
            //// cmbRegion
            //// 
            //this.cmbRegion.BackColor = System.Drawing.Color.White;
            //this.cmbRegion.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.cmbRegion.FormattingEnabled = true;
            //this.cmbRegion.Location = new System.Drawing.Point(116, 171);
            //this.cmbRegion.Name = "cmbRegion";
            //this.cmbRegion.Size = new System.Drawing.Size(150, 40);
            //this.cmbRegion.TabIndex = 3;
            //this.cmbRegion.SelectedIndexChanged += new System.EventHandler(this.CmbRegion_SelectedIndexChanged);
            //// 
            //// lblCountry
            //// 
            //this.lblCountry.BackColor = System.Drawing.Color.AliceBlue;
            //this.lblCountry.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.lblCountry.Location = new System.Drawing.Point(20, 205);
            //this.lblCountry.Name = "lblCountry";
            //this.lblCountry.Size = new System.Drawing.Size(85, 23);
            //this.lblCountry.TabIndex = 1;
            //this.lblCountry.Text = "Country";
            //this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //// 
            //// cmbCountry
            //// 
            //this.cmbCountry.BackColor = System.Drawing.Color.White;
            //this.cmbCountry.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.cmbCountry.FormattingEnabled = true;
            //this.cmbCountry.Location = new System.Drawing.Point(116, 204);
            //this.cmbCountry.Name = "cmbCountry";
            //this.cmbCountry.Size = new System.Drawing.Size(150, 40);
            //this.cmbCountry.TabIndex = 3;
            //this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.CmbCountry_SelectedIndexChanged);
            //// 
            // grpSearchCustomers
            // 
            //this.grpSearchCustomers.BackColor = System.Drawing.Color.White;
            //this.grpSearchCustomers.Controls.Add(this.txtCompany);
            //this.grpSearchCustomers.Controls.Add(this.cmbContactTitle);
            //this.grpSearchCustomers.Controls.Add(this.cmbCountry);
            //this.grpSearchCustomers.Controls.Add(this.lblCompany);
            //this.grpSearchCustomers.Controls.Add(this.cmbRegion);
            //this.grpSearchCustomers.Controls.Add(this.label1);
            //this.grpSearchCustomers.Controls.Add(this.lblContact);
            //this.grpSearchCustomers.Controls.Add(this.lblCountry);
            //this.grpSearchCustomers.Controls.Add(this.txtContact);
            //this.grpSearchCustomers.Controls.Add(this.txtCity);
            //this.grpSearchCustomers.Controls.Add(this.lblCity);
            //this.grpSearchCustomers.Controls.Add(this.lblRegion);
            //this.grpSearchCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            //this.grpSearchCustomers.Font = new System.Drawing.Font("Corbel", 9.75F);
            //this.grpSearchCustomers.Location = new System.Drawing.Point(12, 12);
            //this.grpSearchCustomers.Name = "grpSearchCustomers";
            //this.grpSearchCustomers.Size = new System.Drawing.Size(273, 250);
            //this.grpSearchCustomers.TabIndex = 4;
            //this.grpSearchCustomers.TabStop = false;
            //this.grpSearchCustomers.Text = "Search for Customers by Properties:";
            // 

            // 
            // dgvProducts
            // 
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProducts.Location = new System.Drawing.Point(307, 28);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 82;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(919, 250);
            this.dgvProducts.TabIndex = 5;
            //this.dgvProducts.SelectionChanged += new System.EventHandler(this.DgvCustomers_SelectionChanged);
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSuppliers.Location = new System.Drawing.Point(307, 313);
            this.dgvSuppliers.MultiSelect = false;
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.RowHeadersWidth = 82;
            this.dgvSuppliers.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.Size = new System.Drawing.Size(416, 250);
            this.dgvSuppliers.TabIndex = 5;
            //this.dgvSuppliers.SelectionChanged += new System.EventHandler(this.DgvOrders_SelectionChanged);
            // 
            // rtfProductDetail
            // 
            this.rtfProductDetail.Font = new System.Drawing.Font("Corbel", 11F);
            this.rtfProductDetail.Location = new System.Drawing.Point(12, 268);
            this.rtfProductDetail.Name = "rtfProductDetail";
            this.rtfProductDetail.Size = new System.Drawing.Size(273, 121);
            this.rtfProductDetail.TabIndex = 6;
            this.rtfProductDetail.Text = "";
            // 
            // rtfOrderInformation
            // 
            this.rtfSupplierDetail.BackColor = System.Drawing.SystemColors.Info;
            this.rtfSupplierDetail.Font = new System.Drawing.Font("Corbel", 11F);
            this.rtfSupplierDetail.Location = new System.Drawing.Point(752, 313);
            this.rtfSupplierDetail.Name = "rtfSupplierDetail";
            this.rtfSupplierDetail.Size = new System.Drawing.Size(273, 121);
            this.rtfSupplierDetail.TabIndex = 6;
            this.rtfSupplierDetail.Text = "";
            // 
            // frmNWProducts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1225, 800);
            this.Controls.Add(this.rtfSupplierDetail);
            this.Controls.Add(this.rtfProductDetail);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvSuppliers);
            this.Controls.Add(this.grpSearchProducts);
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
        //private System.Windows.Forms.Label lblProductName;
        //private System.Windows.Forms.TextBox txtProductName;
        //private System.Windows.Forms.Label lblSupplier;
        //private System.Windows.Forms.TextBox txtSupplier;
        //private System.Windows.Forms.Label lblUnitPrice;
        //private System.Windows.Forms.TextBox txtUnitPrice;
        //private System.Windows.Forms.Label lblSupplierContact;
        //private System.Windows.Forms.TextBox txtSupplierContact;
      
        private System.Windows.Forms.GroupBox grpSearchProducts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridView dgvSuppliers;

        private System.Windows.Forms.Label productDetail;
        private System.Windows.Forms.RichTextBox rtfProductDetail;
        private System.Windows.Forms.RichTextBox rtfSupplierDetail;
    }
}