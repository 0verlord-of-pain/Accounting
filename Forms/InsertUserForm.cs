using System;
using System.Windows.Forms;
using Accounting.Enums;
using Accounting.Helper;

namespace Accounting.Forms
{
    public partial class InsertUserForm : Form
    {
        private readonly StartMenu _startMenu;

        public InsertUserForm(StartMenu startMenu)
        {
            _startMenu = startMenu;
            InitializeComponent();
            var departments = SqliteDataAccess.GetDepartments();
            var positions = SqliteDataAccess.GetPositions();

            foreach (var department in departments)
            {
                departmentComboBox.Items.Add(department.name);
            }

            foreach (var position in positions)
            {
                positionComboBox.Items.Add(position.name);
            }

            foreach (var premiumType in Enum.GetValues(typeof(PremiumType)))
            {
                premiumTypeComboBox.Items.Add(premiumType);
            }
        }

        private void InsertUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_startMenu != null)
            {
                _startMenu.LoadDate("");
                _startMenu.Show();
            }
        }

        private void insertUser_Click(object sender, EventArgs e)
        {
            var result = MessageHelper.ShowWarningMessage("добавить");

            if (result == DialogResult.Yes)
            {
                SqliteDataAccess.InsertUser(nameText.Text, lastaNameText.Text, fatherNameText.Text, phoneText.Text,
                    addressText.Text, departmentComboBox.Text, positionComboBox.Text, Convert.ToDecimal(salaryText.Text),
                    Enum.Parse<PremiumType>(premiumTypeComboBox.Text));

                MessageHelper.ShowInfoMessage("добавлены");

                nameText.Text = "";
                lastaNameText.Text = "";
                fatherNameText.Text = "";
                phoneText.Text = "";
                addressText.Text = "";
                departmentComboBox.SelectedIndex = -1;
                positionComboBox.SelectedIndex = -1;
                salaryText.Text = "";
                premiumTypeComboBox.SelectedIndex = -1;
            }
        }

        private void salaryText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
    }
}