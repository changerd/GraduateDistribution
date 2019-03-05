namespace GraduateDistribution
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTileCollege = new MetroFramework.Controls.MetroTile();
            this.metroTileOrganization = new MetroFramework.Controls.MetroTile();
            this.metroTileDistribution = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTileCollege
            // 
            this.metroTileCollege.Location = new System.Drawing.Point(114, 85);
            this.metroTileCollege.Name = "metroTileCollege";
            this.metroTileCollege.Size = new System.Drawing.Size(128, 57);
            this.metroTileCollege.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTileCollege.TabIndex = 0;
            this.metroTileCollege.Text = "Колледж";
            this.metroTileCollege.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileCollege.Click += new System.EventHandler(this.metroTileCollege_Click);
            // 
            // metroTileOrganization
            // 
            this.metroTileOrganization.Location = new System.Drawing.Point(114, 170);
            this.metroTileOrganization.Name = "metroTileOrganization";
            this.metroTileOrganization.Size = new System.Drawing.Size(128, 57);
            this.metroTileOrganization.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTileOrganization.TabIndex = 1;
            this.metroTileOrganization.Text = "Организации";
            this.metroTileOrganization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileOrganization.Click += new System.EventHandler(this.metroTileOrganization_Click);
            // 
            // metroTileDistribution
            // 
            this.metroTileDistribution.Location = new System.Drawing.Point(114, 256);
            this.metroTileDistribution.Name = "metroTileDistribution";
            this.metroTileDistribution.Size = new System.Drawing.Size(128, 57);
            this.metroTileDistribution.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTileDistribution.TabIndex = 2;
            this.metroTileDistribution.Text = "Распределение";
            this.metroTileDistribution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileDistribution.Click += new System.EventHandler(this.metroTileDistribution_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(357, 358);
            this.Controls.Add(this.metroTileDistribution);
            this.Controls.Add(this.metroTileOrganization);
            this.Controls.Add(this.metroTileCollege);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(357, 358);
            this.MinimumSize = new System.Drawing.Size(357, 358);
            this.Name = "MainMenu";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Распределение выпускников";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileCollege;
        private MetroFramework.Controls.MetroTile metroTileOrganization;
        private MetroFramework.Controls.MetroTile metroTileDistribution;
    }
}

