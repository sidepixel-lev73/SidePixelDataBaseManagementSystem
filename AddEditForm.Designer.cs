namespace SidePixelDataBaseManagementSystem
{
    partial class AddEditForm
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
            this.materialNameLabel = new System.Windows.Forms.Label();
            this.materialMeasurementLabel = new System.Windows.Forms.Label();
            this.materialCostLabel = new System.Windows.Forms.Label();
            this.materialNameTextBox = new System.Windows.Forms.TextBox();
            this.materialMeasurementTextBox = new System.Windows.Forms.TextBox();
            this.materialCostTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.invoiceDateTextBox = new System.Windows.Forms.TextBox();
            this.invoiceAmountTextBox = new System.Windows.Forms.TextBox();
            this.invoiceMaterialNameTextBox = new System.Windows.Forms.TextBox();
            this.invoiceDateLabel = new System.Windows.Forms.Label();
            this.invoiceAmountLabel = new System.Windows.Forms.Label();
            this.invoiceMaterialNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialNameLabel
            // 
            this.materialNameLabel.AutoSize = true;
            this.materialNameLabel.Location = new System.Drawing.Point(64, 42);
            this.materialNameLabel.Name = "materialNameLabel";
            this.materialNameLabel.Size = new System.Drawing.Size(118, 13);
            this.materialNameLabel.TabIndex = 0;
            this.materialNameLabel.Text = "Название материала:";
            this.materialNameLabel.Visible = false;
            // 
            // materialMeasurementLabel
            // 
            this.materialMeasurementLabel.AutoSize = true;
            this.materialMeasurementLabel.Location = new System.Drawing.Point(12, 88);
            this.materialMeasurementLabel.Name = "materialMeasurementLabel";
            this.materialMeasurementLabel.Size = new System.Drawing.Size(170, 13);
            this.materialMeasurementLabel.TabIndex = 1;
            this.materialMeasurementLabel.Text = "Единица измерения материала:";
            this.materialMeasurementLabel.Visible = false;
            // 
            // materialCostLabel
            // 
            this.materialCostLabel.AutoSize = true;
            this.materialCostLabel.Location = new System.Drawing.Point(88, 135);
            this.materialCostLabel.Name = "materialCostLabel";
            this.materialCostLabel.Size = new System.Drawing.Size(94, 13);
            this.materialCostLabel.TabIndex = 2;
            this.materialCostLabel.Text = "Цена материала:";
            this.materialCostLabel.Visible = false;
            // 
            // materialNameTextBox
            // 
            this.materialNameTextBox.Location = new System.Drawing.Point(185, 39);
            this.materialNameTextBox.Name = "materialNameTextBox";
            this.materialNameTextBox.Size = new System.Drawing.Size(170, 20);
            this.materialNameTextBox.TabIndex = 3;
            this.materialNameTextBox.Visible = false;
            // 
            // materialMeasurementTextBox
            // 
            this.materialMeasurementTextBox.Location = new System.Drawing.Point(185, 85);
            this.materialMeasurementTextBox.Name = "materialMeasurementTextBox";
            this.materialMeasurementTextBox.Size = new System.Drawing.Size(170, 20);
            this.materialMeasurementTextBox.TabIndex = 4;
            this.materialMeasurementTextBox.Visible = false;
            // 
            // materialCostTextBox
            // 
            this.materialCostTextBox.Location = new System.Drawing.Point(185, 132);
            this.materialCostTextBox.Name = "materialCostTextBox";
            this.materialCostTextBox.Size = new System.Drawing.Size(170, 20);
            this.materialCostTextBox.TabIndex = 5;
            this.materialCostTextBox.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(77, 182);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 41);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(209, 182);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(90, 41);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // invoiceDateTextBox
            // 
            this.invoiceDateTextBox.Location = new System.Drawing.Point(185, 132);
            this.invoiceDateTextBox.Name = "invoiceDateTextBox";
            this.invoiceDateTextBox.Size = new System.Drawing.Size(170, 20);
            this.invoiceDateTextBox.TabIndex = 13;
            this.invoiceDateTextBox.Visible = false;
            // 
            // invoiceAmountTextBox
            // 
            this.invoiceAmountTextBox.Location = new System.Drawing.Point(185, 85);
            this.invoiceAmountTextBox.Name = "invoiceAmountTextBox";
            this.invoiceAmountTextBox.Size = new System.Drawing.Size(170, 20);
            this.invoiceAmountTextBox.TabIndex = 12;
            this.invoiceAmountTextBox.Visible = false;
            // 
            // invoiceMaterialNameTextBox
            // 
            this.invoiceMaterialNameTextBox.Location = new System.Drawing.Point(185, 39);
            this.invoiceMaterialNameTextBox.Name = "invoiceMaterialNameTextBox";
            this.invoiceMaterialNameTextBox.Size = new System.Drawing.Size(170, 20);
            this.invoiceMaterialNameTextBox.TabIndex = 11;
            this.invoiceMaterialNameTextBox.Visible = false;
            // 
            // invoiceDateLabel
            // 
            this.invoiceDateLabel.AutoSize = true;
            this.invoiceDateLabel.Location = new System.Drawing.Point(69, 135);
            this.invoiceDateLabel.Name = "invoiceDateLabel";
            this.invoiceDateLabel.Size = new System.Drawing.Size(113, 13);
            this.invoiceDateLabel.TabIndex = 10;
            this.invoiceDateLabel.Text = "Дата прихода/ухода:";
            this.invoiceDateLabel.Visible = false;
            // 
            // invoiceAmountLabel
            // 
            this.invoiceAmountLabel.AutoSize = true;
            this.invoiceAmountLabel.Location = new System.Drawing.Point(36, 88);
            this.invoiceAmountLabel.Name = "invoiceAmountLabel";
            this.invoiceAmountLabel.Size = new System.Drawing.Size(146, 13);
            this.invoiceAmountLabel.TabIndex = 9;
            this.invoiceAmountLabel.Text = "Количество прихода/ухода:";
            this.invoiceAmountLabel.Visible = false;
            // 
            // invoiceMaterialNameLabel
            // 
            this.invoiceMaterialNameLabel.AutoSize = true;
            this.invoiceMaterialNameLabel.Location = new System.Drawing.Point(64, 42);
            this.invoiceMaterialNameLabel.Name = "invoiceMaterialNameLabel";
            this.invoiceMaterialNameLabel.Size = new System.Drawing.Size(118, 13);
            this.invoiceMaterialNameLabel.TabIndex = 8;
            this.invoiceMaterialNameLabel.Text = "Название материала:";
            this.invoiceMaterialNameLabel.Visible = false;
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.invoiceDateTextBox);
            this.Controls.Add(this.invoiceAmountTextBox);
            this.Controls.Add(this.invoiceMaterialNameTextBox);
            this.Controls.Add(this.invoiceDateLabel);
            this.Controls.Add(this.invoiceAmountLabel);
            this.Controls.Add(this.invoiceMaterialNameLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.materialCostTextBox);
            this.Controls.Add(this.materialMeasurementTextBox);
            this.Controls.Add(this.materialNameTextBox);
            this.Controls.Add(this.materialCostLabel);
            this.Controls.Add(this.materialMeasurementLabel);
            this.Controls.Add(this.materialNameLabel);
            this.Name = "AddEditForm";
            this.Text = "Добавление/редактирование...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label materialNameLabel;
        private System.Windows.Forms.Label materialMeasurementLabel;
        private System.Windows.Forms.Label materialCostLabel;
        private System.Windows.Forms.TextBox materialNameTextBox;
        private System.Windows.Forms.TextBox materialMeasurementTextBox;
        private System.Windows.Forms.TextBox materialCostTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox invoiceDateTextBox;
        private System.Windows.Forms.TextBox invoiceAmountTextBox;
        private System.Windows.Forms.TextBox invoiceMaterialNameTextBox;
        private System.Windows.Forms.Label invoiceDateLabel;
        private System.Windows.Forms.Label invoiceAmountLabel;
        private System.Windows.Forms.Label invoiceMaterialNameLabel;
    }
}