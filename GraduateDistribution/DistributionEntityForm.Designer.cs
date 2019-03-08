namespace GraduateDistribution
{
    partial class DistributionEntityForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxGraduate = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxOrganization = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxPosition = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBoxSalary = new MetroFramework.Controls.MetroTextBox();
            this.dateTimePickerFirst = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSecond = new System.Windows.Forms.DateTimePicker();
            this.metroTileDistributionAdd = new MetroFramework.Controls.MetroTile();
            this.metroTileDistributionEdit = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(117, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(101, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Выпускник:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(98, 102);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(120, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Организация:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(116, 137);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(102, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Должность:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(152, 166);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 25);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Оклад:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(18, 192);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(200, 25);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Начало распределения:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(28, 218);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(190, 25);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Конец распределения:";
            // 
            // metroComboBoxGraduate
            // 
            this.metroComboBoxGraduate.FormattingEnabled = true;
            this.metroComboBoxGraduate.ItemHeight = 23;
            this.metroComboBoxGraduate.Location = new System.Drawing.Point(224, 63);
            this.metroComboBoxGraduate.Name = "metroComboBoxGraduate";
            this.metroComboBoxGraduate.Size = new System.Drawing.Size(237, 29);
            this.metroComboBoxGraduate.TabIndex = 6;
            // 
            // metroComboBoxOrganization
            // 
            this.metroComboBoxOrganization.FormattingEnabled = true;
            this.metroComboBoxOrganization.ItemHeight = 23;
            this.metroComboBoxOrganization.Location = new System.Drawing.Point(224, 98);
            this.metroComboBoxOrganization.Name = "metroComboBoxOrganization";
            this.metroComboBoxOrganization.Size = new System.Drawing.Size(237, 29);
            this.metroComboBoxOrganization.TabIndex = 7;
            // 
            // metroComboBoxPosition
            // 
            this.metroComboBoxPosition.FormattingEnabled = true;
            this.metroComboBoxPosition.ItemHeight = 23;
            this.metroComboBoxPosition.Location = new System.Drawing.Point(224, 133);
            this.metroComboBoxPosition.Name = "metroComboBoxPosition";
            this.metroComboBoxPosition.Size = new System.Drawing.Size(237, 29);
            this.metroComboBoxPosition.TabIndex = 8;
            // 
            // metroTextBoxSalary
            // 
            this.metroTextBoxSalary.Location = new System.Drawing.Point(224, 168);
            this.metroTextBoxSalary.Name = "metroTextBoxSalary";
            this.metroTextBoxSalary.Size = new System.Drawing.Size(237, 23);
            this.metroTextBoxSalary.TabIndex = 9;
            this.metroTextBoxSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxSalary_KeyPress);
            // 
            // dateTimePickerFirst
            // 
            this.dateTimePickerFirst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFirst.Location = new System.Drawing.Point(224, 197);
            this.dateTimePickerFirst.Name = "dateTimePickerFirst";
            this.dateTimePickerFirst.Size = new System.Drawing.Size(237, 20);
            this.dateTimePickerFirst.TabIndex = 10;
            this.dateTimePickerFirst.Value = new System.DateTime(2019, 3, 7, 0, 0, 0, 0);
            // 
            // dateTimePickerSecond
            // 
            this.dateTimePickerSecond.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSecond.Location = new System.Drawing.Point(224, 223);
            this.dateTimePickerSecond.Name = "dateTimePickerSecond";
            this.dateTimePickerSecond.Size = new System.Drawing.Size(237, 20);
            this.dateTimePickerSecond.TabIndex = 11;
            this.dateTimePickerSecond.Value = new System.DateTime(2019, 3, 7, 0, 0, 0, 0);
            // 
            // metroTileDistributionAdd
            // 
            this.metroTileDistributionAdd.Location = new System.Drawing.Point(210, 283);
            this.metroTileDistributionAdd.Name = "metroTileDistributionAdd";
            this.metroTileDistributionAdd.Size = new System.Drawing.Size(75, 23);
            this.metroTileDistributionAdd.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTileDistributionAdd.TabIndex = 12;
            this.metroTileDistributionAdd.Text = "Добавить";
            this.metroTileDistributionAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileDistributionAdd.Visible = false;
            this.metroTileDistributionAdd.Click += new System.EventHandler(this.metroTileDistributionAdd_Click);
            // 
            // metroTileDistributionEdit
            // 
            this.metroTileDistributionEdit.Location = new System.Drawing.Point(188, 283);
            this.metroTileDistributionEdit.Name = "metroTileDistributionEdit";
            this.metroTileDistributionEdit.Size = new System.Drawing.Size(119, 23);
            this.metroTileDistributionEdit.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTileDistributionEdit.TabIndex = 13;
            this.metroTileDistributionEdit.Text = "Редактировать";
            this.metroTileDistributionEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileDistributionEdit.Click += new System.EventHandler(this.metroTileDistribution_Click);
            // 
            // DistributionEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 331);
            this.Controls.Add(this.metroTileDistributionEdit);
            this.Controls.Add(this.metroTileDistributionAdd);
            this.Controls.Add(this.dateTimePickerSecond);
            this.Controls.Add(this.dateTimePickerFirst);
            this.Controls.Add(this.metroTextBoxSalary);
            this.Controls.Add(this.metroComboBoxPosition);
            this.Controls.Add(this.metroComboBoxOrganization);
            this.Controls.Add(this.metroComboBoxGraduate);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(484, 331);
            this.MinimumSize = new System.Drawing.Size(484, 331);
            this.Name = "DistributionEntityForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "DistributionEntityForm";
            this.Load += new System.EventHandler(this.DistributionEntityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox metroComboBoxGraduate;
        private MetroFramework.Controls.MetroComboBox metroComboBoxOrganization;
        private MetroFramework.Controls.MetroComboBox metroComboBoxPosition;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSalary;
        private System.Windows.Forms.DateTimePicker dateTimePickerFirst;
        private System.Windows.Forms.DateTimePicker dateTimePickerSecond;
        private MetroFramework.Controls.MetroTile metroTileDistributionAdd;
        private MetroFramework.Controls.MetroTile metroTileDistributionEdit;
    }
}