using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Accounting.Commands;
using Accounting.Forms;
using Accounting.ModalViews;

namespace Accounting
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            LoadDate("");
            dataGridView1.ReadOnly = true;
        }

        private void report_Click(object sender, EventArgs e)
        {
            var result = Report.CreateReport();

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllLines(filename, result);
            MessageBox.Show("Файл сохранён");
        }

        private void departmentFilter_TextChanged(object sender, EventArgs e)
        {
            LoadDate(departmentFilter.Text);
        }

        private void StartMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = dataGridView1.CurrentCell.RowIndex;
            var userId = Convert.ToInt32(dataGridView1[0, rowIndex].Value);
            var userInfoForm = new UserInfo(this,userId);
            Hide();
            userInfoForm.Show();
        }

        public void LoadDate(string departmentFilter)
        {
            dataGridView1.DataSource = null;
            var source = new BindingSource();
            source.DataSource = string.IsNullOrWhiteSpace(departmentFilter)
                ? SqliteDataAccess.GetUsers()
                : SqliteDataAccess.GetUsers().Where(i => i.Department.ToLower().Contains(departmentFilter.ToLower()));

            dataGridView1.DataSource = source;

        }

        private void department_Click(object sender, EventArgs e)
        {
            var departmentForm = new DepartmentForm(this);
            Hide();
            departmentForm.Show();
        }

        private void positionEditing_Click(object sender, EventArgs e)
        {
            var positionForm = new PositionForm(this);
            Hide();
            positionForm.Show();
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            var insertUserForm = new InsertUserForm(this);
            Hide();
            insertUserForm.Show();
        }

        private void payouts_Click(object sender, EventArgs e)
        {
            var payoutsForm = new PayoutsForm(this);
            Hide();
            payoutsForm.Show();
        }
    }
}