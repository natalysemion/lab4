using System.IO;
using static System.Reflection.Metadata.BlobBuilder;

namespace lab_4
{
    public partial class lab4MainForm : Form
    {
        private void RefreshGrid(List<Biathlete> biathletes)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = biathletes;
        }
        public void FillGrid()
        {
            Helper.biathletes = JsonAction.DeserialiseFromJson(Helper.path);
            dataGridView1.DataSource = Helper.biathletes;
        }
                
        public lab4MainForm()
        {
            InitializeComponent();
            FillGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
            RefreshGrid(Helper.biathletes);
            if (_searched)
            {
                Search();
            }
        }
        bool _searched = false;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(Search())
                _searched = true;
        }
        private bool Search()
        {
            try
            {
                Helper.LinqSortedBiathletes = Helper.biathletes;
                if (checkGender.Checked)
                {
                    Helper.LinqSortedBiathletes = SearchLINQ.SearchByGender(txtCheckGender.Text, Helper.LinqSortedBiathletes).ToList();
                }
                if (checkCountry.Checked)
                {
                    Helper.LinqSortedBiathletes = SearchLINQ.SearchByCountry(txtCheckCountry.Text, Helper.LinqSortedBiathletes).ToList();
                }
                if (checkPenaltyLaps.Checked)
                {
                    Helper.LinqSortedBiathletes = SearchLINQ.SearchByPenaltyLaps(txtCheckPenaltyLaps.Text, Helper.LinqSortedBiathletes).ToList();
                }
                RefreshGrid(Helper.LinqSortedBiathletes);
                if (!checkGender.Checked && !checkPenaltyLaps.Checked && !checkCountry.Checked)
                {
                    RefreshGrid(Helper.biathletes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("lab4 Semion Nataliia K25");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkWithFile.OpenFile();
            RefreshGrid(Helper.biathletes);
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            JsonAction.SerializeToJson(Helper.path, Helper.biathletes);
        }

        private void createNewAnsSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkWithFile.CreateFile();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.ShowDialog();
            RefreshGrid(Helper.biathletes);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ChangeForm changeForm = new ChangeForm();
            changeForm.ShowDialog();
            RefreshGrid(Helper.biathletes);
        }
        
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkWithFile.CreateFile();
        }
    }

}