using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Media_Store.Adding_Forms
{
    public partial class AddGenre : Form
    {
        public AddGenre()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Genre.Text))
            {
                errorProvider.SetError(txt_Genre, "Enter genre");
            }
            else
            {

                using (var context = new ChinookEntities())
                {
                    var newGenre = new Genre()
                    {
                        Name = txt_Genre.Text
                    };

                    if (!context.Genres.Any(g => g.Name == newGenre.Name))
                        context.Genres.Add(newGenre);
                    context.SaveChanges();
                }

                this.Hide();
                var form = new AddItemForm();
                form.ShowDialog();
                this.Close();
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
