namespace GraduateDistribution
{
    partial class OrganizationsForm
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonOrganizationDelete = new MetroFramework.Controls.MetroButton();
            this.metroButtonOrganizationEdit = new MetroFramework.Controls.MetroButton();
            this.metroButtonOrganizationAdd = new MetroFramework.Controls.MetroButton();
            this.dataGridViewOrganization = new System.Windows.Forms.DataGridView();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroButtonPositionDelete = new MetroFramework.Controls.MetroButton();
            this.metroButtonPositionEdit = new MetroFramework.Controls.MetroButton();
            this.metroButtonPositionAdd = new MetroFramework.Controls.MetroButton();
            this.dataGridViewPosition = new System.Windows.Forms.DataGridView();
            this.metroTileRefresh = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganization)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(598, 364);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.metroTextBoxSearch);
            this.metroTabPage1.Controls.Add(this.metroButtonOrganizationDelete);
            this.metroTabPage1.Controls.Add(this.metroButtonOrganizationEdit);
            this.metroTabPage1.Controls.Add(this.metroButtonOrganizationAdd);
            this.metroTabPage1.Controls.Add(this.dataGridViewOrganization);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(590, 325);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Организации";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(328, 2);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 25);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Поиск:";
            // 
            // metroTextBoxSearch
            // 
            this.metroTextBoxSearch.Location = new System.Drawing.Point(399, 3);
            this.metroTextBoxSearch.Name = "metroTextBoxSearch";
            this.metroTextBoxSearch.Size = new System.Drawing.Size(191, 23);
            this.metroTextBoxSearch.TabIndex = 10;
            this.metroTextBoxSearch.TextChanged += new System.EventHandler(this.metroTextBoxSearch_TextChanged);
            // 
            // metroButtonOrganizationDelete
            // 
            this.metroButtonOrganizationDelete.Location = new System.Drawing.Point(394, 289);
            this.metroButtonOrganizationDelete.Name = "metroButtonOrganizationDelete";
            this.metroButtonOrganizationDelete.Size = new System.Drawing.Size(196, 33);
            this.metroButtonOrganizationDelete.TabIndex = 9;
            this.metroButtonOrganizationDelete.Text = "Удалить";
            this.metroButtonOrganizationDelete.Click += new System.EventHandler(this.metroButtonOrganizationDelete_Click);
            // 
            // metroButtonOrganizationEdit
            // 
            this.metroButtonOrganizationEdit.Location = new System.Drawing.Point(202, 289);
            this.metroButtonOrganizationEdit.Name = "metroButtonOrganizationEdit";
            this.metroButtonOrganizationEdit.Size = new System.Drawing.Size(186, 33);
            this.metroButtonOrganizationEdit.TabIndex = 8;
            this.metroButtonOrganizationEdit.Text = "Редактировать";
            this.metroButtonOrganizationEdit.Click += new System.EventHandler(this.metroButtonOrganizationEdit_Click);
            // 
            // metroButtonOrganizationAdd
            // 
            this.metroButtonOrganizationAdd.Location = new System.Drawing.Point(0, 289);
            this.metroButtonOrganizationAdd.Name = "metroButtonOrganizationAdd";
            this.metroButtonOrganizationAdd.Size = new System.Drawing.Size(196, 33);
            this.metroButtonOrganizationAdd.TabIndex = 7;
            this.metroButtonOrganizationAdd.Text = "Добавить";
            this.metroButtonOrganizationAdd.Click += new System.EventHandler(this.metroButtonOrganizationAdd_Click);
            // 
            // dataGridViewOrganization
            // 
            this.dataGridViewOrganization.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrganization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrganization.GridColor = System.Drawing.Color.White;
            this.dataGridViewOrganization.Location = new System.Drawing.Point(0, 30);
            this.dataGridViewOrganization.Name = "dataGridViewOrganization";
            this.dataGridViewOrganization.Size = new System.Drawing.Size(590, 253);
            this.dataGridViewOrganization.TabIndex = 6;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroButtonPositionDelete);
            this.metroTabPage2.Controls.Add(this.metroButtonPositionEdit);
            this.metroTabPage2.Controls.Add(this.metroButtonPositionAdd);
            this.metroTabPage2.Controls.Add(this.dataGridViewPosition);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(590, 325);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Должности";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // metroButtonPositionDelete
            // 
            this.metroButtonPositionDelete.Location = new System.Drawing.Point(394, 289);
            this.metroButtonPositionDelete.Name = "metroButtonPositionDelete";
            this.metroButtonPositionDelete.Size = new System.Drawing.Size(196, 33);
            this.metroButtonPositionDelete.TabIndex = 5;
            this.metroButtonPositionDelete.Text = "Удалить";
            this.metroButtonPositionDelete.Click += new System.EventHandler(this.metroButtonPositionDelete_Click);
            // 
            // metroButtonPositionEdit
            // 
            this.metroButtonPositionEdit.Location = new System.Drawing.Point(202, 289);
            this.metroButtonPositionEdit.Name = "metroButtonPositionEdit";
            this.metroButtonPositionEdit.Size = new System.Drawing.Size(186, 33);
            this.metroButtonPositionEdit.TabIndex = 4;
            this.metroButtonPositionEdit.Text = "Редактировать";
            this.metroButtonPositionEdit.Click += new System.EventHandler(this.metroButtonPositionEdit_Click);
            // 
            // metroButtonPositionAdd
            // 
            this.metroButtonPositionAdd.Location = new System.Drawing.Point(0, 289);
            this.metroButtonPositionAdd.Name = "metroButtonPositionAdd";
            this.metroButtonPositionAdd.Size = new System.Drawing.Size(196, 33);
            this.metroButtonPositionAdd.TabIndex = 3;
            this.metroButtonPositionAdd.Text = "Добавить";
            this.metroButtonPositionAdd.Click += new System.EventHandler(this.metroButtonPositionAdd_Click);
            // 
            // dataGridViewPosition
            // 
            this.dataGridViewPosition.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPosition.GridColor = System.Drawing.Color.White;
            this.dataGridViewPosition.Location = new System.Drawing.Point(0, 3);
            this.dataGridViewPosition.Name = "dataGridViewPosition";
            this.dataGridViewPosition.Size = new System.Drawing.Size(590, 280);
            this.dataGridViewPosition.TabIndex = 2;
            // 
            // metroTileRefresh
            // 
            this.metroTileRefresh.Location = new System.Drawing.Point(540, 34);
            this.metroTileRefresh.Name = "metroTileRefresh";
            this.metroTileRefresh.Size = new System.Drawing.Size(81, 23);
            this.metroTileRefresh.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTileRefresh.TabIndex = 2;
            this.metroTileRefresh.Text = "Обновить";
            this.metroTileRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileRefresh.Click += new System.EventHandler(this.metroTileRefresh_Click);
            // 
            // OrganizationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.metroTileRefresh);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(644, 450);
            this.MinimumSize = new System.Drawing.Size(644, 450);
            this.Name = "OrganizationsForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Организации";
            this.Load += new System.EventHandler(this.OrganizationsForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganization)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton metroButtonOrganizationDelete;
        private MetroFramework.Controls.MetroButton metroButtonOrganizationEdit;
        private MetroFramework.Controls.MetroButton metroButtonOrganizationAdd;
        private System.Windows.Forms.DataGridView dataGridViewOrganization;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton metroButtonPositionDelete;
        private MetroFramework.Controls.MetroButton metroButtonPositionEdit;
        private MetroFramework.Controls.MetroButton metroButtonPositionAdd;
        private System.Windows.Forms.DataGridView dataGridViewPosition;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSearch;
        private MetroFramework.Controls.MetroTile metroTileRefresh;
    }
}