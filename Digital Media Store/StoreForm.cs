using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using PagedList;
using PagedList.EntityFramework;

namespace Digital_Media_Store
{
    public partial class StoreForm : Form
    {
        private int pageNumber = 1;
        private IPagedList<Track> list;
        private Track SelectedTrack;
        private IList<Track> Cart;
        public StoreForm()
        {
            Cart = new List<Track>();
            InitializeComponent();
            this.CenterToScreen();
        }

        public static double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {

            loadingPicture.Show();
            loadingPicture.Update();
            try
            {
                pagePanel.Visible = true;
                pageNumber = 1;
                list = await GetPagedListAsync();
                nextPageButton.Enabled = list.HasNextPage;
                previousPageButton.Enabled = list.HasPreviousPage;

                DataGridView.RowTemplate.Resizable = DataGridViewTriState.True;
                DataGridView.RowTemplate.Height = 40;
                DataGridView.DataSource = list.Select(t => new
                {
                    Artist = t.Album.Artist.Name,
                    Title = t.Name,
                    Album = t.Album.Title
                }).ToList();


                var maxWidth = (DataGridView.Width / 3) - 25;
                DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                foreach (DataGridViewColumn column in DataGridView.Columns)
                {
                    if (column.Width > maxWidth)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        column.Width = maxWidth;
                    }
                }
                pageLabel.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);

            }
            catch { }

