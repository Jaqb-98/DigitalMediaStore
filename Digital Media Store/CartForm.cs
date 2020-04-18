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
    public partial class CartForm : Form
    {
        private IList<Track> Cart;
        private IList<InvoiceLine> InvoiceLines;
        public CartForm(IList<Track> cart)
        {
            InvoiceLines = new List<InvoiceLine>();
            Cart = cart;
            InitializeComponent();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            dgv_Cart.DataSource = Cart.Select(t => new
            {
                Title = t.Name,
                Artist = t.Album.Artist.Name,
                Price = t.UnitPrice
            }).ToList();

            var maxWidth = (dgv_Cart.Width / 3) - 25;

            dgv_Cart.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_Cart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            foreach (DataGridViewColumn column in dgv_Cart.Columns)
            {
                if (column.Width > maxWidth)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    column.Width = maxWidth;
                }
            }

            NumericUpDownColumn numericUpDownColumn = new NumericUpDownColumn();
            numericUpDownColumn.HeaderText = "Quantity";
            dgv_Cart.Columns.Insert(3, numericUpDownColumn);

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Remove from cart";
            dgv_Cart.Columns.Insert(4, buttonColumn);
        }

        private void dgv_Cart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var track = Cart[e.RowIndex];
                Cart.Remove(track);
            }
            dgv_Cart.DataSource = Cart.Select(t => new
            {
                Title = t.Name,
                Artist = t.Album.Artist.Name,
                Price = t.UnitPrice
            }).ToList();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
                .FirstOrDefault(c => c is StoreForm);

            if (formToShow != null)
                formToShow.Show();
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            if (Cart.Count != 0)
            {
                this.Hide();

                for (int i = 0; i < Cart.Count; i++)
                {
                    if (int.TryParse(dgv_Cart.Rows[i].Cells[3].FormattedValue.ToString(), out int quantity)) { }

                    InvoiceLines.Add(new InvoiceLine()
                    {
                        Quantity = quantity,
                        Track = Cart[i],
                        TrackId = Cart[i].TrackId,
                        UnitPrice = Cart[i].UnitPrice

                    });

                }

                var customerInfoForm = new CustomerInfoForm(InvoiceLines);
                customerInfoForm.StartPosition = FormStartPosition.Manual;
                customerInfoForm.Location = this.Location;
                customerInfoForm.ShowDialog();
            }
            else
            {
                errorProvider.SetError(btn_Buy, "Your cart is empty");
            }

        }
    }
}
