﻿namespace Client
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
            this.txtCompanyId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCountryCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCompanyTypes = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.gridResults = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Company identificator:";
            // 
            // txtCompanyId
            // 
            this.txtCompanyId.Location = new System.Drawing.Point(129, 36);
            this.txtCompanyId.Name = "txtCompanyId";
            this.txtCompanyId.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyId.TabIndex = 3;
            this.txtCompanyId.Tag = "Enter ID number...";
            this.txtCompanyId.Enter += new System.EventHandler(this.textbox_Enter);
            this.txtCompanyId.Leave += new System.EventHandler(this.textbox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Country code:";
            // 
            // txtCountryCode
            // 
            this.txtCountryCode.Location = new System.Drawing.Point(328, 36);
            this.txtCountryCode.Name = "txtCountryCode";
            this.txtCountryCode.Size = new System.Drawing.Size(100, 20);
            this.txtCountryCode.TabIndex = 5;
            this.txtCountryCode.Tag = "Enter text...";
            this.txtCountryCode.Enter += new System.EventHandler(this.textbox_Enter);
            this.txtCountryCode.Leave += new System.EventHandler(this.textbox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Company type:";
            // 
            // cbCompanyTypes
            // 
            this.cbCompanyTypes.DisplayMember = "Text";
            this.cbCompanyTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompanyTypes.FormattingEnabled = true;
            this.cbCompanyTypes.Location = new System.Drawing.Point(530, 36);
            this.cbCompanyTypes.Name = "cbCompanyTypes";
            this.cbCompanyTypes.Size = new System.Drawing.Size(148, 21);
            this.cbCompanyTypes.TabIndex = 7;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(603, 63);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 8;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(603, 518);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCompany.Location = new System.Drawing.Point(504, 518);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(92, 23);
            this.btnAddCompany.TabIndex = 11;
            this.btnAddCompany.Text = "Add company";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // gridResults
            // 
            this.gridResults.AllowUserToAddRows = false;
            this.gridResults.AllowUserToDeleteRows = false;
            this.gridResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colCompanyName,
            this.colCountryCode,
            this.colCompanyType});
            this.gridResults.Location = new System.Drawing.Point(16, 92);
            this.gridResults.Name = "gridResults";
            this.gridResults.RowHeadersVisible = false;
            this.gridResults.Size = new System.Drawing.Size(662, 420);
            this.gridResults.TabIndex = 9;
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 80;
            // 
            // colCompanyName
            // 
            this.colCompanyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCompanyName.DataPropertyName = "Name";
            this.colCompanyName.HeaderText = "Company name";
            this.colCompanyName.Name = "colCompanyName";
            // 
            // colCountryCode
            // 
            this.colCountryCode.DataPropertyName = "CountryCode";
            this.colCountryCode.HeaderText = "Country code";
            this.colCountryCode.Name = "colCountryCode";
            // 
            // colCompanyType
            // 
            this.colCompanyType.DataPropertyName = "CompanyType";
            this.colCompanyType.HeaderText = "CompanyType";
            this.colCompanyType.Name = "colCompanyType";
            this.colCompanyType.Width = 120;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Company name:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(129, 10);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(299, 20);
            this.txtCompanyName.TabIndex = 1;
            this.txtCompanyName.Tag = "Enter text...";
            this.txtCompanyName.Enter += new System.EventHandler(this.textbox_Enter);
            this.txtCompanyName.Leave += new System.EventHandler(this.textbox_Leave);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 553);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridResults);
            this.Controls.Add(this.btnAddCompany);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cbCompanyTypes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCountryCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCompanyId);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Form1";
            this.Text = "Company filter";
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCompanyId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCountryCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCompanyTypes;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.DataGridView gridResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCompanyName;
    }
}

