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
    public partial class SummaryForm : Form
    {
        private Customer Customer;
        private IList<InvoiceLine> InvoiceLines;
        public SummaryForm(Customer customer, IList<InvoiceLine> invoiceLines)
        {
            Customer = customer;
            InvoiceLines = invoiceLines;
            InitializeComponent();
        }

        private void btn_EditDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
                .FirstOrDefault(c => c is CustomerInfoForm);

            if (formToShow != null)
                formToShow.Show();
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            lbl_CustomerInfo.Text = $"Name: {Customer.FirstName} {Customer.LastName}\n" +
                                    $"Address: {Customer.Address}\n" +
                                    $"City: {Customer.City}\n" +
                                    $"Country: {Customer.Country}\n" +
                                    $"Phone: {Customer.Phone}\n" +
                                    $"Email: {Customer.Email}";

            foreach (var item in InvoiceLines)
            {
                ListViewItem lvi = new ListViewItem($"{item.Track.Album.Artist.Name}");
                lvi.SubItems.Add($"{ item.Track.Name}");
                lvi.SubItems.Add($"{item.UnitPrice}");
                lvi.SubItems.Add($"{item.Quantity}");
                list_Items.Items.Add(lvi);
            }

            var totalPrice = InvoiceLines.Sum(i => i.Quantity * i.UnitPrice);
            lbl_ItemSummary.Text = $"Total: {totalPrice}$";

        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {

            Customer = AddNewCustomer();
            CreateNewInvoice();


            this.Hide();
            var endForm = new EndForm();
            endForm.ShowDialog();
            this.Close();


        }

        private bool IsInDatabase(Customer customer)
        {
            using (var context = new ChinookEntities())
            {
                return !context.Customers
                    .Any(c => c.FirstName == customer.FirstName
                    && c.LastName == customer.LastName
                    && c.Address == customer.Address
                    && c.Country == customer.Country
                    && c.City == customer.City) ? true : false;
            }
        }

        private Customer AddNewCustomer()
        {
            using (var context = new ChinookEntities())
            {


                if (IsInDatabase(Customer))
                {
                    context.Customers.Add(Customer);
                    context.SaveChanges();
                    return Customer;
                }
                else
                {
                    return context.Customers
                        .Where(c => c.FirstName == Customer.FirstName
                    && c.LastName == Customer.LastName
                    && c.Address == Customer.Address
                    && c.Country == Customer.Country
                    && c.City == Customer.City)
                        .FirstOrDefault();

                }
            }

        }



        private void CreateNewInvoice()
        {

            using (var context = new ChinookEntities())
            {

                var newInvoice = new Invoice()
                {
                    BillingCountry = Customer.Country,
                    BillingCity = Customer.City,
                    CustomerId = Customer.CustomerId,
                    BillingAddress = Customer.Address,
                    BillingPostalCode = Customer.PostalCode,
                    BillingState = Customer.State,
                    InvoiceDate = DateTime.Now,

                };

                context.Invoices.Add(newInvoice);
                context.SaveChanges();

                foreach (var line in InvoiceLines)
                {
                    line.Invoice = newInvoice;
                    context.InvoiceLines.Add(line);
                }

                newInvoice.Total = newInvoice.InvoiceLines.Sum(i => i.UnitPrice * i.Quantity);
                context.SaveChanges();
            }
        }
    }
}
