namespace GraduateDistribution
{
    partial class GroupEntityForm
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
            this.metroComboBoxGroupSpecialtyCode = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBoxGroupQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxEndStudy = new MetroFramework.Controls.MetroTextBox();
            this.metroTileGroupAdd = new MetroFramework.Controls.MetroTile();
            this.metroTileGroupEdit = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(42, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(167, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Код специальности:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(23, 93);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(186, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Количество учащихся:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(97, 123);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(112, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Год выпуска:";
            // 
            // metroComboBoxGroupSpecialtyCode
            // 
            this.metroComboBoxGroupSpecialtyCode.FormattingEnabled = true;
            this.metroComboBoxGroupSpecialtyCode.ItemHeight = 23;
            this.metroComboBoxGroupSpecialtyCode.Location = new System.Drawing.Point(215, 60);
            this.metroComboBoxGroupSpecialtyCode.Name = "metroComboBoxGroupSpecialtyCode";
            this.metroComboBoxGroupSpecialtyCode.Size = new System.Drawing.Size(121, 29);
            this.metroComboBoxGroupSpecialtyCode.TabIndex = 3;
            // 
            // metroTextBoxGroupQuantity
            // 
            this.metroTextBoxGroupQuantity.Location = new System.Drawing.Point(215, 95);
            this.metroTextBoxGroupQuantity.Name = "metroTextBoxGroupQuantity";
            this.metroTextBoxGroupQuantity.Size = new System.Drawing.Size(121, 23);
            this.metroTextBoxGroupQuantity.TabIndex = 4;
            // 
            // metroTextBoxEndStudy
            // 
            this.metroTextBoxEndStudy.Location = new System.Drawing.Point(215, 125);
            this.metroTextBoxEndStudy.Name = "metroTextBoxEndStudy";
            this.metroTextBoxEndStudy.Size = new System.Drawing.Size(121, 23);
            this.metroTextBoxEndStudy.TabIndex = 5;
            // 
            // metroTileGroupAdd
            // 
            this.metroTileGroupAdd.Location = new System.Drawing.Point(134, 183);
            this.metroTileGroupAdd.Name = "metroTileGroupAdd";
            this.metroTileGroupAdd.Size = new System.Drawing.Size(75, 23);
            this.metroTileGroupAdd.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTileGroupAdd.TabIndex = 6;
            this.metroTileGroupAdd.Text = "Добавить";
            this.metroTileGroupAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileGroupAdd.Visible = false;
            this.metroTileGroupAdd.Click += new System.EventHandler(this.metroTileGroupAdd_Click);
            // 
            // metroTileGroupEdit
            // 
            this.metroTileGroupEdit.Location = new System.Drawing.Point(114, 183);
            this.metroTileGroupEdit.Name = "metroTileGroupEdit";
            this.metroTileGroupEdit.Size = new System.Drawing.Size(127, 23);
            this.metroTileGroupEdit.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTileGroupEdit.TabIndex = 7;
            this.metroTileGroupEdit.Text = "Редактировать";
            this.metroTileGroupEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileGroupEdit.Visible = false;
            this.metroTileGroupEdit.Click += new System.EventHandler(this.metroTileGroupEdit_Click);
            // 
            // GroupEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 228);
            this.Controls.Add(this.metroTileGroupEdit);
            this.Controls.Add(this.metroTileGroupAdd);
            this.Controls.Add(this.metroTextBoxEndStudy);
            this.Controls.Add(this.metroTextBoxGroupQuantity);
            this.Controls.Add(this.metroComboBoxGroupSpecialtyCode);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(358, 228);
            this.MinimumSize = new System.Drawing.Size(358, 228);
            this.Name = "GroupEntityForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "GroupEntityForm";
            this.Load += new System.EventHandler(this.GroupEntityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox metroComboBoxGroupSpecialtyCode;
        private MetroFramework.Controls.MetroTextBox metroTextBoxGroupQuantity;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEndStudy;
        private MetroFramework.Controls.MetroTile metroTileGroupAdd;
        private MetroFramework.Controls.MetroTile metroTileGroupEdit;
    }
}