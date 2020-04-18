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
    public partial class AddMediaType : Form
    {
        public AddMediaType()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new AddItemForm();
            form.ShowDialog();
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Type.Text))
            {
                errorProvider.SetError(txt_Type, "Enter type");
            }
            else
            {

                using (var context = new ChinookEntities())
                {
                    var newType = new MediaType()
                    {
                        Name = txt_Type.Text
                    };

                    if (!context.MediaTypes.Any(t => t.Name == newType.Name))
                        context.MediaTypes.Add(newType);

                    context.SaveChanges();
                }


                this.Hide();
                var form = new AddItemForm();
                form.ShowDialog();
                this.Close();
            }
        }
    }
}
