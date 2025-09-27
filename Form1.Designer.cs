namespace SidePixelDataBaseManagementSystem
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.materialGridView = new System.Windows.Forms.DataGridView();
            this.iDBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialMeasurementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new SidePixelDataBaseManagementSystem.DataSet();
            this.invoiceGridView = new System.Windows.Forms.DataGridView();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addMaterial = new System.Windows.Forms.Button();
            this.editMaterial = new System.Windows.Forms.Button();
            this.removeMaterial = new System.Windows.Forms.Button();
            this.removeInvoice = new System.Windows.Forms.Button();
            this.editInvoice = new System.Windows.Forms.Button();
            this.addInvoice = new System.Windows.Forms.Button();
            this.iDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.materialGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialGridView
            // 
            this.materialGridView.AllowUserToAddRows = false;
            this.materialGridView.AllowUserToDeleteRows = false;
            this.materialGridView.AllowUserToResizeColumns = false;
            this.materialGridView.AllowUserToResizeRows = false;
            this.materialGridView.AutoGenerateColumns = false;
            this.materialGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.materialGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBDataGridViewTextBoxColumn,
            this.materialNameDataGridViewTextBoxColumn,
            this.materialMeasurementDataGridViewTextBoxColumn,
            this.materialCostDataGridViewTextBoxColumn});
            this.materialGridView.DataSource = this.materialBindingSource;
            this.materialGridView.Location = new System.Drawing.Point(10, 10);
            this.materialGridView.Margin = new System.Windows.Forms.Padding(0);
            this.materialGridView.Name = "materialGridView";
            this.materialGridView.Size = new System.Drawing.Size(550, 185);
            this.materialGridView.TabIndex = 0;
            // 
            // iDBDataGridViewTextBoxColumn
            // 
            this.iDBDataGridViewTextBoxColumn.DataPropertyName = "ID_B";
            this.iDBDataGridViewTextBoxColumn.HeaderText = "ID_B";
            this.iDBDataGridViewTextBoxColumn.Name = "iDBDataGridViewTextBoxColumn";
            this.iDBDataGridViewTextBoxColumn.Visible = false;
            // 
            // materialNameDataGridViewTextBoxColumn
            // 
            this.materialNameDataGridViewTextBoxColumn.DataPropertyName = "MaterialName";
            this.materialNameDataGridViewTextBoxColumn.HeaderText = "Название материала";
            this.materialNameDataGridViewTextBoxColumn.Name = "materialNameDataGridViewTextBoxColumn";
            // 
            // materialMeasurementDataGridViewTextBoxColumn
            // 
            this.materialMeasurementDataGridViewTextBoxColumn.DataPropertyName = "MaterialMeasurement";
            this.materialMeasurementDataGridViewTextBoxColumn.HeaderText = "Измерение материала";
            this.materialMeasurementDataGridViewTextBoxColumn.Name = "materialMeasurementDataGridViewTextBoxColumn";
            // 
            // materialCostDataGridViewTextBoxColumn
            // 
            this.materialCostDataGridViewTextBoxColumn.DataPropertyName = "MaterialCost";
            this.materialCostDataGridViewTextBoxColumn.HeaderText = "Цена материала";
            this.materialCostDataGridViewTextBoxColumn.Name = "materialCostDataGridViewTextBoxColumn";
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            this.materialBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceGridView
            // 
            this.invoiceGridView.AllowUserToAddRows = false;
            this.invoiceGridView.AllowUserToDeleteRows = false;
            this.invoiceGridView.AllowUserToResizeColumns = false;
            this.invoiceGridView.AllowUserToResizeRows = false;
            this.invoiceGridView.AutoGenerateColumns = false;
            this.invoiceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDADataGridViewTextBoxColumn,
            this.fKBDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.invoiceGridView.DataSource = this.invoiceBindingSource;
            this.invoiceGridView.Location = new System.Drawing.Point(10, 205);
            this.invoiceGridView.Margin = new System.Windows.Forms.Padding(0);
            this.invoiceGridView.Name = "invoiceGridView";
            this.invoiceGridView.Size = new System.Drawing.Size(550, 185);
            this.invoiceGridView.TabIndex = 1;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.dataSet;
            // 
            // addMaterial
            // 
            this.addMaterial.Location = new System.Drawing.Point(565, 10);
            this.addMaterial.Name = "addMaterial";
            this.addMaterial.Size = new System.Drawing.Size(210, 60);
            this.addMaterial.TabIndex = 2;
            this.addMaterial.Text = "Добавить Материал";
            this.addMaterial.UseVisualStyleBackColor = true;
            this.addMaterial.Click += new System.EventHandler(this.addMaterial_Click);
            // 
            // editMaterial
            // 
            this.editMaterial.Location = new System.Drawing.Point(565, 72);
            this.editMaterial.Name = "editMaterial";
            this.editMaterial.Size = new System.Drawing.Size(210, 60);
            this.editMaterial.TabIndex = 3;
            this.editMaterial.Text = "Редактировать Материал";
            this.editMaterial.UseVisualStyleBackColor = true;
            this.editMaterial.Click += new System.EventHandler(this.editMaterial_Click);
            // 
            // removeMaterial
            // 
            this.removeMaterial.Location = new System.Drawing.Point(565, 135);
            this.removeMaterial.Name = "removeMaterial";
            this.removeMaterial.Size = new System.Drawing.Size(210, 60);
            this.removeMaterial.TabIndex = 4;
            this.removeMaterial.Text = "Удалить Материал";
            this.removeMaterial.UseVisualStyleBackColor = true;
            this.removeMaterial.Click += new System.EventHandler(this.removeMaterial_Click);
            // 
            // removeInvoice
            // 
            this.removeInvoice.Location = new System.Drawing.Point(565, 330);
            this.removeInvoice.Name = "removeInvoice";
            this.removeInvoice.Size = new System.Drawing.Size(210, 60);
            this.removeInvoice.TabIndex = 7;
            this.removeInvoice.Text = "Удалить Приход/Уход";
            this.removeInvoice.UseVisualStyleBackColor = true;
            this.removeInvoice.Click += new System.EventHandler(this.removeInvoice_Click);
            // 
            // editInvoice
            // 
            this.editInvoice.Location = new System.Drawing.Point(565, 267);
            this.editInvoice.Name = "editInvoice";
            this.editInvoice.Size = new System.Drawing.Size(210, 60);
            this.editInvoice.TabIndex = 6;
            this.editInvoice.Text = "Редактировать Приход/Уход";
            this.editInvoice.UseVisualStyleBackColor = true;
            this.editInvoice.Click += new System.EventHandler(this.editInvoice_Click);
            // 
            // addInvoice
            // 
            this.addInvoice.Location = new System.Drawing.Point(565, 205);
            this.addInvoice.Name = "addInvoice";
            this.addInvoice.Size = new System.Drawing.Size(210, 60);
            this.addInvoice.TabIndex = 5;
            this.addInvoice.Text = "Добавить Приход/Уход";
            this.addInvoice.UseVisualStyleBackColor = true;
            this.addInvoice.Click += new System.EventHandler(this.addInvoice_Click);
            // 
            // iDADataGridViewTextBoxColumn
            // 
            this.iDADataGridViewTextBoxColumn.DataPropertyName = "ID_A";
            this.iDADataGridViewTextBoxColumn.HeaderText = "ID_A";
            this.iDADataGridViewTextBoxColumn.Name = "iDADataGridViewTextBoxColumn";
            this.iDADataGridViewTextBoxColumn.Visible = false;
            // 
            // fKBDataGridViewTextBoxColumn
            // 
            this.fKBDataGridViewTextBoxColumn.DataPropertyName = "FK_B";
            this.fKBDataGridViewTextBoxColumn.HeaderText = "Название материала";
            this.fKBDataGridViewTextBoxColumn.Name = "fKBDataGridViewTextBoxColumn";
            this.fKBDataGridViewTextBoxColumn.Visible = false;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Количество прихода/ухода";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата прихода/ухода";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 401);
            this.Controls.Add(this.removeInvoice);
            this.Controls.Add(this.editInvoice);
            this.Controls.Add(this.addInvoice);
            this.Controls.Add(this.removeMaterial);
            this.Controls.Add(this.editMaterial);
            this.Controls.Add(this.addMaterial);
            this.Controls.Add(this.invoiceGridView);
            this.Controls.Add(this.materialGridView);
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "mainForm";
            this.Text = "SidePixel DataBase Management System";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView materialGridView;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private DataSet dataSet;
        private System.Windows.Forms.DataGridView invoiceGridView;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.Button addMaterial;
        private System.Windows.Forms.Button editMaterial;
        private System.Windows.Forms.Button removeMaterial;
        private System.Windows.Forms.Button removeInvoice;
        private System.Windows.Forms.Button editInvoice;
        private System.Windows.Forms.Button addInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialMeasurementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}

