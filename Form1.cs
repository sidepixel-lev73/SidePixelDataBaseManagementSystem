using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidePixelDataBaseManagementSystem
{
    public partial class mainForm : Form
    {
        string filePath = "data.xml";
        public mainForm()
        {
            InitializeComponent();
        }
        private void SaveToXML()
        {
            dataSet.Material.AcceptChanges();
            dataSet.Invoice.AcceptChanges();
            dataSet.WriteXml(filePath);
        }
        private void LoadFromXML()
        {
            if (!File.Exists(filePath))
            {
                dataSet.WriteXml(filePath);
            }
            dataSet.Clear();
            dataSet.ReadXml(filePath);
        }
        private void SelectRow(DataGridView dataGrid, int bIndex)
        {
            if (bIndex >= 0 && bIndex < dataGrid.Rows.Count)
            {
                DataGridViewRow row = dataGrid.Rows[bIndex];
                dataGrid.CurrentCell = row.Cells[2];
                row.Selected = true;
                dataGrid.FirstDisplayedScrollingRowIndex = row.Index;
            }
        }

        private void SelectRowID(DataGridView dataGrid, Int64 id)
        {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[0].Value != null &&
                    Convert.ToInt64(row.Cells[0].Value) == id)
                {
                    dataGrid.CurrentCell = row.Cells[2];
                    row.Selected = true;
                    dataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    return;
                }
            }
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            LoadFromXML();

            materialGridView.Sort(materialGridView.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
            invoiceGridView.Sort(invoiceGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void addMaterial_Click(object sender, EventArgs e)
        {
            AddEditForm addEditForm = new AddEditForm(0, dataSet, true);
            addEditForm.ShowDialog();
            SaveToXML();
            SelectRowID(materialGridView, addEditForm.newID);
        }

        private void editMaterial_Click(object sender, EventArgs e)
        {
            if (materialGridView.CurrentRow != null)
            {
                Int64 id = Convert.ToInt64(materialGridView.CurrentRow.Cells[0].Value);
                AddEditForm addEditForm = new AddEditForm(0, dataSet, false, id);
                addEditForm.ShowDialog();
                SaveToXML();
                SelectRowID(materialGridView, id);
            }
        }

        private void removeMaterial_Click(object sender, EventArgs e)
        {
            if (materialGridView.CurrentRow != null)
            {
                Int64 rowId = Convert.ToInt64(materialGridView.CurrentRow.Cells[0].Value);
                DataRow[] rows = dataSet.Invoice.Select($"FK_B = {rowId}");

                if (rows.Length == 0)
                {
                    materialGridView.Rows.Remove(materialGridView.CurrentRow);
                    SaveToXML();
                    SelectRow(materialGridView, 0);
                }
                else
                {
                    MessageBox.Show("Нельзя удалить материал, так как на него есть ссылки в накладных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
            }
        }

        private void addInvoice_Click(object sender, EventArgs e)
        {
            AddEditForm addEditForm = new AddEditForm(1, dataSet, true);
            addEditForm.ShowDialog();
            SaveToXML();
            SelectRowID(invoiceGridView, addEditForm.newID);
        }

        private void editInvoice_Click(object sender, EventArgs e)
        {
            if (invoiceGridView.CurrentRow != null)
            {
                Int64 id = Convert.ToInt64(invoiceGridView.CurrentRow.Cells[0].Value);
                AddEditForm addEditForm = new AddEditForm(1, dataSet, false, id);
                addEditForm.ShowDialog();
                SaveToXML();
                SelectRowID(invoiceGridView, id);
            }
        }

        private void removeInvoice_Click(object sender, EventArgs e)
        {
            if (invoiceGridView.CurrentRow != null)
            {
                invoiceGridView.Rows.Remove(invoiceGridView.CurrentRow);
                SaveToXML();
                SelectRow(invoiceGridView, 0);
            }
        }
    }
}
