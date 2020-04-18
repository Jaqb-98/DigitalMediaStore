using ClassLibrary;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Digital_Media_Store
{
    public partial class ManagementForm : Form
    {
        public ManagementForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private async void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


            listView1.Items.Clear();
            listView1.Visible = true;

            loadingPicture.Show();
            loadingPicture.Update();
            var year = dateTimePicker1.Value.Year;
            var month = dateTimePicker1.Value.Month;
            var day = dateTimePicker1.Value.Day;
            try
            {

                using (var context = new ChinookEntities())
                {
                    var invoicesFromSelectedDate = await context.Invoices
                        .Include(i => i.InvoiceLines)
                        .Include(i => i.Customer)
                        .Where(i => i.InvoiceDate.Year == year && i.InvoiceDate.Month == month && i.InvoiceDate.Day == day)
                        .ToListAsync();

                    foreach (var invoice in invoicesFromSelectedDate)
                    {
                        var customer = invoice.Customer;
                        ListViewGroup lvg = new ListViewGroup($"Order date: {invoice.InvoiceDate}, Order Number: {invoice.InvoiceId}, CustomerID: {customer.CustomerId} {customer.FirstName} {customer.LastName}");
                        listView1.Groups.Add(lvg);
                        foreach (var item in invoice.InvoiceLines)
                        {
                            ListViewItem lvi = new ListViewItem($"{item.Track.TrackId}");
                            lvi.SubItems.Add($"{item.Track.UnitPrice}");
                            lvi.SubItems.Add($"{item.Quantity}");
                            lvi.ToolTipText = $"Title: {item.Track.Name}, Author: {item.Track.Album.Artist.Name}, Album: {item.Track.Album.Title}";
                            listView1.Items.Add(lvi);
                            lvg.Items.Add(lvi);

                        }
                    }

                }
            }
            catch { }

            loadingPicture.Hide();

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new MainWindow();
            form.ShowDialog();
            this.Close();
        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addItemForm = new AddItemForm();
            addItemForm.ShowDialog();
            
        }
    }
}
