using HuuThanh.FAP.V2.Repositories;
namespace HuuThanh.FAP.V2
{
    public partial class ListStudents : Form
    {
        private StudentRepositorySqlserver _repoSqlserver;
        //xài kho dữ liệu lấy từ SQLServer
        public ListStudents()
        {
            InitializeComponent();
            InitializeStudentRepository();
        }

        private void InitializeStudentRepository()
        {
            _repoSqlserver = new StudentRepositorySqlserver();
            dgvStudentList.DataSource = _repoSqlserver.GetAll();
        }

        private void AddStudent(object sender, EventArgs e)
        {
            Student x = new();
            x.Id = txtId.Text;
            x.Name = txtName.Text;
            x.Address = txtAddress.Text;
            x.Gpa = double.Parse(txtGpa.Text);
            _repoSqlserver.Add(x);

            //refresh grid
            dgvStudentList.DataSource = null;
            dgvStudentList.DataSource = _repoSqlserver.GetAll();
        }

        private void UpdateStudent(object sender, EventArgs e)
        {
            Student x = new();
            x.Id = txtId.Text;
            x.Name = txtName.Text;
            x.Address = txtAddress.Text;
            x.Gpa = double.Parse(txtGpa.Text);
            _repoSqlserver.Update(x);

            //refresh grid
            dgvStudentList.DataSource = null;
            dgvStudentList.DataSource = _repoSqlserver.GetAll();
        }

        private void ViewAStudent(object sender, EventArgs e)
        {
            if (dgvStudentList.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvStudentList.SelectedRows[0];
                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtAddress.Text = row.Cells[2].Value.ToString();
                txtGpa.Text = row.Cells[3].Value.ToString();
            }
        }

        private void DeleteStudent(object sender, EventArgs e)
        {
            String id = txtId.Text;
            _repoSqlserver.Delete(id);
            txtId.Text = "";
            dgvStudentList.DataSource = null;
            dgvStudentList.DataSource = _repoSqlserver.GetAll();
        }

        private void SearchStudent(object sender, EventArgs e)
        {
            dgvResult.DataSource = null;
            string keyword = txtKeyword.Text.ToLower();
            List<Student> result = _repoSqlserver.Search(keyword);
            bool isEmpty = !result.Any();
            if(!isEmpty) dgvResult.DataSource = result;
        }
    }
}
