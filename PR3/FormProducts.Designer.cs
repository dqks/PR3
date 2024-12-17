namespace PR3
{
    partial class FormProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            buttonGoBack = new Button();
            buttonSave = new Button();
            panelProducts = new Panel();
            dataGridViewProducts = new DataGridView();
            panelTypesOfProducts = new Panel();
            dataGridViewTypesOfProducts = new DataGridView();
            panelPartnersProducts = new Panel();
            dataGridViewPartnersProducts = new DataGridView();
            panelTop.SuspendLayout();
            panelProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            panelTypesOfProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypesOfProducts).BeginInit();
            panelPartnersProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartnersProducts).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonGoBack);
            panelTop.Controls.Add(buttonSave);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(1257, 99);
            panelTop.TabIndex = 0;
            // 
            // buttonGoBack
            // 
            buttonGoBack.Dock = DockStyle.Left;
            buttonGoBack.Location = new Point(191, 10);
            buttonGoBack.Name = "buttonGoBack";
            buttonGoBack.Size = new Size(232, 79);
            buttonGoBack.TabIndex = 1;
            buttonGoBack.Text = "Перейти на партнеров";
            buttonGoBack.UseVisualStyleBackColor = true;
            buttonGoBack.Click += buttonGoBack_Click_1;
            // 
            // buttonSave
            // 
            buttonSave.Dock = DockStyle.Left;
            buttonSave.Location = new Point(10, 10);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(181, 79);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click_1;
            // 
            // panelProducts
            // 
            panelProducts.Controls.Add(dataGridViewProducts);
            panelProducts.Dock = DockStyle.Left;
            panelProducts.Location = new Point(0, 99);
            panelProducts.Name = "panelProducts";
            panelProducts.Padding = new Padding(10);
            panelProducts.Size = new Size(614, 651);
            panelProducts.TabIndex = 1;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.BackgroundColor = Color.White;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Dock = DockStyle.Fill;
            dataGridViewProducts.Location = new Point(10, 10);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.Size = new Size(594, 631);
            dataGridViewProducts.TabIndex = 0;
            dataGridViewProducts.SelectionChanged += dataGridViewProducts_SelectionChanged;
            // 
            // panelTypesOfProducts
            // 
            panelTypesOfProducts.Controls.Add(dataGridViewTypesOfProducts);
            panelTypesOfProducts.Dock = DockStyle.Top;
            panelTypesOfProducts.Location = new Point(614, 99);
            panelTypesOfProducts.Name = "panelTypesOfProducts";
            panelTypesOfProducts.Padding = new Padding(10);
            panelTypesOfProducts.Size = new Size(643, 303);
            panelTypesOfProducts.TabIndex = 2;
            // 
            // dataGridViewTypesOfProducts
            // 
            dataGridViewTypesOfProducts.BackgroundColor = Color.White;
            dataGridViewTypesOfProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypesOfProducts.Dock = DockStyle.Fill;
            dataGridViewTypesOfProducts.Location = new Point(10, 10);
            dataGridViewTypesOfProducts.Name = "dataGridViewTypesOfProducts";
            dataGridViewTypesOfProducts.Size = new Size(623, 283);
            dataGridViewTypesOfProducts.TabIndex = 0;
            // 
            // panelPartnersProducts
            // 
            panelPartnersProducts.Controls.Add(dataGridViewPartnersProducts);
            panelPartnersProducts.Dock = DockStyle.Fill;
            panelPartnersProducts.Location = new Point(614, 402);
            panelPartnersProducts.Name = "panelPartnersProducts";
            panelPartnersProducts.Padding = new Padding(10);
            panelPartnersProducts.Size = new Size(643, 348);
            panelPartnersProducts.TabIndex = 3;
            // 
            // dataGridViewPartnersProducts
            // 
            dataGridViewPartnersProducts.BackgroundColor = Color.White;
            dataGridViewPartnersProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPartnersProducts.Dock = DockStyle.Fill;
            dataGridViewPartnersProducts.Location = new Point(10, 10);
            dataGridViewPartnersProducts.Name = "dataGridViewPartnersProducts";
            dataGridViewPartnersProducts.Size = new Size(623, 328);
            dataGridViewPartnersProducts.TabIndex = 0;
            // 
            // FormProducts
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1257, 750);
            Controls.Add(panelPartnersProducts);
            Controls.Add(panelTypesOfProducts);
            Controls.Add(panelProducts);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "FormProducts";
            Text = "Продукция";
            panelTop.ResumeLayout(false);
            panelProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            panelTypesOfProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypesOfProducts).EndInit();
            panelPartnersProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartnersProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Button buttonSave;
        private Panel panelProducts;
        private DataGridView dataGridViewProducts;
        private Panel panelTypesOfProducts;
        private Panel panelPartnersProducts;
        private DataGridView dataGridViewTypesOfProducts;
        private DataGridView dataGridViewPartnersProducts;
        private Button buttonGoBack;
    }
}