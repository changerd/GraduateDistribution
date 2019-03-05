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
    public partial class MainMenu : MetroForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void metroTileCollege_Click(object sender, EventArgs e)
        {
            CollegeForm form = new CollegeForm();
            form.Show();
        }

        private void metroTileOrganization_Click(object sender, EventArgs e)
        {
            OrganizationsForm form = new OrganizationsForm();
            form.Show();
        }

        private void metroTileDistribution_Click(object sender, EventArgs e)
        {
            DistributionForm form = new DistributionForm();
            form.Show();
        }
    }
}
