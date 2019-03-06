namespace GraduateDistribution
{
    partial class SpecialtyEntityForm
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
            this.metroTextBoxSpecialtyCode = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxSpecialtyTime = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBoxFormStudy = new MetroFramework.Controls.MetroComboBox();
            this.metroTileSpicialtyAdd = new MetroFramework.Controls.MetroTile();
            this.metroTileSpecialtyEdit = new MetroFramework.Controls.MetroTile();
            this.metroTextBoxSpecialtyName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(128, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Код:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(37, 136);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(135, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Срок обучения:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(23, 171);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(149, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Форма обучения:";
            // 
            // metroTextBoxSpecialtyCode
            // 
            this.metroTextBoxSpecialtyCode.BackColor = System.Drawing.Color.White;
            this.metroTextBoxSpecialtyCode.Location = new System.Drawing.Point(178, 63);
            this.metroTextBoxSpecialtyCode.Name = "metroTextBoxSpecialtyCode";
            this.metroTextBoxSpecialtyCode.Size = new System.Drawing.Size(129, 23);
            this.metroTextBoxSpecialtyCode.TabIndex = 3;
            // 
            // metroTextBoxSpecialtyTime
            // 
            this.metroTextBoxSpecialtyTime.Location = new System.Drawing.Point(178, 138);
            this.metroTextBoxSpecialtyTime.Name = "metroTextBoxSpecialtyTime";
            this.metroTextBoxSpecialtyTime.Size = new System.Drawing.Size(129, 23);
            this.metroTextBoxSpecialtyTime.TabIndex = 4;
            // 
            // metroComboBoxFormStudy
            // 
            this.metroComboBoxFormStudy.FormattingEnabled = true;
            this.metroComboBoxFormStudy.ItemHeight = 23;
            this.metroComboBoxFormStudy.Items.AddRange(new object[] {
            "Дневная",
            "Заочная"});
            this.metroComboBoxFormStudy.Location = new System.Drawing.Point(178, 171);
            this.metroComboBoxFormStudy.Name = "metroComboBoxFormStudy";
            this.metroComboBoxFormStudy.Size = new System.Drawing.Size(129, 29);
            this.metroComboBoxFormStudy.TabIndex = 5;
            // 
            // metroTileSpicialtyAdd
            // 
            this.metroTileSpicialtyAdd.Location = new System.Drawing.Point(137, 234);
            this.metroTileSpicialtyAdd.Name = "metroTileSpicialtyAdd";
            this.metroTileSpicialtyAdd.Size = new System.Drawing.Size(75, 23);
            this.metroTileSpicialtyAdd.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTileSpicialtyAdd.TabIndex = 6;
            this.metroTileSpicialtyAdd.Text = "Добавить";
            this.metroTileSpicialtyAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSpicialtyAdd.Visible = false;
            this.metroTileSpicialtyAdd.Click += new System.EventHandler(this.metroTileSpicialtyAdd_Click);
            // 
            // metroTileSpecialtyEdit
            // 
            this.metroTileSpecialtyEdit.Location = new System.Drawing.Point(118, 234);
            this.metroTileSpecialtyEdit.Name = "metroTileSpecialtyEdit";
            this.metroTileSpecialtyEdit.Size = new System.Drawing.Size(107, 23);
            this.metroTileSpecialtyEdit.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTileSpecialtyEdit.TabIndex = 7;
            this.metroTileSpecialtyEdit.Text = "Редактировать";
            this.metroTileSpecialtyEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSpecialtyEdit.Visible = false;
            this.metroTileSpecialtyEdit.Click += new System.EventHandler(this.metroTileSpecialtyEdit_Click);
            // 
            // metroTextBoxSpecialtyName
            // 
            this.metroTextBoxSpecialtyName.Location = new System.Drawing.Point(178, 101);
            this.metroTextBoxSpecialtyName.Name = "metroTextBoxSpecialtyName";
            this.metroTextBoxSpecialtyName.Size = new System.Drawing.Size(129, 23);
            this.metroTextBoxSpecialtyName.TabIndex = 9;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(80, 99);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(92, 25);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Название:";
            // 
            // SpecialtyEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 295);
            this.Controls.Add(this.metroTextBoxSpecialtyName);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTileSpecialtyEdit);
            this.Controls.Add(this.metroTileSpicialtyAdd);
            this.Controls.Add(this.metroComboBoxFormStudy);
            this.Controls.Add(this.metroTextBoxSpecialtyTime);
            this.Controls.Add(this.metroTextBoxSpecialtyCode);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(330, 295);
            this.MinimumSize = new System.Drawing.Size(330, 295);
            this.Name = "SpecialtyEntityForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "SpecialtyEntityForm";
            this.Load += new System.EventHandler(this.SpecialtyEntityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSpecialtyCode;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSpecialtyTime;
        private MetroFramework.Controls.MetroComboBox metroComboBoxFormStudy;
        private MetroFramework.Controls.MetroTile metroTileSpicialtyAdd;
        private MetroFramework.Controls.MetroTile metroTileSpecialtyEdit;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSpecialtyName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}