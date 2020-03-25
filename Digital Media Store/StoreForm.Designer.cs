using System;
using System.Runtime.InteropServices;

namespace Digital_Media_Store
{
    partial class StoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

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
            this.components = new System.ComponentModel.Container();
            this.radioGroupBox = new System.Windows.Forms.GroupBox();
            this.albumRadio = new System.Windows.Forms.RadioButton();
            this.artistRadio = new System.Windows.Forms.RadioButton();
            this.titleRadio = new System.Windows.Forms.RadioButton();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.playlistBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.storePanel = new System.Windows.Forms.Panel();
            this.DetailsPanel = new System.Windows.Forms.Panel();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.ComposerLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.AddToCartBtn = new System.Windows.Forms.Button();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.AlbumLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ArtistLabel = new System.Windows.Forms.Label();
            this.pageLabel = new System.Windows.Forms.Label();
            this.previousPageButton = new System.Windows.Forms.Button();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.PlaylistLabel = new System.Windows.Forms.Label();
            this.radioGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.storePanel.SuspendLayout();
            this.DetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioGroupBox
            // 
            this.radioGroupBox.Controls.Add(this.albumRadio);
            this.radioGroupBox.Controls.Add(this.artistRadio);
            this.radioGroupBox.Controls.Add(this.titleRadio);
            this.radioGroupBox.Location = new System.Drawing.Point(23, 28);
            this.radioGroupBox.Name = "radioGroupBox";
            this.radioGroupBox.Size = new System.Drawing.Size(173, 171);
            this.radioGroupBox.TabIndex = 0;
            this.radioGroupBox.TabStop = false;
            this.radioGroupBox.Text = "Search songs by";
            // 
            // albumRadio
            // 
            this.albumRadio.AutoSize = true;
            this.albumRadio.Location = new System.Drawing.Point(18, 122);
            this.albumRadio.Name = "albumRadio";
            this.albumRadio.Size = new System.Drawing.Size(91, 32);
            this.albumRadio.TabIndex = 2;
            this.albumRadio.TabStop = true;
            this.albumRadio.Text = "Album";
            this.albumRadio.UseVisualStyleBackColor = true;
            // 
            // artistRadio
            // 
            this.artistRadio.AutoSize = true;
            this.artistRadio.Location = new System.Drawing.Point(18, 84);
            this.artistRadio.Name = "artistRadio";
            this.artistRadio.Size = new System.Drawing.Size(80, 32);
            this.artistRadio.TabIndex = 1;
            this.artistRadio.TabStop = true;
            this.artistRadio.Text = "Artist";
            this.artistRadio.UseVisualStyleBackColor = true;
            // 
            // titleRadio
            // 
            this.titleRadio.AutoSize = true;
            this.titleRadio.Location = new System.Drawing.Point(18, 46);
            this.titleRadio.Name = "titleRadio";
            this.titleRadio.Size = new System.Drawing.Size(70, 32);
            this.titleRadio.TabIndex = 0;
            this.titleRadio.TabStop = true;
            this.titleRadio.Text = "Title";
            this.titleRadio.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(23, 223);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(173, 34);
            this.searchTextBox.TabIndex = 1;
            // 
            // playlistBox
            // 
            this.playlistBox.FormattingEnabled = true;
            this.playlistBox.Items.AddRange(new object[] {
            "------",
            "Music",
            "Movies",
            "TV Shows",
            "Audiobooks",
            "90’s Music",
            "Audiobooks",
            "Movies",
            "Music",
            "Music Videos",
            "TV Shows",
            "Brazilian Music",
            "Classical",
            "Classical 101 - Deep Cuts",
            "Classical 101 - Next Steps",
            "Classical 101 - The Basics",
            "Grunge",
            "Heavy Metal Classic",
            "On-The-Go 1"});
            this.playlistBox.Location = new System.Drawing.Point(23, 306);
            this.playlistBox.Name = "playlistBox";
            this.playlistBox.Size = new System.Drawing.Size(173, 36);
            this.playlistBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(23, 367);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(173, 54);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // DataTable
            // 
            this.DataTable.AllowUserToAddRows = false;
            this.DataTable.AllowUserToDeleteRows = false;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Location = new System.Drawing.Point(222, 28);
            this.DataTable.Name = "DataTable";
            this.DataTable.ReadOnly = true;
            this.DataTable.RowHeadersWidth = 51;
            this.DataTable.RowTemplate.Height = 24;
            this.DataTable.Size = new System.Drawing.Size(1098, 480);
            this.DataTable.TabIndex = 4;
            this.DataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTable_CellContentClick);
            // 
            // storePanel
            // 
            this.storePanel.Controls.Add(this.DetailsPanel);
            this.storePanel.Controls.Add(this.pageLabel);
            this.storePanel.Controls.Add(this.previousPageButton);
            this.storePanel.Controls.Add(this.nextPageButton);
            this.storePanel.Controls.Add(this.PlaylistLabel);
            this.storePanel.Controls.Add(this.radioGroupBox);
            this.storePanel.Controls.Add(this.DataTable);
            this.storePanel.Controls.Add(this.searchTextBox);
            this.storePanel.Controls.Add(this.searchButton);
            this.storePanel.Controls.Add(this.playlistBox);
            this.storePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storePanel.Location = new System.Drawing.Point(0, 0);
            this.storePanel.Name = "storePanel";
            this.storePanel.Size = new System.Drawing.Size(1346, 773);
            this.storePanel.TabIndex = 5;
            this.storePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.storePanel_MouseDown);
            // 
            // DetailsPanel
            // 
            this.DetailsPanel.Controls.Add(this.TypeLabel);
            this.DetailsPanel.Controls.Add(this.ComposerLabel);
            this.DetailsPanel.Controls.Add(this.GenreLabel);
            this.DetailsPanel.Controls.Add(this.AddToCartBtn);
            this.DetailsPanel.Controls.Add(this.LengthLabel);
            this.DetailsPanel.Controls.Add(this.SizeLabel);
            this.DetailsPanel.Controls.Add(this.PriceLabel);
            this.DetailsPanel.Controls.Add(this.AlbumLabel);
            this.DetailsPanel.Controls.Add(this.TitleLabel);
            this.DetailsPanel.Controls.Add(this.ArtistLabel);
            this.DetailsPanel.Location = new System.Drawing.Point(228, 525);
            this.DetailsPanel.Name = "DetailsPanel";
            this.DetailsPanel.Size = new System.Drawing.Size(1092, 199);
            this.DetailsPanel.TabIndex = 9;
            this.DetailsPanel.Visible = false;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(735, 123);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(120, 28);
            this.TypeLabel.TabIndex = 15;
            this.TypeLabel.Text = "Media type: ";
            // 
            // ComposerLabel
            // 
            this.ComposerLabel.AutoSize = true;
            this.ComposerLabel.Location = new System.Drawing.Point(3, 159);
            this.ComposerLabel.Name = "ComposerLabel";
            this.ComposerLabel.Size = new System.Drawing.Size(111, 28);
            this.ComposerLabel.TabIndex = 14;
            this.ComposerLabel.Text = "Composer: ";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(3, 123);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(73, 28);
            this.GenreLabel.TabIndex = 13;
            this.GenreLabel.Text = "Genre: ";
            // 
            // AddToCartBtn
            // 
            this.AddToCartBtn.Location = new System.Drawing.Point(954, 153);
            this.AddToCartBtn.Name = "AddToCartBtn";
            this.AddToCartBtn.Size = new System.Drawing.Size(120, 41);
            this.AddToCartBtn.TabIndex = 12;
            this.AddToCartBtn.Text = "Add to cart";
            this.AddToCartBtn.UseVisualStyleBackColor = true;
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(735, 84);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(81, 28);
            this.LengthLabel.TabIndex = 11;
            this.LengthLabel.Text = "Length: ";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(735, 46);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(56, 28);
            this.SizeLabel.TabIndex = 10;
            this.SizeLabel.Text = "Size: ";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(735, 9);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(63, 28);
            this.PriceLabel.TabIndex = 9;
            this.PriceLabel.Text = "Price: ";
            // 
            // AlbumLabel
            // 
            this.AlbumLabel.AutoSize = true;
            this.AlbumLabel.Location = new System.Drawing.Point(3, 84);
            this.AlbumLabel.Name = "AlbumLabel";
            this.AlbumLabel.Size = new System.Drawing.Size(79, 28);
            this.AlbumLabel.TabIndex = 8;
            this.AlbumLabel.Text = "Album: ";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(3, 46);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(58, 28);
            this.TitleLabel.TabIndex = 7;
            this.TitleLabel.Text = "Title: ";
            // 
            // ArtistLabel
            // 
            this.ArtistLabel.AutoSize = true;
            this.ArtistLabel.Location = new System.Drawing.Point(3, 9);
            this.ArtistLabel.Name = "ArtistLabel";
            this.ArtistLabel.Size = new System.Drawing.Size(68, 28);
            this.ArtistLabel.TabIndex = 6;
            this.ArtistLabel.Text = "Artist: ";
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Location = new System.Drawing.Point(736, 733);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(0, 28);
            this.pageLabel.TabIndex = 8;
            // 
            // previousPageButton
            // 
            this.previousPageButton.Location = new System.Drawing.Point(649, 730);
            this.previousPageButton.Name = "previousPageButton";
            this.previousPageButton.Size = new System.Drawing.Size(81, 34);
            this.previousPageButton.TabIndex = 7;
            this.previousPageButton.Text = "Back";
            this.previousPageButton.UseVisualStyleBackColor = true;
            this.previousPageButton.Click += new System.EventHandler(this.PreviousPageButton_Click);
            // 
            // nextPageButton
            // 
            this.nextPageButton.Location = new System.Drawing.Point(833, 730);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(80, 34);
            this.nextPageButton.TabIndex = 6;
            this.nextPageButton.Text = "Next";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.PextPageButton_Click);
            // 
            // PlaylistLabel
            // 
            this.PlaylistLabel.AutoSize = true;
            this.PlaylistLabel.Location = new System.Drawing.Point(24, 275);
            this.PlaylistLabel.Name = "PlaylistLabel";
            this.PlaylistLabel.Size = new System.Drawing.Size(73, 28);
            this.PlaylistLabel.TabIndex = 5;
            this.PlaylistLabel.Text = "Playlist";
            // 
            // StoreForm
            // 
            this.AccessibleName = "storeForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 773);
            this.Controls.Add(this.storePanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StoreForm";
            this.Text = "StoreForm";
    
            this.radioGroupBox.ResumeLayout(false);
            this.radioGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.storePanel.ResumeLayout(false);
            this.storePanel.PerformLayout();
            this.DetailsPanel.ResumeLayout(false);
            this.DetailsPanel.PerformLayout();
   
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox radioGroupBox;
        private System.Windows.Forms.RadioButton albumRadio;
        private System.Windows.Forms.RadioButton artistRadio;
        private System.Windows.Forms.RadioButton titleRadio;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox playlistBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Panel storePanel;
        private System.Windows.Forms.Label PlaylistLabel;
        private System.Windows.Forms.Button previousPageButton;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.Panel DetailsPanel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label AlbumLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ArtistLabel;
        private System.Windows.Forms.Button AddToCartBtn;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label ComposerLabel;
        private System.Windows.Forms.Label TypeLabel;
    }
}