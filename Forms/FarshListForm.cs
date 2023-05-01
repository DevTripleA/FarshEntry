using FarshEntry.Forms;

namespace FarshEntry
{
    public partial class FarshListForm : Form
    {
        public FarshListForm()
        {
            InitializeComponent();

            FillGridView();
        }

        private void FillGridView()
        {
            var data = DatabaseManager.Fetch(ScriptsFilesNames.FarshQuery);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                FarshGridView.Rows.Add();
                FarshGridView.Rows[i].Cells[0].Value = data.Rows[i]["DifferenceId"].ToString();
                FarshGridView.Rows[i].Cells[1].Value = data.Rows[i]["PositionWord"].ToString();
                FarshGridView.Rows[i].Cells[2].Value = data.Rows[i]["Difference"].ToString();
                FarshGridView.Rows[i].Cells[3].Value = data.Rows[i]["ReadersNames"].ToString();
                FarshGridView.Rows[i].Cells[4].Value = data.Rows[i]["ChapterName"].ToString();
                FarshGridView.Rows[i].Cells[5].Value = data.Rows[i]["Verse"].ToString();
                FarshGridView.Rows[i].Cells[6].Value = data.Rows[i]["Page"].ToString();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addForm = new FarshAddForm();
            addForm.Show();
        }
    }
}