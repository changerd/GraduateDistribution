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

namespace GraduateDistribution.Entities
{
    public partial class OrganizationEntityForm : MetroForm
    {
        public bool btnAddvisible = false;
        public bool btnEditvisible = false;
        public int OrganizationId;
        public string oname, oadre, otel, osphere;

        private void OrganizationEntityForm_Load(object sender, EventArgs e)
        {
            metroTileOrganizationAdd.Visible = btnAddvisible;
            metroTileOrganizationEdit.Visible = btnEditvisible;
            metroTextBoxName.Text = oname;
            metroTextBoxAdress.Text = oadre;
            maskedTextBoxTelephone.Text = otel;
            metroTextBoxSphere.Text = osphere;
        }

        public OrganizationEntityForm()
        {
            InitializeComponent();
        }

        private void metroTileOrganizationAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(metroTextBoxName.Text) ||
                    String.IsNullOrEmpty(metroTextBoxAdress.Text) ||
                    String.IsNullOrEmpty(maskedTextBoxTelephone.Text) ||
                    String.IsNullOrEmpty(metroTextBoxSphere.Text))
                    throw new Exception("Поля не должны быть пустыми!");
                Organization organization = new Organization()
                {
                    OrganizationName = metroTextBoxName.Text,
                    OrganizationAdress = metroTextBoxAdress.Text,
                    OrganizationTelephone = maskedTextBoxTelephone.Text,
                    OrganizationSphere = metroTextBoxSphere.Text,
                };
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    context.Organizations.Add(organization);
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
        

        private void metroTileOrganizationEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(metroTextBoxName.Text) ||
                        String.IsNullOrEmpty(metroTextBoxAdress.Text) ||
                        String.IsNullOrEmpty(maskedTextBoxTelephone.Text) ||
                        String.IsNullOrEmpty(metroTextBoxSphere.Text))
                    throw new Exception("Поля не должны быть пустыми!");
                using (ApplicationDbContext context = new ApplicationDbContext())
                {                    
                    var organization = context.Organizations.Find(OrganizationId);
                    organization.OrganizationName = metroTextBoxName.Text;
                    organization.OrganizationAdress = metroTextBoxAdress.Text;
                    organization.OrganizationTelephone = maskedTextBoxTelephone.Text;
                    organization.OrganizationSphere = metroTextBoxSphere.Text;
                    context.Entry(organization).State = EntityState.Modified;
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
