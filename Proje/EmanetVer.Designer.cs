namespace Proje
{
    partial class EmanetVer
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
            this.lblSubmissionDate = new System.Windows.Forms.Label();
            this.dtpSubmissionDate = new System.Windows.Forms.DateTimePicker();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.dgwBook = new System.Windows.Forms.DataGridView();
            this.dgwMember = new System.Windows.Forms.DataGridView();
            this.labelBarcodeNo = new System.Windows.Forms.Label();
            this.txtSearchBarcodeNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchIdNo = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMember)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubmissionDate
            // 
            this.lblSubmissionDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSubmissionDate.AutoSize = true;
            this.lblSubmissionDate.BackColor = System.Drawing.Color.Transparent;
            this.lblSubmissionDate.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubmissionDate.Location = new System.Drawing.Point(26, 587);
            this.lblSubmissionDate.Name = "lblSubmissionDate";
            this.lblSubmissionDate.Size = new System.Drawing.Size(89, 17);
            this.lblSubmissionDate.TabIndex = 115;
            this.lblSubmissionDate.Text = "Teslim Tarihi";
            // 
            // dtpSubmissionDate
            // 
            this.dtpSubmissionDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpSubmissionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSubmissionDate.Location = new System.Drawing.Point(130, 584);
            this.dtpSubmissionDate.Name = "dtpSubmissionDate";
            this.dtpSubmissionDate.Size = new System.Drawing.Size(200, 20);
            this.dtpSubmissionDate.TabIndex = 114;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.BackColor = System.Drawing.Color.Transparent;
            this.lblIssueDate.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIssueDate.Location = new System.Drawing.Point(26, 548);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(96, 17);
            this.lblIssueDate.TabIndex = 113;
            this.lblIssueDate.Text = "Verilme Tarihi";
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpIssueDate.Enabled = false;
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssueDate.Location = new System.Drawing.Point(130, 545);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(200, 20);
            this.dtpIssueDate.TabIndex = 112;
            // 
            // dgwBook
            // 
            this.dgwBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwBook.Location = new System.Drawing.Point(29, 325);
            this.dgwBook.Name = "dgwBook";
            this.dgwBook.ReadOnly = true;
            this.dgwBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwBook.Size = new System.Drawing.Size(1058, 203);
            this.dgwBook.TabIndex = 111;
            // 
            // dgwMember
            // 
            this.dgwMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMember.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMember.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwMember.Location = new System.Drawing.Point(29, 61);
            this.dgwMember.Name = "dgwMember";
            this.dgwMember.ReadOnly = true;
            this.dgwMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwMember.Size = new System.Drawing.Size(1058, 203);
            this.dgwMember.TabIndex = 110;
            // 
            // labelBarcodeNo
            // 
            this.labelBarcodeNo.AutoSize = true;
            this.labelBarcodeNo.BackColor = System.Drawing.Color.Transparent;
            this.labelBarcodeNo.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBarcodeNo.ForeColor = System.Drawing.Color.White;
            this.labelBarcodeNo.Location = new System.Drawing.Point(26, 290);
            this.labelBarcodeNo.Name = "labelBarcodeNo";
            this.labelBarcodeNo.Size = new System.Drawing.Size(107, 17);
            this.labelBarcodeNo.TabIndex = 109;
            this.labelBarcodeNo.Text = "Barkod No Ara :";
            // 
            // txtSearchBarcodeNo
            // 
            this.txtSearchBarcodeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchBarcodeNo.Location = new System.Drawing.Point(152, 286);
            this.txtSearchBarcodeNo.Name = "txtSearchBarcodeNo";
            this.txtSearchBarcodeNo.Size = new System.Drawing.Size(243, 24);
            this.txtSearchBarcodeNo.TabIndex = 108;
            this.txtSearchBarcodeNo.TextChanged += new System.EventHandler(this.txtSearchBarcodeNo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 107;
            this.label2.Text = "Tc Kimlik No Ara :";
            // 
            // txtSearchIdNo
            // 
            this.txtSearchIdNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchIdNo.Location = new System.Drawing.Point(152, 19);
            this.txtSearchIdNo.Name = "txtSearchIdNo";
            this.txtSearchIdNo.Size = new System.Drawing.Size(243, 24);
            this.txtSearchIdNo.TabIndex = 106;
            this.txtSearchIdNo.TextChanged += new System.EventHandler(this.txtSearchIdNo_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(950, 562);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 42);
            this.btnSave.TabIndex = 116;
            this.btnSave.Text = "Emanet Ver";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(807, 562);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(137, 42);
            this.btnListele.TabIndex = 117;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // EmanetVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1112, 623);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSubmissionDate);
            this.Controls.Add(this.dtpSubmissionDate);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.dgwBook);
            this.Controls.Add(this.dgwMember);
            this.Controls.Add(this.labelBarcodeNo);
            this.Controls.Add(this.txtSearchBarcodeNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchIdNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmanetVer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmanetVer";
            this.Load += new System.EventHandler(this.EmanetVer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubmissionDate;
        private System.Windows.Forms.DateTimePicker dtpSubmissionDate;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.DataGridView dgwBook;
        private System.Windows.Forms.DataGridView dgwMember;
        private System.Windows.Forms.Label labelBarcodeNo;
        private System.Windows.Forms.TextBox txtSearchBarcodeNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchIdNo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnListele;
    }
}