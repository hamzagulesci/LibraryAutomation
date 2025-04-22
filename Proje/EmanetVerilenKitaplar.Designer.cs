namespace Proje
{
    partial class EmanetVerilenKitaplar
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
            this.cmboxSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.txtSearchBookTitle = new System.Windows.Forms.TextBox();
            this.dgwBook = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBook)).BeginInit();
            this.SuspendLayout();
            // 
            // cmboxSelection
            // 
            this.cmboxSelection.DropDownHeight = 108;
            this.cmboxSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmboxSelection.FormattingEnabled = true;
            this.cmboxSelection.IntegralHeight = false;
            this.cmboxSelection.Items.AddRange(new object[] {
            "Tümü",
            "Gecikenler",
            "Gecikmeyenler"});
            this.cmboxSelection.Location = new System.Drawing.Point(797, 5);
            this.cmboxSelection.Name = "cmboxSelection";
            this.cmboxSelection.Size = new System.Drawing.Size(198, 24);
            this.cmboxSelection.TabIndex = 89;
            this.cmboxSelection.SelectedIndexChanged += new System.EventHandler(this.cmboxSelection_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 88;
            this.label1.Text = "İsim Ara :";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchName.Location = new System.Drawing.Point(85, 5);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(243, 24);
            this.txtSearchName.TabIndex = 87;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBookTitle.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookTitle.Location = new System.Drawing.Point(342, 9);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(73, 17);
            this.lblBookTitle.TabIndex = 86;
            this.lblBookTitle.Text = "Kitap Ara :";
            // 
            // txtSearchBookTitle
            // 
            this.txtSearchBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchBookTitle.Location = new System.Drawing.Point(419, 5);
            this.txtSearchBookTitle.Name = "txtSearchBookTitle";
            this.txtSearchBookTitle.Size = new System.Drawing.Size(243, 24);
            this.txtSearchBookTitle.TabIndex = 85;
            this.txtSearchBookTitle.TextChanged += new System.EventHandler(this.txtSearchBookTitle_TextChanged);
            // 
            // dgwBook
            // 
            this.dgwBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwBook.Location = new System.Drawing.Point(0, 56);
            this.dgwBook.Name = "dgwBook";
            this.dgwBook.ReadOnly = true;
            this.dgwBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwBook.Size = new System.Drawing.Size(1023, 559);
            this.dgwBook.TabIndex = 84;
            // 
            // EmanetVerilenKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 615);
            this.Controls.Add(this.cmboxSelection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.txtSearchBookTitle);
            this.Controls.Add(this.dgwBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmanetVerilenKitaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmanetVerilenKitaplar";
            this.Load += new System.EventHandler(this.EmanetVerilenKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmboxSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox txtSearchBookTitle;
        private System.Windows.Forms.DataGridView dgwBook;
    }
}