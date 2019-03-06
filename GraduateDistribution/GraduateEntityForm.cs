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
    public partial class GraduateEntityForm : MetroForm
    {
        public bool btnAddvisible = false;
        public bool btnEditvisible = false;
        public int GraduateId;
        public string gsname, gfname, gsecname, ggender, gadress, gtel;
        public DateTime gbirth;
        public GraduateEntityForm()
        {
            InitializeComponent();
        }
        void GetSpecialty()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var query = context.Groups.Include(s => s.Specialty).ToList();
                List<GraduateGroups> qq = new List<GraduateGroups>();
                foreach (var q in query)
                {
                    GraduateGroups g = new GraduateGroups()
                    {
                        Id = q.GroupId,
                        Name = q.Specialty.SpecialtyCode,
                    };
                    qq.Add(g);
                }
                metroComboBoxGroup.DataSource = qq;
                metroComboBoxGroup.DisplayMember = "Name";
                metroComboBoxGroup.ValueMember = "Id";
            }
        }

        private void GraduateEntityForm_Load(object sender, EventArgs e)
        {
            GetSpecialty();
            metroTileGraduateAdd.Visible = btnAddvisible;
            metroTileGraduateEdit.Visible = btnEditvisible;
        }
        private void metroTileGraduateAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(metroTextBoxSurName.Text) ||
                    String.IsNullOrEmpty(metroTextBoxFirstName.Text) ||
                    String.IsNullOrEmpty(metroTextBoxSecondName.Text) ||
                    dateTimePickerBirth == null ||
                    String.IsNullOrEmpty(metroComboBoxGender.Text) ||
                    String.IsNullOrEmpty(metroTextBoxAdress.Text) ||
                    String.IsNullOrEmpty(maskedTextBoxTelephone.Text))
                    throw new Exception("Поля не должны быть пустыми!");
                Graduate graduate = new Graduate()
                {
                    GraduateSurName = metroTextBoxSurName.Text,
                    GraduateFirstName = metroTextBoxFirstName.Text,
                    GraduateSecondName = metroTextBoxSecondName.Text,
                    GraduateBirthDate = dateTimePickerBirth.Value,
                    GraduateAdress = metroTextBoxAdress.Text,
                    GraduateGender = metroComboBoxGender.Text,
                    GraduateTelephone = maskedTextBoxTelephone.Text,
                    GroupId = Convert.ToInt32(metroComboBoxGroup.SelectedValue),
                };
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    context.Graduates.Add(graduate);
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
    
        private void metroTileGraduateEdit_Click(object sender, EventArgs e)
        {

        }        
    }
}
