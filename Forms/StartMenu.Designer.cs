
namespace Accounting
{
    partial class StartMenu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.departmentEditing = new System.Windows.Forms.Button();
            this.positionEditing = new System.Windows.Forms.Button();
            this.addEmployee = new System.Windows.Forms.Button();
            this.payouts = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.departmentFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 515);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StartMenu_CellClick);
            // 
            // departmentEditing
            // 
            this.departmentEditing.Location = new System.Drawing.Point(100, 2);
            this.departmentEditing.Name = "departmentEditing";
            this.departmentEditing.Size = new System.Drawing.Size(135, 50);
            this.departmentEditing.TabIndex = 3;
            this.departmentEditing.Text = "Редактирование отделов ";
            this.departmentEditing.UseVisualStyleBackColor = true;
            this.departmentEditing.Click += new System.EventHandler(this.department_Click);
            // 
            // positionEditing
            // 
            this.positionEditing.Location = new System.Drawing.Point(240, 1);
            this.positionEditing.Name = "positionEditing";
            this.positionEditing.Size = new System.Drawing.Size(135, 50);
            this.positionEditing.TabIndex = 4;
            this.positionEditing.Text = "Редактирование должностей ";
            this.positionEditing.UseVisualStyleBackColor = true;
            this.positionEditing.Click += new System.EventHandler(this.positionEditing_Click);
            // 
            // addEmployee
            // 
            this.addEmployee.Location = new System.Drawing.Point(381, 2);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(135, 50);
            this.addEmployee.TabIndex = 5;
            this.addEmployee.Text = "Добавить сотрудника";
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // payouts
            // 
            this.payouts.Location = new System.Drawing.Point(522, 1);
            this.payouts.Name = "payouts";
            this.payouts.Size = new System.Drawing.Size(135, 50);
            this.payouts.TabIndex = 6;
            this.payouts.Text = "Выплаты";
            this.payouts.UseVisualStyleBackColor = true;
            this.payouts.Click += new System.EventHandler(this.payouts_Click);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(663, 1);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(135, 50);
            this.report.TabIndex = 7;
            this.report.Text = "Отчет";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // departmentFilter
            // 
            this.departmentFilter.Location = new System.Drawing.Point(804, 12);
            this.departmentFilter.Name = "departmentFilter";
            this.departmentFilter.Size = new System.Drawing.Size(198, 27);
            this.departmentFilter.TabIndex = 8;
            this.departmentFilter.TextChanged += new System.EventHandler(this.departmentFilter_TextChanged);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 572);
            this.Controls.Add(this.departmentFilter);
            this.Controls.Add(this.report);
            this.Controls.Add(this.payouts);
            this.Controls.Add(this.addEmployee);
            this.Controls.Add(this.positionEditing);
            this.Controls.Add(this.departmentEditing);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StartMenu";
            this.Text = "Главное меню";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button departmentEditing;
        private System.Windows.Forms.Button positionEditing;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Button payouts;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox departmentFilter;
    }
}

