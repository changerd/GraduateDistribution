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
    public partial class GroupEntityForm : MetroForm
    {
        public bool btnAddvisible = false;
        public bool btnEditvisible = false;        
        public int GroupId;        
        public int gquantity, gendstudy;

        public GroupEntityForm()
        {
            InitializeComponent();
        }
        void GetSpecialty()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var query = context.Specialties.ToList();
                metroComboBoxGroupSpecialtyCode.DataSource = query;
                metroComboBoxGroupSpecialtyCode.DisplayMember = "SpecialtyCode";
                metroComboBoxGroupSpecialtyCode.ValueMember = "SpecialtyId";
            }
        }
        private void GroupEntityForm_Load(object sender, EventArgs e)
        {
            GetSpecialty();
            metroTileGroupAdd.Visible = btnAddvisible;
            metroTileGroupEdit.Visible = btnEditvisible;
            metroTextBoxGroupQuantity.Text = gquantity.ToString();
            metroTextBoxEndStudy.Text = gendstudy.ToString();            
        }

        private void metroTileGroupAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(metroComboBoxGroupSpecialtyCode.ValueMember) ||
                    String.IsNullOrEmpty(metroTextBoxEndStudy.Text) ||
                    String.IsNullOrEmpty(metroTextBoxGroupQuantity.Text))
                    throw new Exception("Поля не должны быть пустыми!");
                Group group = new Group()
                {
                    SpecialtyId = Convert.ToInt32(metroComboBoxGroupSpecialtyCode.SelectedValue),
                    GroupQuantity = Convert.ToInt32(metroTextBoxGroupQuantity.Text),
                    GroupEndStudy = Convert.ToInt32(metroTextBoxEndStudy.Text),
                };
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    context.Groups.Add(group);
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
        private void metroTileGroupEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(metroComboBoxGroupSpecialtyCode.ValueMember) ||
                    String.IsNullOrEmpty(metroTextBoxEndStudy.Text) ||
                    String.IsNullOrEmpty(metroTextBoxGroupQuantity.Text))
                    throw new Exception("Поля не должны быть пустыми!");
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var group = context.Groups.Find(GroupId);
                    group.SpecialtyId = Convert.ToInt32(metroComboBoxGroupSpecialtyCode.SelectedValue);
                    group.GroupQuantity = Convert.ToInt32(metroTextBoxGroupQuantity.Text);
                    group.GroupEndStudy = Convert.ToInt32(metroTextBoxEndStudy.Text);
                    context.Entry(group).State = EntityState.Modified;
                    context.SaveChanges();
                }
                MessageBox.Show("Запись успешно изменена!", "GraduateDistribution");
                this.Close();

            }
            catch(Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }

        }
    }
}

