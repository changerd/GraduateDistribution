using GraduateDistribution.Entities;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraduateDistribution
{
    public partial class OrganizationsForm : MetroForm
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public OrganizationsForm()
        {
            InitializeComponent();
        }
        void CreateTableOrganization()
        {
            try
            {
                DataTable tableofOrganization = new DataTable();
                DataColumn OrganizationIdColumn = new DataColumn("Номер организации", typeof(int));
                DataColumn OrganizationNameColumn = new DataColumn("Название", typeof(string));
                DataColumn OrganizationAdressColumn = new DataColumn("Адрес", typeof(string));
                DataColumn OrganizationTelephoneColumn = new DataColumn("Телефон", typeof(string));
                DataColumn OrganizationSphereColumn = new DataColumn("Сфера", typeof(string));
                tableofOrganization.Columns.AddRange(new DataColumn[]
                {
                    OrganizationIdColumn,
                    OrganizationNameColumn,
                    OrganizationAdressColumn,
                    OrganizationTelephoneColumn,
                    OrganizationSphereColumn,
                });
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var query = context.Organizations.ToList();
                    int i = 0;
                    foreach (var o in query)
                    {
                        DataRow newRow = tableofOrganization.NewRow();
                        newRow["Номер организации"] = o.OrganizationId;
                        newRow["Название"] = o.OrganizationName;
                        newRow["Адрес"] = o.OrganizationAdress;
                        newRow["Телефон"] = o.OrganizationTelephone;
                        newRow["Сфера"] = o.OrganizationSphere;
                        tableofOrganization.Rows.Add(newRow);
                        i++;
                    }
                    dataGridViewOrganization.DataSource = tableofOrganization;
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }
        void CreateTablePosition()
        {
            try
            {
                DataTable tableofPosition = new DataTable();
                DataColumn PositionIdColumn = new DataColumn("Номер должности", typeof(int));
                DataColumn PositionNameColumn = new DataColumn("Название", typeof(string));
                tableofPosition.Columns.AddRange(new DataColumn[]
                {
                    PositionIdColumn,
                    PositionNameColumn,
                });
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var query = context.Positions.ToList();
                    int i = 0;
                    foreach (var p in query)
                    {
                        DataRow newRow = tableofPosition.NewRow();
                        newRow["Номер должности"] = p.PositionId;
                        newRow["Название"] = p.PositionName;
                        tableofPosition.Rows.Add(newRow);
                        i++;
                    }
                    dataGridViewPosition.DataSource = tableofPosition;
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void OrganizationsForm_Load(object sender, EventArgs e)
        {
            metroTabControl1_SelectedIndexChanged(sender, e);
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedIndex == 0)
            {
                CreateTableOrganization();
            }
            if (metroTabControl1.SelectedIndex == 1)
            {
                CreateTablePosition();
            }
        }

        private void metroTileRefresh_Click(object sender, EventArgs e)
        {
            metroTabControl1_SelectedIndexChanged(sender, e);
        }

        private void metroButtonOrganizationAdd_Click(object sender, EventArgs e)
        {
            OrganizationEntityForm form = new OrganizationEntityForm();
            form.Text = "Добавление организации";
            form.btnAddvisible = true;
            form.Show();
        }

        private void metroButtonOrganizationEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int oid = Convert.ToInt32(dataGridViewOrganization.SelectedCells[0].Value.ToString());
                var organization = db.Organizations.Find(oid);
                OrganizationEntityForm form = new OrganizationEntityForm();
                form.Text = "Изменение организации";
                form.btnEditvisible = true;
                form.OrganizationId = organization.OrganizationId;
                form.oname = organization.OrganizationName;
                form.oadre = organization.OrganizationAdress;
                form.otel = organization.OrganizationTelephone;
                form.osphere = organization.OrganizationSphere;
                form.Show();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroButtonOrganizationDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int oid = Convert.ToInt32(dataGridViewOrganization.SelectedCells[0].Value.ToString());
                var organization = db.Organizations.Find(oid);
                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить организацию?", "GraduateDistribution", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    db.Organizations.Remove(organization);
                    db.SaveChanges();
                }
                OrganizationsForm_Load(sender, e);
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroButtonPositionAdd_Click(object sender, EventArgs e)
        {
            PositionEntityForm form = new PositionEntityForm();
            form.Text = "Добавление должности";
            form.btnAddvisible = true;
            form.Show();
        }

        private void metroButtonPositionEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(dataGridViewPosition.SelectedCells[0].Value.ToString());
                var position = db.Positions.Find(pid);
                PositionEntityForm form = new PositionEntityForm();
                form.Text = "Изменение должности";
                form.btnEditvisible = true;
                form.PositionId = position.PositionId;
                form.pname = position.PositionName;                
                form.Show();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroButtonPositionDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(dataGridViewPosition.SelectedCells[0].Value.ToString());
                var position = db.Positions.Find(pid);
                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить должность?", "GraduateDistribution", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    db.Positions.Remove(position);
                    db.SaveChanges();
                }
                OrganizationsForm_Load(sender, e);
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrencyManager cManager = dataGridViewOrganization.BindingContext[dataGridViewOrganization.DataSource, dataGridViewOrganization.DataMember] as CurrencyManager;
                cManager.SuspendBinding();
                cManager.ResumeBinding();
                for (int i = 0; i < dataGridViewOrganization.RowCount; i++)
                {
                    dataGridViewOrganization.Rows[i].Selected = false;
                }
                if (metroTextBoxSearch.Text == "")
                    for (int i = 0; i < dataGridViewOrganization.RowCount; i++)
                    {
                        dataGridViewOrganization.Rows[i].Selected = false;
                        dataGridViewOrganization.Rows[i].Visible = true;
                    }
                else
                {
                    for (int i = 0; i < dataGridViewOrganization.RowCount; i++)
                    {
                        dataGridViewOrganization.Rows[i].Selected = false;
                        for (int j = 0; j < dataGridViewOrganization.ColumnCount; j++)
                            if (dataGridViewOrganization.Rows[i].Cells[j].Value != null)

                                if (dataGridViewOrganization.Rows[i].Cells[j].Value.ToString().Contains(metroTextBoxSearch.Text))
                                {
                                    dataGridViewOrganization.Rows[i].Selected = true;
                                    dataGridViewOrganization.Rows[i].Visible = true;
                                    break;
                                }
                                else
                                {
                                    dataGridViewOrganization.Rows[i].Selected = false;
                                    dataGridViewOrganization.Rows[i].Visible = false;
                                }
                    }
                }
            }

            catch
            {
                MessageBox.Show("При поиске произошла ошибка, для исправления выберите другую строку");
            }
        }
    }
}
