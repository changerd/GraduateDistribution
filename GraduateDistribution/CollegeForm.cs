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

namespace GraduateDistribution
{
    public partial class CollegeForm : MetroForm
    {
        public CollegeForm()
        {
            InitializeComponent();
        }
        ApplicationDbContext db = new ApplicationDbContext();
        void CreateTableGraduate()
        {
            try
            {
                DataTable tableofGraduate = new DataTable();
                DataColumn GraduateIdColumn = new DataColumn("Номер выпускника", typeof(int));
                DataColumn GraduateSurNameColumn = new DataColumn("Фамилия", typeof(string));
                DataColumn GraduateLastNameColumn = new DataColumn("Имя", typeof(string));
                DataColumn GraduateSecondNameColumn = new DataColumn("Отчество", typeof(string));
                DataColumn GraduateSpecialtyCodeColumn = new DataColumn("Код специальности", typeof(string));
                DataColumn GraduateEndStudyColumn = new DataColumn("Год выпуска", typeof(int));
                DataColumn GraduateBirthDateColumn = new DataColumn("Дата рождения", typeof(DateTime));
                DataColumn GraduateGenderColumn = new DataColumn("Пол", typeof(string));
                DataColumn GraduateAdressColumn = new DataColumn("Адрес", typeof(string));
                DataColumn GraduateTelephoneColumn = new DataColumn("Телефон", typeof(string));
                tableofGraduate.Columns.AddRange(new DataColumn[]
                {
                    GraduateIdColumn,
                    GraduateSurNameColumn,
                    GraduateLastNameColumn,
                    GraduateSecondNameColumn,
                    GraduateSpecialtyCodeColumn,
                    GraduateEndStudyColumn,
                    GraduateBirthDateColumn,
                    GraduateGenderColumn,
                    GraduateAdressColumn,
                    GraduateTelephoneColumn,
                });
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var query = context.Graduates.Include(g => g.Group).Include(s => s.Group.Specialty).ToList();
                    int i = 0;
                    foreach (var g in query)
                    {
                        DataRow newRow = tableofGraduate.NewRow();
                        newRow["Номер выпускника"] = g.GraduateId;
                        newRow["Фамилия"] = g.GraduateSurName;
                        newRow["Имя"] = g.GraduateFirstName;
                        newRow["Отчество"] = g.GraduateSecondName;
                        newRow["Код специальности"] = g.Group.Specialty.SpecialtyCode;
                        newRow["Год выпуска"] = g.Group.GroupEndStudy;
                        newRow["Дата рождения"] = g.GraduateBirthDate;
                        newRow["Пол"] = g.GraduateGender;
                        newRow["Адрес"] = g.GraduateAdress;
                        newRow["Телефон"] = g.GraduateTelephone;
                        tableofGraduate.Rows.Add(newRow);
                        i++;
                    }
                    dataGridViewGraduate.DataSource = tableofGraduate;
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }
        void CreateTableGroup()
        {
            try
            {
                DataTable tableofGroup = new DataTable();
                DataColumn GroupIdColumn = new DataColumn("Номер группы", typeof(int));
                DataColumn GroupSpecialtyCodeColumn = new DataColumn("Код специальности", typeof(string));
                DataColumn GroupQuantityColumn = new DataColumn("Количество учащихся", typeof(int));
                DataColumn GroupEndStudyColumn = new DataColumn("Год выпуска", typeof(int));
                tableofGroup.Columns.AddRange(new DataColumn[]
                {
                    GroupIdColumn,
                    GroupSpecialtyCodeColumn,
                    GroupQuantityColumn,
                    GroupEndStudyColumn,
                });
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var query = context.Groups.Include(s => s.Specialty).ToList();
                    int i = 0;
                    foreach (var g in query)
                    {
                        DataRow newRow = tableofGroup.NewRow();
                        newRow["Номер группы"] = g.GroupId;
                        newRow["Код специальности"] = g.Specialty.SpecialtyCode;
                        newRow["Количество учащихся"] = g.GroupQuantity;
                        newRow["Год выпуска"] = g.GroupEndStudy;                     
                        tableofGroup.Rows.Add(newRow);
                        i++;
                    }
                    dataGridViewGroup.DataSource = tableofGroup;
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }
        void CreateTableSpecialty()
        {
            try
            {
                DataTable tableofSpecialty = new DataTable();
                DataColumn SpecialtyCodeColumn = new DataColumn("Код специальности", typeof(string));
                DataColumn SpecialtyNameColumn = new DataColumn("Название", typeof(string));
                DataColumn SpecialtyTimeColumn = new DataColumn("Срок обучения", typeof(string));
                DataColumn SpecialtyFormStudyColumn = new DataColumn("Форма обучения", typeof(string));
                tableofSpecialty.Columns.AddRange(new DataColumn[]
                {
                    SpecialtyCodeColumn,
                    SpecialtyNameColumn,
                    SpecialtyTimeColumn,
                    SpecialtyFormStudyColumn,
                });
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var query = context.Specialties.ToList();
                    int i = 0;
                    foreach (var s in query)
                    {
                        DataRow newRow = tableofSpecialty.NewRow();
                        newRow["Код специальности"] = s.SpecialtyCode;
                        newRow["Название"] = s.SpecialtyName;
                        newRow["Срок обучения"] = s.SpecialtyTime;
                        newRow["Форма обучения"] = s.SpecialtyFormStudy;
                        tableofSpecialty.Rows.Add(newRow);
                        i++;
                    }
                    dataGridViewSpecialty.DataSource = tableofSpecialty;
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }
        private void CollegeForm_Load(object sender, EventArgs e)
        {
            metroTabControl1_SelectedIndexChanged(sender, e);
        }
        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedIndex == 0)
            {
                CreateTableGraduate();
            }
            if (metroTabControl1.SelectedIndex == 1)
            {
                CreateTableGroup();
            }
            if (metroTabControl1.SelectedIndex == 2)
            {
                CreateTableSpecialty();
            }
        }
        private void metroButtonGraduateAdd_Click(object sender, EventArgs e)
        {
            GraduateEntityForm form = new GraduateEntityForm();
            form.Text = "Добавление выпускника";
            form.btnAddvisible = true;
            form.Show();
        }

        private void metroButtonGraduateEdit_Click(object sender, EventArgs e)
        {

        }

        private void metroButtonGraduateDelete_Click(object sender, EventArgs e)
        {

        }
        private void metroButtonGroupAdd_Click(object sender, EventArgs e)
        {
            GroupEntityForm form = new GroupEntityForm();
            form.Text = "Добавление группы";
            form.btnAddvisible = true;
            form.Show();
        }
        private void metroButtonGroupEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int gid = Convert.ToInt32(dataGridViewGroup.SelectedCells[0].Value.ToString());                
                var group = db.Groups.Find(gid);
                GroupEntityForm form = new GroupEntityForm();
                form.Text = "Изменение группы";
                form.btnEditvisible = true;
                form.GroupId = group.GroupId;
                form.gquantity = group.GroupQuantity;
                form.gendstudy = group.GroupEndStudy;
                form.Show();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroButtonGroupDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int gid = Convert.ToInt32(dataGridViewGroup.SelectedCells[0].Value.ToString());
                var group = db.Groups.Find(gid);
                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить группу?", "GraduateDistribution", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    db.Groups.Remove(group);
                    db.SaveChanges();
                }
                CollegeForm_Load(sender, e);
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }
        private void metroButtonSpecialtyAdd_Click(object sender, EventArgs e)
        {
            SpecialtyEntityForm form = new SpecialtyEntityForm();
            form.Text = "Добавление специальности";
            form.btnAddvisible = true;            
            form.Show();
        }

        private void metroButtonSpecialtyEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string scode = dataGridViewSpecialty.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(scode))
                    throw new Exception("Не выделено поле, которое нужно изменить!");
                var specialty = db.Specialties.SingleOrDefault(s => s.SpecialtyCode == scode);
                SpecialtyEntityForm form = new SpecialtyEntityForm();
                form.Text = "Изменение специальности";
                form.btnEditvisible = true;
                form.SpecialtyId = specialty.SpecialtyId;
                form.sname = specialty.SpecialtyName;
                form.scode = specialty.SpecialtyCode;
                form.stime = specialty.SpecialtyTime;
                form.Show();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroButtonSpecialtyDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string scode = dataGridViewSpecialty.SelectedCells[0].Value.ToString();
                if (String.IsNullOrEmpty(scode))
                    throw new Exception("Не выделено поле, которое нужно удалить!");
                var specialty = db.Specialties.SingleOrDefault(s => s.SpecialtyCode == scode);
                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить специальность?", "GraduateDistribution", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    db.Specialties.Remove(specialty);
                    db.SaveChanges();
                }                
                CollegeForm_Load(sender, e);
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        
    }
}
