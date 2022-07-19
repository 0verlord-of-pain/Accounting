using System;
using System.Windows.Forms;
using Accounting.Enums;
using Accounting.Helper;

namespace Accounting
{
    public partial class UserInfo : Form
    {
        private int UserId { get; }

        private readonly StartMenu _startMenu;

        public UserInfo(StartMenu startMenu, int userId) : this()
        {
            _startMenu = startMenu;
            InitializeComponent();
            UserId = userId;
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

            SetDate();
        }

        public UserInfo()
        {
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            SetDate();
        }

        private void SetDate()
        {
            var user = SqliteDataAccess.GetUserById(UserId);
            lastaNameText.Text = user.LastName;
            nameText.Text = user.Name;
            fatherNameText.Text = user.FatherName;
            phoneText.Text = user.PhoneNumber;
            addressText.Text = user.Address;
            departmentComboBox.Text = user.Department;
            positionComboBox.Text = user.Position;
            salaryText.Text = user.Salary.ToString();
            premiumTypeComboBox.Text = user.PremiumType.ToString();
            premiumText.Text = user.Premium.ToString();
        }

        private void updateUserData_Click(object sender, EventArgs e)
        {
            var result = MessageHelper.ShowWarningMessage("изменить");

            if (result == DialogResult.Yes)
            {
                SqliteDataAccess.UpdateUser(UserId, nameText.Text, lastaNameText.Text, fatherNameText.Text, phoneText.Text,
                    addressText.Text, departmentComboBox.Text, positionComboBox.Text, Convert.ToDecimal(salaryText.Text),
                    Enum.Parse<PremiumType>(premiumTypeComboBox.Text));

                MessageHelper.ShowInfoMessage("изменены");
                SetDate();
            }
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            var result = MessageHelper.ShowWarningMessage("удалить");

            if (result == DialogResult.Yes)
            {
                SqliteDataAccess.DeleteUser(UserId);

                MessageHelper.ShowInfoMessage("удалены");

                if (_startMenu != null)
                {
                    Close();
                    _startMenu.LoadDate("");
                    _startMenu.Show();
                }
            }
        }

        private void UserInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_startMenu != null)
            {
                _startMenu.LoadDate("");
                _startMenu.Show();
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