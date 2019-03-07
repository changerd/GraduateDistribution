using GraduateDistribution.Entities;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace GraduateDistribution
{
    public partial class DistributionForm : MetroForm
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public DistributionForm()
        {
            InitializeComponent();
        }

        void CreateTableDistribution()
        {
            try
            {
                DataTable tableofDistribution = new DataTable();
                DataColumn DistributionIdColumn = new DataColumn("Номер распределения", typeof(int));
                DataColumn DistributionSurnameColumn = new DataColumn("Фамилия", typeof(string));
                DataColumn DistributionFirstNameColumn = new DataColumn("Имя", typeof(string));
                DataColumn DistributionSecondNameColumn = new DataColumn("Отчество", typeof(string));
                DataColumn DistributionOrganizationColumn = new DataColumn("Организация", typeof(string));
                DataColumn DistributionPositionColumn = new DataColumn("Должность", typeof(string));
                DataColumn DistributionSalaryColumn = new DataColumn("Оклад", typeof(decimal));
                DataColumn DistributionStartColumn = new DataColumn("Дата начала распределения", typeof(DateTime));
                DataColumn DistributionEndColumn = new DataColumn("Дата окончания распределения", typeof(DateTime));

                tableofDistribution.Columns.AddRange(new DataColumn[]
                {
                    DistributionIdColumn,
                    DistributionSurnameColumn,
                    DistributionFirstNameColumn,
                    DistributionSecondNameColumn,
                    DistributionOrganizationColumn,
                    DistributionPositionColumn,
                    DistributionSalaryColumn,
                    DistributionStartColumn,
                    DistributionEndColumn,
                });
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var query = context.Distributions.Include(g => g.Graduate).Include(o => o.Organization).Include(p => p.Position);
                    int i = 0;
                    foreach (var d in query)
                    {
                        DataRow newRow = tableofDistribution.NewRow();
                        newRow["Номер распределения"] = d.DistributionId;
                        newRow["Фамилия"] = d.Graduate.GraduateSurName;
                        newRow["Имя"] = d.Graduate.GraduateFirstName;
                        newRow["Отчество"] = d.Graduate.GraduateSecondName;
                        newRow["Организация"] = d.Organization.OrganizationName;
                        newRow["Должность"] = d.Position.PositionName;
                        newRow["Оклад"] = d.DistributionSalary;
                        newRow["Дата начала распределения"] = d.DistributionStart;
                        newRow["Дата окончания распределения"] = d.DistributionEnd;
                        tableofDistribution.Rows.Add(newRow);
                        i++;
                    }
                    dataGridViewDistribution.DataSource = tableofDistribution;
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }
        private void DistributionForm_Load(object sender, EventArgs e)
        {
            CreateTableDistribution();
        }

        private void metroButtonDistributionAdd_Click(object sender, EventArgs e)
        {
            DistributionEntityForm form = new DistributionEntityForm();
            form.Text = "Добавление распределения";
            form.btnAddvisible = true;
            form.Show();
        }

        private void metroButtonDistributionEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int did = Convert.ToInt32(dataGridViewDistribution.SelectedCells[0].Value.ToString());
                var distribution = db.Distributions.Find(did);
                DistributionEntityForm form = new DistributionEntityForm();
                form.Text = "Изменение распределения";
                form.btnEditvisible = true;
                form.DistributionId = distribution.DistributionId;
                form.dsalary = distribution.DistributionSalary;
                form.dfirst = distribution.DistributionStart;
                form.dsecond = distribution.DistributionEnd;
                form.Show();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroButtonDistributionDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int did = Convert.ToInt32(dataGridViewDistribution.SelectedCells[0].Value.ToString());
                var distribution = db.Distributions.Find(did);
                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить распределение?", "GraduateDistribution", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    db.Distributions.Remove(distribution);
                    db.SaveChanges();
                }
                DistributionForm_Load(sender, e);
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroTileRefresh_Click(object sender, EventArgs e)
        {
            DistributionForm_Load(sender, e);
        }

        private void metroTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrencyManager cManager = dataGridViewDistribution.BindingContext[dataGridViewDistribution.DataSource, dataGridViewDistribution.DataMember] as CurrencyManager;
                cManager.SuspendBinding();
                cManager.ResumeBinding();
                for (int i = 0; i < dataGridViewDistribution.RowCount; i++)
                {
                    dataGridViewDistribution.Rows[i].Selected = false;
                }
                if (metroTextBoxSearch.Text == "")
                    for (int i = 0; i < dataGridViewDistribution.RowCount; i++)
                    {
                        dataGridViewDistribution.Rows[i].Selected = false;
                        dataGridViewDistribution.Rows[i].Visible = true;
                    }
                else
                {
                    for (int i = 0; i < dataGridViewDistribution.RowCount; i++)
                    {
                        dataGridViewDistribution.Rows[i].Selected = false;
                        for (int j = 0; j < dataGridViewDistribution.ColumnCount; j++)
                            if (dataGridViewDistribution.Rows[i].Cells[j].Value != null)

                                if (dataGridViewDistribution.Rows[i].Cells[j].Value.ToString().Contains(metroTextBoxSearch.Text))
                                {
                                    dataGridViewDistribution.Rows[i].Selected = true;
                                    dataGridViewDistribution.Rows[i].Visible = true;
                                    break;
                                }
                                else
                                {
                                    dataGridViewDistribution.Rows[i].Selected = false;
                                    dataGridViewDistribution.Rows[i].Visible = false;
                                }
                    }
                }
            }

            catch
            {
                MessageBox.Show("При поиске произошла ошибка, для исправления выберите другую строку");
            }
        }

        private void metroCheckBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBoxDate.Checked)
            {
                dateTimePickerExportStartFirst.Enabled = true;
                dateTimePickerExportStartSecond.Enabled = true;
                dateTimePickerExportEndFirst.Enabled = true;
                dateTimePickerExportEndSecond.Enabled = true;

            }
            else
            {
                dateTimePickerExportStartFirst.Enabled = false;
                dateTimePickerExportStartSecond.Enabled = false;
                dateTimePickerExportEndFirst.Enabled = false;
                dateTimePickerExportEndSecond.Enabled = false;
            }
        }

        private void metroTileExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                List<Distribution> distributions = new List<Distribution>();
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    IQueryable<Distribution> query = context.Distributions.Include(g => g.Graduate).Include(o => o.Organization).Include(p => p.Position);
                    if (metroCheckBoxDate.Checked)
                    {
                        query = query.Where(d => d.DistributionStart >= dateTimePickerExportStartFirst.Value &&
                         d.DistributionStart <= dateTimePickerExportStartSecond.Value &&
                         d.DistributionEnd >= dateTimePickerExportEndFirst.Value &&
                         d.DistributionEnd <= dateTimePickerExportEndSecond.Value);
                    }
                    distributions = query.ToList();
                }
                Excel.Application excelApp = new Excel.Application();
                excelApp.Workbooks.Add();
                Excel._Worksheet worksheet = excelApp.ActiveSheet;
                if (metroCheckBoxDate.Checked)
                    worksheet.Cells[1, "A"] = "Распределения начиная с " + dateTimePickerExportStartFirst.Value.ToShortDateString() +
                        " по " + dateTimePickerExportStartSecond.Value.ToShortDateString() + " и заканчивая с " +
                        dateTimePickerExportEndFirst.Value.ToShortDateString() + " по " +
                        dateTimePickerExportEndSecond.Value.ToShortDateString();
                else
                    worksheet.Cells[1, "A"] = "Все распределения";
                worksheet.Cells[2, "A"] = "Номер распределения";
                worksheet.Cells[2, "B"] = "Фамилия";
                worksheet.Cells[2, "C"] = "Имя";
                worksheet.Cells[2, "D"] = "Отчество";
                worksheet.Cells[2, "E"] = "Организация";
                worksheet.Cells[2, "F"] = "Должность";
                worksheet.Cells[2, "G"] = "Оклад";
                worksheet.Cells[2, "H"] = "Дата начала распределения";
                worksheet.Cells[2, "I"] = "Дата окончания распределения";
                int row = 2;
                foreach (var d in distributions)
                {
                    row++;
                    worksheet.Cells[row, "A"] = d.DistributionId;
                    worksheet.Cells[row, "B"] = d.Graduate.GraduateSurName;
                    worksheet.Cells[row, "C"] = d.Graduate.GraduateFirstName;
                    worksheet.Cells[row, "D"] = d.Graduate.GraduateSecondName;
                    worksheet.Cells[row, "E"] = d.Organization.OrganizationName;
                    worksheet.Cells[row, "F"] = d.Position.PositionName;
                    worksheet.Cells[row, "G"] = d.DistributionSalary;
                    worksheet.Cells[row, "H"] = d.DistributionStart;
                    worksheet.Cells[row, "I"] = d.DistributionEnd;
                }
                worksheet.Range["A1"].AutoFormat(Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic1);
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = "Сохранение xlsx файла";
                saveFileDialog1.Filter = "xlsx файлы (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    worksheet.SaveAs(saveFileDialog1.FileName);
                }
                excelApp.Quit();
                MessageBox.Show("Excel-файл успешно сохранен", "GraduateDistribution");
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroTileExportWord_Click(object sender, EventArgs e)
        {
            try
            {
                int did = Convert.ToInt32(dataGridViewDistribution.SelectedCells[0].Value.ToString());
                var query = db.Distributions.Include(g => g.Graduate).Include(o => o.Organization).Include(p => p.Position);
                var distribution = query.SingleOrDefault(d => d.DistributionId == did);
                Word.Application app = new Word.Application();
                Word.Document doc = new Word.Document();
                Word.Range r = doc.Range();
                Word.Table table = doc.Tables.Add(r, 9, 2);
                object begCell = table.Cell(1, 1).Range.Start;
                object endCell = table.Cell(1, 2).Range.End;
                Word.Range wordcellrange = doc.Range(ref begCell, ref endCell);
                wordcellrange.Select();
                app.Selection.Cells.Merge();
                table.Cell(1, 1).Range.Text = "Распределение №" + distribution.DistributionId;
                table.Borders.Enable = 0;
                table.Cell(2, 1).Range.Text = "Фамилия:";
                table.Cell(3, 1).Range.Text = "Имя:";
                table.Cell(4, 1).Range.Text = "Отчество:";
                table.Cell(5, 1).Range.Text = "Организация:";
                table.Cell(6, 1).Range.Text = "Должность:";
                table.Cell(7, 1).Range.Text = "Оклад:";
                table.Cell(8, 1).Range.Text = "Дата начала распределения:";
                table.Cell(9, 1).Range.Text = "Дата окончания распределения:";
                r.Bold = 0;
                r.Font.Size = 14;
                table.Cell(2, 2).Range.Text = distribution.Graduate.GraduateSurName.ToString();
                table.Cell(3, 2).Range.Text = distribution.Graduate.GraduateFirstName.ToString();
                table.Cell(4, 2).Range.Text = distribution.Graduate.GraduateSecondName.ToString();
                table.Cell(5, 2).Range.Text = distribution.Organization.OrganizationName.ToString();
                table.Cell(6, 2).Range.Text = distribution.Position.PositionName.ToString();
                table.Cell(7, 2).Range.Text = distribution.DistributionSalary.ToString();
                table.Cell(8, 2).Range.Text = distribution.DistributionStart.ToString();
                table.Cell(9, 2).Range.Text = distribution.DistributionEnd.ToString();
                foreach (Word.Row row in table.Rows)
                {

                    foreach (Word.Cell cell in row.Cells)
                    {
                        if (cell.RowIndex == 1)
                        {
                            cell.Range.Bold = 1;
                            cell.Range.Font.Name = "Times New Roman";
                            cell.Range.Font.Size = 16;
                            cell.Range.Borders.Enable = 0;
                            cell.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            cell.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        }
                        else
                        {
                            cell.Range.Borders.Enable = 0;
                            cell.Range.Font.Name = "Times New Roman";
                            cell.Range.Font.Size = 14;
                            cell.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            cell.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                        }
                    }
                }
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = "Сохранение doc файла";
                saveFileDialog1.Filter = "doc файлы (*.doc)|*.doc|Все файлы (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    doc.SaveAs(string.Format(saveFileDialog1.FileName));
                }
                app.Quit();
                MessageBox.Show("Word-файл успешно сохранён", "GraduateDistribution");
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }

        }

        private void metroTileFilter_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tableofDistribution = new DataTable();
                DataColumn DistributionIdColumn = new DataColumn("Номер распределения", typeof(int));
                DataColumn DistributionSurnameColumn = new DataColumn("Фамилия", typeof(string));
                DataColumn DistributionFirstNameColumn = new DataColumn("Имя", typeof(string));
                DataColumn DistributionSecondNameColumn = new DataColumn("Отчество", typeof(string));
                DataColumn DistributionOrganizationColumn = new DataColumn("Организация", typeof(string));
                DataColumn DistributionPositionColumn = new DataColumn("Должность", typeof(string));
                DataColumn DistributionSalaryColumn = new DataColumn("Оклад", typeof(decimal));
                DataColumn DistributionStartColumn = new DataColumn("Дата начала распределения", typeof(DateTime));
                DataColumn DistributionEndColumn = new DataColumn("Дата окончания распределения", typeof(DateTime));

                tableofDistribution.Columns.AddRange(new DataColumn[]
                {
                    DistributionIdColumn,
                    DistributionSurnameColumn,
                    DistributionFirstNameColumn,
                    DistributionSecondNameColumn,
                    DistributionOrganizationColumn,
                    DistributionPositionColumn,
                    DistributionSalaryColumn,
                    DistributionStartColumn,
                    DistributionEndColumn,
                });
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var query = context.Distributions.Include(g => g.Graduate).
                        Include(o => o.Organization).
                        Include(p => p.Position).
                        Where(d => d.DistributionStart >= dateTimePickerFilterStartFirst.Value &&
                         d.DistributionStart <= dateTimePickerFilterStartSecond.Value &&
                         d.DistributionEnd >= dateTimePickerFilterEndFirst.Value &&
                         d.DistributionEnd <= dateTimePickerFilterEndSecond.Value);
                    int i = 0;
                    foreach (var d in query)
                    {
                        DataRow newRow = tableofDistribution.NewRow();
                        newRow["Номер распределения"] = d.DistributionId;
                        newRow["Фамилия"] = d.Graduate.GraduateSurName;
                        newRow["Имя"] = d.Graduate.GraduateFirstName;
                        newRow["Отчество"] = d.Graduate.GraduateSecondName;
                        newRow["Организация"] = d.Organization.OrganizationName;
                        newRow["Должность"] = d.Position.PositionName;
                        newRow["Оклад"] = d.DistributionSalary;
                        newRow["Дата начала распределения"] = d.DistributionStart;
                        newRow["Дата окончания распределения"] = d.DistributionEnd;
                        tableofDistribution.Rows.Add(newRow);
                        i++;
                    }
                    dataGridViewDistribution.DataSource = tableofDistribution;
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }
    }
}
