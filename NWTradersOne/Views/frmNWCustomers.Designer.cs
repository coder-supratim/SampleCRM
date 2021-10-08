namespace NWTraders.Views
{
    partial class frmNWCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.cmbRegion = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.grpSearchCustomers = new System.Windows.Forms.GroupBox();
            this.cmbContactTitle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.rtfCustomerInformation = new System.Windows.Forms.RichTextBox();
            this.rtfOrderInformation = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpSearchCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
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
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // lblCompany
            // 
            this.lblCompany.BackColor = System.Drawing.Color.AliceBlue;
            this.lblCompany.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(20, 43);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(85, 23);
            this.lblCompany.TabIndex = 1;
            this.lblCompany.Text = "Company";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCompany
            // 
            this.txtCompany.BackColor = System.Drawing.Color.White;
            this.txtCompany.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.Location = new System.Drawing.Point(116, 43);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(150, 27);
            this.txtCompany.TabIndex = 2;
            this.txtCompany.TextChanged += new System.EventHandler(this.TxtCompany_TextChanged);
            // 
            // lblContact
            // 
            this.lblContact.BackColor = System.Drawing.Color.AliceBlue;
            this.lblContact.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(20, 76);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(85, 23);
            this.lblContact.TabIndex = 1;
            this.lblContact.Text = "Contact";
            this.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.Color.White;
            this.txtContact.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(116, 73);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(150, 27);
            this.txtContact.TabIndex = 2;
            this.txtContact.TextChanged += new System.EventHandler(this.TxtContact_TextChanged);
            // 
            // lblCity
            // 
            this.lblCity.BackColor = System.Drawing.Color.AliceBlue;
            this.lblCity.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(20, 141);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(85, 23);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.White;
            this.txtCity.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(116, 141);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(150, 27);
            this.txtCity.TabIndex = 2;
            this.txtCity.TextChanged += new System.EventHandler(this.TxtCity_TextChanged);
            // 
            // lblRegion
            // 
            this.lblRegion.BackColor = System.Drawing.Color.AliceBlue;
            this.lblRegion.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegion.Location = new System.Drawing.Point(20, 178);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(85, 23);
            this.lblRegion.TabIndex = 1;
            this.lblRegion.Text = "Region";
            this.lblRegion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbRegion
            // 
            this.cmbRegion.BackColor = System.Drawing.Color.White;
            this.cmbRegion.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Location = new System.Drawing.Point(116, 171);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(150, 27);
            this.cmbRegion.TabIndex = 3;
            this.cmbRegion.SelectedIndexChanged += new System.EventHandler(this.CmbRegion_SelectedIndexChanged);
            // 
            // lblCountry
            // 
            this.lblCountry.BackColor = System.Drawing.Color.AliceBlue;
            this.lblCountry.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(20, 205);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(85, 23);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "Country";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCountry
            // 
            this.cmbCountry.BackColor = System.Drawing.Color.White;
            this.cmbCountry.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(116, 204);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(150, 27);
            this.cmbCountry.TabIndex = 3;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.CmbCountry_SelectedIndexChanged);
            // 
            // grpSearchCustomers
            // 
            this.grpSearchCustomers.BackColor = System.Drawing.Color.White;
            this.grpSearchCustomers.Controls.Add(this.txtCompany);
            this.grpSearchCustomers.Controls.Add(this.cmbContactTitle);
            this.grpSearchCustomers.Controls.Add(this.cmbCountry);
            this.grpSearchCustomers.Controls.Add(this.lblCompany);
            this.grpSearchCustomers.Controls.Add(this.cmbRegion);
            this.grpSearchCustomers.Controls.Add(this.label1);
            this.grpSearchCustomers.Controls.Add(this.lblContact);
            this.grpSearchCustomers.Controls.Add(this.lblCountry);
            this.grpSearchCustomers.Controls.Add(this.txtContact);
            this.grpSearchCustomers.Controls.Add(this.txtCity);
            this.grpSearchCustomers.Controls.Add(this.lblCity);
            this.grpSearchCustomers.Controls.Add(this.lblRegion);
            this.grpSearchCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpSearchCustomers.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.grpSearchCustomers.Location = new System.Drawing.Point(12, 12);
            this.grpSearchCustomers.Name = "grpSearchCustomers";
            this.grpSearchCustomers.Size = new System.Drawing.Size(273, 250);
            this.grpSearchCustomers.TabIndex = 4;
            this.grpSearchCustomers.TabStop = false;
            this.grpSearchCustomers.Text = "Search for Customers by Properties:";
            // 
            // cmbContactTitle
            // 
            this.cmbContactTitle.BackColor = System.Drawing.Color.White;
            this.cmbContactTitle.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbContactTitle.FormattingEnabled = true;
            this.cmbContactTitle.Location = new System.Drawing.Point(116, 105);
            this.cmbContactTitle.Name = "cmbContactTitle";
            this.cmbContactTitle.Size = new System.Drawing.Size(150, 27);
            this.cmbContactTitle.TabIndex = 3;
            this.cmbContactTitle.SelectedIndexChanged += new System.EventHandler(this.CmbContactTitle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contact Title";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCustomers.Location = new System.Drawing.Point(307, 28);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 82;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.dgvCustomers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(919, 250);
            this.dgvCustomers.TabIndex = 5;
            this.dgvCustomers.SelectionChanged += new System.EventHandler(this.DgvCustomers_SelectionChanged);
            // 
            // dgvOrders
            // 
            this.dgvOrders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOrders.Location = new System.Drawing.Point(307, 313);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 82;
            this.dgvOrders.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(416, 250);
            this.dgvOrders.TabIndex = 5;
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.DgvOrders_SelectionChanged);
            // 
            // rtfCustomerInformation
            // 
            this.rtfCustomerInformation.Font = new System.Drawing.Font("Corbel", 11F);
            this.rtfCustomerInformation.Location = new System.Drawing.Point(16, 313);
            this.rtfCustomerInformation.Name = "rtfCustomerInformation";
            this.rtfCustomerInformation.Size = new System.Drawing.Size(273, 227);
            this.rtfCustomerInformation.TabIndex = 6;
            this.rtfCustomerInformation.Text = "";
            // 
            // rtfOrderInformation
            // 
            this.rtfOrderInformation.BackColor = System.Drawing.SystemColors.Info;
            this.rtfOrderInformation.Font = new System.Drawing.Font("Corbel", 11F);
            this.rtfOrderInformation.Location = new System.Drawing.Point(752, 313);
            this.rtfOrderInformation.Name = "rtfOrderInformation";
            this.rtfOrderInformation.Size = new System.Drawing.Size(273, 121);
            this.rtfOrderInformation.TabIndex = 6;
            this.rtfOrderInformation.Text = "";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Details";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customer Orders";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(748, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Order Detail";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmNWCustomers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1250, 800);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtfOrderInformation);
            this.Controls.Add(this.rtfCustomerInformation);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.grpSearchCustomers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNWCustomers";
            this.Text = "Northwind Traders Inc.";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grpSearchCustomers.ResumeLayout(false);
            this.grpSearchCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.ComboBox cmbRegion;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.GroupBox grpSearchCustomers;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.ComboBox cmbContactTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtfCustomerInformation;
        private System.Windows.Forms.RichTextBox rtfOrderInformation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

