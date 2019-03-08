namespace GraduateDistribution
{
    partial class DistributionForm
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
            this.metroTextBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.dataGridViewDistribution = new System.Windows.Forms.DataGridView();
            this.metroCheckBoxDate = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePickerExportStartFirst = new System.Windows.Forms.DateTimePicker();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePickerExportStartSecond = new System.Windows.Forms.DateTimePicker();
            this.metroTileExportExcel = new MetroFramework.Controls.MetroTile();
            this.metroTileExportWord = new MetroFramework.Controls.MetroTile();
            this.metroButtonDistributionAdd = new MetroFramework.Controls.MetroButton();
            this.metroButtonDistributionEdit = new MetroFramework.Controls.MetroButton();
            this.metroButtonDistributionDelete = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePickerExportEndFirst = new System.Windows.Forms.DateTimePicker();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePickerExportEndSecond = new System.Windows.Forms.DateTimePicker();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePickerFilterEndFirst = new System.Windows.Forms.DateTimePicker();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePickerFilterEndSecond = new System.Windows.Forms.DateTimePicker();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePickerFilterStartFirst = new System.Windows.Forms.DateTimePicker();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePickerFilterStartSecond = new System.Windows.Forms.DateTimePicker();
            this.metroTileFilter = new MetroFramework.Controls.MetroTile();
            this.metroTileRefresh = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDistribution)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Поиск:";
            // 
            // metroTextBoxSearch
            // 
            this.metroTextBoxSearch.Location = new System.Drawing.Point(94, 63);
            this.metroTextBoxSearch.Name = "metroTextBoxSearch";
            this.metroTextBoxSearch.Size = new System.Drawing.Size(325, 23);
            this.metroTextBoxSearch.TabIndex = 1;
            this.metroTextBoxSearch.TextChanged += new System.EventHandler(this.metroTextBoxSearch_TextChanged);
            // 
            // dataGridViewDistribution
            // 
            this.dataGridViewDistribution.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDistribution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDistribution.Location = new System.Drawing.Point(23, 92);
            this.dataGridViewDistribution.Name = "dataGridViewDistribution";
            this.dataGridViewDistribution.Size = new System.Drawing.Size(969, 578);
            this.dataGridViewDistribution.TabIndex = 2;
            // 
            // metroCheckBoxDate
            // 
            this.metroCheckBoxDate.AutoSize = true;
            this.metroCheckBoxDate.Location = new System.Drawing.Point(3, 14);
            this.metroCheckBoxDate.Name = "metroCheckBoxDate";
            this.metroCheckBoxDate.Size = new System.Drawing.Size(65, 15);
            this.metroCheckBoxDate.TabIndex = 6;
            this.metroCheckBoxDate.Text = "По дате";
            this.metroCheckBoxDate.UseVisualStyleBackColor = true;
            this.metroCheckBoxDate.CheckedChanged += new System.EventHandler(this.metroCheckBoxDate_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(16, 55);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(27, 25);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "С:";
            // 
            // dateTimePickerExportStartFirst
            // 
            this.dateTimePickerExportStartFirst.Enabled = false;
            this.dateTimePickerExportStartFirst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerExportStartFirst.Location = new System.Drawing.Point(49, 60);
            this.dateTimePickerExportStartFirst.Name = "dateTimePickerExportStartFirst";
            this.dateTimePickerExportStartFirst.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerExportStartFirst.TabIndex = 8;
            this.dateTimePickerExportStartFirst.Value = new System.DateTime(2019, 3, 7, 0, 0, 0, 0);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(5, 89);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 25);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "По:";
            // 
            // dateTimePickerExportStartSecond
            // 
            this.dateTimePickerExportStartSecond.Enabled = false;
            this.dateTimePickerExportStartSecond.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerExportStartSecond.Location = new System.Drawing.Point(49, 94);
            this.dateTimePickerExportStartSecond.Name = "dateTimePickerExportStartSecond";
            this.dateTimePickerExportStartSecond.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerExportStartSecond.TabIndex = 10;
            this.dateTimePickerExportStartSecond.Value = new System.DateTime(2019, 3, 7, 0, 0, 0, 0);
            // 
            // metroTileExportExcel
            // 
            this.metroTileExportExcel.Location = new System.Drawing.Point(16, 215);
            this.metroTileExportExcel.Name = "metroTileExportExcel";
            this.metroTileExportExcel.Size = new System.Drawing.Size(120, 23);
            this.metroTileExportExcel.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTileExportExcel.TabIndex = 11;
            this.metroTileExportExcel.Text = "Экспорт";
            this.metroTileExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileExportExcel.Click += new System.EventHandler(this.metroTileExportExcel_Click);
            // 
            // metroTileExportWord
            // 
            this.metroTileExportWord.Location = new System.Drawing.Point(18, 37);
            this.metroTileExportWord.Name = "metroTileExportWord";
            this.metroTileExportWord.Size = new System.Drawing.Size(120, 23);
            this.metroTileExportWord.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTileExportWord.TabIndex = 12;
            this.metroTileExportWord.Text = "Экспорт";
            this.metroTileExportWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileExportWord.Click += new System.EventHandler(this.metroTileExportWord_Click);
            // 
            // metroButtonDistributionAdd
            // 
            this.metroButtonDistributionAdd.Location = new System.Drawing.Point(23, 676);
            this.metroButtonDistributionAdd.Name = "metroButtonDistributionAdd";
            this.metroButtonDistributionAdd.Size = new System.Drawing.Size(323, 33);
            this.metroButtonDistributionAdd.TabIndex = 13;
            this.metroButtonDistributionAdd.Text = "Добавить";
            this.metroButtonDistributionAdd.Click += new System.EventHandler(this.metroButtonDistributionAdd_Click);
            // 
            // metroButtonDistributionEdit
            // 
            this.metroButtonDistributionEdit.Location = new System.Drawing.Point(352, 676);
            this.metroButtonDistributionEdit.Name = "metroButtonDistributionEdit";
            this.metroButtonDistributionEdit.Size = new System.Drawing.Size(311, 33);
            this.metroButtonDistributionEdit.TabIndex = 14;
            this.metroButtonDistributionEdit.Text = "Редактировать";
            this.metroButtonDistributionEdit.Click += new System.EventHandler(this.metroButtonDistributionEdit_Click);
            // 
            // metroButtonDistributionDelete
            // 
            this.metroButtonDistributionDelete.Location = new System.Drawing.Point(669, 676);
            this.metroButtonDistributionDelete.Name = "metroButtonDistributionDelete";
            this.metroButtonDistributionDelete.Size = new System.Drawing.Size(323, 33);
            this.metroButtonDistributionDelete.TabIndex = 15;
            this.metroButtonDistributionDelete.Text = "Удалить";
            this.metroButtonDistributionDelete.Click += new System.EventHandler(this.metroButtonDistributionDelete_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.dateTimePickerExportEndFirst);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.dateTimePickerExportEndSecond);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.metroCheckBoxDate);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.dateTimePickerExportStartFirst);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroTileExportExcel);
            this.metroPanel1.Controls.Add(this.dateTimePickerExportStartSecond);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(1014, 110);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(154, 249);
            this.metroPanel1.TabIndex = 16;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.Location = new System.Drawing.Point(5, 117);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(64, 25);
            this.metroLabel10.TabIndex = 17;
            this.metroLabel10.Text = "Конец:";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.Location = new System.Drawing.Point(16, 140);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(27, 25);
            this.metroLabel11.TabIndex = 13;
            this.metroLabel11.Text = "С:";
            // 
            // dateTimePickerExportEndFirst
            // 
            this.dateTimePickerExportEndFirst.Enabled = false;
            this.dateTimePickerExportEndFirst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerExportEndFirst.Location = new System.Drawing.Point(49, 145);
            this.dateTimePickerExportEndFirst.Name = "dateTimePickerExportEndFirst";
            this.dateTimePickerExportEndFirst.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerExportEndFirst.TabIndex = 14;
            this.dateTimePickerExportEndFirst.Value = new System.DateTime(2019, 3, 7, 0, 0, 0, 0);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.Location = new System.Drawing.Point(5, 174);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(38, 25);
            this.metroLabel12.TabIndex = 15;
            this.metroLabel12.Text = "По:";
            // 
            // dateTimePickerExportEndSecond
            // 
            this.dateTimePickerExportEndSecond.Enabled = false;
            this.dateTimePickerExportEndSecond.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerExportEndSecond.Location = new System.Drawing.Point(49, 179);
            this.dateTimePickerExportEndSecond.Name = "dateTimePickerExportEndSecond";
            this.dateTimePickerExportEndSecond.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerExportEndSecond.TabIndex = 16;
            this.dateTimePickerExportEndSecond.Value = new System.DateTime(2019, 3, 7, 0, 0, 0, 0);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(5, 32);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(74, 25);
            this.metroLabel9.TabIndex = 12;
            this.metroLabel9.Text = "Начало:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(1014, 96);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(136, 25);
            this.metroLabel4.TabIndex = 17;
            this.metroLabel4.Text = "Экспорт в Ecxel:";
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.metroTileExportWord);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(1014, 379);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(154, 81);
            this.metroPanel2.TabIndex = 18;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(1017, 369);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(139, 25);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "Экспорт в Word:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(1014, 465);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(72, 25);
            this.metroLabel6.TabIndex = 21;
            this.metroLabel6.Text = "Фильтр:";
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.metroLabel7);
            this.metroPanel3.Controls.Add(this.metroLabel8);
            this.metroPanel3.Controls.Add(this.dateTimePickerFilterEndFirst);
            this.metroPanel3.Controls.Add(this.metroLabel13);
            this.metroPanel3.Controls.Add(this.dateTimePickerFilterEndSecond);
            this.metroPanel3.Controls.Add(this.metroLabel14);
            this.metroPanel3.Controls.Add(this.metroLabel15);
            this.metroPanel3.Controls.Add(this.dateTimePickerFilterStartFirst);
            this.metroPanel3.Controls.Add(this.metroLabel16);
            this.metroPanel3.Controls.Add(this.dateTimePickerFilterStartSecond);
            this.metroPanel3.Controls.Add(this.metroTileFilter);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(1014, 479);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(154, 230);
            this.metroPanel3.TabIndex = 20;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(5, 96);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(64, 25);
            this.metroLabel7.TabIndex = 27;
            this.metroLabel7.Text = "Конец:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(16, 119);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(27, 25);
            this.metroLabel8.TabIndex = 23;
            this.metroLabel8.Text = "С:";
            // 
            // dateTimePickerFilterEndFirst
            // 
            this.dateTimePickerFilterEndFirst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFilterEndFirst.Location = new System.Drawing.Point(49, 124);
            this.dateTimePickerFilterEndFirst.Name = "dateTimePickerFilterEndFirst";
            this.dateTimePickerFilterEndFirst.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerFilterEndFirst.TabIndex = 24;
            this.dateTimePickerFilterEndFirst.Value = new System.DateTime(2019, 3, 7, 0, 0, 0, 0);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel13.Location = new System.Drawing.Point(5, 153);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(38, 25);
            this.metroLabel13.TabIndex = 25;
            this.metroLabel13.Text = "По:";
            // 
            // dateTimePickerFilterEndSecond
            // 
            this.dateTimePickerFilterEndSecond.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFilterEndSecond.Location = new System.Drawing.Point(49, 158);
            this.dateTimePickerFilterEndSecond.Name = "dateTimePickerFilterEndSecond";
            this.dateTimePickerFilterEndSecond.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerFilterEndSecond.TabIndex = 26;
            this.dateTimePickerFilterEndSecond.Value = new System.DateTime(2019, 3, 7, 0, 0, 0, 0);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.Location = new System.Drawing.Point(5, 11);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(74, 25);
            this.metroLabel14.TabIndex = 22;
            this.metroLabel14.Text = "Начало:";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel15.Location = new System.Drawing.Point(16, 34);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(27, 25);
            this.metroLabel15.TabIndex = 18;
            this.metroLabel15.Text = "С:";
            // 
            // dateTimePickerFilterStartFirst
            // 
            this.dateTimePickerFilterStartFirst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFilterStartFirst.Location = new System.Drawing.Point(49, 39);
            this.dateTimePickerFilterStartFirst.Name = "dateTimePickerFilterStartFirst";
            this.dateTimePickerFilterStartFirst.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerFilterStartFirst.TabIndex = 19;
            this.dateTimePickerFilterStartFirst.Value = new System.DateTime(2019, 3, 7, 0, 0, 0, 0);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel16.Location = new System.Drawing.Point(5, 68);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(38, 25);
            this.metroLabel16.TabIndex = 20;
            this.metroLabel16.Text = "По:";
            // 
            // dateTimePickerFilterStartSecond
            // 
            this.dateTimePickerFilterStartSecond.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFilterStartSecond.Location = new System.Drawing.Point(49, 73);
            this.dateTimePickerFilterStartSecond.Name = "dateTimePickerFilterStartSecond";
            this.dateTimePickerFilterStartSecond.Size = new System.Drawing.Size(94, 20);
            this.dateTimePickerFilterStartSecond.TabIndex = 21;
            this.dateTimePickerFilterStartSecond.Value = new System.DateTime(2019, 3, 7, 0, 0, 0, 0);
            // 
            // metroTileFilter
            // 
            this.metroTileFilter.Location = new System.Drawing.Point(18, 194);
            this.metroTileFilter.Name = "metroTileFilter";
            this.metroTileFilter.Size = new System.Drawing.Size(120, 23);
            this.metroTileFilter.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTileFilter.TabIndex = 11;
            this.metroTileFilter.Text = "Фильтр";
            this.metroTileFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileFilter.Click += new System.EventHandler(this.metroTileFilter_Click);
            // 
            // metroTileRefresh
            // 
            this.metroTileRefresh.Location = new System.Drawing.Point(1070, 63);
            this.metroTileRefresh.Name = "metroTileRefresh";
            this.metroTileRefresh.Size = new System.Drawing.Size(98, 23);
            this.metroTileRefresh.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTileRefresh.TabIndex = 22;
            this.metroTileRefresh.Text = "Обновить";
            this.metroTileRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileRefresh.Click += new System.EventHandler(this.metroTileRefresh_Click);
            // 
            // DistributionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 728);
            this.Controls.Add(this.metroTileRefresh);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroButtonDistributionDelete);
            this.Controls.Add(this.metroButtonDistributionEdit);
            this.Controls.Add(this.metroButtonDistributionAdd);
            this.Controls.Add(this.dataGridViewDistribution);
            this.Controls.Add(this.metroTextBoxSearch);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1191, 728);
            this.MinimumSize = new System.Drawing.Size(1191, 728);
            this.Name = "DistributionForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Распределение";
            this.Load += new System.EventHandler(this.DistributionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDistribution)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewDistribution;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxDate;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DateTimePicker dateTimePickerExportStartFirst;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DateTimePicker dateTimePickerExportStartSecond;
        private MetroFramework.Controls.MetroTile metroTileExportExcel;
        private MetroFramework.Controls.MetroTile metroTileExportWord;
        private MetroFramework.Controls.MetroButton metroButtonDistributionAdd;
        private MetroFramework.Controls.MetroButton metroButtonDistributionEdit;
        private MetroFramework.Controls.MetroButton metroButtonDistributionDelete;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroTile metroTileFilter;
        private MetroFramework.Controls.MetroTile metroTileRefresh;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.DateTimePicker dateTimePickerExportEndFirst;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.DateTimePicker dateTimePickerExportEndSecond;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.DateTimePicker dateTimePickerFilterEndFirst;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private System.Windows.Forms.DateTimePicker dateTimePickerFilterEndSecond;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private System.Windows.Forms.DateTimePicker dateTimePickerFilterStartFirst;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private System.Windows.Forms.DateTimePicker dateTimePickerFilterStartSecond;
    }
}