using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMSClassLibrary;
using PagedList;


namespace Digital_Media_Store
{
    public partial class StoreForm : Form
    {
        int pageNumber = 1;
        IPagedList<Track> list;

        public StoreForm()
        {
            InitializeComponent();
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            list = await GetPagedListAsync();
            nextPageButton.Enabled = list.HasNextPage;
            previousPageButton.Enabled = list.HasPreviousPage;
            DataTable.DataSource = list.Select(t => new
            {
                Artist = t.Album.Artist.Name,
                Title = t.Name,
                Album = t.Album.Title,
            }).ToList();
            pageLabel.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
        }

        private void storePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        private async Task<IPagedList<Track>> GetPagedListAsync(int pageNumber = 1, int pageSize = 25)
        {

            using (var context = new ChinookEntities())
            {
                var selectedRadioBox = radioGroupBox.Controls.OfType<RadioButton>()
                                                             .FirstOrDefault(b => b.Checked)
                                                             .Text;

                IQueryable<Track> tracks;

                //bool playlistSelected = (playlistBox.SelectedIndex == -1 || playlistBox.SelectedIndex == 0) ? false : true;

                //if (playlistSelected)
                //{
                //    tracks = await PlaylistFilter(context, pageNumber, pageSize);
                //}

                //if (playlistBox.SelectedIndex == -1 || playlistBox.SelectedIndex == 0)
                //    tracks = context.Tracks.Include(t => t.Album).OrderBy(x => x.Name).ToPagedList(pageNumber, pageSize);



                switch (selectedRadioBox)
                {
                    case "Title":
                        tracks = context.Tracks
                            .Where(t => t.Name.Contains(searchTextBox.Text));
                        break;
                    case "Artist":
                        tracks = context.Tracks
                            .Include(t => t.Album)
                            .Where(t => t.Album.Artist.Name.Contains(searchTextBox.Text));
                        break;
                    case "Album":
                        tracks = context.Tracks
                            .Include(t => t.Album)
                            .Where(t => t.Album.Title.Contains(searchTextBox.Text));
                        break;
                    default:
                        tracks = context.Tracks;
                        break;

                }

                IPagedList<Track> returnTracks = tracks
                                            .Include(t => t.Album)
                                            .Include(t => t.Album.Artist)
                                            .Include(t => t.Genre)
                                            .Include(t => t.MediaType)
                                            .OrderBy(t => t.Name)
                                            .ToPagedList(pageNumber, pageSize);

                return returnTracks;

            }
        }



        private async Task<IPagedList<Track>> PlaylistFilter(ChinookEntities context, int pageNumber, int pageSize)
        {

            var selectedPlayList = playlistBox.Text;


            var tracks = await context.Playlists.Where(t => t.Name == selectedPlayList)
                                         .FirstOrDefaultAsync();


            return tracks.Tracks.ToPagedList(pageNumber, pageSize);

        }

        private async void PreviousPageButton_Click(object sender, EventArgs e)
        {
            if (list.HasPreviousPage)
            {
                list = await GetPagedListAsync(--pageNumber);
                nextPageButton.Enabled = list.HasNextPage;
                previousPageButton.Enabled = list.HasPreviousPage;
                DataTable.DataSource = list.Select(t => new
                {
                    Artist = t.Album.Artist.Name,
                    Title = t.Name,
                    Album = t.Album.Title,
                }).ToList();
                pageLabel.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
            }
        }

        private async void PextPageButton_Click(object sender, EventArgs e)
        {
            if (list.HasNextPage)
            {
                list = await GetPagedListAsync(++pageNumber);
                nextPageButton.Enabled = list.HasNextPage;
                previousPageButton.Enabled = list.HasPreviousPage;
                DataTable.DataSource = list.Select(t => new
                {
                    Artist = t.Album.Artist.Name,
                    Title = t.Name,
                    Album = t.Album.Title,
                }).ToList();
                pageLabel.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
            }
        }

        private void DataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DetailsPanel.Visible = true;
            var selectedTrack = list[e.RowIndex];

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


            double ConvertBytesToMegabytes(long bytes)
            {
                return (bytes / 1024f) / 1024f;
            }

        }

  
    }
}
