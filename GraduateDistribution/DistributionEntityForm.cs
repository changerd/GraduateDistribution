using GraduateDistribution.Entities;
using GraduateDistribution.VM;
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

namespace GraduateDistribution
{
    public partial class DistributionEntityForm : MetroForm
    {
        public bool btnAddvisible = false;
        public bool btnEditvisible = false;
        public int DistributionId;
        public decimal dsalary;
        public DateTime dfirst = DateTime.Now.Date, dsecond = DateTime.Now.Date;
        public DistributionEntityForm()
        {
            InitializeComponent();
        }
        void GetComboBoxes()
        {
            List<Graduate> graduates = new List<Graduate>();
            List<DistributionGraduate> graduatesnew = new List<DistributionGraduate>();
            List<Organization> organizations = new List<Organization>();
            List<Position> positions = new List<Position>();
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                graduates = context.Graduates.ToList();
                organizations = context.Organizations.ToList(); ;
                positions = context.Positions.ToList();
            }
            foreach(var g in graduates)
            {
                DistributionGraduate dg = new DistributionGraduate()
                {
                    Id = g.GraduateId,
                    Name = g.GraduateSurName + " " + g.GraduateFirstName + " " + g.GraduateSecondName,
                };
                graduatesnew.Add(dg);
            }
            metroComboBoxGraduate.DataSource = graduatesnew;
            metroComboBoxGraduate.DisplayMember = "Name";
            metroComboBoxGraduate.ValueMember = "Id";
            metroComboBoxOrganization.DataSource = organizations;
            metroComboBoxOrganization.DisplayMember = "OrganizationName";
            metroComboBoxOrganization.ValueMember = "OrganizationId";
            metroComboBoxPosition.DataSource = positions;
            metroComboBoxPosition.DisplayMember = "PositionName";
            metroComboBoxPosition.ValueMember = "PositionId";
        }
        private void DistributionEntityForm_Load(object sender, EventArgs e)
        {
            GetComboBoxes();
            metroTileDistributionAdd.Visible = btnAddvisible;
            metroTileDistributionEdit.Visible = btnEditvisible;
            metroTextBoxSalary.Text = dsalary.ToString();
            dateTimePickerFirst.Value = dfirst;
            dateTimePickerSecond.Value = dsecond;
        }

        private void metroTileDistributionAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(metroTextBoxSalary.Text))
                    throw new Exception("Поля не должны быть пустыми!");
                Distribution distribution = new Distribution()
                {
                    GraduateId = Convert.ToInt32(metroComboBoxGraduate.SelectedValue),
                    OrganizationId = Convert.ToInt32(metroComboBoxOrganization.SelectedValue),
                    PositionId = Convert.ToInt32(metroComboBoxPosition.SelectedValue),
                    DistributionStart = dateTimePickerFirst.Value,
                    DistributionEnd = dateTimePickerSecond.Value,
                    DistributionSalary = Convert.ToDecimal(metroTextBoxSalary.Text),
                };
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    context.Distributions.Add(distribution);
                    context.SaveChanges();
                }
                MessageBox.Show("Запись успешно добавлена!", "GraduateDistribution");
                this.Close();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }        

        private void metroTileDistribution_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(metroTextBoxSalary.Text))
                    throw new Exception("Поля не должны быть пустыми!");
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var distribution = context.Distributions.Find(DistributionId);
                    distribution.GraduateId = Convert.ToInt32(metroComboBoxGraduate.SelectedValue);
                    distribution.OrganizationId = Convert.ToInt32(metroComboBoxOrganization.SelectedValue);
                    distribution.PositionId = Convert.ToInt32(metroComboBoxPosition.SelectedValue);
                    distribution.DistributionStart = dateTimePickerFirst.Value;
                    distribution.DistributionEnd = dateTimePickerSecond.Value;
                    distribution.DistributionSalary = Convert.ToDecimal(metroTextBoxSalary.Text);
                    context.Entry(distribution).State = EntityState.Modified;
                    context.SaveChanges();
                }
                MessageBox.Show("Запись успешно изменена!", "GraduateDistribution");
                this.Close();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }
        private void metroTextBoxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 46)
            {
                e.Handled = true;
            }
        }
    }
}