            loadingPicture.Hide();
        }

        private async Task<IPagedList<Track>> GetPagedListAsync(int pageNumber = 1, int pageSize = 25)
        {

            using (var context = new ChinookEntities())
            {
                var selectedRadioBox = radioGroupBox.Controls.OfType<RadioButton>()
                                                             .FirstOrDefault(b => b.Checked)
                                                             .Text;

                IQueryable<Track> tracks;

                //searching by genre
                bool genreSelected = (GenreBox.SelectedIndex == -1 || GenreBox.SelectedIndex == 0) ? false : true;

                if (genreSelected)
                {
                    var selectedGenre = GenreBox.Text;
                    tracks = context.Tracks.Where(t => t.Genre.Name == selectedGenre);
                }
                else
                    tracks = context.Tracks;
                //---------------------------

                // searching by title/artist/album
                switch (selectedRadioBox)
                {
                    case "Title":
                        tracks = tracks
                            .Where(t => t.Name.Contains(searchTextBox.Text));
                        break;
                    case "Artist":
                        tracks = tracks
                            .Include(t => t.Album)
                            .Where(t => t.Album.Artist.Name.Contains(searchTextBox.Text));
                        break;
                    case "Album":
                        tracks = tracks
                            .Include(t => t.Album)
                            .Where(t => t.Album.Title.Contains(searchTextBox.Text));
                        break;
                    default:
                        tracks = context.Tracks;
                        break;

                }
                //-------------------------------

                IPagedList<Track> returnTracks = await tracks
                                             .Include(t => t.Album)
                                             .Include(t => t.Album.Artist)
                                             .Include(t => t.Genre)
                                             .Include(t => t.MediaType)
                                             .OrderBy(t => t.Name)
                                             .ToPagedListAsync(pageNumber, pageSize);

                return returnTracks;

            }
        }




        /// <summary>
        /// Switch to previous page if avilable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void PreviousPageButton_Click(object sender, EventArgs e)
        {
            if (list.HasPreviousPage)
            {
                list = await GetPagedListAsync(--pageNumber);
                nextPageButton.Enabled = list.HasNextPage;
                previousPageButton.Enabled = list.HasPreviousPage;
                DataGridView.DataSource = list.Select(t => new
                {
                    Artist = t.Album.Artist.Name,
                    Title = t.Name,
                    Album = t.Album.Title,
                }).ToList();
                pageLabel.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
            }
        }
        /// <summary>
        /// Switch to next page if avilable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void NextPageButton_Click(object sender, EventArgs e)
        {
            if (list.HasNextPage)
            {
                list = await GetPagedListAsync(++pageNumber);
                nextPageButton.Enabled = list.HasNextPage;
                previousPageButton.Enabled = list.HasPreviousPage;
                DataGridView.DataSource = list.Select(t => new
                {
                    Artist = t.Album.Artist.Name,
                    Title = t.Name,
                    Album = t.Album.Title,
                }).ToList();
                pageLabel.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
            }
        }

        /// <summary>
        /// Displays panel with detail informations about selected track
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            addedToCartPicture.Visible = false;
            DetailsPanel.Visible = true;
            DetailsTablePanel.Visible = true;
            if (e.RowIndex == -1)
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        OrderByAuthor();
                        break;
                    case 1:
                        OrderByTitle();
                        break;
                    case 2:
                        OrderByAlbum();
                        break;
                }
            }
            else
            {
                var selectedTrack = list[e.RowIndex];
                SelectedTrack = selectedTrack;

                ArtistLabel.Text = string.Format("Artist: {0}", selectedTrack.Album.Artist.Name.ToString());
                TitleLabel.Text = string.Format("Title: {0}", selectedTrack.Name.ToString());
                AlbumLabel.Text = string.Format("Album: {0}", selectedTrack.Album.Title.ToString());
                PriceLabel.Text = string.Format("Price: {0} $", selectedTrack.UnitPrice.ToString());
                GenreLabel.Text = string.Format("Genre: {0}", selectedTrack.Genre.Name);
                ComposerLabel.Text = string.Format("Composer: {0}", selectedTrack.Composer);
                TypeLabel.Text = string.Format("Media type: {0}", selectedTrack.MediaType.Name);
                SizeLabel.Text = string.Format("Size: {0} MB", Math.Round(ConvertBytesToMegabytes(selectedTrack.Bytes.Value), 2));

                TimeSpan t = TimeSpan.FromMilliseconds(selectedTrack.Milliseconds);
                var lengthInMinutes = t.ToString(@"mm\:ss");
                LengthLabel.Text = string.Format("Length: {0}", lengthInMinutes);





            }
        }

        private void OrderByAuthor()
        {
            var orderedList = list
                .OrderBy(x => x.Album.Artist.Name)
                .Select(t => new
                {
                    Artist = t.Album.Artist.Name,
                    Title = t.Name,
                    Album = t.Album.Title
                }).ToList();
            DataGridView.DataSource = orderedList;
        }
        private void OrderByTitle()
        {
            var orderedList = list
                .OrderBy(x => x.Name)
                .Select(t => new
                {
                    Artist = t.Album.Artist.Name,
                    Title = t.Name,
                    Album = t.Album.Title
                }).ToList();
            DataGridView.DataSource = orderedList;
        }
        private void OrderByAlbum()
        {
            var orderedList = list
                .OrderBy(x => x.Album.Title)
                .Select(t => new
                {
                    Artist = t.Album.Artist.Name,
                    Title = t.Name,
                    Album = t.Album.Title
                }).ToList();
            DataGridView.DataSource = orderedList;
        }

        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            addedToCartPicture.Show();
            if (!Cart.Contains(SelectedTrack))
                Cart.Add(SelectedTrack);
        }

        private void btn_Cart_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cartForm = new CartForm(Cart);
            cartForm.StartPosition = FormStartPosition.Manual;
            cartForm.Location = this.Location;
            cartForm.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new MainWindow();
            form.ShowDialog();
            this.Close();
        }

        private async void StoreForm_Load(object sender, EventArgs e)
        {
            using (var context = new ChinookEntities())
            {
                List<string> genresList = new List<string>();
                genresList.Add("");
                var genres = await context.Genres.Select(g => g.Name).ToListAsync();

                foreach (var genre in genres)
                {
                    if (!genresList.Contains(genre.ToString()))
                    {
                        genresList.Add(genre.ToString());
                    }
                }

                foreach (var item in genresList)
                {
                    GenreBox.Items.Add(item.ToString());
                }
            }
        }
    }
}
