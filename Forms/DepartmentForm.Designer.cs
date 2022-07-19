
namespace Accounting.Forms
{
    partial class DepartmentForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDepartmentText = new System.Windows.Forms.TextBox();
            this.nameLable = new System.Windows.Forms.Label();
            this.insertDepartmentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(561, 360);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nameDepartmentText
            // 
            this.nameDepartmentText.Location = new System.Drawing.Point(104, 32);
            this.nameDepartmentText.Name = "nameDepartmentText";
            this.nameDepartmentText.Size = new System.Drawing.Size(282, 27);
            this.nameDepartmentText.TabIndex = 1;
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Location = new System.Drawing.Point(13, 35);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(77, 20);
            this.nameLable.TabIndex = 2;
            this.nameLable.Text = "Название";
            // 
            // insertDepartmentButton
            // 
            this.insertDepartmentButton.Location = new System.Drawing.Point(422, 30);
            this.insertDepartmentButton.Name = "insertDepartmentButton";
            this.insertDepartmentButton.Size = new System.Drawing.Size(94, 29);
            this.insertDepartmentButton.TabIndex = 3;
            this.insertDepartmentButton.Text = "Добавить";
            this.insertDepartmentButton.UseVisualStyleBackColor = true;
            this.insertDepartmentButton.Click += new System.EventHandler(this.insertDepartmentButton_Click);
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 439);
            this.Controls.Add(this.insertDepartmentButton);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.nameDepartmentText);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DepartmentForm";
            this.Text = "Редактирование Отделений";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DepartmentForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nameDepartmentText;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.Button insertDepartmentButton;
    }
}