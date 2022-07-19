
namespace Accounting.Forms
{
    partial class PositionForm
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
            this.insertPositionButton = new System.Windows.Forms.Button();
            this.nameLable = new System.Windows.Forms.Label();
            this.namePositionText = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // insertPositionButton
            // 
            this.insertPositionButton.Location = new System.Drawing.Point(429, 10);
            this.insertPositionButton.Name = "insertPositionButton";
            this.insertPositionButton.Size = new System.Drawing.Size(94, 29);
            this.insertPositionButton.TabIndex = 7;
            this.insertPositionButton.Text = "Добавить";
            this.insertPositionButton.UseVisualStyleBackColor = true;
            this.insertPositionButton.Click += new System.EventHandler(this.insertPositionButton_Click);
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Location = new System.Drawing.Point(20, 15);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(77, 20);
            this.nameLable.TabIndex = 6;
            this.nameLable.Text = "Название";
            // 
            // namePositionText
            // 
            this.namePositionText.Location = new System.Drawing.Point(111, 12);
            this.namePositionText.Name = "namePositionText";
            this.namePositionText.Size = new System.Drawing.Size(282, 27);
            this.namePositionText.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(561, 360);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // PositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 416);
            this.Controls.Add(this.insertPositionButton);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.namePositionText);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PositionForm";
            this.Text = "Редактирование Должностей";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PositionForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.TextBox namePositionText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insertPositionButton;
    }
}