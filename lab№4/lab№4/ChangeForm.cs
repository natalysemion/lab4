using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_4
{
    public partial class ChangeForm : Form
    {
        public ChangeForm()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Biathlete biathlete = new Biathlete();
            try
            {
                Change();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }

        public void Change()
        {
            
            int id;
            if (int.TryParse(txtId.Text, out id))
            {
                Helper.ChangeBiathleteById(Helper.CheckInput(txtId.Text, txtName.Text, txtGender.Text, txtCountry.Text, txtShooting.Text, txtPenaltyLaps.Text));
               
            }
            else
            {
                MessageBox.Show("Enteres wrong id");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Biathlete biathlete = new Biathlete();
           biathlete =  Helper.SearchId(txtId.Text);
            txtName.Text = biathlete.Name;
            txtGender.Text = biathlete.Gender;
            txtCountry.Text = biathlete.Country;
            txtShooting.Text = biathlete.Shooting.ToString();
            txtPenaltyLaps.Text = biathlete.PenaltyLaps.ToString();
        }
    }
}
