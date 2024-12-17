using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using PR3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3
{
    public partial class FormProducts : Form
    {
        private TestDbContext? db;

        public FormProducts()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.db = new TestDbContext();

            this.db.Products.Load();
            this.dataGridViewProducts.DataSource = db.Products.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (this.db != null)
            {
                var currentRow = this.dataGridViewProducts.CurrentRow;

                if (currentRow == null)
                {
                    return;
                }

                var product = (Product)currentRow.DataBoundItem;

                if (product != null)
                {
                    this.db.Entry(product).Collection(e => e.PartnersProducts).Load();

                    this.dataGridViewPartnersProducts.DataSource = product.PartnersProducts;
                    this.dataGridViewTypesOfProducts.DataSource = product.IdTypeOfProduct;
                }
            }
        }

        private void buttonGoBack_Click_1(object sender, EventArgs e)
        {
            FormMain form = new FormMain();
            form.Show();
            this.Hide();
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            this.db!.SaveChanges();

            this.dataGridViewProducts.Refresh();
            this.dataGridViewProducts.Refresh();
        }
    }
}
