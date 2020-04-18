using ClassLibrary;
using Digital_Media_Store.Adding_Forms;
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

namespace Digital_Media_Store
{
    public partial class AddItemForm : Form
    {
        private Artist Artist;
        private Album Album;
        private Genre Genre;
        private MediaType MediaType;
        public AddItemForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private async void btn_Add_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (ValidateFields())
            {

                using (var context = new ChinookEntities())
                {
                    Artist = await context.Artists
                        .Where(a => a.Name == comboBox_Author.SelectedItem.ToString())
                        .FirstOrDefaultAsync();

                    Album = await context.Albums
                        .Where(a => a.Title == comboBox_Album.SelectedItem.ToString())
                        .FirstOrDefaultAsync();

                    Genre = await context.Genres
                        .Where(g => g.Name == comboBox_Genre.SelectedItem.ToString())
                        .FirstOrDefaultAsync();

                    MediaType = await context.MediaTypes
                        .Where(m => m.Name == comboBox_MediaType.SelectedItem.ToString())
                        .FirstOrDefaultAsync();

                    if (double.TryParse(txt_Size.Text, out double size)) { }
                    if (double.TryParse(txt_Minutes.Text, out double minutes)) { }
                    if (double.TryParse(txt_Seconds.Text, out double seconds)) { }
                    if (decimal.TryParse(txt_Price.Text, out decimal price)) { }

                    var newTrack = new Track()
                    {
                        Name = txt_Title.Text,
                        Album = this.Album,
                        AlbumId = this.Album.AlbumId,
                        Bytes = (int)ConvertMegabytesToBytes(size),
                        Composer = txt_Composer.Text,
                        Genre = this.Genre,
                        GenreId = this.Genre.GenreId,
                        MediaType = this.MediaType,
                        MediaTypeId = this.MediaType.MediaTypeId,
                        Milliseconds = (int)(ConvertMinutesToMilliseconds(minutes) + ConvertSecondsToMilliseconds(seconds)),
                        UnitPrice = price


                    };

                    double ConvertMinutesToMilliseconds(double time)
                    {
                        return TimeSpan.FromMinutes(time).TotalMilliseconds;
                    }

                    double ConvertSecondsToMilliseconds(double time)
                    {
                        return TimeSpan.FromSeconds(time).TotalMilliseconds;
                    }

                    double ConvertMegabytesToBytes(double mb)
                    {
                        return mb * 1048576;
                    }


                    context.Tracks.Add(newTrack);
                    context.SaveChanges();

                    MessageBox.Show("Track added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    var form = new AddItemForm();
                    form.ShowDialog();
                    this.Close();
                }
            }
        }

        private async void AddItemForm_Load(object sender, EventArgs e)
        {
            using (var context = new ChinookEntities())
            {
                var authors = await context.Artists.ToListAsync();
                foreach (var author in authors)
                {
                    if (!comboBox_Author.Items.Contains(author.Name))
                        comboBox_Author.Items.Add(author.Name);
                }




                var genres = await context.Genres.ToListAsync();

                foreach (var genre in genres)
                {
                    if (!comboBox_Genre.Items.Contains(genre.Name))
                        comboBox_Genre.Items.Add(genre.Name);
                }


                var mediaTypes = await context.MediaTypes.ToListAsync();
                foreach (var type in mediaTypes)
                {
                    if (!comboBox_MediaType.Items.Contains(type.Name))
                        comboBox_MediaType.Items.Add(type.Name);

                }


            }
        }

        private async void comboBox_Author_SelectedValueChanged(object sender, EventArgs e)
        {
            using (var context = new ChinookEntities())
            {
                var selectedAuthor = comboBox_Author.SelectedItem;

                var artist = context.Artists
                    .Where(a => a.Name == (string)selectedAuthor)
                    .FirstOrDefault();

                var albums = await context.Albums
                    .Where(a => a.ArtistId == artist.ArtistId)
                    .ToListAsync();


                foreach (var album in albums)
                {
                    if (!comboBox_Album.Items.Contains(album.Title))
                        comboBox_Album.Items.Add(album.Title);
                }

            }
        }

        private void btn_NewAuthor_Click(object sender, EventArgs e)
        {
            this.Hide();
            var add = new AddAuthor();
            add.ShowDialog();
            this.Close();
        }

        private void btn_NewAlbum_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new AddAlbum();
            form.ShowDialog();
            this.Close();
        }

        private void btn_NewGenre_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new AddGenre();
            form.ShowDialog();
            this.Close();
        }

        private void btn_NewMediaType_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new AddMediaType();
            form.ShowDialog();
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new ManagementForm();
            form.ShowDialog();
            this.Close();
        }


        private bool ValidateFields()
        {
            int errors = 0;

            if (String.IsNullOrEmpty(txt_Title.Text))
            {
                errorProvider.SetError(txt_Title, "Enter title");
                errors++;
            }
            if (String.IsNullOrEmpty(txt_Size.Text))
            {
                errorProvider.SetError(txt_Size, "Enter file size");
                errors++;
            }
            if (String.IsNullOrEmpty(txt_Seconds.Text))
            {
                errorProvider.SetError(txt_Seconds, "Enter file length");
                errors++;
            }
            if (String.IsNullOrEmpty(txt_Price.Text))
            {
                errorProvider.SetError(txt_Price, "Enter price");
                errors++;
            }
            if (comboBox_Album.SelectedIndex<0)
            {
                errorProvider.SetError(comboBox_Album, "Chooose album");
                errors++;
            }
            if (comboBox_Author.SelectedIndex < 0)
            {
                errorProvider.SetError(comboBox_Author, "Chooose author");
                errors++;
            }
            if (comboBox_Genre.SelectedIndex < 0)
            {
                errorProvider.SetError(comboBox_Genre, "Chooose genre");
                errors++;
            }
            if (comboBox_MediaType.SelectedIndex < 0)
            {
                errorProvider.SetError(comboBox_MediaType, "Chooose media type");
                errors++;
            }


            if (errors > 0)
                return false;
            else return true;
        }
    }
}
