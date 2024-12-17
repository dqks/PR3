namespace PR3
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            buttonSave = new Button();
            panelPartners = new Panel();
            dataGridViewPartners = new DataGridView();
            panelTypesOfPartners = new Panel();
            dataGridViewTypesOfPartners = new DataGridView();
            panelPartnersProducts = new Panel();
            dataGridViewPartnersProducts = new DataGridView();
            buttonGoNext = new Button();
            panelTop.SuspendLayout();
            panelPartners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartners).BeginInit();
            panelTypesOfPartners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypesOfPartners).BeginInit();
            panelPartnersProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartnersProducts).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(buttonGoNext);
            panelTop.Controls.Add(buttonSave);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(1257, 96);
            panelTop.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Dock = DockStyle.Left;
            buttonSave.Location = new Point(10, 10);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(157, 76);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // panelPartners
            // 
            panelPartners.Controls.Add(dataGridViewPartners);
            panelPartners.Dock = DockStyle.Left;
            panelPartners.Location = new Point(0, 96);
            panelPartners.Name = "panelPartners";
            panelPartners.Padding = new Padding(10);
            panelPartners.Size = new Size(633, 654);
            panelPartners.TabIndex = 1;
            // 
            // dataGridViewPartners
            // 
            dataGridViewPartners.BackgroundColor = Color.White;
            dataGridViewPartners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPartners.Dock = DockStyle.Fill;
            dataGridViewPartners.Location = new Point(10, 10);
            dataGridViewPartners.Name = "dataGridViewPartners";
            dataGridViewPartners.Size = new Size(613, 634);
            dataGridViewPartners.TabIndex = 0;
            dataGridViewPartners.SelectionChanged += dataGridViewPartners_SelectionChanged;
            // 
            // panelTypesOfPartners
            // 
            panelTypesOfPartners.Controls.Add(dataGridViewTypesOfPartners);
            panelTypesOfPartners.Dock = DockStyle.Top;
            panelTypesOfPartners.Location = new Point(633, 96);
            panelTypesOfPartners.Name = "panelTypesOfPartners";
            panelTypesOfPartners.Padding = new Padding(10);
            panelTypesOfPartners.Size = new Size(624, 336);
            panelTypesOfPartners.TabIndex = 2;
            // 
            // dataGridViewTypesOfPartners
            // 
            dataGridViewTypesOfPartners.BackgroundColor = Color.White;
            dataGridViewTypesOfPartners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypesOfPartners.Dock = DockStyle.Fill;
            dataGridViewTypesOfPartners.Location = new Point(10, 10);
            dataGridViewTypesOfPartners.Name = "dataGridViewTypesOfPartners";
            dataGridViewTypesOfPartners.Size = new Size(604, 316);
            dataGridViewTypesOfPartners.TabIndex = 0;
            // 
            // panelPartnersProducts
            // 
            panelPartnersProducts.Controls.Add(dataGridViewPartnersProducts);
            panelPartnersProducts.Dock = DockStyle.Fill;
            panelPartnersProducts.Location = new Point(633, 432);
            panelPartnersProducts.Name = "panelPartnersProducts";
            panelPartnersProducts.Padding = new Padding(10);
            panelPartnersProducts.Size = new Size(624, 318);
            panelPartnersProducts.TabIndex = 3;
            // 
            // dataGridViewPartnersProducts
            // 
            dataGridViewPartnersProducts.BackgroundColor = Color.White;
            dataGridViewPartnersProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPartnersProducts.Dock = DockStyle.Fill;
            dataGridViewPartnersProducts.Location = new Point(10, 10);
            dataGridViewPartnersProducts.Name = "dataGridViewPartnersProducts";
            dataGridViewPartnersProducts.Size = new Size(604, 298);
            dataGridViewPartnersProducts.TabIndex = 0;
            // 
            // buttonGoNext
            // 
            buttonGoNext.Dock = DockStyle.Left;
            buttonGoNext.Location = new Point(167, 10);
            buttonGoNext.Name = "buttonGoNext";
            buttonGoNext.Size = new Size(210, 76);
            buttonGoNext.TabIndex = 1;
            buttonGoNext.Text = "Перейти на продукты";
            buttonGoNext.UseVisualStyleBackColor = true;
            buttonGoNext.Click += buttonGoNext_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1257, 750);
            Controls.Add(panelPartnersProducts);
            Controls.Add(panelTypesOfPartners);
            Controls.Add(panelPartners);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "FormMain";
            Text = "Партнеры";
            panelTop.ResumeLayout(false);
            panelPartners.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartners).EndInit();
            panelTypesOfPartners.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypesOfPartners).EndInit();
            panelPartnersProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartnersProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Button buttonSave;
        private Panel panelPartners;
        private DataGridView dataGridViewPartners;
        private Panel panelTypesOfPartners;
        private DataGridView dataGridViewTypesOfPartners;
        private Panel panelPartnersProducts;
        private DataGridView dataGridViewPartnersProducts;
        private Button buttonGoNext;
    }
}
