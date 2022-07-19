using System;
using System.Windows.Forms;
using Accounting.Helper;

namespace Accounting.Forms
{
    public partial class PositionForm : Form
    {
        private readonly StartMenu _startMenu;

        public PositionForm(StartMenu startMenu) : this()
        {
            InitializeComponent();
            _startMenu = startMenu;
            var source = new BindingSource();
            var posotions = SqliteDataAccess.GetPositions();
            source.DataSource = posotions;
            dataGridView1.DataSource = source;
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "delete_button";
            deleteButton.HeaderText = "";
            deleteButton.Text = "Удалить";
            deleteButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteButton);
            var updateButton = new DataGridViewButtonColumn();
            updateButton.Name = "update_button";
            updateButton.HeaderText = "";
            updateButton.Text = "Редактировать";
            updateButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(updateButton);
            dataGridView1.ReadOnly = false;
            dataGridView1.Columns[0].ReadOnly = true;
        }

        public PositionForm()
        {
        }

        private void LoadDate()
        {
            var source = new BindingSource();
            var positions = SqliteDataAccess.GetPositions();
            source.DataSource = positions;
            dataGridView1.DataSource = source;
        }

        private void PositionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_startMenu != null)
            {
                _startMenu.LoadDate("");
                _startMenu.Show();
            }
        }

        private void insertPositionButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(namePositionText.Text))
            {
                SqliteDataAccess.InsertPosition(namePositionText.Text);
                MessageHelper.ShowInfoMessage("добавлены");
                LoadDate();
                namePositionText.Text = "";
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["delete_button"].Index)
            {
                var result = MessageHelper.ShowWarningMessage("удалить");

                if (result == DialogResult.Yes)
                {
                    var rowIndex = dataGridView1.CurrentCell.RowIndex;
                    var positionId = Convert.ToInt32(dataGridView1[2, rowIndex].Value);
                    SqliteDataAccess.DeletePosition(positionId);

                    MessageHelper.ShowInfoMessage("удалены");
                    LoadDate();
                }
            }

            if (e.ColumnIndex == dataGridView1.Columns["update_button"].Index)
            {
                var result = MessageHelper.ShowWarningMessage("изенить");

                if (result == DialogResult.Yes)
                {
                    var rowIndex = dataGridView1.CurrentCell.RowIndex;
                    var positionId = Convert.ToInt32(dataGridView1[2, rowIndex].Value);
                    var name = dataGridView1[3, rowIndex].Value.ToString();
                    SqliteDataAccess.UpdatePosition(positionId, name);

                    MessageHelper.ShowInfoMessage("изменены");
                    LoadDate();
                }
            }
        }
    }
}