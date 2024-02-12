using HuuThanh.FAP.V2.Repositories;
namespace HuuThanh.FAP.V2
{
    public partial class ListStudents : Form
    {
        private IStudentRepository _repo;
        //xài kho dữ liệu lấy từ SQLServer
        public ListStudents()
        {
            InitializeComponent();
            InitializeStudentRepository();
        }

        private void InitializeStudentRepository()
        {
            _repo = new StudentRepositorySqlServer();
            dgvStudentList.DataSource = _repo.GetAll();
        }

        private void AddStudent(object sender, EventArgs e)
        {
            Student x = new();
            x.Id = txtId.Text;
            x.Name = txtName.Text;
            x.Address = txtAddress.Text;
            x.Gpa = double.Parse(txtGpa.Text);
            _repo.Add(x);

            //refresh grid
            dgvStudentList.DataSource = null;
            dgvStudentList.DataSource = _repo.GetAll();
        }

        private void UpdateStudent(object sender, EventArgs e)
        {
            Student x = new();
            x.Id = txtId.Text;
            x.Name = txtName.Text;
            x.Address = txtAddress.Text;
            x.Gpa = double.Parse(txtGpa.Text);
            _repo.Update(x);

            //refresh grid
            dgvStudentList.DataSource = null;
            dgvStudentList.DataSource = _repo.GetAll();
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
            _repo.Delete(id);
            txtId.Text = "";
            dgvStudentList.DataSource = null;
            dgvStudentList.DataSource = _repo.GetAll();
        }

        private void SearchStudent(object sender, EventArgs e)
        {
            dgvResult.DataSource = null;
            string keyword = txtKeyword.Text.ToLower();
            List<Student> result = _repo.Search(keyword);
            bool isEmpty = !result.Any();
            if(!isEmpty) dgvResult.DataSource = result;
        }
    }
}
