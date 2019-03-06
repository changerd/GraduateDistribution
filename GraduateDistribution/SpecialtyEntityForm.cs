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
    public partial class SpecialtyEntityForm : MetroForm
    {
        public bool btnAddvisible = false;
        public bool btnEditvisible = false;
        public int SpecialtyId;
        public string scode, sname, stime;
        public SpecialtyEntityForm()
        {
            InitializeComponent();            
        }
        private void SpecialtyEntityForm_Load(object sender, EventArgs e)
        {
            metroTileSpicialtyAdd.Visible = btnAddvisible;
            metroTileSpecialtyEdit.Visible = btnEditvisible;
            metroTextBoxSpecialtyName.Text = sname;
            metroTextBoxSpecialtyCode.Text = scode;
            metroTextBoxSpecialtyTime.Text = stime;
        }

        private void metroTileSpicialtyAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(metroTextBoxSpecialtyCode.Text) ||
                    String.IsNullOrEmpty(metroTextBoxSpecialtyName.Text) ||
                    String.IsNullOrEmpty(metroTextBoxSpecialtyTime.Text) ||
                    String.IsNullOrEmpty(metroComboBoxFormStudy.Text))
                    throw new Exception("Поля не должны быть пустыми!");
                Specialty specialty = new Specialty
                {
                    SpecialtyCode = metroTextBoxSpecialtyCode.Text,
                    SpecialtyName = metroTextBoxSpecialtyName.Text,
                    SpecialtyTime = metroTextBoxSpecialtyTime.Text,
                    SpecialtyFormStudy = metroComboBoxFormStudy.Text,
                };
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    context.Specialties.Add(specialty);
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

        private void metroTileSpecialtyEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(metroTextBoxSpecialtyCode.Text) ||
                    String.IsNullOrEmpty(metroTextBoxSpecialtyName.Text) ||
                    String.IsNullOrEmpty(metroTextBoxSpecialtyTime.Text) ||
                    String.IsNullOrEmpty(metroComboBoxFormStudy.Text))
                    throw new Exception("Поля не должны быть пустыми!");                
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var specialty = context.Specialties.Find(SpecialtyId);
                    specialty.SpecialtyCode = metroTextBoxSpecialtyCode.Text;
                    specialty.SpecialtyName = metroTextBoxSpecialtyName.Text;
                    specialty.SpecialtyTime = metroTextBoxSpecialtyTime.Text;
                    specialty.SpecialtyFormStudy = metroComboBoxFormStudy.Text;
                    context.Entry(specialty).State = EntityState.Modified;
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

        
    }
}
