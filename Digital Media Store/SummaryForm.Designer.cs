namespace Digital_Media_Store
{
    partial class SummaryForm
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
            this.btn_EditDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_CustomerInfo = new System.Windows.Forms.Label();
            this.list_Items = new System.Windows.Forms.ListView();
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.lbl_ItemSummary = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_EditDetails
            // 
            this.btn_EditDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_EditDetails.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_EditDetails.Location = new System.Drawing.Point(12, 483);
            this.btn_EditDetails.Name = "btn_EditDetails";
            this.btn_EditDetails.Size = new System.Drawing.Size(98, 58);
            this.btn_EditDetails.TabIndex = 1;
            this.btn_EditDetails.Text = "Edit";
            this.btn_EditDetails.UseVisualStyleBackColor = false;
            this.btn_EditDetails.Click += new System.EventHandler(this.btn_EditDetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Summary:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.lbl_CustomerInfo);
            this.panel1.Controls.Add(this.btn_EditDetails);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 553);
            this.panel1.TabIndex = 3;
            // 
            // lbl_CustomerInfo
            // 
            this.lbl_CustomerInfo.AutoSize = true;
            this.lbl_CustomerInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerInfo.Location = new System.Drawing.Point(12, 46);
            this.lbl_CustomerInfo.Name = "lbl_CustomerInfo";
            this.lbl_CustomerInfo.Size = new System.Drawing.Size(0, 28);
            this.lbl_CustomerInfo.TabIndex = 3;
            // 
            // list_Items
            // 
            this.list_Items.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.list_Items.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_Items.AutoArrange = false;
            this.list_Items.BackColor = System.Drawing.SystemColors.Control;
            this.list_Items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Author,
            this.Title,
            this.Price,
            this.Quantity});
            this.list_Items.HideSelection = false;
            this.list_Items.LabelWrap = false;
            this.list_Items.Location = new System.Drawing.Point(20, 46);
            this.list_Items.Name = "list_Items";
            this.list_Items.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.list_Items.Size = new System.Drawing.Size(529, 289);
            this.list_Items.TabIndex = 0;
            this.list_Items.UseCompatibleStateImageBehavior = false;
            this.list_Items.View = System.Windows.Forms.View.Details;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 173;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 200;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 58;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 92;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Confirm.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_Confirm.Location = new System.Drawing.Point(447, 483);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(102, 58);
            this.btn_Confirm.TabIndex = 0;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // lbl_ItemSummary
            // 
            this.lbl_ItemSummary.AutoSize = true;
            this.lbl_ItemSummary.Location = new System.Drawing.Point(15, 364);
            this.lbl_ItemSummary.Name = "lbl_ItemSummary";
            this.lbl_ItemSummary.Size = new System.Drawing.Size(0, 28);
            this.lbl_ItemSummary.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl_ItemSummary);
            this.panel2.Controls.Add(this.btn_Confirm);
            this.panel2.Controls.Add(this.list_Items);
            this.panel2.Location = new System.Drawing.Point(343, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 553);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ordered items";
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "SummaryForm";
            this.Text = "Digital Media Store";
            this.Load += new System.EventHandler(this.SummaryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_EditDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_CustomerInfo;
        private System.Windows.Forms.ListView list_Items;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Label lbl_ItemSummary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}