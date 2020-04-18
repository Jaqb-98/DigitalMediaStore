using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Digital_Media_Store
{
    public partial class CustomerInfoForm : Form
    {
        private IList<InvoiceLine> InvoiceLines;
        public CustomerInfoForm(IList<InvoiceLine> invoiceLines)
        {
            this.InvoiceLines = invoiceLines;
            InitializeComponent();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^([0-9]{9})$").Success;
        }




        private void btn_SubmitDetails_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (txt_Boxes_Validating())
            {
                var newCustomer = new Customer()
                {
                    FirstName = txt_Name.Text,
                    LastName = txt_LastName.Text,
                    Company = String.IsNullOrEmpty(txt_Company.Text) ? null : txt_Company.Text,
                    Address = txt_Address.Text,
                    City = txt_City.Text,
                    Country = txt_Country.Text,
                    PostalCode = String.IsNullOrEmpty(txt_PostalCode.Text) ? null : txt_PostalCode.Text,
                    Phone = String.IsNullOrEmpty(txt_Phone.Text) ? null : txt_Phone.Text,
                    Fax = String.IsNullOrEmpty(txt_Fax.Text) ? null : txt_Fax.Text,
                    Email = txt_Email.Text
                };

                this.Hide();
                var summaryForm = new SummaryForm(newCustomer, InvoiceLines);
                summaryForm.StartPosition = FormStartPosition.Manual;
                summaryForm.Location = this.Location;
                summaryForm.ShowDialog();
            }
        }


        private bool txt_Boxes_Validating()
        {
            int wrongInputs = 0;
            if (String.IsNullOrEmpty(txt_Name.Text) || !Regex.Match(txt_Name.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                errorProvider.SetError(txt_Name, "Invalid first name");
                wrongInputs++;
            }
            if (String.IsNullOrEmpty(txt_LastName.Text) || !Regex.Match(txt_LastName.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                errorProvider.SetError(txt_LastName, "Invalid last name");
                wrongInputs++;
            }
            if (String.IsNullOrEmpty(txt_Country.Text))
            {
                errorProvider.SetError(txt_Country, "Please enter your country");
                wrongInputs++;
            }
            if (String.IsNullOrEmpty(txt_City.Text))
            {
                errorProvider.SetError(txt_City, "Please enter your city");
                wrongInputs++;
            }
            if (String.IsNullOrEmpty(txt_Address.Text))
            {
                errorProvider.SetError(txt_Address, "Please enter your address");
                wrongInputs++;
            }
            if (!IsValidEmail(txt_Email.Text))
            {
                errorProvider.SetError(txt_Email, "Please enter valid email address");
                wrongInputs++;
            }
            if (!IsPhoneNumber(txt_Phone.Text) && !String.IsNullOrEmpty(txt_Phone.Text))
            {
                errorProvider.SetError(txt_Phone, "Phone number format: xxxxxxxxx");
                wrongInputs++;
            }

            if (wrongInputs > 0)
                return false;
            else return true;

        }
    }



}