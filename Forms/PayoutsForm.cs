using System.Linq;
using System.Windows.Forms;

namespace Accounting.Forms
{
    public partial class PayoutsForm : Form
    {

        private readonly StartMenu _startMenu;

        public PayoutsForm(StartMenu startMenu)
        {
            _startMenu = startMenu;
            InitializeComponent();
            LoadDate("");
            dataGridView1.ReadOnly = true;
        }

        public void LoadDate(string payoutFilter)
        {
            dataGridView1.DataSource = null;
            var source = new BindingSource();
            source.DataSource = string.IsNullOrWhiteSpace(payoutFilter)
                ? SqliteDataAccess.GetPayouts()
                : SqliteDataAccess.GetPayouts().Where(i => i.Department.ToLower().Contains(payoutFilter.ToLower()));

            dataGridView1.DataSource = source;
        }

        private void PayoutsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_startMenu != null)
            {
                _startMenu.LoadDate("");
                _startMenu.Show();
            }
        }

        private void payoutFilterText_TextChanged(object sender, System.EventArgs e)
        {
            LoadDate(payoutFilterText.Text);
        }
    }
}