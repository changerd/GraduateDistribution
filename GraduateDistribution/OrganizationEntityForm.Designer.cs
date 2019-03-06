namespace GraduateDistribution.Entities
{
    partial class OrganizationEntityForm
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
            this.metroTextBoxName = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxAdress = new MetroFramework.Controls.MetroTextBox();
            this.maskedTextBoxTelephone = new System.Windows.Forms.MaskedTextBox();
            this.metroTextBoxSphere = new MetroFramework.Controls.MetroTextBox();
            this.metroTileOrganizationAdd = new MetroFramework.Controls.MetroTile();
            this.metroTileOrganizationEdit = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(198, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Название организации:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(52, 89);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(169, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Адрес организации:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(31, 116);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(190, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Телефон организации:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(48, 147);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(173, 25);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Сфера организации:";
            // 
            // metroTextBoxName
            // 
            this.metroTextBoxName.Location = new System.Drawing.Point(227, 63);
            this.metroTextBoxName.Name = "metroTextBoxName";
            this.metroTextBoxName.Size = new System.Drawing.Size(166, 23);
            this.metroTextBoxName.TabIndex = 4;
            // 
            // metroTextBoxAdress
            // 
            this.metroTextBoxAdress.Location = new System.Drawing.Point(227, 93);
            this.metroTextBoxAdress.Name = "metroTextBoxAdress";
            this.metroTextBoxAdress.Size = new System.Drawing.Size(166, 23);
            this.metroTextBoxAdress.TabIndex = 5;
            // 
            // maskedTextBoxTelephone
            // 
            this.maskedTextBoxTelephone.Location = new System.Drawing.Point(227, 123);
            this.maskedTextBoxTelephone.Mask = "+375-##-###-##-##";
            this.maskedTextBoxTelephone.Name = "maskedTextBoxTelephone";
            this.maskedTextBoxTelephone.Size = new System.Drawing.Size(166, 20);
            this.maskedTextBoxTelephone.TabIndex = 6;
            // 
            // metroTextBoxSphere
            // 
            this.metroTextBoxSphere.Location = new System.Drawing.Point(227, 150);
            this.metroTextBoxSphere.Name = "metroTextBoxSphere";
            this.metroTextBoxSphere.Size = new System.Drawing.Size(166, 23);
            this.metroTextBoxSphere.TabIndex = 7;
            // 
            // metroTileOrganizationAdd
            // 
            this.metroTileOrganizationAdd.Location = new System.Drawing.Point(176, 200);
            this.metroTileOrganizationAdd.Name = "metroTileOrganizationAdd";
            this.metroTileOrganizationAdd.Size = new System.Drawing.Size(75, 23);
            this.metroTileOrganizationAdd.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTileOrganizationAdd.TabIndex = 8;
            this.metroTileOrganizationAdd.Text = "Добавить";
            this.metroTileOrganizationAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileOrganizationAdd.Visible = false;
            this.metroTileOrganizationAdd.Click += new System.EventHandler(this.metroTileOrganizationAdd_Click);
            // 
            // metroTileOrganizationEdit
            // 
            this.metroTileOrganizationEdit.Location = new System.Drawing.Point(157, 200);
            this.metroTileOrganizationEdit.Name = "metroTileOrganizationEdit";
            this.metroTileOrganizationEdit.Size = new System.Drawing.Size(115, 23);
            this.metroTileOrganizationEdit.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTileOrganizationEdit.TabIndex = 9;
            this.metroTileOrganizationEdit.Text = "Редактировать";
            this.metroTileOrganizationEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileOrganizationEdit.Visible = false;
            this.metroTileOrganizationEdit.Click += new System.EventHandler(this.metroTileOrganizationEdit_Click);
            // 
            // OrganizationEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 243);
            this.Controls.Add(this.metroTileOrganizationEdit);
            this.Controls.Add(this.metroTileOrganizationAdd);
            this.Controls.Add(this.metroTextBoxSphere);
            this.Controls.Add(this.maskedTextBoxTelephone);
            this.Controls.Add(this.metroTextBoxAdress);
            this.Controls.Add(this.metroTextBoxName);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(418, 243);
            this.MinimumSize = new System.Drawing.Size(418, 243);
            this.Name = "OrganizationEntityForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "OrganizationEntityForm";
            this.Load += new System.EventHandler(this.OrganizationEntityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBoxName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAdress;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelephone;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSphere;
        private MetroFramework.Controls.MetroTile metroTileOrganizationAdd;
        private MetroFramework.Controls.MetroTile metroTileOrganizationEdit;
    }
}