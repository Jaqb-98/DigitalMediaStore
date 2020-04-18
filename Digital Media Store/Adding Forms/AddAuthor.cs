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

namespace Digital_Media_Store
{
    public partial class AddAuthor : Form
    {
        public AddAuthor()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (String.IsNullOrEmpty(txt_AuthorName.Text))
            {
                errorProvider.SetError(txt_AuthorName, "Enter author name");
            }
            else
            {

                using (var context = new ChinookEntities())
                {
                    var newArtist = new Artist()
                    {
                        Name = txt_AuthorName.Text
                    };

                    if (!context.Artists.Any(a => a.Name == newArtist.Name))
                        context.Artists.Add(newArtist);
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
