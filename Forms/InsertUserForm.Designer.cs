
namespace Accounting.Forms
{
    partial class InsertUserForm
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
            this.insertUser = new System.Windows.Forms.Button();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.premiumTypeComboBox = new System.Windows.Forms.ComboBox();
            this.salaryText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.fatherNameText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.lastaNameText = new System.Windows.Forms.TextBox();
            this.pramiumTypeLable = new System.Windows.Forms.Label();
            this.nameLable = new System.Windows.Forms.Label();
            this.salaryLable = new System.Windows.Forms.Label();
            this.positionLable = new System.Windows.Forms.Label();
            this.departmentLable = new System.Windows.Forms.Label();
            this.fatherNameLable = new System.Windows.Forms.Label();
            this.addressLable = new System.Windows.Forms.Label();
            this.phoneNumberLable = new System.Windows.Forms.Label();
            this.lastNameLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // insertUser
            // 
            this.insertUser.Location = new System.Drawing.Point(320, 127);
            this.insertUser.Name = "insertUser";
            this.insertUser.Size = new System.Drawing.Size(150, 30);
            this.insertUser.TabIndex = 50;
            this.insertUser.Text = "Добавить данные";
            this.insertUser.UseVisualStyleBackColor = true;
            this.insertUser.Click += new System.EventHandler(this.insertUser_Click);
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(153, 162);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(150, 25);
            this.departmentComboBox.TabIndex = 47;
            // 
            // positionComboBox
            // 
            this.positionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionComboBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Location = new System.Drawing.Point(153, 192);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(150, 25);
            this.positionComboBox.TabIndex = 46;
            // 
            // premiumTypeComboBox
            // 
            this.premiumTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.premiumTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.premiumTypeComboBox.FormattingEnabled = true;
            this.premiumTypeComboBox.Location = new System.Drawing.Point(153, 252);
            this.premiumTypeComboBox.Name = "premiumTypeComboBox";
            this.premiumTypeComboBox.Size = new System.Drawing.Size(150, 25);
            this.premiumTypeComboBox.TabIndex = 45;
            // 
            // salaryText
            // 
            this.salaryText.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salaryText.Location = new System.Drawing.Point(153, 222);
            this.salaryText.Name = "salaryText";
            this.salaryText.Size = new System.Drawing.Size(150, 25);
            this.salaryText.TabIndex = 44;
            this.salaryText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salaryText_KeyPress);
            // 
            // phoneText
            // 
            this.phoneText.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneText.Location = new System.Drawing.Point(153, 102);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(150, 25);
            this.phoneText.TabIndex = 43;
            // 
            // fatherNameText
            // 
            this.fatherNameText.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fatherNameText.Location = new System.Drawing.Point(153, 72);
            this.fatherNameText.Name = "fatherNameText";
            this.fatherNameText.Size = new System.Drawing.Size(150, 25);
            this.fatherNameText.TabIndex = 42;
            // 
            // addressText
            // 
            this.addressText.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressText.Location = new System.Drawing.Point(153, 132);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(150, 25);
            this.addressText.TabIndex = 41;
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameText.Location = new System.Drawing.Point(153, 42);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(150, 25);
            this.nameText.TabIndex = 40;
            // 
            // lastaNameText
            // 
            this.lastaNameText.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastaNameText.Location = new System.Drawing.Point(153, 12);
            this.lastaNameText.Name = "lastaNameText";
            this.lastaNameText.Size = new System.Drawing.Size(150, 25);
            this.lastaNameText.TabIndex = 39;
            // 
            // pramiumTypeLable
            // 
            this.pramiumTypeLable.AutoSize = true;
            this.pramiumTypeLable.Location = new System.Drawing.Point(8, 255);
            this.pramiumTypeLable.Name = "pramiumTypeLable";
            this.pramiumTypeLable.Size = new System.Drawing.Size(61, 20);
            this.pramiumTypeLable.TabIndex = 38;
            this.pramiumTypeLable.Text = "Оценка";
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Location = new System.Drawing.Point(8, 45);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(39, 20);
            this.nameLable.TabIndex = 36;
            this.nameLable.Text = "Имя";
            // 
            // salaryLable
            // 
            this.salaryLable.AutoSize = true;
            this.salaryLable.Location = new System.Drawing.Point(8, 225);
            this.salaryLable.Name = "salaryLable";
            this.salaryLable.Size = new System.Drawing.Size(51, 20);
            this.salaryLable.TabIndex = 35;
            this.salaryLable.Text = "Оклад";
            // 
            // positionLable
            // 
            this.positionLable.AutoSize = true;
            this.positionLable.Location = new System.Drawing.Point(8, 195);
            this.positionLable.Name = "positionLable";
            this.positionLable.Size = new System.Drawing.Size(86, 20);
            this.positionLable.TabIndex = 34;
            this.positionLable.Text = "Должность";
            // 
            // departmentLable
            // 
            this.departmentLable.AutoSize = true;
            this.departmentLable.Location = new System.Drawing.Point(8, 165);
            this.departmentLable.Name = "departmentLable";
            this.departmentLable.Size = new System.Drawing.Size(50, 20);
            this.departmentLable.TabIndex = 33;
            this.departmentLable.Text = "Отдел";
            // 
            // fatherNameLable
            // 
            this.fatherNameLable.AutoSize = true;
            this.fatherNameLable.Location = new System.Drawing.Point(8, 75);
            this.fatherNameLable.Name = "fatherNameLable";
            this.fatherNameLable.Size = new System.Drawing.Size(72, 20);
            this.fatherNameLable.TabIndex = 32;
            this.fatherNameLable.Text = "Отчество";
            // 
            // addressLable
            // 
            this.addressLable.AutoSize = true;
            this.addressLable.Location = new System.Drawing.Point(8, 135);
            this.addressLable.Name = "addressLable";
            this.addressLable.Size = new System.Drawing.Size(58, 20);
            this.addressLable.TabIndex = 31;
            this.addressLable.Text = "Адресс";
            // 
            // phoneNumberLable
            // 
            this.phoneNumberLable.AutoSize = true;
            this.phoneNumberLable.Location = new System.Drawing.Point(8, 105);
            this.phoneNumberLable.Name = "phoneNumberLable";
            this.phoneNumberLable.Size = new System.Drawing.Size(127, 20);
            this.phoneNumberLable.TabIndex = 30;
            this.phoneNumberLable.Text = "Номер телефона";
            // 
            // lastNameLable
            // 
            this.lastNameLable.AutoSize = true;
            this.lastNameLable.Location = new System.Drawing.Point(8, 20);
            this.lastNameLable.Name = "lastNameLable";
            this.lastNameLable.Size = new System.Drawing.Size(73, 20);
            this.lastNameLable.TabIndex = 29;
            this.lastNameLable.Text = "Фамилия";
            // 
            // InsertUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 293);
            this.Controls.Add(this.insertUser);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.positionComboBox);
            this.Controls.Add(this.premiumTypeComboBox);
            this.Controls.Add(this.salaryText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.fatherNameText);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.lastaNameText);
            this.Controls.Add(this.pramiumTypeLable);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.salaryLable);
            this.Controls.Add(this.positionLable);
            this.Controls.Add(this.departmentLable);
            this.Controls.Add(this.fatherNameLable);
            this.Controls.Add(this.addressLable);
            this.Controls.Add(this.phoneNumberLable);
            this.Controls.Add(this.lastNameLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InsertUserForm";
            this.Text = "Добавление сотрудника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InsertUserForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertUser;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.ComboBox premiumTypeComboBox;
        private System.Windows.Forms.TextBox salaryText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox fatherNameText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox lastaNameText;
        private System.Windows.Forms.Label pramiumTypeLable;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.Label salaryLable;
        private System.Windows.Forms.Label positionLable;
        private System.Windows.Forms.Label departmentLable;
        private System.Windows.Forms.Label fatherNameLable;
        private System.Windows.Forms.Label addressLable;
        private System.Windows.Forms.Label phoneNumberLable;
        private System.Windows.Forms.Label lastNameLable;
    }
}