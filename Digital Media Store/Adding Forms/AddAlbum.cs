using ClassLibrary;
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
    public partial class AddAlbum : Form
    {
        public AddAlbum()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (comboBox_Author.SelectedIndex < 0)
            {
                errorProvider.SetError(comboBox_Author, "Choose author");
            }
            else if (String.IsNullOrEmpty(txt_Title.Text))
            {
                errorProvider.SetError(txt_Title, "Enter album title");
            }
            else
            {

                using (var context = new ChinookEntities())
                {
                    string selectedArtist = comboBox_Author.SelectedItem.ToString();

                    var artist = context.Artists
                        .Where(a => a.Name == selectedArtist)
                        .FirstOrDefault();

                    var newAlbum = new Album()
                    {
                        Artist = artist,
                        ArtistId = artist.ArtistId,
                        Title = txt_Title.Text
                    };

                    context.Albums.Add(newAlbum);
                    context.SaveChanges();

                }
                this.Hide();
                var form = new AddItemForm();
                form.ShowDialog();
                this.Close();

            }
        }

        private async void AddAlbum_Load(object sender, EventArgs e)
        {
            using (var context = new ChinookEntities())
            {

                var authors = await context.Artists.ToListAsync();
                foreach (var author in authors)
                {
                    if (!comboBox_Author.Items.Contains(author.Name))
                        comboBox_Author.Items.Add(author.Name);
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new AddItemForm();
            form.ShowDialog();
            this.Close();
        }
    }
}
