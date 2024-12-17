using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using PR3.Models;
using System.ComponentModel;

namespace PR3
{
    public partial class FormMain : Form
    {
        private TestDbContext? db;
        public FormMain()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.db = new TestDbContext();

            this.db.Partners.Load();
            this.dataGridViewPartners.DataSource = db.Partners.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.db!.SaveChanges();

            this.dataGridViewPartners.Refresh();
            this.dataGridViewPartners.Refresh();
        }

        private void dataGridViewPartners_SelectionChanged(object sender, EventArgs e)
        {
            if (this.db != null)
            {
                var currentRow = this.dataGridViewPartners.CurrentRow;

                if (currentRow == null)
                {
                    return;
                }

                var partner = (Partner)currentRow.DataBoundItem;
                if (partner != null)
                {
                this.db.Entry(partner).Collection(e => e.PartnersProducts).Load();
                this.dataGridViewPartnersProducts.DataSource = partner.PartnersProducts;

                /*this.db.Entry(partner).Collection(e => e.IdTypeOfPartnerNavigation).Load();*/
                }
            }
        }

        private void buttonGoNext_Click(object sender, EventArgs e)
        {
            FormProducts form = new FormProducts();
            form.Show();
            this.Hide();
        }
    }
}