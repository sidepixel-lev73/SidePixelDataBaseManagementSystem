using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidePixelDataBaseManagementSystem
{
    public partial class AddEditForm : Form
    {
        int formType;  // 0 = material, 1 = invoice
        Int64 editID;
        private DataSet dataSet;
        public Int64 newID;
        bool newMaterial;
        bool saveb = false;
        public AddEditForm(int formtype, DataSet data, bool newMaterial, Int64 editID = 0)
        {
            InitializeComponent();
            this.editID = editID;
            this.newMaterial = newMaterial;
            this.dataSet = data;
            this.formType = formtype;
            if (formType == 0)
            {
                materialNameLabel.Visible = true;
                materialNameTextBox.Visible = true;
                materialMeasurementLabel.Visible = true;
                materialMeasurementTextBox.Visible = true;
                materialCostLabel.Visible = true;
                materialCostTextBox.Visible = true;
                if (!newMaterial)
                {
                    DataView dataView = dataSet.Material.AsDataView();
                    dataView.RowFilter = $"ID_B = {editID}";
                    if (dataView.Count > 0)
                    {
                        DataRowView row = dataView[0];
                        materialNameTextBox.Text = row["MaterialName"].ToString();
                        materialMeasurementTextBox.Text = row["MaterialMeasurement"].ToString();
                        materialCostTextBox.Text = row["MaterialCost"].ToString();
                    }
                }
            }
            else
            {
                invoiceMaterialNameLabel.Visible = true;
                invoiceMaterialNameTextBox.Visible = true;
                invoiceAmountLabel.Visible = true;
                invoiceAmountTextBox.Visible = true;
                invoiceDateLabel.Visible = true;
                invoiceDateTextBox.Visible = true;
                if (!newMaterial)
                {
                    DataView dataView = dataSet.Invoice.AsDataView();
                    dataView.RowFilter = $"ID_A = {editID}";
                    if (dataView.Count > 0)
                    {
                        DataRowView row = dataView[0];
                        long fk_b = Convert.ToInt64(row["FK_B"]);
                        DataRow[] materialRows = dataSet.Material.Select($"ID_B = {fk_b}");
                        if (materialRows.Length > 0)
                        {
                            invoiceMaterialNameTextBox.Text = materialRows[0]["MaterialName"].ToString();
                        }
                        else
                        {
                            invoiceMaterialNameTextBox.Text = "";
                        }
                        invoiceAmountTextBox.Text = row["Amount"].ToString();
                        invoiceDateTextBox.Text = row["Date"].ToString();
                    }
                }
            }
        }
        private void MaterialValidating()
        {
            saveb = false;
            string FillingErrors = "";
            decimal Cost;
            if (materialNameTextBox.Text == "") FillingErrors = "Название материала не заполнено.\n";
            if (materialMeasurementTextBox.Text == "") FillingErrors = "Единица измерения материала не заполнена.\n";
            if (materialCostTextBox.Text == "") FillingErrors = "Цена материала не заполнена.\n";
            else
            {
                if (!decimal.TryParse(materialCostTextBox.Text, out Cost))
                {
                    FillingErrors = FillingErrors + "Цена материала заполнена не правильно. (для не целых чисел - используйте запятую)\n";
                }
                else
                {
                    decimal.TryParse(materialCostTextBox.Text, out Cost);
                }
            }
            if (FillingErrors != "")
            {
                MessageBox.Show(FillingErrors, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                saveb = true;
            }
        }
        private void InvoiceValidating()
        {
            saveb = false;
            string FillingErrors = "";
            decimal Amount;
            DateTime Date;
            if (invoiceMaterialNameTextBox.Text == "") FillingErrors = "Название материала не заполнено.\n";
            if (invoiceAmountTextBox.Text == "") FillingErrors = "Количество материала не заполнена.\n";
            if (invoiceDateTextBox.Text == "") FillingErrors = "Дата накладной не заполнена.\n";
            else
            {
                if (dataSet.Material.Select($"MaterialName = '{invoiceMaterialNameTextBox.Text}'").Length == 0)
                {
                    FillingErrors = FillingErrors + "Такого материала не существует.\n";
                }
                if (!decimal.TryParse(invoiceAmountTextBox.Text, out Amount))
                {
                    FillingErrors = FillingErrors + "Количество задано не правильно.\n";
                }
                else
                {
                    decimal.TryParse(materialCostTextBox.Text, out Amount);
                }
                if (!DateTime.TryParse(invoiceDateTextBox.Text, out Date))
                {
                    FillingErrors = FillingErrors + "Дата задана не правильно.\n";
                }
                else
                {
                    DateTime.TryParse(invoiceDateTextBox.Text, out Date);
                }
            }
            if (FillingErrors != "")
            {
                MessageBox.Show(FillingErrors, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                saveb = true;
            }
        }
        private void SaveMaterial()
        {
            if (newMaterial)
            {
                DataRow newRow = dataSet.Material.NewRow();
                /*
                object DBID = dataSet.Material.Compute("MAX(ID_B)", "");
                if (DBID != DBNull.Value)
                    newID = Convert.ToInt64(DBID) + 1;
                else
                    newID = Convert.ToInt64(0);
                newRow["ID_B"] = newID;
                */
                newRow["MaterialName"] = materialNameTextBox.Text;
                newRow["MaterialMeasurement"] = materialMeasurementTextBox.Text;
                newRow["MaterialCost"] = Convert.ToDecimal(materialCostTextBox.Text);
                dataSet.Material.Rows.Add(newRow);
                dataSet.Material.AcceptChanges();
            }
            else
            {
                DataRow[] rows = dataSet.Material.Select($"ID_B = {editID}");
                if (rows.Length > 0)
                {
                    DataRow row = rows[0];
                    row["MaterialName"] = materialNameTextBox.Text;
                    row["MaterialMeasurement"] = materialMeasurementTextBox.Text;
                    row["MaterialCost"] = Convert.ToDecimal(materialCostTextBox.Text);
                    dataSet.Material.AcceptChanges();
                    newID = editID;
                }
            }
        }
        private void SaveInvoice()
        {
            if (newMaterial)
            {
                DataRow newRow = dataSet.Invoice.NewRow();
                /*
                object DBID = dataSet.Invoice.Compute("MAX(ID_A)", "");
                if (DBID != DBNull.Value)
                    newID = Convert.ToInt64(DBID) + 1;
                else
                    newID = Convert.ToInt64(0);
                newRow["ID_A"] = newID;
                */
                newRow["FK_B"] = dataSet.Material.Select($"MaterialName = '{invoiceMaterialNameTextBox.Text}'")[0]["ID_B"];
                newRow["Amount"] = invoiceAmountTextBox.Text;
                newRow["Date"] = Convert.ToDateTime(invoiceDateTextBox.Text);
                dataSet.Invoice.Rows.Add(newRow);
                dataSet.Invoice.AcceptChanges();
            }
            else
            {
                DataRow[] rows = dataSet.Invoice.Select($"ID_A = {editID}");
                if (rows.Length > 0)
                {
                    DataRow row = rows[0];
                    row["FK_B"] = dataSet.Material.Select($"MaterialName = '{invoiceMaterialNameTextBox.Text}'")[0]["ID_B"];
                    row["Amount"] = invoiceAmountTextBox.Text;
                    row["Date"] = Convert.ToDateTime(invoiceDateTextBox.Text);
                    dataSet.Invoice.AcceptChanges();
                    newID = editID;
                }
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (formType == 0) MaterialValidating();
            else InvoiceValidating();
            if (!saveb)
            {
                if (formType == 0) SaveMaterial();
                else SaveInvoice();
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            saveb = false;
            this.Close();
        }

        private void AddEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = saveb;
        }
    }
}
