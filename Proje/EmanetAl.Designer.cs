namespace Proje
{
    partial class EmanetAl
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
            this.dgwBook = new System.Windows.Forms.DataGridView();
            this.btnEmanet = new System.Windows.Forms.Button();
            this.labelBarcodeNo = new System.Windows.Forms.Label();
            this.txtSearchBarcodeNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchIdNo = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBook
            // 
            this.dgwBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwBook.Location = new System.Drawing.Point(0, 59);
            this.dgwBook.Name = "dgwBook";
            this.dgwBook.ReadOnly = true;
            this.dgwBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwBook.Size = new System.Drawing.Size(1046, 557);
            this.dgwBook.TabIndex = 91;
            // 
            // btnEmanet
            // 
            this.btnEmanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanet.Location = new System.Drawing.Point(795, 11);
            this.btnEmanet.Name = "btnEmanet";
            this.btnEmanet.Size = new System.Drawing.Size(119, 31);
            this.btnEmanet.TabIndex = 92;
            this.btnEmanet.Text = "Emanet Al";
            this.btnEmanet.UseVisualStyleBackColor = true;
            this.btnEmanet.Click += new System.EventHandler(this.btnEmanet_Click);
            // 
            // labelBarcodeNo
            // 
            this.labelBarcodeNo.AutoSize = true;
            this.labelBarcodeNo.BackColor = System.Drawing.Color.Transparent;
            this.labelBarcodeNo.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBarcodeNo.ForeColor = System.Drawing.Color.Black;
            this.labelBarcodeNo.Location = new System.Drawing.Point(405, 15);
            this.labelBarcodeNo.Name = "labelBarcodeNo";
            this.labelBarcodeNo.Size = new System.Drawing.Size(107, 17);
            this.labelBarcodeNo.TabIndex = 98;
            this.labelBarcodeNo.Text = "Barkod No Ara :";
            // 
            // txtSearchBarcodeNo
            // 
            this.txtSearchBarcodeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchBarcodeNo.Location = new System.Drawing.Point(531, 11);
            this.txtSearchBarcodeNo.Multiline = true;
            this.txtSearchBarcodeNo.Name = "txtSearchBarcodeNo";
            this.txtSearchBarcodeNo.Size = new System.Drawing.Size(243, 31);
            this.txtSearchBarcodeNo.TabIndex = 97;
            this.txtSearchBarcodeNo.TextChanged += new System.EventHandler(this.txtSearchBarcodeNo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 96;
            this.label2.Text = "Tc Kimlik No Ara :";
            // 
            // txtSearchIdNo
            // 
            this.txtSearchIdNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchIdNo.Location = new System.Drawing.Point(138, 11);
            this.txtSearchIdNo.Multiline = true;
            this.txtSearchIdNo.Name = "txtSearchIdNo";
            this.txtSearchIdNo.Size = new System.Drawing.Size(243, 31);
            this.txtSearchIdNo.TabIndex = 95;
            this.txtSearchIdNo.TextChanged += new System.EventHandler(this.txtSearchIdNo_TextChanged);
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(918, 11);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(119, 31);
            this.btnListele.TabIndex = 99;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // EmanetAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 616);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.labelBarcodeNo);
            this.Controls.Add(this.txtSearchBarcodeNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchIdNo);
            this.Controls.Add(this.btnEmanet);
            this.Controls.Add(this.dgwBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmanetAl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmanetAl";
            this.Load += new System.EventHandler(this.EmanetAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBook;
        private System.Windows.Forms.Button btnEmanet;
        private System.Windows.Forms.Label labelBarcodeNo;
        private System.Windows.Forms.TextBox txtSearchBarcodeNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchIdNo;
        private System.Windows.Forms.Button btnListele;
    }
}