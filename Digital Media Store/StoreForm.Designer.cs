using System;
using System.Linq;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreForm));
            this.FilterPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Cart = new System.Windows.Forms.Button();
            this.GenreSearchLabel = new System.Windows.Forms.Label();
            this.GenreBox = new System.Windows.Forms.ComboBox();
            this.radioGroupBox = new System.Windows.Forms.GroupBox();
            this.albumRadio = new System.Windows.Forms.RadioButton();
            this.artistRadio = new System.Windows.Forms.RadioButton();
            this.titleRadio = new System.Windows.Forms.RadioButton();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.DetailsPanel = new System.Windows.Forms.Panel();
            this.pagePanel = new System.Windows.Forms.TableLayoutPanel();
            this.pageLabel = new System.Windows.Forms.Label();
            this.previousPageButton = new System.Windows.Forms.Button();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.DetailsTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.ArtistLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AlbumLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.ComposerLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.AddToCartBtn = new System.Windows.Forms.Button();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loadingPicture = new System.Windows.Forms.PictureBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.addedToCartPicture = new System.Windows.Forms.PictureBox();
            this.FilterPanel.SuspendLayout();
            this.radioGroupBox.SuspendLayout();
            this.DetailsPanel.SuspendLayout();
            this.pagePanel.SuspendLayout();
            this.DetailsTablePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addedToCartPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterPanel
            // 
            this.FilterPanel.Controls.Add(this.button1);
            this.FilterPanel.Controls.Add(this.btn_Cart);
            this.FilterPanel.Controls.Add(this.GenreSearchLabel);
            this.FilterPanel.Controls.Add(this.GenreBox);
            this.FilterPanel.Controls.Add(this.radioGroupBox);
            this.FilterPanel.Controls.Add(this.searchTextBox);
            this.FilterPanel.Controls.Add(this.searchButton);
            this.FilterPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FilterPanel.Location = new System.Drawing.Point(0, 0);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(205, 753);
            this.FilterPanel.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 658);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 83);
            this.button1.TabIndex = 20;
            this.button1.Text = "←";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Cart
            // 
            this.btn_Cart.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_Cart.Location = new System.Drawing.Point(12, 453);
            this.btn_Cart.Name = "btn_Cart";
            this.btn_Cart.Size = new System.Drawing.Size(173, 51);
            this.btn_Cart.TabIndex = 19;
            this.btn_Cart.Text = "Your Cart";
            this.btn_Cart.UseVisualStyleBackColor = false;
            this.btn_Cart.Click += new System.EventHandler(this.btn_Cart_Click);
            // 
            // GenreSearchLabel
            // 
            this.GenreSearchLabel.AutoSize = true;
            this.GenreSearchLabel.Location = new System.Drawing.Point(12, 277);
            this.GenreSearchLabel.Name = "GenreSearchLabel";
            this.GenreSearchLabel.Size = new System.Drawing.Size(64, 28);
            this.GenreSearchLabel.TabIndex = 18;
            this.GenreSearchLabel.Text = "Genre";
            // 
            // GenreBox
            // 
            this.GenreBox.FormattingEnabled = true;
            this.GenreBox.Items.AddRange(new object[] {
            "",
            "Rock",
            "Jazz",
            "Metal",
            "Alternative & Punk",
            "Rock And Roll",
            "Blues",
            "Latin",
            "Reggae",
            "Pop",
            "Soundtrack",
            "Bossa Nova",
            "Easy Listening",
            "Heavy Metal",
            "R&B/Soul",
            "Electronica/Dance",
            "World",
            "Hip Hop/Rap",
            "Science Fiction",
            "TV Shows",
            "Sci Fi & Fantasy",
            "Drama",
            "Comedy",
            "Alternative",
            "Classical",
            "Opera"});
            this.GenreBox.Location = new System.Drawing.Point(12, 308);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(173, 36);
            this.GenreBox.TabIndex = 17;
            // 
            // radioGroupBox
            // 
            this.radioGroupBox.Controls.Add(this.albumRadio);
            this.radioGroupBox.Controls.Add(this.artistRadio);
            this.radioGroupBox.Controls.Add(this.titleRadio);
            this.radioGroupBox.Location = new System.Drawing.Point(12, 25);
            this.radioGroupBox.Name = "radioGroupBox";
            this.radioGroupBox.Size = new System.Drawing.Size(173, 171);
            this.radioGroupBox.TabIndex = 12;
            this.radioGroupBox.TabStop = false;
            this.radioGroupBox.Text = "Search by";
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
            this.searchTextBox.Location = new System.Drawing.Point(12, 220);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(173, 34);
            this.searchTextBox.TabIndex = 13;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.searchButton.Location = new System.Drawing.Point(12, 379);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(173, 54);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DetailsPanel
            // 
            this.DetailsPanel.Controls.Add(this.pagePanel);
            this.DetailsPanel.Controls.Add(this.DetailsTablePanel);
            this.DetailsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DetailsPanel.Location = new System.Drawing.Point(205, 491);
            this.DetailsPanel.Name = "DetailsPanel";
            this.DetailsPanel.Size = new System.Drawing.Size(956, 262);
            this.DetailsPanel.TabIndex = 7;
            // 
            // pagePanel
            // 
            this.pagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pagePanel.ColumnCount = 3;
            this.pagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.pagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pagePanel.Controls.Add(this.pageLabel, 1, 0);
            this.pagePanel.Controls.Add(this.previousPageButton, 0, 0);
            this.pagePanel.Controls.Add(this.nextPageButton, 2, 0);
            this.pagePanel.Location = new System.Drawing.Point(0, 215);
            this.pagePanel.Name = "pagePanel";
            this.pagePanel.RowCount = 1;
            this.pagePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pagePanel.Size = new System.Drawing.Size(950, 44);
            this.pagePanel.TabIndex = 40;
            this.pagePanel.Visible = false;
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageLabel.Location = new System.Drawing.Point(409, 0);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(132, 44);
            this.pageLabel.TabIndex = 28;
            // 
            // previousPageButton
            // 
            this.previousPageButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.previousPageButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.previousPageButton.Location = new System.Drawing.Point(333, 3);
            this.previousPageButton.Name = "previousPageButton";
            this.previousPageButton.Size = new System.Drawing.Size(70, 38);
            this.previousPageButton.TabIndex = 27;
            this.previousPageButton.Text = "Back";
            this.previousPageButton.UseVisualStyleBackColor = false;
            this.previousPageButton.Click += new System.EventHandler(this.PreviousPageButton_Click);
            // 
            // nextPageButton
            // 
            this.nextPageButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.nextPageButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.nextPageButton.Location = new System.Drawing.Point(547, 3);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(72, 38);
            this.nextPageButton.TabIndex = 26;
            this.nextPageButton.Text = "Next";
            this.nextPageButton.UseVisualStyleBackColor = false;
            this.nextPageButton.Click += new System.EventHandler(this.NextPageButton_Click);
            // 
            // DetailsTablePanel
            // 
            this.DetailsTablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailsTablePanel.ColumnCount = 5;
            this.DetailsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.88445F));
            this.DetailsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.026062F));
            this.DetailsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.11312F));
            this.DetailsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.026062F));
            this.DetailsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.95031F));
            this.DetailsTablePanel.Controls.Add(this.addedToCartPicture, 3, 4);
            this.DetailsTablePanel.Controls.Add(this.TypeLabel, 4, 3);
            this.DetailsTablePanel.Controls.Add(this.ArtistLabel, 0, 0);
            this.DetailsTablePanel.Controls.Add(this.TitleLabel, 0, 1);
            this.DetailsTablePanel.Controls.Add(this.AlbumLabel, 0, 2);
            this.DetailsTablePanel.Controls.Add(this.GenreLabel, 0, 3);
            this.DetailsTablePanel.Controls.Add(this.ComposerLabel, 0, 4);
            this.DetailsTablePanel.Controls.Add(this.LengthLabel, 4, 2);
            this.DetailsTablePanel.Controls.Add(this.SizeLabel, 4, 1);
            this.DetailsTablePanel.Controls.Add(this.PriceLabel, 4, 0);
            this.DetailsTablePanel.Controls.Add(this.AddToCartBtn, 4, 4);
            this.DetailsTablePanel.Location = new System.Drawing.Point(0, 0);
            this.DetailsTablePanel.Name = "DetailsTablePanel";
            this.DetailsTablePanel.RowCount = 5;
            this.DetailsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.DetailsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.DetailsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.DetailsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.DetailsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.DetailsTablePanel.Size = new System.Drawing.Size(956, 209);
            this.DetailsTablePanel.TabIndex = 39;
            this.DetailsTablePanel.Visible = false;
            // 
            // TypeLabel
            // 
            this.TypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(651, 129);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(120, 28);
            this.TypeLabel.TabIndex = 38;
            this.TypeLabel.Text = "Media type: ";
            // 
            // ArtistLabel
            // 
            this.ArtistLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ArtistLabel.AutoSize = true;
            this.ArtistLabel.Location = new System.Drawing.Point(3, 6);
            this.ArtistLabel.Name = "ArtistLabel";
            this.ArtistLabel.Size = new System.Drawing.Size(68, 28);
            this.ArtistLabel.TabIndex = 29;
            this.ArtistLabel.Text = "Artist: ";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(3, 47);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(58, 28);
            this.TitleLabel.TabIndex = 30;
            this.TitleLabel.Text = "Title: ";
            // 
            // AlbumLabel
            // 
            this.AlbumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AlbumLabel.AutoSize = true;
            this.AlbumLabel.Location = new System.Drawing.Point(3, 88);
            this.AlbumLabel.Name = "AlbumLabel";
            this.AlbumLabel.Size = new System.Drawing.Size(79, 28);
            this.AlbumLabel.TabIndex = 31;
            this.AlbumLabel.Text = "Album: ";
            // 
            // GenreLabel
            // 
            this.GenreLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(3, 129);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(73, 28);
            this.GenreLabel.TabIndex = 36;
            this.GenreLabel.Text = "Genre: ";
            // 
            // ComposerLabel
            // 
            this.ComposerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ComposerLabel.AutoSize = true;
            this.ComposerLabel.Location = new System.Drawing.Point(3, 172);
            this.ComposerLabel.Name = "ComposerLabel";
            this.ComposerLabel.Size = new System.Drawing.Size(111, 28);
            this.ComposerLabel.TabIndex = 37;
            this.ComposerLabel.Text = "Composer: ";
            // 
            // LengthLabel
            // 
            this.LengthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(651, 88);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(81, 28);
            this.LengthLabel.TabIndex = 34;
            this.LengthLabel.Text = "Length: ";
            // 
            // SizeLabel
            // 
            this.SizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(651, 47);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(56, 28);
            this.SizeLabel.TabIndex = 33;
            this.SizeLabel.Text = "Size: ";
            // 
            // PriceLabel
            // 
            this.PriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(651, 6);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(63, 28);
            this.PriceLabel.TabIndex = 32;
            this.PriceLabel.Text = "Price: ";
            // 
            // AddToCartBtn
            // 
            this.AddToCartBtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.AddToCartBtn.Location = new System.Drawing.Point(651, 167);
            this.AddToCartBtn.Name = "AddToCartBtn";
            this.AddToCartBtn.Size = new System.Drawing.Size(120, 39);
            this.AddToCartBtn.TabIndex = 35;
            this.AddToCartBtn.Text = "Add to cart";
            this.AddToCartBtn.UseVisualStyleBackColor = false;
            this.AddToCartBtn.Click += new System.EventHandler(this.AddToCartBtn_Click);
            // 
            // RightPanel
            // 
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(1161, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(21, 753);
            this.RightPanel.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loadingPicture);
            this.panel1.Controls.Add(this.DataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(205, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 491);
            this.panel1.TabIndex = 10;
            // 
            // loadingPicture
            // 
            this.loadingPicture.Image = ((System.Drawing.Image)(resources.GetObject("loadingPicture.Image")));
            this.loadingPicture.Location = new System.Drawing.Point(442, 188);
            this.loadingPicture.Name = "loadingPicture";
            this.loadingPicture.Size = new System.Drawing.Size(66, 66);
            this.loadingPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loadingPicture.TabIndex = 10;
            this.loadingPicture.TabStop = false;
            this.loadingPicture.Visible = false;
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToOrderColumns = true;
            this.DataGridView.AllowUserToResizeRows = false;
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.EnableHeadersVisualStyles = false;
            this.DataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.DataGridView.Location = new System.Drawing.Point(0, 0);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(956, 491);
            this.DataGridView.TabIndex = 9;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // addedToCartPicture
            // 
            this.addedToCartPicture.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addedToCartPicture.Image = ((System.Drawing.Image)(resources.GetObject("addedToCartPicture.Image")));
            this.addedToCartPicture.Location = new System.Drawing.Point(619, 173);
            this.addedToCartPicture.Name = "addedToCartPicture";
            this.addedToCartPicture.Size = new System.Drawing.Size(26, 26);
            this.addedToCartPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.addedToCartPicture.TabIndex = 11;
            this.addedToCartPicture.TabStop = false;
            this.addedToCartPicture.Visible = false;
            // 
            // StoreForm
            // 
            this.AccessibleName = "storeForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DetailsPanel);
            this.Controls.Add(this.FilterPanel);
            this.Controls.Add(this.RightPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "StoreForm";
            this.Text = "Digital Media Store";
            this.FilterPanel.ResumeLayout(false);
            this.FilterPanel.PerformLayout();
            this.radioGroupBox.ResumeLayout(false);
            this.radioGroupBox.PerformLayout();
            this.DetailsPanel.ResumeLayout(false);
            this.pagePanel.ResumeLayout(false);
            this.pagePanel.PerformLayout();
            this.DetailsTablePanel.ResumeLayout(false);
            this.DetailsTablePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadingPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addedToCartPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel FilterPanel;
        private System.Windows.Forms.Label GenreSearchLabel;
        private System.Windows.Forms.ComboBox GenreBox;
        private System.Windows.Forms.GroupBox radioGroupBox;
        private System.Windows.Forms.RadioButton albumRadio;
        private System.Windows.Forms.RadioButton artistRadio;
        private System.Windows.Forms.RadioButton titleRadio;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel DetailsPanel;
        private System.Windows.Forms.Button previousPageButton;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Label ComposerLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Button AddToCartBtn;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label AlbumLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ArtistLabel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.TableLayoutPanel DetailsTablePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TableLayoutPanel pagePanel;
        private System.Windows.Forms.PictureBox loadingPicture;
        private System.Windows.Forms.Button btn_Cart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox addedToCartPicture;
    }
}